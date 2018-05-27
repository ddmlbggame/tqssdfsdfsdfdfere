using System;
using UnityEngine;

namespace AppAdvisory.BallX
{
	public class MissileRed : MonoBehaviour
	{
		[SerializeField]
		private AudioSource source;

		[SerializeField]
		private AudioClip hitBrick;

		[SerializeField]
		private AudioClip hitPickable;

		public Action<MissileRed> HitFloor;

		public float Speed;

		private float timeToConsiderBeingStuck = 5f;

		private float timer;

		private Vector3 baseOffsetDirection = Vector3.down * 0.1f;

		public Vector3 Direction
		{
			get;
			set;
		}

		private void FixedUpdate()
		{
			base.transform.position += Vector3.left * Time.deltaTime * this.Speed;
			this.timer += Time.deltaTime;
			RaycastHit2D hit = Physics2D.Raycast(base.transform.position, this.Direction, this.Speed * Time.deltaTime * 1.2f, -257);
			if (!hit)
			{
				return;
			}
			if (hit.collider.CompareTag(Constants.HITABLE_TAG))
			{
				Cell component = hit.collider.GetComponent<Cell>();
				component.RedHit(this);
				this.source.PlayOneShot(this.hitBrick);
				Debug.Log(" missiles collided brick");
				this.timer = 0f;
			}
			if (hit.collider.CompareTag(Constants.FLOOR_TAG))
			{
				return;
			}
			if (hit.collider.CompareTag(Constants.PICKABLE_TAG))
			{
				this.timer = 0f;
				return;
			}
			Vector3 zero = Vector3.zero;
			if (this.timer >= this.timeToConsiderBeingStuck)
			{
				this.timer = 0f;
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
