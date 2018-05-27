using DG.Tweening;
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

		private List<Transform> trajectoryDots;

		private List<Ball> balls;

		private int stopedBallsCount;

		private float threshold = 0.1f;

		public Action TurnEnded;

		public static int Azzerapalline;

		public float timerCheck;

		public static float Timercheck;

		public int BAlleinGioco;

		public int Zero;

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
				return this.stopedBallsCount == this.balls.Count;
			}
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
			this.balls = new List<Ball>();
			this.AddBall();
		}

		public void AddBall()
		{
			Ball ball = UnityEngine.Object.Instantiate<Ball>(this.ballPrefab);
			ball.transform.position = base.transform.position;
			ball.transform.localScale *= this.BallScale;
			ball.gameObject.SetActive(false);
			Ball expr_4B = ball;
			expr_4B.HitFloor = (Action<Ball>)Delegate.Combine(expr_4B.HitFloor, new Action<Ball>(this.OnBallHitWall));
			this.balls.Add(ball);
		}

		private void OnBallHitWall(Ball ball)
		{
			ball.gameObject.SetActive(false);
			if (this.stopedBallsCount == 0)
			{
				base.transform.position = new Vector3(ball.transform.position.x, base.transform.position.y);
				//this.DisplayPlayer(true);
			}
			ball.transform.position = base.transform.position;
			this.stopedBallsCount++;
			if (this.AllBallsStoped)
			{
				this.EndTurn();
			}
		}

		//private void MoveBallToPlayer(Ball ball)
		//{
		//	ball.transform.DOMove()
		//}

		public void StartTurn()
		{
			this.SubscribeToInputManager();
			this.DisplayNRemainingBalls(true);
			this.SetNRemainingBalls(this.balls.Count);
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

		public void SetUpTrajectoryDots()
		{
			this.trajectoryDots = new List<Transform>();
			int num = 0;
			while ((float)num < this.numberOfDots)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.dotPrefab);
				gameObject.transform.localScale *= this.BallScale;
				gameObject.transform.position = Vector3.zero;
				gameObject.SetActive(false);
				this.trajectoryDots.Add(gameObject.transform);
				num++;
			}
		}

		private void StartFiring(Vector3 startPos)
		{
			//foreach (Transform current in this.trajectoryDots)
			//{
			//	if (!(current != null))
			//	{
			//		break;
			//	}
			//	current.position = base.transform.position;
			//	current.gameObject.SetActive(true);
			//}
			if (lineRenderer != null)
			{
				lineRenderer.gameObject.SetActive(false);
			}
		}
		private LineRenderer lineRenderer;
		Vector3[] linerenderpos = new Vector3[3];
		private void Fire(Vector3 movement)
		{
			movement = movement - base.transform.position;
			movement = new Vector3(movement.x, movement.y, 0);
			Vector2 direction = movement;
			UnityEngine.Debug.DrawRay(base.transform.position, direction);
			RaycastHit2D hit = Physics2D.Raycast(base.transform.position, direction, 1000, 1 << 9);
			//Vector2 hitpos = Vector2.zero;
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
					LineRenderObj.transform.position = base.transform.position;
					lineRenderer = LineRenderObj.AddComponent<LineRenderer>();
					//设置材质  
					lineRenderer.material = new Material(Shader.Find("Particles/Additive"));
					//设置颜色  
					lineRenderer.SetColors(Color.red, Color.yellow);
					//设置宽度  
					lineRenderer.SetWidth(0.02f, 0.02f);
					lineRenderer.positionCount = 3;
					//lineRenderer.useWorldSpace = false;
				}
				else
				{
					lineRenderer.transform.position = base.transform.position;
					lineRenderer.gameObject.SetActive(true);
				}
				linerenderpos[0] = base.transform.position;
				linerenderpos[1] = new Vector3(hit.point.x, hit.point.y, 0);
				Vector2 destpos = hit.point + hitdirection.normalized * 1f;
				linerenderpos[2] = new Vector3(destpos.x, destpos.y, 0);
				lineRenderer.SetPositions(linerenderpos);
			}
			//if (this.trajectoryDots != null)
			//{
			//	if (movement == Vector3.zero)
			//	{
			//		return;
			//	}
			//	if (movement != Vector3.zero)
			//	{
			//		this.SetTrajectoryPoints(base.transform.position, movement);
			//	}
			//}
			//else
			//{
			//	UnityEngine.Debug.Log("No swipe");
			//}
		}

		private void EndFiring(Vector3 movement)
		{
			if (lineRenderer != null)
			{
				lineRenderer.gameObject.SetActive(false);
			}
			movement = movement -base.transform.position;
			movement = new Vector3(movement.x, movement.y, 0);
			//foreach (Transform current in this.trajectoryDots)
			//{
			//	if (!(current != null))
			//	{
			//		return;
			//	}
			//	current.gameObject.SetActive(false);
			//}
			if (Vector3.Angle(movement, Vector3.up) > 90f - this.offsetRotation)
			{
				return;
			}
			//Vector3 b = new Vector3(this.ScreenRect.xMin, base.transform.position.y, 0f);
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

			startPosition = this.transform.position;
			i = 0;
			while (true)
			{
				if (i >= this.balls.Count)
				{
					yield return new WaitForSeconds(2f * this.SpawnFrequency);
					this.DisplayNRemainingBalls(false);
					yield break;
				}
				else
				{
					this.BAlleinGioco = 1;
					ball = this.balls[i];
					ball.transform.position = startPosition + movement * 0.5f * 0f;
					ball.gameObject.SetActive(true);
					ball.Direction = movement.normalized;
					ball.Speed = this.Speed;
					if (this.ballcolors != null)
					{
						ball.SetColor(this.ballcolors[i % this.ballcolors.Length]);
					}
					this.SetNRemainingBalls(this.balls.Count - 1 - i);
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

		private void SetTrajectoryPoints(Vector3 posStart, Vector2 direction)
		{
			float num = Mathf.Sqrt(direction.x * direction.x + direction.y * direction.y);
			float num2 = 57.29578f * Mathf.Atan2(direction.y, direction.x);
			float num3 = 0f;
			num3 += 0.5f;
			foreach (Transform current in this.trajectoryDots)
			{
				float num4 = num * num3 * Mathf.Cos(num2 * 0.0174532924f);
				float num5 = num * num3 * Mathf.Sin(num2 * 0.0174532924f);
				Vector3 position = new Vector3(posStart.x + num4, posStart.y + num5, 0f);
				current.position = position;
				current.gameObject.SetActive(true);
				current.eulerAngles = new Vector3(0f, 0f, Mathf.Atan2(direction.y, direction.x));
				num3 += 0.5f;
			}
		}

		public void Update()
		{
			if (GameManager.Gonext == 0)
			{
				this.stopedBallsCount = 0;
			}
		}
	}
}
