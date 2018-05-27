using System;
using UnityEngine;

namespace AppAdvisory.BallX
{
	public class Atomic : MonoBehaviour
	{
		[SerializeField]
		private AudioSource source;

		[SerializeField]
		private AudioClip hitBrick;

		[SerializeField]
		private AudioClip hitPickable;

		public Action<Atomic> HitFloor;

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
			base.transform.position += Vector3.up * Time.deltaTime * this.Speed;
			this.timer += Time.deltaTime;
			Vector3 zero = Vector3.zero;
			if (this.timer >= this.timeToConsiderBeingStuck)
			{
				this.timer = 0f;
				zero = this.baseOffsetDirection;
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
	}
}
