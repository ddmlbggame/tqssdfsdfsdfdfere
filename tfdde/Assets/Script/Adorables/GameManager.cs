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

		private static readonly string VerySimpleAdsURL = "http://u3d.as/oWD";

		private static readonly string VerySimpleRateURL = "http://u3d.as/Dt2";

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
		private UIManager uiManager;

		[SerializeField]
		private Player player;

		[SerializeField]
		private AudioSource source;

		[SerializeField]
		private AudioClip gameOver;

		private Rect screenRect;

		private float stepX;

		public float stepXbomb;

		private float maxCellProbability;

		private List<Transform> cells;

		private Transform gridContainer;

		private Vector3 bottomLimit;

		public static int nTurn;

		private int ballToAddCount;

		public Camera cam;

		public float aspect;

		public static int StatoRisoluzione;

		//public Sprite SoundOn;

		//public Sprite SoundOff;

		//public GameObject btnimg;

		//public GameObject btnimgPause;

		public bool CanMute;

		public static int ContinuaReward;

		public static int Continuacount;

		public static int Gonext;

		public static int Econesso;

		public static int Continuads;

		public GameObject BtnContinua;

		public GameObject BtnRateus;

		public GameObject BtnX2coins;

		public static int ManagerContinua = 1;

		public int FasedelGiocoContinue;

		public static int Fase;

		public static int ShopOpen;

		//public GameObject CanvasQuit;

		private Vector3 MovingDirection = Vector3.up;

		public GameObject BtnBomba;

		//public GameObject Btngift;

		public int AttivaBomba;

		public int ObFatto;

		public static float height;

		public float Altezza;

		private void Awake()
		{
			Instance = this;
		}
		private void Start()
		{
			this.CanMute = true;
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
			//this.SubscribeToUIManager();
			this.SetUpScreen();
			this.SetUpGrid();
			this.SetUpLevelBounds();
			this.SetUpPlayer();
		}

		private void SubscribeToUIManager()
		{
			UIManager expr_06 = this.uiManager;
			expr_06.PlayButtonClicked = (Action)Delegate.Combine(expr_06.PlayButtonClicked, new Action(this.OnPlayButtonClicked));
			UIManager expr_2D = this.uiManager;
			expr_2D.WatchAdButtonClicked = (Action)Delegate.Combine(expr_2D.WatchAdButtonClicked, new Action(this.OnWatchAdButtonClicked));
			UIManager expr_54 = this.uiManager;
			expr_54.RateButtonClicked = (Action)Delegate.Combine(expr_54.RateButtonClicked, new Action(this.OnRateButtonClicked));
			UIManager expr_7B = this.uiManager;
			expr_7B.MainMenuButtonClicked = (Action)Delegate.Combine(expr_7B.MainMenuButtonClicked, new Action(this.OnMainMenuButtonClicked));
			UIManager expr_A2 = this.uiManager;
			expr_A2.ReplayButtonClicked = (Action)Delegate.Combine(expr_A2.ReplayButtonClicked, new Action(this.OnReplayButtonClicked));
			UIManager expr_C9 = this.uiManager;
			expr_C9.ContinueButtonClicked = (Action)Delegate.Combine(expr_C9.ContinueButtonClicked, new Action(this.OnContinueButtonClicked));
			UIManager expr_F0 = this.uiManager;
			expr_F0.PauseButtonClicked = (Action)Delegate.Combine(expr_F0.PauseButtonClicked, new Action(this.Paused));
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
			Sounds.PlayBtnSound = 1;
			this.StartGame();
			GameManager.Fase = 1;
			GameManager.Gonext = 1;
			this.NextTurn();
			this.AttivaBomba = 1;
		}

		public void RestartGame()
		{
			if (PlayerPrefs.HasKey("RemoveAds"))
			{
				this.AttivaBomba = 1;
				GameManager.ManagerContinua = 1;
				PlayerPrefs.SetInt("continua", GameManager.ManagerContinua);
				PlayerPrefs.Save();
				Sounds.PlayBtnSound = 1;
				this.uiManager.DisplayContinua(false);
				this.uiManager.DisplayTitlecard(false);
				this.uiManager.DisplayHUD(true);
				this.DisplayPlayer(true);
				Time.timeScale = 1f;
				this.player.StartTurn();
				this.Reset();
				Utils.Currentscore = 0;
				this.currentMinCellCount = this.startMinCellCount;
				this.currentMaxCellCount = this.startMinCellCount;
				this.NextTurn();
				this.BtnRateus.SetActive(true);
				this.BtnX2coins.SetActive(true);
				Player.Azzerapalline = 1;
				this.player.SetUpBalls();
			}
			else
			{
				this.AttivaBomba = 1;
				GameManager.ManagerContinua = 1;
				PlayerPrefs.SetInt("continua", GameManager.ManagerContinua);
				PlayerPrefs.Save();
				Sounds.PlayBtnSound = 1;
				this.uiManager.DisplayContinua(false);
				this.uiManager.DisplayTitlecard(false);
				this.uiManager.DisplayHUD(true);
				this.DisplayPlayer(true);
				Time.timeScale = 1f;
				this.player.StartTurn();
				this.Reset();
				Utils.Currentscore = 0;
				this.currentMinCellCount = this.startMinCellCount;
				this.currentMaxCellCount = this.startMinCellCount;
				this.NextTurn();
				this.BtnRateus.SetActive(true);
				this.BtnX2coins.SetActive(true);
				Player.Azzerapalline = 1;
				this.player.SetUpBalls();
			}
		}

		public void MuteAudio()
		{
			if (this.CanMute)
			{
				AudioListener.pause = true;
				this.CanMute = false;
				//this.btnimg.GetComponent<Image>().sprite = this.SoundOff;
				//this.btnimgPause.GetComponent<Image>().sprite = this.SoundOff;
			}
			else
			{
				AudioListener.pause = false;
				this.CanMute = true;
				//this.btnimg.GetComponent<Image>().sprite = this.SoundOn;
				//this.btnimgPause.GetComponent<Image>().sprite = this.SoundOn;
			}
		}

		private void OnWatchAdButtonClicked()
		{
		}

		private void OnRateButtonClicked()
		{
		}

		private void OnShopButtonClicked()
		{
		}

		private void OnReplayButtonClicked()
		{
			this.uiManager.DisplayGameOver(false);
			this.StartGame();
			Time.timeScale = 1f;
		}

		private void Paused()
		{
			Sounds.PlayBtnSound = 1;
			this.uiManager.DisplayPause(true);
			this.uiManager.DisplayHUD(false);
			Time.timeScale = 0f;
		}

		private void ContinuaRewarded()
		{
			GameManager.Continuacount++;
			PlayerPrefs.SetInt("cont", GameManager.Continuacount);
			PlayerPrefs.Save();
			Sounds.PlayBtnSound = 1;
			//this.uiManager.DisplayContinua(false);
			//this.uiManager.DisplayTitlecard(false);
			this.DisplayPlayer(true);
			Time.timeScale = 1f;
			BombShoot.RandomEffect = 5;
			this.player.StartTurn();
			GameManager.ManagerContinua = 2;
			PlayerPrefs.SetInt("continua", GameManager.ManagerContinua);
			PlayerPrefs.Save();
		}

		private void RewardedVideoAdShowFailed()
		{
			Sounds.PlayBtnSound = 1;
			this.uiManager.DisplayContinua(true);
			this.uiManager.DisplayTitlecard(false);
			Time.timeScale = 0f;
			GameManager.ManagerContinua = 2;
		}

		private void OnContinueButtonClicked()
		{
	
		}

		private void OnMainMenuButtonClicked()
		{
			Sounds.PlayBtnSound = 1;
			Utils.NextTurn = 2;
			this.uiManager.DisplayGameOver(false);
			this.uiManager.DisplayTitlecard(true);
			this.Reset();
			this.player.SetUpBalls();
			GameManager.Fase = 0;
			GameManager.Gonext = 0;
			this.DisplayPlayer(false);
			this.BtnRateus.SetActive(true);
			this.BtnX2coins.SetActive(true);
		}

		public void Reset()
		{
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
			this.cells = new List<Transform>();
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
					//else
					//{
					//	this.CreateBrick(i, 0);
					//}
				}
			}
		}

		private void MoveGrid()
		{
			foreach (Transform current in this.cells)
			{
				Vector3 endposition = current.position - Vector3.up * this.stepX;
				current.DOMove(endposition, 0.5f);
			}
		}

		private void NextTurn()
		{
			base.StartCoroutine(this.NextTurnCoroutine());
			UnityEngine.Debug.Log("next turn");
		}

		public void InternetStatus()
		{
			if (Application.internetReachability != NetworkReachability.NotReachable)
			{
				this.Continuareilgioco();
				if (GameManager.ManagerContinua == 1)
				{
					this.BtnContinua.SetActive(true);
					this.BtnContinua.GetComponent<Button>().enabled = true;
					this.BtnRateus.SetActive(false);
					this.BtnX2coins.SetActive(false);
					GameManager.Econesso = 1;
				}
			}
			else
			{
				this.Continuareilgioco();
				if (GameManager.ManagerContinua == 1)
				{
					this.BtnContinua.SetActive(true);
					this.BtnContinua.GetComponent<Button>().enabled = false;
					this.BtnRateus.SetActive(false);
					this.BtnX2coins.SetActive(false);
					GameManager.Econesso = 0;
				}
			}
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
				Time.timeScale = 0f;
				UnityEngine.Debug.Log("gameover");
			}
			else
			{
				yield return new WaitForSeconds(0.5f);
				for (int i = 0; i < this.ballToAddCount; i++)
					{
					this.player.AddBall();
				}
				this.ballToAddCount = 0;
				this.player.StartTurn();
			}
		}

		//public void RateButtonClick()
		//{
		//	Application.OpenURL("https://play.google.com/store/apps/details?id=com.ItaIndieStudio.BubbleShotBallz");
		//}

		private void Continuareilgioco()
		{
			PlayerPrefs.SetInt("continua", GameManager.ManagerContinua);
			PlayerPrefs.Save();
			GameManager.ManagerContinua = PlayerPrefs.GetInt("continua");
			if (GameManager.ManagerContinua == 2)
			{
				int num = UnityEngine.Random.Range(1, 3);
				if (num == 1)
				{
					this.BtnContinua.SetActive(false);
					this.BtnRateus.SetActive(true);
					this.BtnX2coins.SetActive(false);
				}
				else if (num == 2)
				{
					this.BtnContinua.SetActive(false);
					this.BtnRateus.SetActive(false);
					this.BtnX2coins.SetActive(true);
				}
			}
			UnityEngine.Debug.Log("Panello continua e apparso");
			this.ShowAds();
			for (int i = this.cells.Count - 1; i > -1; i--)
			{
			}
			this.DisplayPlayer(false);
			this.uiManager.DisplayHUD(false);
			this.uiManager.DisplayContinua(true);
		}

		private void GameOver()
		{
			this.ShowAds();
			for (int i = this.cells.Count - 1; i > -1; i--)
			{
				UnityEngine.Object.Destroy(this.cells[i].gameObject);
				this.cells.RemoveAt(i);
			}
			this.DisplayPlayer(false);
			this.uiManager.DisplayHUD(false);
			this.uiManager.DisplayGameOver(true);
		}

		private void DisplayPlayer(bool isShown)
		{
			this.player.gameObject.SetActive(isShown);
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
					Vector3 position = this.cells[i].position;
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
			Transform transform;
			if (value < this.addBallProbability)
			{
				AddBall addBall = UnityEngine.Object.Instantiate<AddBall>(this.addBallPrefab);
				AddBall expr_26 = addBall;
				expr_26.OnCollision = (Action<AddBall>)Delegate.Combine(expr_26.OnCollision, new Action<AddBall>(this.AddBall_OnCollision));
				transform = addBall.transform;
			}
			else if (value < this.addCoinProbability)
			{
				AddBomb addBomb = UnityEngine.Object.Instantiate<AddBomb>(this.addBombPrefab);
				AddBomb expr_6C = addBomb;
				expr_6C.OnCollision = (Action<AddBomb>)Delegate.Combine(expr_6C.OnCollision, new Action<AddBomb>(this.AddBomb_OnCollision));
				transform = addBomb.transform;
			}
			else
			{
				AddCoin addCoin = UnityEngine.Object.Instantiate<AddCoin>(this.addCoinPrefab);
				AddCoin expr_A8 = addCoin;
				expr_A8.OnCollision = (Action<AddCoin>)Delegate.Combine(expr_A8.OnCollision, new Action<AddCoin>(this.AddCoin_OnCollision));
				transform = addCoin.transform;
			}
			transform.SetParent(this.gridContainer);
			transform.localPosition = this.GetPositionFromModel(x, y);
			this.cells.Add(transform);
		}

		private void AddBall_OnCollision(AddBall sender)
		{
			this.cells.Remove(sender.transform);
			this.ballToAddCount++;
		}

		private void AddCoin_OnCollision(AddCoin sender)
		{
			this.cells.Remove(sender.transform);
			Utils.Moneta++;
			PlayerPrefs.SetInt("moneta", Utils.Moneta);
			PlayerPrefs.Save();
		}

		private void AddBomb_OnCollision(AddBomb sender)
		{
			this.cells.Remove(sender.transform);
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
			this.cells.Add(cell.transform);
			int count = UnityEngine.Random.Range(this.currentMinCellCount, this.currentMaxCellCount + 1);
			cell._count = count;
			cell.SetCount(count);
			cell.SetColors(this.cellColors ,this.colorStep);
			cell.SetStartScale(cell.transform.localScale);
		}

		private void Cell_OnDestroyedByBall(IHitableByBall sender)
		{
			MonoBehaviour monoBehaviour = (MonoBehaviour)sender;
			this.cells.Remove(monoBehaviour.transform);
		}

		private void Cell_OnDestroyedByBomb(IHitableByBall sender)
		{
			MonoBehaviour monoBehaviour = (MonoBehaviour)sender;
			this.cells.Remove(monoBehaviour.transform);
		}

		private void Cell_OnDestroyedByBomba(IHitableByBall sender)
		{
			MonoBehaviour monoBehaviour = (MonoBehaviour)sender;
			this.cells.Remove(monoBehaviour.transform);
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
			this.player.SetUpTrajectoryDots();
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

		public void Achievement()
		{
			Sounds.PlayBtnSound = 1;
		}

		public void Leaderboard()
		{
			Sounds.PlayBtnSound = 1;
		}

		public void Tenk()
		{
			Utils.Moneta += 20000;
			PlayerPrefs.SetInt("moneta", Utils.Moneta);
			PlayerPrefs.Save();
		}

		public void CallBombAtomic()
		{
			this.BtnBomba.SetActive(false);
		}

		public void CallRandomBomb()
		{
			//this.Btngift.SetActive(false);
			//base.StartCoroutine(this.attivaBtn());
		}

		[DebuggerHidden]
		private IEnumerator attivaBtn()
		{
			yield return new WaitForSeconds(30f);
			//this.Btngift.SetActive(true);
		}


		public void Update()
		{
			if (GameManager.ContinuaReward == 1)
			{
				GameManager.ContinuaReward = 0;
				this.ContinuaRewarded();
			}
			if (GameManager.ContinuaReward == 2)
			{
				GameManager.ContinuaReward = 0;
				this.RewardedVideoAdShowFailed();
			}
			GameManager.Continuacount = PlayerPrefs.GetInt("cont");
			if (GameManager.Continuacount >= 20 && this.ObFatto == 0)
			{
				this.ObFatto = 1;
				PlayerPrefs.SetInt("obFatto", this.ObFatto);
				PlayerPrefs.Save();
				this.ObFatto = PlayerPrefs.GetInt("obFatto");
			}
			if (Utils.Currentscore > 25 && this.AttivaBomba == 1)
			{
				this.AttivaBomba = 0;
				this.BtnBomba.SetActive(true);
			}
			else if (Utils.Currentscore < 25 && this.AttivaBomba == 1)
			{
				this.BtnBomba.SetActive(false);
			}
			this.BtnBomba.transform.Translate(this.MovingDirection * Time.smoothDeltaTime);
			if (this.BtnBomba.transform.position.y > 1.5f)
			{
				this.MovingDirection = Vector3.down;
			}
			else if (this.BtnBomba.transform.position.y < -1.5f)
			{
				this.MovingDirection = Vector3.up;
			}
			this.FasedelGiocoContinue = GameManager.ManagerContinua;
			if (Input.GetKeyDown(KeyCode.Escape) && GameManager.Fase == 1)
			{
				this.Paused();
				UnityEngine.Debug.Log("pause");
			}
			else if (Input.GetKeyDown(KeyCode.Escape) && GameManager.Fase == 0)
			{
				Application.Quit();
			}
			this.player.Speed = this.speed;
			if (GameManager.Continuads == 1)
			{
				GameManager.Continuads = 0;
				UnityEngine.Debug.Log("Checked Update");
			}
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

			if(pos.x< this.leftWall.transform.position.x)
			{
				return true;
			}

			if (pos.x > this.rightWall.transform.position.x)
			{
				return true;
			}
			return false;
		}

		public void ShowAds()
		{
			int num = PlayerPrefs.GetInt("GAMEOVER_COUNT", 0);
			num++;
			if (num >= this.numberOfPlayToShowInterstitial)
			{
				UnityEngine.Debug.LogWarning("To show ads, please have a look at Very Simple Ad on the Asset Store, or go to this link: " + GameManager.VerySimpleAdsURL);
				PlayerPrefs.SetInt("GAMEOVER_COUNT", 0);
			}
			else
			{
				PlayerPrefs.SetInt("GAMEOVER_COUNT", num);
			}
			PlayerPrefs.Save();
		}
	}
}
