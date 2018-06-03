using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Adorables.Ball
{
	public class GameManager : MonoBehaviour
	{
		public static GameManager Instance;

		private AudioSource audio;

		[SerializeField]
		private float speed = 10f;

		[SerializeField]
		private float spawnFrequency = 0.25f;

		[SerializeField]
		private int numberOfRow = 8;

		[SerializeField]
		private int numberOfColumn = 7;

		[SerializeField]
		private int nTurnToUpgradeMaxCellCount = 1;

		[SerializeField]
		private int upgradeMaxCellCount = 2;

		[SerializeField]
		private int nTurnToUpgradeMinCellCount = 4;

		[SerializeField]
		private int upgradeMinCellCount = 1;

		private int currentMinCellCount;

		private int currentMaxCellCount;

		private int startMinCellCount = 1;

		private int startMaxCellCount = 2;

		[SerializeField]
		private Color[] cellColors;
		[SerializeField]
		private int colorStep;

		[SerializeField]
		private int coinsPerVideo = 10;

		[SerializeField]
		public int numberOfPlayToShowInterstitial = 3;

		[SerializeField]
		private float brickProbability = 0.3f;

		[SerializeField]
		private float powerUpProbability = 0.1f;

		[SerializeField]
		private float emptyProbabilty = 0.2f;

		[Range(0f, 1f), SerializeField]
		private float addBallProbability = 0.75f;

		[Range(0f, 1f), SerializeField]
		private float addCoinProbability = 0.75f;

		public float SpawnChance;

		private float maxSpawnProbability;

		[SerializeField]
		private Cell[] brickPrefabs;

		[SerializeField]
		private float[] brickProbabilities;

		[SerializeField]
		private AddBall addBallPrefab;

		[SerializeField]
		private AddBomb addBombPrefab;

		[SerializeField]
		private AddCoin addCoinPrefab;

		[SerializeField]
		private BoxCollider2D leftWall;

		[SerializeField]
		private BoxCollider2D rightWall;

		[SerializeField]
		private BoxCollider2D bottomWall;

		[SerializeField]
		private BoxCollider2D topWall;

		[SerializeField]
		private Transform background;

		[SerializeField]
		public Player player;

		[SerializeField]
		private AudioSource source;

		[SerializeField]
		private AudioClip gameOver;

		private Rect screenRect;

		private float stepX;

		public float stepXbomb;

		private float maxCellProbability;

		private List<BasicCell> cells;

		private Transform gridContainer;

		private Vector3 bottomLimit;

		public static int nTurn;

		private int ballToAddCount;

		public Camera cam;

		public float aspect;

		public static int StatoRisoluzione;

		public static int Gonext;

		private Vector3 MovingDirection = Vector3.up;

		public static float height;

		public float Altezza;

		private void Awake()
		{
			Instance = this;
		}
		private void Start()
		{
			this.aspect = this.cam.aspect;
			int pixelHeight = this.cam.pixelHeight;
			int pixelWidth = this.cam.pixelWidth;
			base.transform.localScale = new Vector3(this.aspect * base.transform.localScale.z, base.transform.localScale.y, base.transform.localScale.z);

			//if (this.aspect == 0.5f)
			//{
			//	this.Altezza = 1.73f;
			//	GameManager.StatoRisoluzione = 1;
			//}
			//if (this.aspect == 0.4864865f)
			//{
			//	this.Altezza = 1.68f;
			//	GameManager.StatoRisoluzione = 1;
			//}
			//if (this.aspect == 0.5625f)
			//{
			//	this.Altezza = 1.94f;
			//	GameManager.StatoRisoluzione = 1;
			//}
			//if (this.aspect == 0.5620609f)
			//{
			//	this.Altezza = 1.93f;
			//	GameManager.StatoRisoluzione = 1;
			//}
			//if (this.aspect == 0.75f)
			//{
			//	this.Altezza = 2.57f;
			//	GameManager.StatoRisoluzione = 2;
			//}
			//if (this.aspect == 0.625f)
			//{
			//	this.Altezza = 2.15f;
			//	GameManager.StatoRisoluzione = 2;
			//}
			//if (this.aspect == 0.6f)
			//{
			//	this.Altezza = 2.05f;
			//	GameManager.StatoRisoluzione = 2;
			//}
			//if (this.aspect == 0.5859375f)
			//{
			//	this.Altezza = 2.01f;
			//	GameManager.StatoRisoluzione = 2;
			//}
			//if (this.aspect == 0.6666667f)
			//{
			//	this.Altezza = 2.286f;
			//	GameManager.StatoRisoluzione = 2;
			//}
			//if (this.aspect == 0.5125f)
			//{
			//	this.Altezza = 1.77f;
			//	GameManager.StatoRisoluzione = 2;
			//}

			this.Altezza = this.aspect / 0.29f;
			GameManager.StatoRisoluzione = 2;
			this.audio = base.GetComponent<AudioSource>();
			if (this.brickPrefabs.Length != this.brickProbabilities.Length)
			{
				throw new Exception("Cell Prefabs and Probabilities don't have the same length !");
			}
			this.SetUpScreen();
			this.SetUpGrid();
			this.SetUpLevelBounds();
			this.SetUpPlayer();
		}

		public void FixedUpdate()
		{
			if (GameManager.Gonext == 0)
			{
				GameObject.FindWithTag("Ball").SetActive(false);
			}
			if (GameManager.Gonext == 1)
			{
				GameObject.FindWithTag("Ball").SetActive(true);
			}
		}

		public void OnPlayButtonClicked()
		{
			this.StartGame();
			GameManager.Gonext = 1;
			this.NextTurn();
		}
		public void OnReplayButtonClicked()
		{
			this.Reset();
			this.StartGame();
		}

		public void Reset()
		{
			this.ballToAddCount = 0;
			for (int i = this.cells.Count - 1; i > -1; i--)
			{
				UnityEngine.Object.Destroy(this.cells[i].gameObject);
				this.cells.RemoveAt(i);
			}
		}

		private void StartGame()
		{
			this.DisplayPlayer(true);
			this.currentMinCellCount = this.startMinCellCount;
			this.currentMaxCellCount = this.startMinCellCount;
			this.StartPlayer();
		}

		private void SetUpGrid()
		{
			this.stepX = Mathf.Min(this.screenRect.width, this.screenRect.height) / (float)(this.numberOfColumn + 1);
			float num = this.stepX / 2f;
			this.gridContainer = new GameObject("Grid").transform;
			this.cells = new List<BasicCell>();
			for (int i = 0; i < this.brickProbabilities.Length; i++)
			{
				this.maxCellProbability += this.brickProbabilities[i];
			}
			this.maxSpawnProbability = this.brickProbability + this.powerUpProbability + this.emptyProbabilty;
			this.bottomLimit = new Vector3(0f, this.gridContainer.position.y - ((float)this.numberOfColumn + 2f) * this.stepX, 0f);
		}

		private void CreateLine()
		{
			for (int i = 0; i < this.numberOfColumn; i++)
			{
				float num = this.brickProbability;
				float num2 = UnityEngine.Random.Range(0f, this.maxSpawnProbability);
				if (num2 < num)
				{
					this.CreateBrick(i, 0);
				}
				else
				{
					num += this.powerUpProbability;
					if (num2 < num)
					{
						UnityEngine.Debug.Log("CreatePowerUp");
						this.CreatePowerUp(i, 0);
					}
				}
			}
		}

		private void MoveGrid()
		{
			foreach (BasicCell current in this.cells)
			{
				Vector3 endposition = current.transform.position - Vector3.up * this.stepX;
				current.transform.DOMove(endposition, 0.5f);
			}
		}

		private void NextTurn()
		{
			base.StartCoroutine(this.NextTurnCoroutine());
			UnityEngine.Debug.Log("next turn");
		}

		[DebuggerHidden]
		private IEnumerator NextTurnCoroutine()
		{

			if (GameManager.Gonext == 1)
			{
				this.CreateLine();
				this.MoveGrid();
				this.UpgradeDifficulty();
				UnityEngine.Debug.Log("ha creato");
			}
			if (this.CheckLoose())
			{
				this.ballToAddCount = 0;
				this.source.PlayOneShot(this.gameOver);
				yield return new WaitForSeconds(0.5f);
				UnityEngine.Debug.Log("gameover");
			}
			else
			{
				yield return new WaitForSeconds(0.5f);
				this.player.AddBall(this.ballToAddCount);
				this.ballToAddCount = 0;
				this.player.StartTurn();
			}
		}

		private void DisplayPlayer(bool isShown)
		{
			this.player.gameObject.SetActive(true);
		}

		private void UpgradeDifficulty()
		{
			if (GameManager.nTurn % this.nTurnToUpgradeMinCellCount == 0)
			{
				this.currentMinCellCount += this.upgradeMinCellCount;
			}
			if (GameManager.nTurn % this.nTurnToUpgradeMaxCellCount == 0)
			{
				this.currentMaxCellCount += this.upgradeMaxCellCount;
			}
		}

		private bool CheckLoose()
		{
			if (this.cells.Count == 0)
			{
				return false;
			}
			for (int i = 0; i < this.cells.Count; i++)
			{
				if (!this.cells[i].CompareTag(Constants.PICKABLE_TAG))
				{
					Vector3 position = this.cells[i].transform.position;
					int layerMask = -1537;
					RaycastHit2D hit = Physics2D.Raycast(position, -Vector3.up, this.stepX * 2.25f, layerMask);
					return hit && hit.collider.CompareTag(Constants.FLOOR_TAG);
				}
			}
			return false;
		}

		private void OnTurnEnded()
		{
			Utils.NextTurn = 1;
			GameManager.nTurn++;
			this.NextTurn();
			Sounds.PlaynextSound = 1;
		}

		private void CreatePowerUp(int x, int y)
		{
			float value = UnityEngine.Random.value;
			this.SpawnChance = value;
			BasicCell cell;
			if (value < this.addBallProbability)
			{
				AddBall addBall = UnityEngine.Object.Instantiate<AddBall>(this.addBallPrefab);
				AddBall expr_26 = addBall;
				expr_26.OnCollision = (Action<AddBall>)Delegate.Combine(expr_26.OnCollision, new Action<AddBall>(this.AddBall_OnCollision));
				cell = addBall;
			}
			else if (value < this.addCoinProbability)
			{
				AddBomb addBomb = UnityEngine.Object.Instantiate<AddBomb>(this.addBombPrefab);
				AddBomb expr_6C = addBomb;
				expr_6C.OnCollision = (Action<AddBomb>)Delegate.Combine(expr_6C.OnCollision, new Action<AddBomb>(this.AddBomb_OnCollision));
				cell = addBomb;
			}
			else
			{
				AddCoin addCoin = UnityEngine.Object.Instantiate<AddCoin>(this.addCoinPrefab);
				AddCoin expr_A8 = addCoin;
				expr_A8.OnCollision = (Action<AddCoin>)Delegate.Combine(expr_A8.OnCollision, new Action<AddCoin>(this.AddCoin_OnCollision));
				cell = addCoin;
			}
			cell.transform.SetParent(this.gridContainer);
			cell.transform.localPosition = this.GetPositionFromModel(x, y);
			this.cells.Add(cell);
		}

		private void AddBall_OnCollision(AddBall sender)
		{
			this.cells.Remove(sender);
			this.ballToAddCount++;
		}

		private void AddCoin_OnCollision(AddCoin sender)
		{
			this.cells.Remove(sender);
			Utils.Moneta++;
			PlayerPrefs.SetInt("moneta", Utils.Moneta);
			PlayerPrefs.Save();
		}

		private void AddBomb_OnCollision(AddBomb sender)
		{
			this.cells.Remove(sender);
			UnityEngine.Debug.Log("missili lanciati");
		}

		private void CreateBrick(int x, int y)
		{
			float num = UnityEngine.Random.Range(0f, this.maxCellProbability);
			float num2 = 0f;
			Cell cell = null;
			for (int i = 0; i < this.brickPrefabs.Length; i++)
			{
				num2 += this.brickProbabilities[i];
				if (num < num2)
				{
					cell = UnityEngine.Object.Instantiate<Cell>(this.brickPrefabs[i]);
					break;
				}
			}
			cell.transform.SetParent(this.gridContainer);
			GameObject expr_6E = cell.gameObject;
			expr_6E.name = expr_6E.name + "_" + x.ToString();
			cell.transform.localScale *= this.stepX;
			cell.transform.localPosition = this.GetPositionFromModel(x, y);
			cell.OnDestroyedByBall += new OnDestroyedEventHandler(this.Cell_OnDestroyedByBall);
			this.cells.Add(cell);
			int count = UnityEngine.Random.Range(this.currentMinCellCount, this.currentMaxCellCount + 1);
			cell._count = count;
			cell.SetCount(count);
			cell.SetColors(this.cellColors ,this.colorStep);
			cell.SetStartScale(cell.transform.localScale);
		}

		private void Cell_OnDestroyedByBall(BasicCell sender)
		{
			this.cells.Remove(sender);
		}

		private void Cell_OnDestroyedByBomb(BasicCell sender)
		{
			this.cells.Remove(sender);
		}

		private void Cell_OnDestroyedByBomba(BasicCell sender)
		{
			this.cells.Remove(sender);
		}

		private Vector3 GetPositionFromModel(int x, int y)
		{
			Vector3 result = new Vector3(this.stepX + (float)x * this.stepX, (float)(-(float)y) * this.stepX, 0f);
			return result;
		}

		private void SetUpPlayer()
		{
			this.player.transform.localScale *= this.stepX;
			this.player.Speed = this.speed;
			this.player.SpawnFrequency = this.spawnFrequency;
			this.player.BallScale = this.stepX;
			this.player.ScreenRect = this.screenRect;
			//this.player.SetUpTrajectoryDots();
			Player expr_76 = this.player;
			expr_76.TurnEnded = (Action)Delegate.Combine(expr_76.TurnEnded, new Action(this.OnTurnEnded));
		}

		private void StartPlayer()
		{
			this.player.transform.position = this.bottomLimit;
			this.player.SetUpBalls();
			this.DisplayPlayer(true);
		}

		private void SetUpScreen()
		{
			this.screenRect = CameraTools.GetScreenRect();
		}

		private void SetUpLevelBounds()
		{
			Camera main = Camera.main;
			GameManager.height = this.Altezza * main.orthographicSize;
			float num = GameManager.height * main.aspect;
			float num2 = (float)(this.numberOfRow + 1) * this.stepX;
			float num3 = GameManager.height - num2;
			float num4 = num3 * 0.6f;
			float num5 = num3 * 0.75f;
			float num6 = this.stepX / 2f;
			//this.gridContainer.position = new Vector3(this.screenRect.xMin + num6, this.screenRect.yMax - num6 - num4);
			this.gridContainer.position = new Vector3(this.screenRect.xMin, this.screenRect.yMax - num4);
			this.bottomLimit = new Vector3(0f, this.screenRect.yMin + num5, 0f);
			Vector2 size = new Vector2(this.screenRect.width + 1f, 0.1f);
			Vector2 size2 = new Vector2(0.1f, this.screenRect.height + 1f);
			this.topWall.transform.position = new Vector3(0f, this.screenRect.yMax - num4, 0f);
			this.topWall.size = size;
			this.bottomWall.transform.position = this.bottomLimit - 0.125f * this.stepX * Vector3.up;
			this.bottomWall.size = size;
			this.leftWall.transform.position = new Vector3(this.screenRect.xMin, 0f, 0f);
			this.leftWall.size = size2;
			this.rightWall.transform.position = new Vector3(this.screenRect.xMax, 0f, 0f);
			this.rightWall.size = size2;
			this.background.localScale = new Vector3(Mathf.Min(this.screenRect.width, this.screenRect.height) + 0.6f, num2 + 0.6f, 2f);
			Vector3 backpos = (this.topWall.transform.position + this.bottomWall.transform.position) / 2f;
			this.background.transform.position = new Vector3(backpos.x, backpos.y, 2);
			//this.leftWall.transform.position = new Vector3(-this.background.localScale.x / 2f + num6, 0f, 0f);
			//this.rightWall.transform.position = new Vector3(this.background.localScale.x / 2f - num6, 0f, 0f);
			//this.gridContainer.position = new Vector3(-this.background.localScale.x / 2f + num6, this.screenRect.yMax - num6 - num4 );
			//this.gridContainer.position = new Vector3(-this.background.localScale.x / 2f + num6, this.screenRect.yMax - num4);
		}

		public bool CheckOutBound(Vector3 pos)
		{
			if(pos.y> this.topWall.transform.position.y+2)
			{
				return true;
			}
			if(pos.y < this.bottomWall.transform.position.y - 2)
			{
				return true;
			}

			if(pos.x< this.leftWall.transform.position.x-2)
			{
				return true;
			}

			if (pos.x > this.rightWall.transform.position.x+2)
			{
				return true;
			}
			return false;
		}
		public Vector3 GetPlayerBallPos()
		{
			return this.player.GetBallPos();
		}
	}
}
