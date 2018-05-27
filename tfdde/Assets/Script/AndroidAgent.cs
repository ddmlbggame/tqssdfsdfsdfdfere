//using IronSourceJSON;
//using System;
//using System.Collections.Generic;
//using UnityEngine;

//public class AndroidAgent : IronSourceIAgent
//{
//	private static AndroidJavaObject _androidBridge;

//	private static readonly string AndroidBridge = "com.ironsource.unity.androidbridge.AndroidBridge";

//	private const string REWARD_AMOUNT = "reward_amount";

//	private const string REWARD_NAME = "reward_name";

//	private const string PLACEMENT_NAME = "placement_name";

//	public AndroidAgent()
//	{
//		Debug.Log("AndroidAgent ctr");
//	}

//	private AndroidJavaObject getBridge()
//	{
//		if (AndroidAgent._androidBridge == null)
//		{
//			using (AndroidJavaClass androidJavaClass = new AndroidJavaClass(AndroidAgent.AndroidBridge))
//			{
//				AndroidAgent._androidBridge = androidJavaClass.CallStatic<AndroidJavaObject>("getInstance", new object[0]);
//			}
//		}
//		return AndroidAgent._androidBridge;
//	}

//	public void reportAppStarted()
//	{
//		this.getBridge().Call("reportAppStarted", new object[0]);
//	}

//	public void onApplicationPause(bool pause)
//	{
//		if (pause)
//		{
//			this.getBridge().Call("onPause", new object[0]);
//		}
//		else
//		{
//			this.getBridge().Call("onResume", new object[0]);
//		}
//	}

//	public void setAge(int age)
//	{
//		this.getBridge().Call("setAge", new object[]
//		{
//			age
//		});
//	}

//	public void setGender(string gender)
//	{
//		this.getBridge().Call("setGender", new object[]
//		{
//			gender
//		});
//	}

//	public void setMediationSegment(string segment)
//	{
//		this.getBridge().Call("setMediationSegment", new object[]
//		{
//			segment
//		});
//	}

//	public string getAdvertiserId()
//	{
//		return this.getBridge().Call<string>("getAdvertiserId", new object[0]);
//	}

//	public void validateIntegration()
//	{
//		this.getBridge().Call("validateIntegration", new object[0]);
//	}

//	public void shouldTrackNetworkState(bool track)
//	{
//		this.getBridge().Call("shouldTrackNetworkState", new object[]
//		{
//			track
//		});
//	}

//	public bool setDynamicUserId(string dynamicUserId)
//	{
//		return this.getBridge().Call<bool>("setDynamicUserId", new object[]
//		{
//			dynamicUserId
//		});
//	}

//	public void setAdaptersDebug(bool enabled)
//	{
//		this.getBridge().Call("setAdaptersDebug", new object[]
//		{
//			enabled
//		});
//	}

//	public void setUserId(string userId)
//	{
//		this.getBridge().Call("setUserId", new object[]
//		{
//			userId
//		});
//	}

//	public void init(string appKey)
//	{
//		this.getBridge().Call("setPluginData", new object[]
//		{
//			"Unity",
//			IronSource.pluginVersion(),
//			IronSource.unityVersion()
//		});
//		this.getBridge().Call("init", new object[]
//		{
//			appKey
//		});
//	}

//	public void init(string appKey, params string[] adUnits)
//	{
//		this.getBridge().Call("setPluginData", new object[]
//		{
//			"Unity",
//			IronSource.pluginVersion(),
//			IronSource.unityVersion()
//		});
//		this.getBridge().Call("init", new object[]
//		{
//			appKey,
//			adUnits
//		});
//	}

//	public void showRewardedVideo()
//	{
//		this.getBridge().Call("showRewardedVideo", new object[0]);
//	}

//	public void showRewardedVideo(string placementName)
//	{
//		this.getBridge().Call("showRewardedVideo", new object[]
//		{
//			placementName
//		});
//	}

//	public bool isRewardedVideoAvailable()
//	{
//		return this.getBridge().Call<bool>("isRewardedVideoAvailable", new object[0]);
//	}

