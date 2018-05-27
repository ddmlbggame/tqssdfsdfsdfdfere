using System;
using UnityEngine;

namespace AppAdvisory.BallX
{
	public class colliderAngolo : MonoBehaviour
	{
		public Transform lineStart;

		public Transform lineEnd;

		private RaycastHit2D whatIHit;

		public Action<colliderAngolo> OnCollision;

		private void Update()
		{
			this.Raycasting();
		}

		private void Raycasting()
		{
			Debug.DrawLine(this.lineStart.position, this.lineEnd.position, Color.green);
			if (Physics2D.Linecast(this.lineStart.position, this.lineEnd.position, 1000))
			{
				this.whatIHit = Physics2D.Linecast(this.lineStart.position, this.lineEnd.position);
				Cell component = this.whatIHit.collider.GetComponent<Cell>();
				component.AngoloBallHit(this);
				Debug.Log("collided with angolo");
			}
		}
	}
}
