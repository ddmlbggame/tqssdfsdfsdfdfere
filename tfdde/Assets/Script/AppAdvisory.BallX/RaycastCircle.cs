using System;
using UnityEngine;

namespace AppAdvisory.BallX
{
	public class RaycastCircle : MonoBehaviour
	{
		[SerializeField]
		private AudioSource source;

		[SerializeField]
		private AudioClip hitBrick;

		[SerializeField]
		private AudioClip hitPickable;

		private void OnTriggerEnter2D(Collider2D col)
		{
			if (col.gameObject.tag == "Hitable")
			{
				MonoBehaviour.print("Working");
				Debug.Log("destroy");
				this.source.PlayOneShot(this.hitBrick);
				Debug.Log(" collision collided brick");
			}
		}
	}
}