//	public bool isRewardedVideoPlacementCapped(string placementName)
//	{
//		return this.getBridge().Call<bool>("isRewardedVideoPlacementCapped", new object[]
//		{
//			placementName
//		});
//	}

//	public IronSourcePlacement getPlacementInfo(string placementName)
//	{
//		string text = this.getBridge().Call<string>("getPlacementInfo", new object[]
//		{
//			placementName
//		});
//		IronSourcePlacement result = null;
//		if (text != null)
//		{
//			Dictionary<string, object> dictionary = Json.Deserialize(text) as Dictionary<string, object>;
//			string placementName2 = dictionary["placement_name"].ToString();
//			string rewardName = dictionary["reward_name"].ToString();
//			int rewardAmount = Convert.ToInt32(dictionary["reward_amount"].ToString());
//			result = new IronSourcePlacement(placementName2, rewardName, rewardAmount);
//		}
//		return result;
//	}

//	public void setRewardedVideoServerParams(Dictionary<string, string> parameters)
//	{
//		string text = Json.Serialize(parameters);
//		this.getBridge().Call("setRewardedVideoServerParams", new object[]
//		{
//			text
//		});
//	}

//	public void clearRewardedVideoServerParams()
//	{
//		this.getBridge().Call("clearRewardedVideoServerParams", new object[0]);
//	}

//	public void loadInterstitial()
//	{
//		this.getBridge().Call("loadInterstitial", new object[0]);
//	}

//	public void showInterstitial()
//	{
//		this.getBridge().Call("showInterstitial", new object[0]);
//	}

//	public void showInterstitial(string placementName)
//	{
//		this.getBridge().Call("showInterstitial", new object[]
//		{
//			placementName
//		});
//	}

//	public bool isInterstitialReady()
//	{
//		return this.getBridge().Call<bool>("isInterstitialReady", new object[0]);
//	}

//	public bool isInterstitialPlacementCapped(string placementName)
//	{
//		return this.getBridge().Call<bool>("isInterstitialPlacementCapped", new object[]
//		{
//			placementName
//		});
//	}

//	public void showOfferwall()
//	{
//		this.getBridge().Call("showOfferwall", new object[0]);
//	}

//	public void showOfferwall(string placementName)
//	{
//		this.getBridge().Call("showOfferwall", new object[]
//		{
//			placementName
//		});
//	}

//	public void getOfferwallCredits()
//	{
//		this.getBridge().Call("getOfferwallCredits", new object[0]);
//	}

//	public bool isOfferwallAvailable()
//	{
//		return this.getBridge().Call<bool>("isOfferwallAvailable", new object[0]);
//	}

//	public void loadBanner(IronSourceBannerSize size, IronSourceBannerPosition position)
//	{
//		this.getBridge().Call("loadBanner", new object[]
//		{
//			(int)size,
//			(int)position
//		});
//	}

//	public void loadBanner(IronSourceBannerSize size, IronSourceBannerPosition position, string placementName)
//	{
//		this.getBridge().Call("loadBanner", new object[]
//		{
//			(int)size,
//			(int)position,
//			placementName
//		});
//	}

//	public void destroyBanner()
//	{
//		this.getBridge().Call("destroyBanner", new object[0]);
//	}

//	public void displayBanner()
//	{
//		this.getBridge().Call("displayBanner", new object[0]);
//	}

//	public void hideBanner()
//	{
//		this.getBridge().Call("hideBanner", new object[0]);
//	}

//	public bool isBannerPlacementCapped(string placementName)
//	{
//		return this.getBridge().Call<bool>("isBannerPlacementCapped", new object[]
//		{
//			placementName
//		});
//	}

//	public void setSegment(IronSourceSegment segment)
//	{
//		Dictionary<string, string> segmentAsDict = segment.getSegmentAsDict();
//		string text = Json.Serialize(segmentAsDict);
//		this.getBridge().Call("setSegment", new object[]
//		{
//			text
//		});
//	}
//}
