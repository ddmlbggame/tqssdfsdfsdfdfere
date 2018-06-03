using System;
using UnityEngine;

namespace Adorables.Ball
{
	public class AddBall : BasicCell
	{
		[SerializeField]
		private Transform border;

		public Action<AddBall> OnCollision;

		private Vector3 startScale;

		private float count;

		private void OnTriggerEnter2D(Collider2D other)
		{
			UnityEngine.Debug.Log("------" + other.name);
			if (other.CompareTag(Constants.BALL_TAG))
			{
				if (this.OnCollision != null)
				{
					this.OnCollision(this);
				}
				UnityEngine.Object.Destroy(base.gameObject);
			}
			else if (other.CompareTag(Constants.FLOOR_TAG))
			{
				base.gameObject.SetActive(false);
			}
		}

		private void Start()
		{
			this.count = UnityEngine.Random.Range(0f, 3.14159274f);
			this.startScale = this.border.localScale;
		}

		private void Update()
		{
			this.count += Time.deltaTime;
			this.border.localScale = this.startScale * (1f + 0.1f * Mathf.Sin(this.count * 10f));
		}
	}
}
