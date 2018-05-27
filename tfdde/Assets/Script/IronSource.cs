//using System;
//using System.Collections.Generic;
//using UnityEngine;

//public class IronSource : IronSourceIAgent
//{
//	private IronSourceIAgent _platformAgent;

//	private static IronSource _instance;

//	private const string UNITY_PLUGIN_VERSION = "6.7.3";

//	public const string GENDER_MALE = "male";

//	public const string GENDER_FEMALE = "female";

//	public const string GENDER_UNKNOWN = "unknown";

//	public static IronSource Agent
//	{
//		get
//		{
//			if (IronSource._instance == null)
//			{
//				IronSource._instance = new IronSource();
//			}
//			return IronSource._instance;
//		}
//	}

//	private IronSource()
//	{
//		this._platformAgent = new AndroidAgent();
//	}

//	public static string pluginVersion()
//	{
//		return "6.7.3";
//	}

//	public static string unityVersion()
//	{
//		return Application.unityVersion;
//	}

//	public void reportAppStarted()
//	{
//		this._platformAgent.reportAppStarted();
//	}

//	public void onApplicationPause(bool pause)
//	{
//		this._platformAgent.onApplicationPause(pause);
//	}

//	public void setAge(int age)
//	{
//		this._platformAgent.setAge(age);
//	}

//	public void setGender(string gender)
//	{
//		if (gender.Equals("male"))
//		{
//			this._platformAgent.setGender("male");
//		}
//		else if (gender.Equals("female"))
//		{
//			this._platformAgent.setGender("female");
//		}
//		else if (gender.Equals("unknown"))
//		{
//			this._platformAgent.setGender("unknown");
//		}
//	}

//	public void setMediationSegment(string segment)
//	{
//		this._platformAgent.setMediationSegment(segment);
//	}

//	public string getAdvertiserId()
//	{
//		return this._platformAgent.getAdvertiserId();
//	}

//	public void validateIntegration()
//	{
//		this._platformAgent.validateIntegration();
//	}

//	public void shouldTrackNetworkState(bool track)
//	{
//		this._platformAgent.shouldTrackNetworkState(track);
//	}

//	public bool setDynamicUserId(string dynamicUserId)
//	{
//		return this._platformAgent.setDynamicUserId(dynamicUserId);
//	}

//	public void setAdaptersDebug(bool enabled)
//	{
//		this._platformAgent.setAdaptersDebug(enabled);
//	}

//	public void setUserId(string userId)
//	{
//		this._platformAgent.setUserId(userId);
//	}

//	public void init(string appKey)
//	{
//		this._platformAgent.init(appKey);
//	}

//	public void init(string appKey, params string[] adUnits)
//	{
//		this._platformAgent.init(appKey, adUnits);
//	}

//	public void showRewardedVideo()
//	{
//		this._platformAgent.showRewardedVideo();
//	}

//	public void showRewardedVideo(string placementName)
//	{
//		this._platformAgent.showRewardedVideo(placementName);
//	}

//	public IronSourcePlacement getPlacementInfo(string placementName)
//	{
//		return this._platformAgent.getPlacementInfo(placementName);
//	}

//	public bool isRewardedVideoAvailable()
//	{
//		return this._platformAgent.isRewardedVideoAvailable();
//	}

//	public bool isRewardedVideoPlacementCapped(string placementName)
//	{
//		return this._platformAgent.isRewardedVideoPlacementCapped(placementName);
//	}

//	public void setRewardedVideoServerParams(Dictionary<string, string> parameters)
//	{
//		this._platformAgent.setRewardedVideoServerParams(parameters);
//	}

//	public void clearRewardedVideoServerParams()
//	{
//		this._platformAgent.clearRewardedVideoServerParams();
//	}

//	public void loadInterstitial()
//	{
//		this._platformAgent.loadInterstitial();
//	}

//	public void showInterstitial()
//	{
//		this._platformAgent.showInterstitial();
//	}

//	public void showInterstitial(string placementName)
//	{
//		this._platformAgent.showInterstitial(placementName);
//	}

//	public bool isInterstitialReady()
//	{
//		return this._platformAgent.isInterstitialReady();
//	}

//	public bool isInterstitialPlacementCapped(string placementName)
//	{
//		return this._platformAgent.isInterstitialPlacementCapped(placementName);
//	}

//	public void showOfferwall()
//	{
//		this._platformAgent.showOfferwall();
//	}

//	public void showOfferwall(string placementName)
//	{
//		this._platformAgent.showOfferwall(placementName);
//	}

//	public void getOfferwallCredits()
//	{
//		this._platformAgent.getOfferwallCredits();
//	}

//	public bool isOfferwallAvailable()
//	{
//		return this._platformAgent.isOfferwallAvailable();
//	}

//	public void loadBanner(IronSourceBannerSize size, IronSourceBannerPosition position)
//	{
//		this._platformAgent.loadBanner(size, position);
//	}

//	public void loadBanner(IronSourceBannerSize size, IronSourceBannerPosition position, string placementName)
//	{
//		this._platformAgent.loadBanner(size, position, placementName);
//	}

//	public void destroyBanner()
//	{
//		this._platformAgent.destroyBanner();
//	}

//	public void displayBanner()
//	{
//		this._platformAgent.displayBanner();
//	}

//	public void hideBanner()
//	{
//		this._platformAgent.hideBanner();
//	}

//	public bool isBannerPlacementCapped(string placementName)
//	{
//		return this._platformAgent.isBannerPlacementCapped(placementName);
//	}

//	public void setSegment(IronSourceSegment segment)
//	{
//		this._platformAgent.setSegment(segment);
//	}
//}
