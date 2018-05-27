using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

namespace Adorables.Ball
{
	public class Cell : MonoBehaviour, IHitableByBall
	{
		[SerializeField]
		private SpriteRenderer spriteRenderer;

		[SerializeField]
		private TextMesh number;

		private Vector3 startScale;

		public int _count;

		private Color[] colors;

		private int colorStep;

		public event OnDestroyedEventHandler OnDestroyedByBall;

		//public event OnDestroyedEventHandler OnDestroyedByBall
		//{
		//	add
		//	{
		//		OnDestroyedEventHandler onDestroyedEventHandler = this.OnDestroyedByBall;
		//		OnDestroyedEventHandler onDestroyedEventHandler2;
		//		do
		//		{
		//			onDestroyedEventHandler2 = onDestroyedEventHandler;
		//			onDestroyedEventHandler = Interlocked.CompareExchange<OnDestroyedEventHandler>(ref this.OnDestroyedByBall, (OnDestroyedEventHandler)Delegate.Combine(onDestroyedEventHandler2, value), onDestroyedEventHandler);
		//		}
		//		while (onDestroyedEventHandler != onDestroyedEventHandler2);
		//	}
		//	remove
		//	{
		//		OnDestroyedEventHandler onDestroyedEventHandler = this.OnDestroyedByBall;
		//		OnDestroyedEventHandler onDestroyedEventHandler2;
		//		do
		//		{
		//			onDestroyedEventHandler2 = onDestroyedEventHandler;
		//			onDestroyedEventHandler = Interlocked.CompareExchange<OnDestroyedEventHandler>(ref this.OnDestroyedByBall, (OnDestroyedEventHandler)Delegate.Remove(onDestroyedEventHandler2, value), onDestroyedEventHandler);
		//		}
		//		while (onDestroyedEventHandler != onDestroyedEventHandler2);
		//	}
		//}

		public int Count
		{
			get
			{
				return this._count;
			}
			set
			{
				this._count = value;
				this.number.text = this._count.ToString();
			}
		}

		public Color Color
		{
			get
			{
				return this.spriteRenderer.color;
			}
			set
			{
				this.spriteRenderer.color = value;
			}
		}

		public void SetCount(int count)
		{
			this.number.text = count.ToString();
		}

		public void SetColors(Color[] colors ,int colorStep)
		{
			this.colors = colors;
			this.colorStep = colorStep;
			this.Color = this.GetColorFromCount(this._count);
		}

		private Color GetColorFromCount(int count)
		{

			for (int i = 0; i < this.colors.Length - 1; i++)
			{
				int num = (i + 1) * this.colorStep;
				if (count < num)
				{
					return Color.Lerp(this.colors[i], this.colors[i + 1], (float)count / (float)this.colorStep);
				}
			}
			return this.colors[this.colors.Length-1];
			
		}

		private void OnEnable()
		{
			this.startScale = this.transform.localScale;
		}

		public void SetStartScale(Vector3 scale)
		{
			this.startScale = scale;
		}
		[DebuggerHidden]
		public IEnumerator DOPunchScaleCoroutine(float amplitude, float time = 1f)
		{
			Vector3 midScale;
			float count;
			float firstDuration;
			midScale = this.startScale * (1f - amplitude);
			count = 0f;
			firstDuration = time / 2f;
			yield return 0;
			if (count < firstDuration)
			{
				count += Time.deltaTime;
				this.transform.localScale = Vector3.Lerp(this.startScale, midScale, count / firstDuration);
			}
			count = 0;
			while (true)
			{
				if (count < firstDuration)
				{
					count += Time.deltaTime;
					this.transform.localScale = Vector3.Lerp(midScale, this.startScale, count / firstDuration);
					yield return 0;
				}
				else
				{
					this.transform.localScale = this.startScale;
					yield break;
				}
				
			}
		}

