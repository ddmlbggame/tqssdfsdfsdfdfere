using System;
using UnityEngine;

namespace AppAdvisory.BallX
{
	public class UIManager : MonoBehaviour
	{
		[SerializeField]
		private RectTransform titlecard;

		[SerializeField]
		private RectTransform gameOver;

		[SerializeField]
		private RectTransform Shop;

		[SerializeField]
		private RectTransform Info;

		[SerializeField]
		private RectTransform InfoAbout;

		[SerializeField]
		private RectTransform pausa;

		[SerializeField]
		private RectTransform Continue;

		[SerializeField]
		private RectTransform hud;

		public Action PlayButtonClicked;

		public Action WatchAdButtonClicked;

		public Action ShopButtonClicked;

		public Action InfoButtonClicked;

		public Action RateButtonClicked;

		public Action ReplayButtonClicked;

		public Action MainMenuButtonClicked;

		public Action PauseButtonClicked;

		public Action PauseResumeButtonClicked;

		public Action ContinueButtonClicked;

		private void Start()
		{
			this.DisplayTitlecard(true);
			this.DisplayGameOver(false);
			this.DisplayPause(false);
			this.DisplayHUD(false);
			this.DisplayContinua(false);
			this.DisplayInfo(false);
		}

		public void DisplayInfoAbout(bool isShown)
		{
			this.InfoAbout.gameObject.SetActive(isShown);
		}

		public void DisplayInfo(bool isShown)
		{
			this.Info.gameObject.SetActive(isShown);
		}

		public void DisplayContinua(bool isShown)
		{
			this.Continue.gameObject.SetActive(isShown);
		}

		public void DisplayShop(bool isShown)
		{
			GameManager.Gonext = 1;
			this.Shop.gameObject.SetActive(isShown);
		}

		public void DisplayTitlecard(bool isShown)
		{
			this.titlecard.gameObject.SetActive(isShown);
		}

		public void DisplayGameOver(bool isShown)
		{
			this.gameOver.gameObject.SetActive(isShown);
		}

		public void DisplayPause(bool isShown)
		{
			this.pausa.gameObject.SetActive(isShown);
		}

		public void DisplayHUD(bool isShown)
		{
			this.hud.gameObject.SetActive(isShown);
		}

		public void OnPlayButton()
		{
			if (this.PlayButtonClicked != null)
			{
				this.PlayButtonClicked();
			}
			this.DisplayTitlecard(false);
		}

		public void OnWatchAdButton()
		{
			if (this.WatchAdButtonClicked != null)
			{
				this.WatchAdButtonClicked();
			}
		}

		public void OnInfoAbout()
		{
			if (this.InfoButtonClicked != null)
			{
				this.InfoButtonClicked();
			}
			Sounds.PlayBtnSound = 1;
			this.DisplayShop(false);
			this.DisplayHUD(false);
			this.DisplayContinua(false);
			this.DisplayPause(false);
			this.DisplayTitlecard(false);
			this.DisplayInfoAbout(true);
			Debug.Log("info aperto");
		}

		public void OnInfoAboutClose()
		{
			if (this.InfoButtonClicked != null)
			{
				this.InfoButtonClicked();
			}
			Sounds.PlayBtnSound = 1;
			this.DisplayShop(false);
			this.DisplayHUD(false);
			this.DisplayContinua(false);
			this.DisplayPause(false);
			this.DisplayInfoAbout(false);
			Debug.Log("info aperto");
		}

		public void OnInfo()
		{
			if (this.InfoButtonClicked != null)
			{
				this.InfoButtonClicked();
			}
			Sounds.PlayBtnSound = 1;
			this.DisplayShop(false);
			this.DisplayHUD(false);
			this.DisplayContinua(false);
			this.DisplayPause(false);
			this.DisplayTitlecard(false);
			this.DisplayInfo(true);
			Debug.Log("info aperto");
		}

		public void OnInfoClose()
		{
			if (this.InfoButtonClicked != null)
			{
				this.InfoButtonClicked();
			}
			Sounds.PlayBtnSound = 1;
			this.DisplayShop(false);
			this.DisplayHUD(false);
			this.DisplayContinua(false);
			this.DisplayPause(false);
			this.DisplayTitlecard(true);
			this.DisplayInfo(false);
			Debug.Log("info aperto");
		}

		public void NewGame()
		{
			Application.OpenURL("https://play.google.com/store/apps/details?id=com.ItaIndieStudio.basketball2k18");
		}

		public void OnShopButton()
		{
			if (this.ShopButtonClicked != null)
			{
				this.ShopButtonClicked();
			}
			Sounds.PlayBtnSound = 1;
			this.DisplayShop(true);
			this.DisplayHUD(false);
			this.DisplayContinua(false);
			this.DisplayPause(false);
			this.DisplayTitlecard(false);
			Time.timeScale = 1f;
			Debug.Log("shop aperto");
		}

		public void OnShopButtonClose()
		{
			if (this.ShopButtonClicked != null)
			{
				this.ShopButtonClicked();
			}
			Sounds.PlayBtnSound = 1;
			this.DisplayShop(false);
			this.DisplayHUD(false);
			this.DisplayContinua(false);
			this.DisplayPause(false);
			this.DisplayTitlecard(true);
			Time.timeScale = 1f;
			Debug.Log("shop aperto");
		}

		public void OnRateButton()
		{
			if (this.RateButtonClicked != null)
			{
				this.RateButtonClicked();
			}
		}

		public void OnReplayButton()
		{
			if (this.ReplayButtonClicked != null)
			{
				this.ReplayButtonClicked();
			}
		}

		public void OnContinueButton()
		{
			if (this.ContinueButtonClicked != null)
			{
				this.ContinueButtonClicked();
			}
			Sounds.PlayBtnSound = 1;
			Debug.Log("Resumed from continue ads");
			this.DisplayPause(false);
			this.DisplayContinua(false);
			Time.timeScale = 1f;
			this.DisplayHUD(true);
		}

		public void OnMainMenuButton()
		{
			if (this.MainMenuButtonClicked != null)
			{
				this.MainMenuButtonClicked();
			}
			this.DisplayHUD(false);
			this.DisplayContinua(false);
			this.DisplayPause(false);
			Time.timeScale = 1f;
			GameManager.ManagerContinua = 1;
			PlayerPrefs.SetInt("continua", GameManager.ManagerContinua);
			PlayerPrefs.Save();
		}

		public void OnPauseButton()
		{
			if (this.PauseButtonClicked != null)
			{
				this.PauseButtonClicked();
			}
			Debug.Log("Pausa");
			this.DisplayPause(true);
			this.DisplayHUD(false);
			Time.timeScale = 0f;
		}

		public void OnPauseResumeButton()
		{
			if (this.PauseResumeButtonClicked != null)
			{
				this.PauseResumeButtonClicked();
			}
			Sounds.PlayBtnSound = 1;
			Debug.Log("Resumed");
			this.DisplayPause(false);
			Time.timeScale = 1f;
			this.DisplayHUD(true);
		}

		public void Update()
		{
		}

		public void Privacypolicy()
		{
			Application.OpenURL("https://itaindiestudio.com/privacy-policy");
		}
	}
}
