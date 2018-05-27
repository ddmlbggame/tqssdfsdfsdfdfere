using System;
using UnityEngine;

namespace Adorables.Ball
{
	public class Atomickollider : MonoBehaviour
	{
		[SerializeField]
		private AudioSource source;

		[SerializeField]
		private AudioClip hitBrick;

		[SerializeField]
		private AudioClip hitPickable;

		public Action<Atomickollider> HitFloor;

		public float Speed;

		public Vector2 Direction;

		private void FixedUpdate()
		{
			Ray2D ray2D = new Ray2D(base.transform.position, -Vector3.up);
			Debug.DrawRay(ray2D.origin, ray2D.direction, Color.green);
		}
	}
}
