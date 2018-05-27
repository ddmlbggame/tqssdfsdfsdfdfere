using System;
using UnityEngine;
using UnityEngine.UI;

namespace AppAdvisory.BallX
{
	public class shopScript : MonoBehaviour
	{
		public GameObject ButtonUnlock;

		public GameObject Facebook;

		public GameObject Twitter;

		public GameObject Instagram;

		public GameObject Selezionato;

		[SerializeField]
		private Text BtnUnlock;

		public static int BAllCurrent;

		public int BallSelected;

		public GameObject Ball1;

		public GameObject Ball2;

		public GameObject Ball3;

		public GameObject Ball4;

		public GameObject Ball5;

		public GameObject Ball6;

		public GameObject Ball7;

		public GameObject Ball8;

		public GameObject Ball9;

		public GameObject Ball10;

		public GameObject Ball11;

		public GameObject Ball12;

		public GameObject Ball13;

		public GameObject Ball14;

		public GameObject Ball15;

		public GameObject Ball16;

		public GameObject Ball17;

		public GameObject Ball18;

		public GameObject Ball19;

		public GameObject Ball20;

		public static int B1;

		public static int B2;

		public static int B3;

		public static int B4;

		public static int B5;

		public static int B6;

		public static int B7;

		public static int B8;

		public static int B9;

		public static int B10;

		public static int B11;

		public static int B12;

		public static int B13;

		public static int B14;

		public static int B15;

		public static int B16;

		public static int B17;

		public static int B18;

		public static int B19;

		public static int B20;

		public int bb1;

		public int bb2;

		public int bb3;

		public int bb4;

		public int bb5;

		public int bb6;

		public int bb7;

		public int bb8;

		public int bb9;

		public int bb10;

		public int bb11;

		public int bb12;

		public int bb13;

		public int bb14;

		public int bb15;

		public int bb16;

		public int bb17;

		public int bb18;

		public int bb19;

		public int bb20;

		[SerializeField]
		private Text CurrentBAllText;

		public void Next()
		{
			shopScript.BAllCurrent++;
			Sounds.PlayBtnSound = 1;
		}

		public void PreviousBall()
		{
			shopScript.BAllCurrent--;
			Sounds.PlayBtnSound = 1;
		}

		public void RemoveAds()
		{
			Sounds.PlayBtnSound = 1;
		}

		public void Start()
		{
			shopScript.BAllCurrent = 1;
			shopScript.B1 = 1;
			PlayerPrefs.SetInt("B1", shopScript.B1);
			PlayerPrefs.Save();
		}

