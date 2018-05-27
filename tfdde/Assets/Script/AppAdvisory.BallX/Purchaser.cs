//using System;
//using UnityEngine;
//using UnityEngine.Purchasing;
//using UnityEngine.Purchasing.Extension;

//namespace AppAdvisory.BallX
//{
//	public class Purchaser : MonoBehaviour, IStoreListener
//	{
//		private static IStoreController m_StoreController;

//		private static IExtensionProvider m_StoreExtensionProvider;

//		public static string Buy250 = "com.itaindiestudio.bubbleshotballz.coin250";

//		public static string Buy560 = "com.itaindiestudio.bubbleshotballz.coin560";

//		public static string Buy1200 = "com.itaindiestudio.bubbleshotballz.coin1200";

//		public static string Buy2600 = "com.itaindiestudio.bubbleshotballz.coin2600";

//		public static string RemoveAds = "com.itaindiestudio.bubbleshotballz.removeads";

//		private static string kProductNameAppleSubscription = "com.unity3d.subscription.new";

//		private static string kProductNameGooglePlaySubscription = "com.unity3d.subscription.original";

//		public GameObject AdsButton;

//		private void Start()
//		{
//			if (Purchaser.m_StoreController == null)
//			{
//				this.InitializePurchasing();
//			}
//		}

//		public void InitializePurchasing()
//		{
//			if (this.IsInitialized())
//			{
//				return;
//			}
//			ConfigurationBuilder configurationBuilder = ConfigurationBuilder.Instance(StandardPurchasingModule.Instance(), new IPurchasingModule[0]);
//			configurationBuilder.AddProduct(Purchaser.Buy250, ProductType.Consumable);
//			configurationBuilder.AddProduct(Purchaser.Buy560, ProductType.Consumable);
//			configurationBuilder.AddProduct(Purchaser.Buy1200, ProductType.Consumable);
//			configurationBuilder.AddProduct(Purchaser.Buy2600, ProductType.Consumable);
//			configurationBuilder.AddProduct(Purchaser.RemoveAds, ProductType.NonConsumable);
//			UnityPurchasing.Initialize(this, configurationBuilder);
//		}

//		private bool IsInitialized()
//		{
//			return Purchaser.m_StoreController != null && Purchaser.m_StoreExtensionProvider != null;
//		}

//		public void BuyCoins250()
//		{
//			this.BuyProductID(Purchaser.Buy250);
//			Sounds.PlayBtnSound = 1;
//		}

//		public void BuyCoins560()
//		{
//			this.BuyProductID(Purchaser.Buy560);
//			Sounds.PlayBtnSound = 1;
//		}

//		public void BuyCoins1200()
//		{
//			this.BuyProductID(Purchaser.Buy1200);
//			Sounds.PlayBtnSound = 1;
//		}

//		public void BuyCoins2600()
//		{
//			this.BuyProductID(Purchaser.Buy2600);
//			Sounds.PlayBtnSound = 1;
//		}

//		public void RemoveTheAds()
//		{
//			if (PlayerPrefs.HasKey("RemoveAds"))
//			{
//				Debug.Log("ads are bought ");
//				this.AdsButton.SetActive(false);
//			}
//			else
//			{
//				this.BuyProductID(Purchaser.RemoveAds);
//			}
//			Sounds.PlayBtnSound = 1;
//		}

//		public void DeleteplayerPrefs()
//		{
//			PlayerPrefs.DeleteAll();
//		}

//		private void BuyProductID(string productId)
//		{
//			if (this.IsInitialized())
//			{
//				Product product = Purchaser.m_StoreController.products.WithID(productId);
//				if (product != null && product.availableToPurchase)
//				{
//					Debug.Log(string.Format("Purchasing product asychronously: '{0}'", product.definition.id));
//					Purchaser.m_StoreController.InitiatePurchase(product);
//				}
//				else
//				{
//					Debug.Log("BuyProductID: FAIL. Not purchasing product, either is not found or is not available for purchase");
//				}
//			}
//			else
//			{
//				Debug.Log("BuyProductID FAIL. Not initialized.");
//			}
//		}

//		public void RestorePurchases()
//		{
//			if (!this.IsInitialized())
//			{
//				Debug.Log("RestorePurchases FAIL. Not initialized.");
//				return;
//			}
//			if (Application.platform == RuntimePlatform.IPhonePlayer || Application.platform == RuntimePlatform.OSXPlayer)
//			{
//				Debug.Log("RestorePurchases started ...");
//				IAppleExtensions extension = Purchaser.m_StoreExtensionProvider.GetExtension<IAppleExtensions>();
//				extension.RestoreTransactions(delegate(bool result)
//				{
//					Debug.Log("RestorePurchases continuing: " + result + ". If no further messages, no purchases available to restore.");
//				});
//			}
//			else
//			{
//				Debug.Log("RestorePurchases FAIL. Not supported on this platform. Current = " + Application.platform);
//			}
//		}

//		public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
//		{
//			Debug.Log("OnInitialized: PASS");
//			Purchaser.m_StoreController = controller;
//			Purchaser.m_StoreExtensionProvider = extensions;
//		}

//		public void OnInitializeFailed(InitializationFailureReason error)
//		{
//			Debug.Log("OnInitializeFailed InitializationFailureReason:" + error);
//		}

//		public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs args)
//		{
//			if (string.Equals(args.purchasedProduct.definition.id, Purchaser.Buy250, StringComparison.Ordinal))
//			{
//				Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
//				Utils.Moneta += 250;
//				PlayerPrefs.SetInt("moneta", Utils.Moneta);
//				PlayerPrefs.Save();
//			}
//			if (string.Equals(args.purchasedProduct.definition.id, Purchaser.Buy560, StringComparison.Ordinal))
//			{
//				Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
//				Utils.Moneta += 560;
//				PlayerPrefs.SetInt("moneta", Utils.Moneta);
//				PlayerPrefs.Save();
//			}
//			if (string.Equals(args.purchasedProduct.definition.id, Purchaser.Buy1200, StringComparison.Ordinal))
//			{
//				Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
//				Utils.Moneta += 1200;
//				PlayerPrefs.SetInt("moneta", Utils.Moneta);
//				PlayerPrefs.Save();
//			}
//			if (string.Equals(args.purchasedProduct.definition.id, Purchaser.Buy2600, StringComparison.Ordinal))
//			{
//				Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
//				Utils.Moneta += 2600;
//				PlayerPrefs.SetInt("moneta", Utils.Moneta);
//				PlayerPrefs.Save();
//			}
//			else if (string.Equals(args.purchasedProduct.definition.id, Purchaser.RemoveAds, StringComparison.Ordinal))
//			{
//				rewarded.RemoveAds = 1;
//				Pservices.a8 = 1;
//				PlayerPrefs.SetInt("RemoveAds", rewarded.RemoveAds);
//				PlayerPrefs.Save();
//				Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
//			}
//			return PurchaseProcessingResult.Complete;
//		}

//		public void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason)
//		{
//			Debug.Log(string.Format("OnPurchaseFailed: FAIL. Product: '{0}', PurchaseFailureReason: {1}", product.definition.storeSpecificId, failureReason));
//		}

//		private void Update()
//		{
//			if (PlayerPrefs.HasKey("RemoveAds"))
//			{
//				Debug.Log("ads off ");
//				this.AdsButton.SetActive(false);
//			}
//			else
//			{
//				this.AdsButton.SetActive(true);
//			}
//		}
//	}
//}
