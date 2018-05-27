using System;
using UnityEngine;

namespace AppAdvisory.BallX
{
	public class COLB : MonoBehaviour
	{
		[SerializeField]
		private Transform border;

		public Action<destro> OnCollision;

		private Vector3 startScale;

		private float count;

		private void Start()
		{
			this.count = 0f;
			this.startScale = this.border.localScale;
		}

		private void Update()
		{
			this.count += Time.deltaTime;
			this.border.localScale = this.startScale * (1f * Mathf.Sin(this.count * 0f));
		}
	}
}
