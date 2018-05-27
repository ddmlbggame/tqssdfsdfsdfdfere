using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AppAdvisory.BallX
{
	public class shakecam : MonoBehaviour
	{
		//[CompilerGenerated]
		//private sealed class <TimeAgain>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		//{
		//	internal shakecam $this;

		//	internal object $current;

		//	internal bool $disposing;

		//	internal int $PC;

		//	object IEnumerator<object>.Current
		//	{
		//		[DebuggerHidden]
		//		get
		//		{
		//			return this.$current;
		//		}
		//	}

		//	object IEnumerator.Current
		//	{
		//		[DebuggerHidden]
		//		get
		//		{
		//			return this.$current;
		//		}
		//	}

		//	[DebuggerHidden]
		//	public <TimeAgain>c__Iterator0()
		//	{
		//	}

		//	public bool MoveNext()
		//	{
		//		uint num = (uint)this.$PC;
		//		this.$PC = -1;
		//		switch (num)
		//		{
		//		case 0u:
		//			this.$current = new WaitForSeconds(0.2f);
		//			if (!this.$disposing)
		//			{
		//				this.$PC = 1;
		//			}
		//			return true;
		//		case 1u:
		//			this.$this.shakeDuration = 0.7f;
		//			this.$PC = -1;
		//			break;
		//		}
		//		return false;
		//	}

		//	[DebuggerHidden]
		//	public void Dispose()
		//	{
		//		this.$disposing = true;
		//		this.$PC = -1;
		//	}

		//	[DebuggerHidden]
		//	public void Reset()
		//	{
		//		throw new NotSupportedException();
		//	}
		//}

		//[CompilerGenerated]
		//private sealed class <TimeShake>c__Iterator1 : IEnumerator, IDisposable, IEnumerator<object>
		//{
		//	internal shakecam $this;

		//	internal object $current;

		//	internal bool $disposing;

		//	internal int $PC;

		//	object IEnumerator<object>.Current
		//	{
		//		[DebuggerHidden]
		//		get
		//		{
		//			return this.$current;
		//		}
		//	}

		//	object IEnumerator.Current
		//	{
		//		[DebuggerHidden]
		//		get
		//		{
		//			return this.$current;
		//		}
		//	}

		//	[DebuggerHidden]
		//	public <TimeShake>c__Iterator1()
		//	{
		//	}

		//	public bool MoveNext()
		//	{
		//		uint num = (uint)this.$PC;
		//		this.$PC = -1;
		//		switch (num)
		//		{
		//		case 0u:
		//			this.$current = new WaitForSeconds(4f);
		//			if (!this.$disposing)
		//			{
		//				this.$PC = 1;
		//			}
		//			return true;
		//		case 1u:
		//			shakecam.shake = 0;
		//			this.$this.StartCoroutine(this.$this.TimeAgain());
		//			this.$PC = -1;
		//			break;
		//		}
		//		return false;
		//	}

		//	[DebuggerHidden]
		//	public void Dispose()
		//	{
		//		this.$disposing = true;
		//		this.$PC = -1;
		//	}

		//	[DebuggerHidden]
		//	public void Reset()
		//	{
		//		throw new NotSupportedException();
		//	}
		//}

		public static int shake;

		public Transform camTransform;

		public float shakeDuration = 7f;

		public float shakeAmount = 0.7f;

		public float decreaseFactor = 1f;

		private Vector3 originalPos;

		private void Awake()
		{
			if (this.camTransform == null)
			{
				this.camTransform = (base.GetComponent(typeof(Transform)) as Transform);
			}
		}

		private void OnEnable()
		{
			this.originalPos = this.camTransform.localPosition;
		}

		[DebuggerHidden]
		private IEnumerator TimeAgain()
		{
			yield return new WaitForSeconds(0.2f);
			this.shakeDuration = 0.7f;
		}

		[DebuggerHidden]
		private IEnumerator TimeShake()
		{
			yield return new WaitForSeconds(4f);
			shakecam.shake = 0;
			this.StartCoroutine(this.TimeAgain());
		}

		private void Update()
		{
			if (shakecam.shake == 1)
			{
				base.StartCoroutine(this.TimeShake());
				if (this.shakeDuration > 0f)
				{
					this.camTransform.localPosition = this.originalPos + UnityEngine.Random.insideUnitSphere * this.shakeAmount;
					this.shakeDuration -= Time.deltaTime * this.decreaseFactor;
				}
				else
				{
					this.shakeDuration = 0f;
					this.camTransform.localPosition = this.originalPos;
				}
			}
		}
	}
}