		public void BuyBall()
		{
			Sounds.PlayBtnSound = 1;
			if (shopScript.B5 != 1 && shopScript.BAllCurrent == 5 && Utils.Moneta >= 250)
			{
				shopScript.B5 = 1;
				PlayerPrefs.SetInt("B5", shopScript.B5);
				PlayerPrefs.Save();
				Utils.RemoveCash = 1;
			}
			else if (shopScript.B5 != 1 && shopScript.BAllCurrent == 5 && Utils.Moneta < 250)
			{
				Sounds.PlayBtnNocoin = 1;
			}
			if (shopScript.B6 != 1 && shopScript.BAllCurrent == 6 && Utils.Moneta >= 250)
			{
				shopScript.B6 = 1;
				PlayerPrefs.SetInt("B6", shopScript.B6);
				PlayerPrefs.Save();
				Utils.RemoveCash = 1;
			}
			else if (shopScript.B6 != 1 && shopScript.BAllCurrent == 6 && Utils.Moneta < 250)
			{
				Sounds.PlayBtnNocoin = 1;
			}
			if (shopScript.B7 != 1 && shopScript.BAllCurrent == 7 && Utils.Moneta >= 250)
			{
				shopScript.B7 = 1;
				PlayerPrefs.SetInt("B7", shopScript.B7);
				PlayerPrefs.Save();
				Utils.RemoveCash = 1;
			}
			else if (shopScript.B7 != 1 && shopScript.BAllCurrent == 7 && Utils.Moneta < 250)
			{
				Sounds.PlayBtnNocoin = 1;
			}
			if (shopScript.B8 != 1 && shopScript.BAllCurrent == 8 && Utils.Moneta >= 250)
			{
				shopScript.B8 = 1;
				PlayerPrefs.SetInt("B8", shopScript.B8);
				PlayerPrefs.Save();
				Utils.RemoveCash = 1;
			}
			else if (shopScript.B8 != 1 && shopScript.BAllCurrent == 8 && Utils.Moneta < 250)
			{
				Sounds.PlayBtnNocoin = 1;
			}
			if (shopScript.B9 != 1 && shopScript.BAllCurrent == 9 && Utils.Moneta >= 250)
			{
				shopScript.B9 = 1;
				PlayerPrefs.SetInt("B9", shopScript.B9);
				PlayerPrefs.Save();
				Utils.RemoveCash = 1;
			}
			else if (shopScript.B9 != 1 && shopScript.BAllCurrent == 9 && Utils.Moneta < 250)
			{
				Sounds.PlayBtnNocoin = 1;
			}
			if (shopScript.B10 != 1 && shopScript.BAllCurrent == 10 && Utils.Moneta >= 250)
			{
				shopScript.B10 = 1;
				PlayerPrefs.SetInt("B10", shopScript.B10);
				PlayerPrefs.Save();
				Utils.RemoveCash = 1;
			}
			else if (shopScript.B10 != 1 && shopScript.BAllCurrent == 10 && Utils.Moneta < 250)
			{
				Sounds.PlayBtnNocoin = 1;
			}
			if (shopScript.B11 != 1 && shopScript.BAllCurrent == 11 && Utils.Moneta >= 250)
			{
				shopScript.B11 = 1;
				PlayerPrefs.SetInt("B11", shopScript.B11);
				PlayerPrefs.Save();
				Utils.RemoveCash = 1;
			}
			else if (shopScript.B11 != 1 && shopScript.BAllCurrent == 11 && Utils.Moneta < 250)
			{
				Sounds.PlayBtnNocoin = 1;
			}
			if (shopScript.B12 != 1 && shopScript.BAllCurrent == 12 && Utils.Moneta >= 250)
			{
				shopScript.B12 = 1;
				PlayerPrefs.SetInt("B12", shopScript.B12);
				PlayerPrefs.Save();
				Utils.RemoveCash = 1;
			}
			else if (shopScript.B12 != 1 && shopScript.BAllCurrent == 12 && Utils.Moneta < 250)
			{
				Sounds.PlayBtnNocoin = 1;
			}
			if (shopScript.B13 != 1 && shopScript.BAllCurrent == 13 && Utils.Moneta >= 250)
			{
				shopScript.B13 = 1;
				PlayerPrefs.SetInt("B13", shopScript.B13);
				PlayerPrefs.Save();
				Utils.RemoveCash = 1;
			}
			else if (shopScript.B13 != 1 && shopScript.BAllCurrent == 13 && Utils.Moneta < 250)
			{
				Sounds.PlayBtnNocoin = 1;
			}
			if (shopScript.B14 != 1 && shopScript.BAllCurrent == 14 && Utils.Moneta >= 250)
			{
				shopScript.B14 = 1;
				PlayerPrefs.SetInt("B14", shopScript.B14);
				PlayerPrefs.Save();
				Utils.RemoveCash = 1;
			}
			else if (shopScript.B14 != 1 && shopScript.BAllCurrent == 14 && Utils.Moneta < 250)
			{
				Sounds.PlayBtnNocoin = 1;
			}
			if (shopScript.B15 != 1 && shopScript.BAllCurrent == 15 && Utils.Moneta >= 250)
			{
				shopScript.B15 = 1;
				PlayerPrefs.SetInt("B15", shopScript.B15);
				PlayerPrefs.Save();
				Utils.RemoveCash = 1;
			}
			else if (shopScript.B15 != 1 && shopScript.BAllCurrent == 15 && Utils.Moneta < 250)
			{
				Sounds.PlayBtnNocoin = 1;
			}
			if (shopScript.B16 != 1 && shopScript.BAllCurrent == 16 && Utils.Moneta >= 250)
			{
				shopScript.B16 = 1;
				PlayerPrefs.SetInt("B16", shopScript.B16);
				PlayerPrefs.Save();
				Utils.RemoveCash = 1;
			}
			else if (shopScript.B16 != 1 && shopScript.BAllCurrent == 16 && Utils.Moneta < 250)
			{
				Sounds.PlayBtnNocoin = 1;
			}
			if (shopScript.B17 != 1 && shopScript.BAllCurrent == 17 && Utils.Moneta >= 250)
			{
				shopScript.B17 = 1;
				PlayerPrefs.SetInt("B17", shopScript.B17);
				PlayerPrefs.Save();
				Utils.RemoveCash = 1;
			}
			else if (shopScript.B17 != 1 && shopScript.BAllCurrent == 17 && Utils.Moneta < 250)
			{
				Sounds.PlayBtnNocoin = 1;
			}
			if (shopScript.B18 != 1 && shopScript.BAllCurrent == 18 && Utils.Moneta >= 250)
			{
				shopScript.B18 = 1;
				PlayerPrefs.SetInt("B18", shopScript.B18);
				PlayerPrefs.Save();
				Utils.RemoveCash = 1;
			}
			else if (shopScript.B18 != 1 && shopScript.BAllCurrent == 18 && Utils.Moneta < 250)
			{
				Sounds.PlayBtnNocoin = 1;
			}
			if (shopScript.B19 != 1 && shopScript.BAllCurrent == 19 && Utils.Moneta >= 250)
			{
				shopScript.B19 = 1;
				PlayerPrefs.SetInt("B19", shopScript.B19);
				PlayerPrefs.Save();
				Utils.RemoveCash = 1;
			}
			else if (shopScript.B19 != 1 && shopScript.BAllCurrent == 19 && Utils.Moneta < 250)
			{
				Sounds.PlayBtnNocoin = 1;
			}
			if (shopScript.B20 != 1 && shopScript.BAllCurrent == 20 && Utils.Moneta >= 250)
			{
				shopScript.B20 = 1;
				PlayerPrefs.SetInt("B20", shopScript.B20);
				PlayerPrefs.Save();
				Utils.RemoveCash = 1;
			}
			else if (shopScript.B20 != 1 && shopScript.BAllCurrent == 20 && Utils.Moneta < 250)
			{
				Sounds.PlayBtnNocoin = 1;
			}
		}

