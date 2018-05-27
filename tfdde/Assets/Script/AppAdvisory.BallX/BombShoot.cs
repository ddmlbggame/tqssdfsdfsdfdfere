using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AppAdvisory.BallX
{
	public class BombShoot : MonoBehaviour
	{
	
		public static int RandomEffect;

		[SerializeField]
		private GameObject AtomicPrefab;

		[SerializeField]
		private GameObject OndaUrto;

		[SerializeField]
		private GameObject RazzoprefabAtomic;

		[SerializeField]
		private GameObject RedRazzi;

		[SerializeField]
		private GameObject AtomiccolliderPrefab;

		[SerializeField]
		private GameObject ballPrefab;

		[SerializeField]
		private GameObject bombPrefab;

		[SerializeField]
		private GameObject colliderPrefab;

		[SerializeField]
		private SpriteRenderer spriteRenderer;

		[SerializeField]
		private float numberOfDots = 3f;

		[SerializeField]
		private GameObject dotPrefab;

		public GameObject CenterExplosion;

		public GameObject Bottom;

		public GameObject sp1;

		public GameObject sp2;

		public GameObject sp3;

		public GameObject sp4;

		public GameObject sp1T;

		public GameObject sp2T;

		public GameObject sp3T;

		public GameObject sp4T;

		public static int ShootBomb;

		public GameObject spawnpoint1;

		public GameObject spawnpoint2;

		public GameObject spawnpoint3;

		public GameObject spawnpoint4;

		public GameObject spawnpoint5;

		public GameObject spawnpoint6;

		public GameObject spawnpoint7;

		public GameObject spawnpointred;

		public Rect ScreenRect
		{
			get;
			set;
		}

		public float Speed
		{
			get;
			set;
		}

		public float SpawnFrequency
		{
			get;
			set;
		}

		public float BallScale
		{
			get;
			set;
		}

		private void Start()
		{
			BombShoot.RandomEffect = 4;
		}

		public void Red()
		{
			GameObject obj = UnityEngine.Object.Instantiate<GameObject>(this.RedRazzi, this.spawnpointred.transform.position, this.spawnpointred.transform.rotation);
			UnityEngine.Object.Destroy(obj, 2f);
		}

		public void Atomic()
		{
			GameObject obj = UnityEngine.Object.Instantiate<GameObject>(this.RazzoprefabAtomic, this.Bottom.transform.position, this.Bottom.transform.rotation);
			UnityEngine.Object.Destroy(obj, 2.6f);
			base.StartCoroutine(this.Boom1());
			Sounds.PlayAtomicsound = 1;
		}

		[DebuggerHidden]
		private IEnumerator Boom1()
		{
			GameObject Bomb2;
			yield return new WaitForSeconds(2.45f);
			Bomb2 = UnityEngine.Object.Instantiate<GameObject>(this.OndaUrto, this.CenterExplosion.transform.position, this.CenterExplosion.transform.rotation);
			UnityEngine.Object.Destroy(Bomb2, 2f);
			this.StartCoroutine(this.BigBoom());
			shakecam.shake = 1;
		}

		[DebuggerHidden]
		private IEnumerator BigBoom()
		{
			GameObject Bomb2;
		     yield return  new WaitForSeconds(0.45f);
			Bomb2 = UnityEngine.Object.Instantiate<GameObject>(this.AtomicPrefab, this.CenterExplosion.transform.position, this.CenterExplosion.transform.rotation);
			UnityEngine.Object.Destroy(Bomb2, 4f);
			this.StartCoroutine(this.BigBoomColiderClean());
		}

		[DebuggerHidden]
		private IEnumerator BigBoomColiderClean()
		{
			GameObject Bomb2;
			yield return new WaitForSeconds(0.2f);
			Bomb2 = UnityEngine.Object.Instantiate<GameObject>(this.AtomiccolliderPrefab, this.CenterExplosion.transform.position, this.CenterExplosion.transform.rotation);
			UnityEngine.Object.Destroy(Bomb2, 3f);
		}

		public void Bomb()
		{
			if (GameManager.StatoRisoluzione == 2)
			{
				this.sp1 = this.sp1T;
				this.sp2 = this.sp2T;
				this.sp3 = this.sp3T;
				this.sp4 = this.sp4T;
			}
			GameObject obj = UnityEngine.Object.Instantiate<GameObject>(this.bombPrefab, this.sp1.transform.position, this.sp1.transform.rotation);
			UnityEngine.Object.Destroy(obj, 5f);
			base.StartCoroutine(this.Bomb2());
		}

		[DebuggerHidden]
		private IEnumerator Bomb2()
		{
			GameObject Bomba;
			yield return new WaitForSeconds(0.5f);
			Bomba = UnityEngine.Object.Instantiate<GameObject>(this.bombPrefab, this.sp2.transform.position, this.sp2.transform.rotation);
			UnityEngine.Object.Destroy(Bomba, 5f);
			this.StartCoroutine(this.Bomb3());
		}

		[DebuggerHidden]
		private IEnumerator Bomb3()
		{
			GameObject Bomba;
			yield return new WaitForSeconds(0.5f);
			Bomba = UnityEngine.Object.Instantiate<GameObject>(this.bombPrefab, this.sp3.transform.position, this.sp3.transform.rotation);
			UnityEngine.Object.Destroy(Bomba, 5f);
			this.StartCoroutine(this.Bomb4());
		}

		[DebuggerHidden]
		private IEnumerator Bomb4()
		{
			GameObject Bomba;
			yield return new WaitForSeconds(0.5f);
			Bomba = UnityEngine.Object.Instantiate<GameObject>(this.bombPrefab, this.sp4.transform.position, this.sp4.transform.rotation);
			UnityEngine.Object.Destroy(Bomba, 5f);
		}

		public void Shot()
		{
			GameObject obj = UnityEngine.Object.Instantiate<GameObject>(this.ballPrefab, this.spawnpoint1.transform.position, this.spawnpoint1.transform.rotation);
			UnityEngine.Object.Destroy(obj, 3f);
			base.StartCoroutine(this.Ball2());
		}

		[DebuggerHidden]
		private IEnumerator Ball2()
		{
			GameObject Bomb2;
			yield return new WaitForSeconds(0.2f);
			Bomb2 = UnityEngine.Object.Instantiate<GameObject>(this.ballPrefab, this.spawnpoint2.transform.position, this.spawnpoint2.transform.rotation);
			UnityEngine.Object.Destroy(Bomb2, 3f);
			this.StartCoroutine(this.Ball3());
		}

		[DebuggerHidden]
		private IEnumerator Ball3()
		{
			GameObject Bomb3;
			yield return new WaitForSeconds(0.2f);
			Bomb3 = UnityEngine.Object.Instantiate<GameObject>(this.ballPrefab, this.spawnpoint3.transform.position, this.spawnpoint3.transform.rotation);
			UnityEngine.Object.Destroy(Bomb3, 3f);
			this.StartCoroutine(this.Ball4());
		}

		[DebuggerHidden]
		private IEnumerator Ball4()
		{
			GameObject Bomb4;
			yield return new WaitForSeconds(0.2f);
			Bomb4 = UnityEngine.Object.Instantiate<GameObject>(this.ballPrefab, this.spawnpoint4.transform.position, this.spawnpoint4.transform.rotation);
			UnityEngine.Object.Destroy(Bomb4, 3f);
			this.StartCoroutine(this.Ball5());
		}

		[DebuggerHidden]
		private IEnumerator Ball5()
		{
			GameObject Bomb5;
			yield return new WaitForSeconds(0.2f);
			Bomb5 = UnityEngine.Object.Instantiate<GameObject>(this.ballPrefab, this.spawnpoint5.transform.position, this.spawnpoint5.transform.rotation);
			UnityEngine.Object.Destroy(Bomb5, 3f);
			this.StartCoroutine(this.Ball6());
		}

		[DebuggerHidden]
		private IEnumerator Ball6()
		{
			GameObject Bomb6;
			yield return new WaitForSeconds(0.2f);
			Bomb6 = UnityEngine.Object.Instantiate<GameObject>(this.ballPrefab, this.spawnpoint6.transform.position, this.spawnpoint6.transform.rotation);
			UnityEngine.Object.Destroy(Bomb6, 3f);
			this.StartCoroutine(this.Ball7());
		}

		[DebuggerHidden]
		private IEnumerator Ball7()
		{
			GameObject Bomb7;
			yield return new WaitForSeconds(0.2f);
			Bomb7 = UnityEngine.Object.Instantiate<GameObject>(this.ballPrefab, this.spawnpoint7.transform.position, this.spawnpoint7.transform.rotation);
			UnityEngine.Object.Destroy(Bomb7, 3f);
		}

		public void RandomGen()
		{
			BombShoot.RandomEffect = UnityEngine.Random.Range(1, 4);
		}

		private void Update()
		{
			if (BombShoot.ShootBomb == 1)
			{
				BombShoot.ShootBomb = 0;
				this.RandomGen();
			}
			if (BombShoot.RandomEffect == 1)
			{
				BombShoot.RandomEffect = 0;
				this.Shot();
			}
			if (BombShoot.RandomEffect == 2)
			{
				BombShoot.RandomEffect = 0;
				this.Bomb();
			}
			if (BombShoot.RandomEffect == 3)
			{
				BombShoot.RandomEffect = 0;
				this.Atomic();
			}
			if (BombShoot.RandomEffect == 5)
			{
				BombShoot.RandomEffect = 0;
				this.Red();
			}
		}
	}
}