		[DebuggerHidden]
		public IEnumerator DOPunchScaleCoroutineBomb(float amplitude, float time = 1f)
		{
			Vector3 midScale;
			float count;
			float firstDuration;
			midScale = this.startScale * (2f - amplitude);
			count = 0f;
			firstDuration = time / 2f;
			UnityEngine.Debug.LogError(this.startScale);
			if (count < firstDuration)
			{
				count += Time.deltaTime;
				this.transform.localScale = Vector3.Lerp(this.startScale, midScale, count / firstDuration);
		
			}
			count = 0f;
			while (true)
			{
				if (count < firstDuration)
				{
					count += Time.deltaTime;
					this.transform.localScale = Vector3.Lerp(midScale, this.startScale, count / firstDuration);
					yield return 0;
				}else
				{
					UnityEngine.Debug.LogError(this.startScale);
					this.transform.localScale = this.startScale;
					yield break;
				}
				
			}
		
		}

		public void BallHit(Ball ball)
		{
			LoadingBarLevel.AggiungiCol = 1;
			this._count--;
			this.number.text = this._count.ToString();
			this.Color = this.GetColorFromCount(this._count);
			base.StartCoroutine(this.DOPunchScaleCoroutine(0.1f, 0.1f));
			if (this.Count <= 0)
			{
				if (this.OnDestroyedByBall != null)
				{
					this.OnDestroyedByBall(this);
				}
				//GameObject gameObject = UnityEngine.Object.Instantiate(Resources.Load("Prefab/Exp")) as GameObject;
				//GameObject obj = UnityEngine.Object.Instantiate<GameObject>(gameObject, base.transform.position, base.transform.rotation);
				//UnityEngine.Object.Destroy(obj, 0.2f);
				//UnityEngine.Object.Destroy(gameObject, 0.2f);
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}

		public void ABallHit(destro ball)
		{
			LoadingBarLevel.AggiungiCol = 1;
			this._count--;
			this.number.text = this._count.ToString();
			this.Color = this.GetColorFromCount(this._count);
			base.StartCoroutine(this.DOPunchScaleCoroutine(0.1f, 0.1f));
			if (this.Count <= 10000)
			{
				if (this.OnDestroyedByBall != null)
				{
					this.OnDestroyedByBall(this);
				}
				//GameObject gameObject = UnityEngine.Object.Instantiate(Resources.Load("Exp")) as GameObject;
				//GameObject obj = UnityEngine.Object.Instantiate<GameObject>(gameObject, base.transform.position, base.transform.rotation);
				//UnityEngine.Object.Destroy(obj, 0.2f);
				//UnityEngine.Object.Destroy(gameObject, 0.2f);
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}

		public void RBallHit(rayKol ball)
		{
			LoadingBarLevel.AggiungiCol = 1;
			this._count--;
			this.number.text = this._count.ToString();
			this.Color = this.GetColorFromCount(this._count);
			base.StartCoroutine(this.DOPunchScaleCoroutine(0.1f, 0.1f));
			if (this.Count <= 10000)
			{
				if (this.OnDestroyedByBall != null)
				{
					this.OnDestroyedByBall(this);
				}
				//GameObject gameObject = UnityEngine.Object.Instantiate(Resources.Load("Exp")) as GameObject;
				//GameObject obj = UnityEngine.Object.Instantiate<GameObject>(gameObject, base.transform.position, base.transform.rotation);
				//UnityEngine.Object.Destroy(obj, 0.2f);
				//UnityEngine.Object.Destroy(gameObject, 0.2f);
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}

		public void RedHit(MissileRed ball)
		{
			LoadingBarLevel.AggiungiCol = 1;
			this._count--;
			this.number.text = this._count.ToString();
			this.Color = this.GetColorFromCount(this._count);
			base.StartCoroutine(this.DOPunchScaleCoroutineBomb(0.4f, 0.4f));
			if (this.Count <= 10000)
			{
				if (this.OnDestroyedByBall != null)
				{
					this.OnDestroyedByBall(this);
				}
				//GameObject gameObject = UnityEngine.Object.Instantiate(Resources.Load("Exp")) as GameObject;
				//GameObject obj = UnityEngine.Object.Instantiate<GameObject>(gameObject, base.transform.position, base.transform.rotation);
				//UnityEngine.Object.Destroy(obj, 0.2f);
				//UnityEngine.Object.Destroy(gameObject, 0.2f);
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}

		public void RedContinueHit(RedCol ball)
		{
			LoadingBarLevel.AggiungiCol = 1;
			this._count--;
			this.number.text = this._count.ToString();
			this.Color = this.GetColorFromCount(this._count);
			base.StartCoroutine(this.DOPunchScaleCoroutineBomb(0.4f, 0.4f));
			if (this.Count <= 10000)
			{
				if (this.OnDestroyedByBall != null)
				{
					this.OnDestroyedByBall(this);
				}
				//GameObject gameObject = UnityEngine.Object.Instantiate(Resources.Load("Exp")) as GameObject;
				//GameObject obj = UnityEngine.Object.Instantiate<GameObject>(gameObject, base.transform.position, base.transform.rotation);
				//UnityEngine.Object.Destroy(obj, 0.2f);
				//UnityEngine.Object.Destroy(gameObject, 0.2f);
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}

		public void BombHit(missile ball)
		{
			LoadingBarLevel.AggiungiCol = 1;
			this._count--;
			this.number.text = this._count.ToString();
			this.Color = this.GetColorFromCount(this._count);
			base.StartCoroutine(this.DOPunchScaleCoroutineBomb(0.4f, 0.4f));
			if (this.Count <= 10000)
			{
				if (this.OnDestroyedByBall != null)
				{
					this.OnDestroyedByBall(this);
				}
				//GameObject gameObject = UnityEngine.Object.Instantiate(Resources.Load("Exp")) as GameObject;
				//GameObject obj = UnityEngine.Object.Instantiate<GameObject>(gameObject, base.transform.position, base.transform.rotation);
				//UnityEngine.Object.Destroy(obj, 0.2f);
				//UnityEngine.Object.Destroy(gameObject, 0.2f);
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}

		public void BombaHit(BombScriptExplosion ball)
		{
			LoadingBarLevel.AggiungiCol = 1;
			this._count--;
			this.number.text = this._count.ToString();
			this.Color = this.GetColorFromCount(this._count);
			base.StartCoroutine(this.DOPunchScaleCoroutine(0.1f, 0.1f));
			if (this.Count <= 0)
			{
				if (this.OnDestroyedByBall != null)
				{
					this.OnDestroyedByBall(this);
				}
				//GameObject gameObject = UnityEngine.Object.Instantiate(Resources.Load("Exp")) as GameObject;
				//GameObject obj = UnityEngine.Object.Instantiate<GameObject>(gameObject, base.transform.position, base.transform.rotation);
				//UnityEngine.Object.Destroy(obj, 0.2f);
				//UnityEngine.Object.Destroy(gameObject, 0.2f);
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}

		public void BombaAtomicaHit(RaycastCircle ball)
		{
			LoadingBarLevel.AggiungiCol = 1;
			this._count--;
			this.number.text = this._count.ToString();
			this.Color = this.GetColorFromCount(this._count);
			base.StartCoroutine(this.DOPunchScaleCoroutine(0.1f, 0.1f));
			if (this.Count <= 10000)
			{
				if (this.OnDestroyedByBall != null)
				{
					this.OnDestroyedByBall(this);
				}
				//GameObject gameObject = UnityEngine.Object.Instantiate(Resources.Load("Exp")) as GameObject;
				//GameObject obj = UnityEngine.Object.Instantiate<GameObject>(gameObject, base.transform.position, base.transform.rotation);
				//UnityEngine.Object.Destroy(obj, 0.2f);
				//UnityEngine.Object.Destroy(gameObject, 0.2f);
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}

		public void AngoloBallHit(colliderAngolo angolo)
		{
			UnityEngine.Debug.Log("collided with angolo");
		}

	}
}
