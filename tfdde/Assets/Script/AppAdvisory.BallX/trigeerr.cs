using System;
using UnityEngine;

namespace AppAdvisory.BallX
{
	public class trigeerr : MonoBehaviour
	{
		public bool collisione;

		private void Start()
		{
		}

		private void OnCollisionEnter2D(Collision2D coll)
		{
			if (coll.gameObject.GetComponent<CircleCollider2D>().tag == "bomba")
			{
				this.collisione = true;
				Debug.Log("boom");
			}
		}

		private void Update()
		{
		}
	}
}
