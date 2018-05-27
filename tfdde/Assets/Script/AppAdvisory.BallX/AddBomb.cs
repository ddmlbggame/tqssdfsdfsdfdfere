using System;
using UnityEngine;

namespace AppAdvisory.BallX
{
	public class AddBomb : MonoBehaviour
	{
		public Action<AddBomb> OnCollision;

		private void OnTriggerEnter2D(Collider2D other)
		{
			if (other.CompareTag(Constants.BALL_TAG))
			{
				if (this.OnCollision != null)
				{
					this.OnCollision(this);
				}
				BombShoot.ShootBomb = 1;
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}
	}
}
