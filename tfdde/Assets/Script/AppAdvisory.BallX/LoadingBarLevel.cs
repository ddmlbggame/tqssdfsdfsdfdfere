using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace AppAdvisory.BallX
{
	public class LoadingBarLevel : MonoBehaviour
	{
		//[CompilerGenerated]
		//private sealed class <Wait>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		//{
		//	internal LoadingBarLevel $this;

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
		//	public <Wait>c__Iterator0()
		//	{
		//	}

		//	public bool MoveNext()
		//	{
		//		uint num = (uint)this.$PC;
		//		this.$PC = -1;
		//		switch (num)
		//		{
		//		case 0u:
		//			this.$current = new WaitForSeconds(1f);
		//			if (!this.$disposing)
		//			{
		//				this.$PC = 1;
		//			}
		//			return true;
		//		case 1u:
		//			this.$this.Cambia = 1;
		//			UnityEngine.Debug.Log("cambiato");
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

		public Image Loadingbar;

		public Transform TextIndicator;

		public static int AggiungiCol;

		public int currentAmount;

		public int Level;

		public int Cambia = 1;

		public int l1;

		public int l2;

		public int l3;

		public int l4;

		public int l5;

		public int l6;

		public int l7;

		public int l8;

		public float div;

		private void Start()
		{
			this.currentAmount = PlayerPrefs.GetInt("CurrentAmount");
			this.Level = PlayerPrefs.GetInt("Level");
		}

		[DebuggerHidden]
		private IEnumerator Wait()
		{
			yield return new WaitForSeconds(1f);
			this.Cambia = 1;
			UnityEngine.Debug.Log("cambiato");
			//LoadingBarLevel.<Wait>c__Iterator0 <Wait>c__Iterator = new LoadingBarLevel.<Wait>c__Iterator0();
			//<Wait>c__Iterator.$this = this;
			//return <Wait>c__Iterator;
		}

		public void CambiaLivello()
		{
			this.Level++;
			PlayerPrefs.SetInt("Level", this.Level);
			Sounds.PlayLevelupSound = 1;
			base.StartCoroutine(this.Wait());
			UnityEngine.Debug.Log("Livello cambiato");
		}

		public void Deletesaves()
		{
			PlayerPrefs.DeleteAll();
		}

		private void Update()
		{
			this.Loadingbar.fillAmount = (float)this.currentAmount / this.div;
			this.TextIndicator.GetComponent<Text>().text = this.Level.ToString();
			if ((float)this.currentAmount >= this.div)
			{
				this.currentAmount = 0;
				PlayerPrefs.SetInt("CurrentAmount", this.currentAmount);
				this.CambiaLivello();
			}
			if (LoadingBarLevel.AggiungiCol == 1)
			{
				LoadingBarLevel.AggiungiCol = 0;
				this.currentAmount++;
				PlayerPrefs.SetInt("CurrentAmount", this.currentAmount);
			}
			if (this.Level < 5)
			{
				this.div = 300f;
				PlayerPrefs.SetFloat("div", this.div);
			}
			if (this.Level == 5)
			{
				this.div = 800f;
				PlayerPrefs.SetFloat("div", this.div);
			}
			if (this.Level == 20)
			{
				this.div = 1300f;
				PlayerPrefs.SetFloat("div", this.div);
			}
			if (this.Level == 40)
			{
				this.div = 1800f;
				PlayerPrefs.SetFloat("div", this.div);
			}
			if (this.Level == 80)
			{
				this.div = 2300f;
				PlayerPrefs.SetFloat("div", this.div);
			}
			if (this.Level == 120)
			{
				this.div = 2800f;
				PlayerPrefs.SetFloat("div", this.div);
			}
			if (this.Level == 200)
			{
				this.div = 3000f;
				PlayerPrefs.SetFloat("div", this.div);
			}
			if (this.Level == 300)
			{
				this.div = 3500f;
				PlayerPrefs.SetFloat("div", this.div);
			}
			if (this.Level == 500)
			{
				this.div = 4000f;
				PlayerPrefs.SetFloat("div", this.div);
			}
			this.div = PlayerPrefs.GetFloat("div");
			if (this.Level == 5 && this.l1 == 0)
			{
				this.l1 = 1;
			}
			if (this.Level == 20 && this.l2 == 0)
			{
				this.l2 = 1;
			}
			if (this.Level == 50 && this.l3 == 0)
			{
				this.l3 = 1;
			}
			if (this.Level == 100 && this.l4 == 0)
			{
				this.l4 = 1;
			}
			if (this.Level == 300 && this.l5 == 0)
			{
				this.l5 = 1;
			}
			if (this.Level == 500 && this.l6 == 0)
			{
				this.l6 = 1;
			}
			if (this.Level == 1000 && this.l7 == 0)
			{
				this.l7 = 1;
			}
		}
	}
}
