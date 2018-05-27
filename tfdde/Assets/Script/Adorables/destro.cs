using System;
using UnityEngine;

namespace Adorables.Ball
{
	public class destro : MonoBehaviour
	{
		public bool uP;

		public bool Left;

		public bool Down;

		public GameObject rotate;

		public Transform lineStart;

		public Transform lineEnd;

		private RaycastHit2D whatIHit;

		[SerializeField]
		private AudioSource source;

		[SerializeField]
		private AudioClip hitBrick;

		[SerializeField]
		private AudioClip hitPickable;

		public Action<destro> OnCollision;

		private Vector3 startScale;

		private float count;

		public float Speed;

		private float timeToConsiderBeingStuck = 2f;

		private float timer;

		private Vector3 baseOffsetDirection = Vector3.down * 0.1f;

		public Vector3 Direction
		{
			get;
			set;
		}

		private void Update()
		{
			this.rotate.transform.Rotate(0f, 0f, 8f);
			this.Raycasting();
		}

		private void Raycasting()
		{
			Debug.DrawLine(this.lineStart.position, this.lineEnd.position, Color.green);
			if (Physics2D.Linecast(this.lineStart.position, this.lineEnd.position, 1000))
			{
				this.whatIHit = Physics2D.Linecast(this.lineStart.position, this.lineEnd.position);
				this.uP = true;
				Cell component = this.whatIHit.collider.GetComponent<Cell>();
				component.ABallHit(this);
				this.source.PlayOneShot(this.hitBrick);
				Debug.Log("atomic collided");
				this.timer = 0f;
			}
			else
			{
				this.uP = false;
			}
		}

		private void Start()
		{
			this.count = UnityEngine.Random.Range(0f, 3.14159274f);
		}
	}
}
