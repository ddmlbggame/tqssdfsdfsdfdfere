using System;
using UnityEngine;

namespace AppAdvisory.BallX
{
	public class Ball : MonoBehaviour
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
		private float maxspeed = 12f;

		[SerializeField]
		private SpriteRenderer ballsprite;

		public Action<Ball> HitFloor;

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
			base.transform.position += this.Direction * Time.deltaTime * this.Speed;
			this.timer += Time.deltaTime;
			if (GameManager.Instance.CheckOutBound(base.transform.position))
			{
				UnityEngine.Debug.LogError("–°«Ú¥©«Ω¡À");
				if (this.HitFloor != null)
				{
					this.HitFloor(this);
				}
			}
			Debug.DrawRay(base.transform.position, this.Direction);
			RaycastHit2D hit = Physics2D.Raycast(base.transform.position, this.Direction, this.Speed * Time.deltaTime * 1.2f, 1 << 9);
			if (!hit)
			{
				return;
			}
			if (hit.collider.CompareTag(Constants.HITABLE_TAG))
			{
				Cell component = hit.collider.GetComponent<Cell>();
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

			//if (hit.collider.CompareTag(Constants.BALL_TAG))
			//{
			//	return;
			//}
			this.Speed += this.addspeed;
			this.Speed = Mathf.Min(this.Speed, this.maxspeed);
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

		private void OnEnable()
		{
			this.timer = 0f;
		}

		private void OnDisable()
		{
			this.timer = 0f;
		}


		private void OnTriggerEnter2D(Collider2D other)
		{
			if (other.CompareTag(Constants.FLOOR_TAG) && this.HitFloor != null)
			{
				this.HitFloor(this);
			}
		}
	}
}
