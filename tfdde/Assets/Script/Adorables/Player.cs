using DG.Tweening;
using SimplePool;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Adorables.Ball
{
	public class Player : MonoBehaviour
	{

		[SerializeField]
		private Ball ballPrefab;

		//public GameObject Ven;

		[SerializeField]
		private TextMesh nRemainingBalls;

		[SerializeField]
		private float offsetRotation = 1;

		[SerializeField]
		private float numberOfDots = 10f;

		[SerializeField]
		private GameObject dotPrefab;

		[SerializeField]
		private Color[] ballcolors;

		[SerializeField]
		private Material linerenderma;

		[SerializeField]
		private Transform ball_pos;

		private Pool<Ball> _balls_pool;

		private int ballcount;

		//private List<Ball> balls;

		private int stopedBallsCount;

		private float threshold = 0.1f;

		public Action TurnEnded;

		public static int Azzerapalline;

		public float timerCheck;

		public static float Timercheck;

		public int BAlleinGioco;

		public int Zero;

		private Vector3 nextplayerpos;

		public Rect ScreenRect
		{
			get;
			set;
		}

		public float Speed
		{
			get;
			set;
		}

		public float SpawnFrequency
		{
			get;
			set;
		}

		public float BallScale
		{
			get;
			set;
		}

		public bool AllBallsStoped
		{
			get
			{
				return this.stopedBallsCount == this.ballcount;
			}
		}

		private void Awake()
		{
			_balls_pool = new Pool<Ball>();
		}

		private void OnDestroy()
		{
			_balls_pool.ClearUp();
		}

		public void FixedUpdate()
		{
			if (this.BAlleinGioco == 1)
			{
				Player.Timercheck += Time.deltaTime;
			}
			this.timerCheck = Player.Timercheck;
		}

		private void SubscribeToInputManager()
		{
			UnityEngine.Debug.Log("SubscribeToInputManager");
			InputManager.OnSwipeStarted += new Action<Vector3>(this.StartFiring);
			InputManager.OnSwipe += new Action<Vector3>(this.Fire);
			InputManager.OnSwipeEnded += new Action<Vector3>(this.EndFiring);
		}

		private void UnsubscribeToInputManager()
		{
			UnityEngine.Debug.Log("UnsubscribeToInputManager");
			InputManager.OnSwipeStarted -= new Action<Vector3>(this.StartFiring);
			InputManager.OnSwipe -= new Action<Vector3>(this.Fire);
			InputManager.OnSwipeEnded -= new Action<Vector3>(this.EndFiring);
		}

		public void SetUpBalls()
		{
			//this.balls = new List<Ball>();
			this.AddBall(500);
		}

		public void AddBall(int count)
		{
			//Ball ball = this._balls_pool.GetObject().ball;
			//this.balls.Add(ball);
			this.ballcount += count;
		}

		public void InitBall(Ball ball)
		{
			ball.transform.position = base.transform.position;
			ball.transform.localScale *= this.BallScale;
			Ball expr_4B = ball;
			expr_4B.HitFloor = (Action<Ball>)Delegate.Combine(expr_4B.HitFloor, new Action<Ball>(this.OnBallHitWall));
			ball.DeathAction = (Action<Ball>)Delegate.Combine(expr_4B.DeathAction, new Action<Ball>(this.OnBallDeath));
		}


		private void OnBallDeath(Ball ball)
		{
			this._balls_pool.DeleteObject(ball);
			//ball.gameObject.SetActive(false);
			this.stopedBallsCount++;
			if (this.AllBallsStoped)
			{
				this.EndTurn();
			}
		}
		private void OnBallHitWall(Ball ball)
		{
			nextplayerpos = new Vector3(ball.transform.position.x, base.transform.position.y);
			if (!firsthit)
			{
				firsthit = true;
				SetPlayerNextPos();
			}
		}

		private bool fireall = false;
		private bool firsthit = false;
		private void SetPlayerNextPos()
		{
			if(fireall && firsthit)
			{
				//base.transform.position = nextplayerpos;
				PlayerMoveNextPos();
			}
		}

		private void PlayerMoveNextPos()
		{
			base.transform.DOMove(nextplayerpos ,0.2f);
		}


		public void StartTurn()
		{
			this.SubscribeToInputManager();
			this.DisplayNRemainingBalls(true);
			this.SetNRemainingBalls(ballcount);
			this.DisplayPlayer(true);
			base.transform.position = new Vector3(Mathf.Clamp(base.transform.position.x, this.ScreenRect.xMin + base.transform.localScale.x, this.ScreenRect.xMax - base.transform.localScale.x), base.transform.position.y, 0f);
		}

		private void EndTurn()
		{
			if (this.TurnEnded != null)
			{
				this.TurnEnded();
			}
			this.BAlleinGioco = 0;
		}

		private void StartFiring(Vector3 startPos)
		{
			if (lineRenderer != null)
			{
				lineRenderer.gameObject.SetActive(false);
			}
		}
		private LineRenderer lineRenderer;
		Vector3[] linerenderpos = new Vector3[3];
		private void Fire(Vector3 movement)
		{
			movement = movement - this.GetBallPos();
			movement = new Vector3(movement.x, movement.y, 0);
			Vector2 direction = movement;
			UnityEngine.Debug.DrawRay(this.GetBallPos(), direction);
			RaycastHit2D hit = Physics2D.Raycast(this.GetBallPos(), direction, 1000, 1 << 9);
			//Vector2 circle_origin = hit.point + (-direction * 0.1f);
			//RaycastHit2D hitcircle = Physics2D.CircleCast(circle_origin, direction, 1000, 1 << 9);
			
			Vector2 hitdirection = Vector2.Reflect(direction, hit.normal);
			//if (hit.collider!=null && hit.collider.CompareTag(Constants.HITABLE_TAG))
			//{
			//	hitpos = hit.point;
			//}

			if (movement == Vector3.zero)
			{
				return;
			}
			if (movement != Vector3.zero)
			{
				if (lineRenderer == null)
				{
					GameObject LineRenderObj = new GameObject("linerender");
					LineRenderObj.transform.position = this.GetBallPos();
					lineRenderer = LineRenderObj.AddComponent<LineRenderer>();
					//设置材质  
					lineRenderer.material = linerenderma;
					//设置颜色  
					lineRenderer.SetColors(Color.red, Color.yellow);
					//设置宽度  
					lineRenderer.SetWidth(0.02f, 0.02f);
					lineRenderer.positionCount = 3;
					//lineRenderer.useWorldSpace = false;
				}
				else
				{
					lineRenderer.transform.position = this.GetBallPos();
					lineRenderer.gameObject.SetActive(true);
				}
				linerenderpos[0] = this.GetBallPos();
				linerenderpos[1] = new Vector3(hit.point.x, hit.point.y, 0);
				Vector2 destpos = hit.point + hitdirection.normalized * 1f;
				linerenderpos[2] = new Vector3(destpos.x, destpos.y, 0);
				lineRenderer.SetPositions(linerenderpos);
			}
		}

		private void EndFiring(Vector3 movement)
		{
			firsthit = false;
			fireall = false;
			if (lineRenderer != null)
			{
				lineRenderer.gameObject.SetActive(false);
			}
			movement = movement -this.GetBallPos();
			movement = new Vector3(movement.x, movement.y, 0);
			if (Vector3.Angle(movement, Vector3.up) > 90f - this.offsetRotation)
			{
				return;
			}
			Vector3 b = new Vector3(this.ScreenRect.xMin, base.transform.position.y, 0f);
			//if (Vector3.Distance(base.transform.position, b) < base.transform.localScale.x + this.threshold && Vector3.Dot(movement, Vector3.right) < 0f)
			//{
			//	return;
			//}
			//Vector3 b2 = new Vector3(this.ScreenRect.xMax, base.transform.position.y, 0f);
			//if (Vector3.Distance(base.transform.position, b2) < base.transform.localScale.x + this.threshold && Vector3.Dot(movement, Vector3.right) > 0f)
			//{
			//	return;
			//}
			this.UnsubscribeToInputManager();
			//this.DisplayPlayer(false);
			this.stopedBallsCount = 0;
			base.StartCoroutine(this.SpawnBallsCoroutine(movement));
		}

		[DebuggerHidden]
		private IEnumerator SpawnBallsCoroutine(Vector3 movement)
		{
			Vector3 startPosition;
			int i;
			Ball ball;

			startPosition = this.GetBallPos();
			i = 0;
			while (true)
			{
				if (i >= this.ballcount)
				{
					fireall = true;
					SetPlayerNextPos();
					yield return new WaitForSeconds(2f * this.SpawnFrequency);
					this.DisplayNRemainingBalls(false);
					yield break;
				}
				else
				{
					this.BAlleinGioco = 1;
					//ball = this.balls[i];
					ball = this._balls_pool.GetObject();
					ball.transform.position = startPosition + movement * 0.5f * 0f;
					ball.gameObject.SetActive(true);
					ball.Direction = movement.normalized;
					ball.Speed = this.Speed;
					ball.SetDeadMovePos(startPosition);
					if (this.ballcolors != null)
					{
						ball.SetColor(this.ballcolors[i % this.ballcolors.Length]);
					}
					this.SetNRemainingBalls(this.ballcount - 1 - i);
					yield return new WaitForSeconds(this.SpawnFrequency);
					i++;
				}
			}
			
		}

		private void SetNRemainingBalls(int count)
		{
			this.nRemainingBalls.text = "x" + count.ToString();
		}

		private void DisplayNRemainingBalls(bool isShown)
		{
			this.nRemainingBalls.gameObject.SetActive(isShown);
		}

		private void DisplayPlayer(bool isShown)
		{
			this.gameObject.SetActive(isShown);
		}

		public void Update()
		{
			if (GameManager.Gonext == 0)
			{
				this.stopedBallsCount = 0;
			}
		}

		public Vector3 GetBallPos()
		{
			return this.ball_pos.position;
		}
	}
}
