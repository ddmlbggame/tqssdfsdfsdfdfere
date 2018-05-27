using System;
using UnityEngine;
using UnityEngine.UI;

namespace Adorables.Ball
{
	public class Utils : MonoBehaviour
	{
		[SerializeField]
		private Text gameOverCurrentScore;

		[SerializeField]
		private Text gameOverBestScore;

		[SerializeField]
		private Text hudCurrentScore;

		[SerializeField]
		private Text hudBestScore;

		[SerializeField]
		private Text hudCoins;

		[SerializeField]
		private Text coinsShop;

		public static int Moneta;

		public static int Bestscore;

		public static int Currentscore;

		public static int RemoveCash;

		public static int AddCash;

		public static int VideoCash;

		public static int NextTurn;

		public void Start()
		{
			if (PlayerPrefs.HasKey("moneta") || PlayerPrefs.HasKey("bestScore"))
			{
				Utils.Moneta = PlayerPrefs.GetInt("moneta");
			}
			else
			{
				Utils.Moneta = 0;
			}
		}

		public void Update()
		{
			Utils.Bestscore = PlayerPrefs.GetInt("bestScore");
			int bestscore = Utils.Bestscore;
			if (bestscore < Utils.Currentscore)
			{
				PlayerPrefs.SetInt("bestScore", Utils.Currentscore);
				PlayerPrefs.Save();
				this.hudBestScore.text = Utils.Currentscore.ToString();
			}
			if (Utils.Currentscore > bestscore)
			{
			}
			this.coinsShop.text = Utils.Moneta.ToString();
			this.hudCoins.text = Utils.Moneta.ToString();
			this.hudBestScore.text = Utils.Bestscore.ToString();
			this.hudCurrentScore.text = Utils.Currentscore.ToString();
			this.gameOverCurrentScore.text = Utils.Currentscore.ToString();
			this.gameOverBestScore.text = Utils.Bestscore.ToString();
			if (Utils.RemoveCash == 1)
			{
				Utils.RemoveCash = 0;
				Utils.Moneta -= 250;
				PlayerPrefs.SetInt("moneta", Utils.Moneta);
				PlayerPrefs.Save();
			}
			if (Utils.NextTurn == 1)
			{
				Utils.NextTurn = 0;
				Utils.Currentscore++;
			}
			if (Utils.NextTurn == 2)
			{
				Utils.NextTurn = 0;
				Utils.Currentscore = 0;
			}
		}
	}
}
