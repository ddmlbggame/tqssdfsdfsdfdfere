using System;
using UnityEngine;

namespace Adorables.Ball
{
	public class AddCoin : MonoBehaviour
	{
		public Action<AddCoin> OnCollision;

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
	}
}