		public void FbUnlock()
		{
			Application.OpenURL("fb://page/1374329222665352");
			shopScript.B2 = 1;
			PlayerPrefs.SetInt("B2", shopScript.B2);
			PlayerPrefs.Save();
		}

		public void FB()
		{
			Application.OpenURL("fb://page/1374329222665352");
			Sounds.PlayBtnSound = 1;
		}

		public void TT()
		{
			Application.OpenURL("https://twitter.com/ItaIndieStudio");
			Sounds.PlayBtnSound = 1;
		}

		public void IG()
		{
			Application.OpenURL("https://www.instagram.com/itaindiestudio");
			Sounds.PlayBtnSound = 1;
		}

		public void TwUnlock()
		{
			Application.OpenURL("https://twitter.com/ItaIndieStudio");
			shopScript.B3 = 1;
			PlayerPrefs.SetInt("B3", shopScript.B3);
			PlayerPrefs.Save();
		}

		public void IGUnlock()
		{
			Application.OpenURL("https://www.instagram.com/itaindiestudio");
			shopScript.B4 = 1;
			PlayerPrefs.SetInt("B4", shopScript.B4);
			PlayerPrefs.Save();
		}

		private void Update()
		{
			this.bb1 = shopScript.B1;
			this.bb2 = shopScript.B2;
			this.bb3 = shopScript.B3;
			this.bb4 = shopScript.B4;
			this.bb5 = shopScript.B5;
			this.bb6 = shopScript.B6;
			this.bb7 = shopScript.B7;
			this.bb8 = shopScript.B8;
			this.bb9 = shopScript.B9;
			this.bb10 = shopScript.B10;
			this.bb11 = shopScript.B11;
			this.bb12 = shopScript.B12;
			this.bb13 = shopScript.B13;
			this.bb14 = shopScript.B14;
			this.bb15 = shopScript.B15;
			this.bb16 = shopScript.B16;
			this.bb17 = shopScript.B17;
			this.bb18 = shopScript.B18;
			this.bb19 = shopScript.B19;
			this.bb20 = shopScript.B20;
			shopScript.B1 = PlayerPrefs.GetInt("B1");
			shopScript.B2 = PlayerPrefs.GetInt("B2");
			shopScript.B3 = PlayerPrefs.GetInt("B3");
			shopScript.B4 = PlayerPrefs.GetInt("B4");
			shopScript.B5 = PlayerPrefs.GetInt("B5");
			shopScript.B6 = PlayerPrefs.GetInt("B6");
			shopScript.B7 = PlayerPrefs.GetInt("B7");
			shopScript.B8 = PlayerPrefs.GetInt("B8");
			shopScript.B9 = PlayerPrefs.GetInt("B9");
			shopScript.B10 = PlayerPrefs.GetInt("B10");
			shopScript.B11 = PlayerPrefs.GetInt("B11");
			shopScript.B12 = PlayerPrefs.GetInt("B12");
			shopScript.B13 = PlayerPrefs.GetInt("B13");
			shopScript.B14 = PlayerPrefs.GetInt("B14");
			shopScript.B15 = PlayerPrefs.GetInt("B15");
			shopScript.B16 = PlayerPrefs.GetInt("B16");
			shopScript.B17 = PlayerPrefs.GetInt("B17");
			shopScript.B18 = PlayerPrefs.GetInt("B18");
			shopScript.B19 = PlayerPrefs.GetInt("B19");
			shopScript.B20 = PlayerPrefs.GetInt("B20");
			this.CurrentBAllText.text = string.Empty + shopScript.BAllCurrent.ToString();
			this.BallSelected = shopScript.BAllCurrent;
			if (shopScript.BAllCurrent > 20)
			{
				shopScript.BAllCurrent = 1;
			}
			if (shopScript.BAllCurrent < 1)
			{
				shopScript.BAllCurrent = 20;
			}
			if (shopScript.BAllCurrent == 1 && shopScript.B1 != 1)
			{
				this.Ball1.SetActive(true);
				this.ButtonUnlock.SetActive(false);
				this.Selezionato.SetActive(false);
				this.BtnUnlock.text = "FREE";
			}
			else if (shopScript.BAllCurrent == 1 && shopScript.B1 == 1)
			{
				this.Ball1.SetActive(true);
				this.ButtonUnlock.SetActive(false);
				this.Selezionato.SetActive(true);
			}
			else
			{
				this.Ball1.SetActive(false);
			}
			if (shopScript.BAllCurrent != 2)
			{
				this.Facebook.SetActive(false);
			}
			if (shopScript.BAllCurrent != 3)
			{
				this.Twitter.SetActive(false);
			}
			if (shopScript.BAllCurrent != 4)
			{
				this.Instagram.SetActive(false);
			}
			if (shopScript.BAllCurrent == 2 && shopScript.B2 != 1)
			{
				this.Ball2.SetActive(true);
				this.ButtonUnlock.SetActive(false);
				this.Facebook.SetActive(true);
				this.Selezionato.SetActive(false);
				this.BtnUnlock.text = string.Empty;
			}
			else if (shopScript.BAllCurrent == 2 && shopScript.B2 == 1)
			{
				this.Ball2.SetActive(true);
				this.ButtonUnlock.SetActive(false);
				this.Facebook.SetActive(false);
				this.Selezionato.SetActive(true);
			}
			else
			{
				this.Ball2.SetActive(false);
			}
			if (shopScript.BAllCurrent == 3 && shopScript.B3 != 1)
			{
				this.Ball3.SetActive(true);
				this.ButtonUnlock.SetActive(false);
				this.Twitter.SetActive(true);
				this.Selezionato.SetActive(false);
				this.BtnUnlock.text = string.Empty;
			}
			else if (shopScript.BAllCurrent == 3 && shopScript.B3 == 1)
			{
				this.Ball3.SetActive(true);
				this.ButtonUnlock.SetActive(false);
				this.Twitter.SetActive(false);
				this.Selezionato.SetActive(true);
			}
			else
			{
				this.Ball3.SetActive(false);
			}
			if (shopScript.BAllCurrent == 4 && shopScript.B4 != 1)
			{
				this.Ball4.SetActive(true);
				this.ButtonUnlock.SetActive(false);
				this.Instagram.SetActive(true);
				this.Selezionato.SetActive(false);
				this.BtnUnlock.text = "0";
			}
			else if (shopScript.BAllCurrent == 4 && shopScript.B4 == 1)
			{
				this.Ball4.SetActive(true);
				this.ButtonUnlock.SetActive(false);
				this.Instagram.SetActive(false);
				this.Selezionato.SetActive(true);
			}
			else
			{
				this.Ball4.SetActive(false);
			}
			if (shopScript.BAllCurrent == 5 && shopScript.B5 != 1)
			{
				this.Ball5.SetActive(true);
				this.ButtonUnlock.SetActive(true);
				this.Selezionato.SetActive(false);
				this.BtnUnlock.text = "250";
			}
			else if (shopScript.BAllCurrent == 5 && shopScript.B5 == 1)
			{
				this.Selezionato.SetActive(true);
				this.Ball5.SetActive(true);
				this.ButtonUnlock.SetActive(false);
			}
			else
			{
				this.Ball5.SetActive(false);
			}
			if (shopScript.BAllCurrent == 6 && shopScript.B6 != 1)
			{
				this.Ball6.SetActive(true);
				this.ButtonUnlock.SetActive(true);
				this.Selezionato.SetActive(false);
				this.BtnUnlock.text = "250";
			}
			else if (shopScript.BAllCurrent == 6 && shopScript.B6 == 1)
			{
				this.Selezionato.SetActive(true);
				this.Ball6.SetActive(true);
				this.ButtonUnlock.SetActive(false);
			}
			else
			{
				this.Ball6.SetActive(false);
			}
			if (shopScript.BAllCurrent == 7 && shopScript.B7 != 1)
			{
				this.Ball7.SetActive(true);
				this.ButtonUnlock.SetActive(true);
				this.Selezionato.SetActive(false);
				this.BtnUnlock.text = "250";
			}
			else if (shopScript.BAllCurrent == 7 && shopScript.B7 == 1)
			{
				this.Selezionato.SetActive(true);
				this.Ball7.SetActive(true);
				this.ButtonUnlock.SetActive(false);
			}
			else
			{
				this.Ball7.SetActive(false);
			}
			if (shopScript.BAllCurrent == 8 && shopScript.B8 != 1)
			{
				this.Ball8.SetActive(true);
				this.ButtonUnlock.SetActive(true);
				this.Selezionato.SetActive(false);
				this.BtnUnlock.text = "250";
			}
			else if (shopScript.BAllCurrent == 8 && shopScript.B8 == 1)
			{
				this.Selezionato.SetActive(true);
				this.Ball8.SetActive(true);
				this.ButtonUnlock.SetActive(false);
			}
			else
			{
				this.Ball8.SetActive(false);
			}
			if (shopScript.BAllCurrent == 9 && shopScript.B9 != 1)
			{
				this.Ball9.SetActive(true);
				this.ButtonUnlock.SetActive(true);
				this.Selezionato.SetActive(false);
				this.BtnUnlock.text = "250";
			}
			else if (shopScript.BAllCurrent == 9 && shopScript.B9 == 1)
			{
				this.Selezionato.SetActive(true);
				this.Ball9.SetActive(true);
				this.ButtonUnlock.SetActive(false);
			}
			else
			{
				this.Ball9.SetActive(false);
			}
			if (shopScript.BAllCurrent == 10 && shopScript.B10 != 1)
			{
				this.Ball10.SetActive(true);
				this.ButtonUnlock.SetActive(true);
				this.Selezionato.SetActive(false);
				this.BtnUnlock.text = "250";
			}
			else if (shopScript.BAllCurrent == 10 && shopScript.B10 == 1)
			{
				this.Selezionato.SetActive(true);
				this.Ball10.SetActive(true);
				this.ButtonUnlock.SetActive(false);
			}
			else
			{
				this.Ball10.SetActive(false);
			}
			if (shopScript.BAllCurrent == 11 && shopScript.B11 != 1)
			{
				this.Ball11.SetActive(true);
				this.ButtonUnlock.SetActive(true);
				this.Selezionato.SetActive(false);
				this.BtnUnlock.text = "250";
			}
			else if (shopScript.BAllCurrent == 11 && shopScript.B11 == 1)
			{
				this.Selezionato.SetActive(true);
				this.Ball11.SetActive(true);
				this.ButtonUnlock.SetActive(false);
			}
			else
			{
				this.Ball11.SetActive(false);
			}
			if (shopScript.BAllCurrent == 12 && shopScript.B12 != 1)
			{
				this.Ball12.SetActive(true);
				this.ButtonUnlock.SetActive(true);
				this.Selezionato.SetActive(false);
				this.BtnUnlock.text = "250";
			}
			else if (shopScript.BAllCurrent == 12 && shopScript.B12 == 1)
			{
				this.Selezionato.SetActive(true);
				this.Ball12.SetActive(true);
				this.ButtonUnlock.SetActive(false);
			}
			else
			{
				this.Ball12.SetActive(false);
			}
			if (shopScript.BAllCurrent == 13 && shopScript.B13 != 1)
			{
				this.Ball13.SetActive(true);
				this.ButtonUnlock.SetActive(true);
				this.Selezionato.SetActive(false);
				this.BtnUnlock.text = "250";
			}
			else if (shopScript.BAllCurrent == 13 && shopScript.B13 == 1)
			{
				this.Selezionato.SetActive(true);
				this.Ball13.SetActive(true);
				this.ButtonUnlock.SetActive(false);
			}
			else
			{
				this.Ball13.SetActive(false);
			}
			if (shopScript.BAllCurrent == 14 && shopScript.B14 != 1)
			{
				this.Ball14.SetActive(true);
				this.ButtonUnlock.SetActive(true);
				this.Selezionato.SetActive(false);
				this.BtnUnlock.text = "250";
			}
			else if (shopScript.BAllCurrent == 14 && shopScript.B14 == 1)
			{
				this.Selezionato.SetActive(true);
				this.Ball14.SetActive(true);
				this.ButtonUnlock.SetActive(false);
			}
			else
			{
				this.Ball14.SetActive(false);
			}
			if (shopScript.BAllCurrent == 15 && shopScript.B15 != 1)
			{
				this.Ball15.SetActive(true);
				this.ButtonUnlock.SetActive(true);
				this.Selezionato.SetActive(false);
				this.BtnUnlock.text = "250";
			}
			else if (shopScript.BAllCurrent == 15 && shopScript.B15 == 1)
			{
				this.Selezionato.SetActive(true);
				this.Ball15.SetActive(true);
				this.ButtonUnlock.SetActive(false);
			}
			else
			{
				this.Ball15.SetActive(false);
			}
			if (shopScript.BAllCurrent == 16 && shopScript.B16 != 1)
			{
				this.Ball16.SetActive(true);
				this.ButtonUnlock.SetActive(true);
				this.Selezionato.SetActive(false);
				this.BtnUnlock.text = "250";
			}
			else if (shopScript.BAllCurrent == 16 && shopScript.B16 == 1)
			{
				this.Selezionato.SetActive(true);
				this.Ball16.SetActive(true);
				this.ButtonUnlock.SetActive(false);
			}
			else
			{
				this.Ball16.SetActive(false);
			}
			if (shopScript.BAllCurrent == 17 && shopScript.B17 != 1)
			{
				this.Ball17.SetActive(true);
				this.ButtonUnlock.SetActive(true);
				this.Selezionato.SetActive(false);
				this.BtnUnlock.text = "250";
			}
			else if (shopScript.BAllCurrent == 17 && shopScript.B17 == 1)
			{
				this.Selezionato.SetActive(true);
				this.Ball17.SetActive(true);
				this.ButtonUnlock.SetActive(false);
			}
			else
			{
				this.Ball17.SetActive(false);
			}
			if (shopScript.BAllCurrent == 18 && shopScript.B18 != 1)
			{
				this.Ball18.SetActive(true);
				this.ButtonUnlock.SetActive(true);
				this.Selezionato.SetActive(false);
				this.BtnUnlock.text = "250";
			}
			else if (shopScript.BAllCurrent == 18 && shopScript.B18 == 1)
			{
				this.Selezionato.SetActive(true);
				this.Ball18.SetActive(true);
				this.ButtonUnlock.SetActive(false);
			}
			else
			{
				this.Ball18.SetActive(false);
			}
			if (shopScript.BAllCurrent == 19 && shopScript.B19 != 1)
			{
				this.Ball19.SetActive(true);
				this.ButtonUnlock.SetActive(true);
				this.Selezionato.SetActive(false);
				this.BtnUnlock.text = "250";
			}
			else if (shopScript.BAllCurrent == 19 && shopScript.B19 == 1)
			{
				this.Selezionato.SetActive(true);
				this.Ball19.SetActive(true);
				this.ButtonUnlock.SetActive(false);
			}
			else
			{
				this.Ball19.SetActive(false);
			}
			if (shopScript.BAllCurrent == 20 && shopScript.B20 != 1)
			{
				this.Ball20.SetActive(true);
				this.ButtonUnlock.SetActive(true);
				this.Selezionato.SetActive(false);
				this.BtnUnlock.text = "250";
			}
			else if (shopScript.BAllCurrent == 20 && shopScript.B20 == 1)
			{
				this.Selezionato.SetActive(true);
				this.Ball20.SetActive(true);
				this.ButtonUnlock.SetActive(false);
			}
			else
			{
				this.Ball20.SetActive(false);
			}
		}
	}
}
