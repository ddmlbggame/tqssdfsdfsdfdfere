using SimplePool;
using System;
using UnityEngine;

namespace Adorables.Ball
{
	public class Ball : MonoBehaviour , IAboPool<Ball>
	{
		[SerializeField]
		private AudioSource source;

		[SerializeField]
		private AudioClip hitBrick;

		[SerializeField]
		private AudioClip hitPickable;
		[SerializeField]
		private float addspeed = 0.3f;

		[SerializeField]
		private float maxspeed = 11f;

		[SerializeField]
		private float Acceleration = -0.3f;

		[SerializeField]
		private float minspeed = 7f;

		[SerializeField]
		private float startspeed = 3f;

		[SerializeField]
		private SpriteRenderer ballsprite;

		public Action<Ball> HitFloor;

		public Action<Ball> DeathAction;

		private float timeToConsiderBeingStuck = 3f;

		private float timeToConsiderBeingStuckVuoto = 6f;

		private float timer;

		private Vector3 baseOffsetDirection = Vector3.down * 0.1f;
		
		public float Speed
		{
			get;
			set;
		}

		public Vector3 Direction
		{
			get;
			set;
		}

		public void SetColor(Color color)
		{
			this.ballsprite.color = color;
			TrailRenderer trail_render = this.GetComponent<TrailRenderer>();
			trail_render.startColor = color;
			trail_render.endColor = color;
		}
		private void FixedUpdate()
		{
			if (deadtomove)
			{
				DeadToMove();
			}else
			{
				base.transform.position += this.Direction * Time.deltaTime * this.Speed;
				this.timer += Time.deltaTime;
				//this.Speed += Time.deltaTime * Acceleration;
				//this.Speed = Mathf.Max(this.minspeed, this.Speed);
				if (GameManager.Instance.CheckOutBound(base.transform.position))
				{
					UnityEngine.Debug.LogError("–°«Ú¥©«Ω¡À");
					if (this.DeathAction != null)
					{
						this.DeathAction(this);
					}
				}
				//Debug.Log(Vector2.Angle(Vector2.up, Direction));
				//base.transform.eulerAngles = new Vector3(0,0, -Vector2.Angle(Vector2.up, Direction));
				Vector2 dest = base.transform.position + this.Direction * this.Speed * Time.deltaTime * 1.2f;
				//Debug.Log(this.Direction + ":" + this.Speed * Time.deltaTime * 1.2f);
				Debug.DrawLine(base.transform.position, dest);
				//RaycastHit2D hit = Physics2D.Raycast(base.transform.position, this.Direction, this.Speed * Time.deltaTime * 1.2f, 1 << 9);
				RaycastHit2D hit = Physics2D.CircleCast(base.transform.position, 0.01f,this.Direction, this.Speed * Time.deltaTime * 1.2f, 1 << 9);
				
				if (!hit)
				{
					return;
				}
				if (hit.collider.CompareTag(Constants.HITABLE_TAG))
				{
					Cell component = hit.collider.GetComponent<Cell>();
					if (component == null)
					{
						component = hit.collider.transform.parent.GetComponent<Cell>();
					}
					component.BallHit(this);
					this.source.PlayOneShot(this.hitBrick);
					this.timer = 0f;
					Player.Timercheck = 0f;
				}
				if (hit.collider.CompareTag(Constants.FLOOR_TAG))
				{
					return;
				}
				if (hit.collider.CompareTag(Constants.PICKABLE_TAG))
				{
					this.source.PlayOneShot(this.hitPickable);
					this.timer = 0f;
					Player.Timercheck = 0f;
					return;
				}
				//this.Speed += this.addspeed;
				//this.Speed = Mathf.Min(this.Speed, this.maxspeed);
				Vector3 zero = Vector3.zero;
				if (this.timer >= this.timeToConsiderBeingStuck)
				{
					this.timer = 0f;
					Player.Timercheck = 0f;
					zero = this.baseOffsetDirection;
				}
				if (Player.Timercheck >= this.timeToConsiderBeingStuckVuoto)
				{
					Player.Timercheck = 0f;
					zero = this.baseOffsetDirection;
				}
				this.Direction = Vector3.Reflect(this.Direction, hit.normal) + zero;
			}
		}

		private void OnEnable()
		{
			this.timer = 0f;
		}

		private void OnDisable()
		{
			this.timer = 0f;
		}

		private bool deadtomove = false;

		private float deathspeed = 6;
		private float deathAcceleration = 2f;
		public void SetDeadMovePos(Vector3 pos)
		{
			deadtomove = false;
		}

		public void DeadToMove()
		{
			Vector3 direction = (GameManager.Instance.GetPlayerBallPos() - this.transform.position).normalized;
			this.transform.position += direction * Time.deltaTime * this.deathspeed;
			deathspeed += Time.deltaTime;
			deathspeed = Mathf.Clamp(deathspeed, 6, 10);
			if (Vector3.Distance(this.transform.position, GameManager.Instance.GetPlayerBallPos()) <= 0.1f)
			{
				this.transform.position = GameManager.Instance.GetPlayerBallPos();
				if (this.DeathAction != null)
				{
					this.DeathAction(this);
				}
			}
		}

		private void OnTriggerEnter2D(Collider2D other)
		{
			if (other.CompareTag(Constants.FLOOR_TAG) && this.HitFloor!=null)
			{
				deadtomove = true;
				deathspeed = this.Speed+2;
				this.HitFloor(this);
			}

			if (other.CompareTag(Constants.HITABLE_TAG))
			{
				//this.Direction = Vector3.Reflect(this.Direction, other.collider.po) + zero;
			}
			
		}

		private void OnCollisionEnter2D(Collision2D collid)
		{

		}

		public bool Init()
		{
			//var obj = Resources.Load("Prefab/Ball3");
			//GameObject ball = UnityEngine.Object.Instantiate(obj) as GameObject;
			GameManager.Instance.player.InitBall(this);
			return true;
		}

		public Ball Create()
		{
			var obj = Resources.Load("Prefab/Ball3");
			GameObject ball = UnityEngine.Object.Instantiate(obj) as GameObject;
			return ball.GetComponent<Ball>();
		}

		public void OnRecycle()
		{
			this.gameObject.SetActive(true);
		}

		public void OnDelete()
		{
			this.gameObject.SetActive(false);
		}

		//public static Ball Create()
		//{
		//	var obj = Resources.Load("Prefab/Ball3");
		//	GameObject ball = UnityEngine.Object.Instantiate(obj) as GameObject;
		//	return ball.GetComponent<Ball>();
		//}
	}
}
