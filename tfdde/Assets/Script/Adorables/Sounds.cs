using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Adorables.Ball
{
	public class Sounds : MonoBehaviour
	{
		[SerializeField]
		private AudioSource source;

		[SerializeField]
		private AudioClip LvUp;

		[SerializeField]
		private AudioClip Btnsound;

		[SerializeField]
		private AudioClip BtnNoCoins;

		[SerializeField]
		private AudioClip lancioAtomic;

		[SerializeField]
		private AudioClip BoomAtomic;

		[SerializeField]
		private AudioClip NEXTSound;

		public static int PlayLevelupSound;

		public static int PlayBtnSound;

		public static int PlayBtnNocoin;

		public static int PlayAtomicsound;

		public static int PlaynextSound;

		[DebuggerHidden]
		private IEnumerator BoomSound()
		{
			yield return new WaitForSeconds(2.5f);
			this.source.PlayOneShot(this.BoomAtomic);
		}

		public void AtomicM()
		{
			this.source.PlayOneShot(this.lancioAtomic);
			base.StartCoroutine(this.BoomSound());
		}

		private void Update()
		{
			if (Sounds.PlaynextSound == 1)
			{
				Sounds.PlaynextSound = 0;
				this.source.PlayOneShot(this.NEXTSound);
			}
			if (Sounds.PlayAtomicsound == 1)
			{
				Sounds.PlayAtomicsound = 0;
				this.AtomicM();
			}
			if (Sounds.PlayLevelupSound == 1)
			{
				Sounds.PlayLevelupSound = 0;
				this.source.PlayOneShot(this.LvUp);
			}
			if (Sounds.PlayBtnSound == 1)
			{
				Sounds.PlayBtnSound = 0;
				this.source.PlayOneShot(this.Btnsound);
			}
			if (Sounds.PlayBtnNocoin == 1)
			{
				Sounds.PlayBtnNocoin = 0;
				this.source.PlayOneShot(this.BtnNoCoins);
			}
		}
	}
}
