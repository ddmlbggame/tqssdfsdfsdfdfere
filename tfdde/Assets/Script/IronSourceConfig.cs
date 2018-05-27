using IronSourceJSON;
using System;
using System.Collections.Generic;
using UnityEngine;

public class IronSourceConfig
{
	//private const string unsupportedPlatformStr = "Unsupported Platform";

	//private static IronSourceConfig _instance;

	//private static AndroidJavaObject _androidBridge;

	//private static readonly string AndroidBridge = "com.ironsource.unity.androidbridge.AndroidBridge";

	//public static IronSourceConfig Instance
	//{
	//	get
	//	{
	//		if (IronSourceConfig._instance == null)
	//		{
	//			IronSourceConfig._instance = new IronSourceConfig();
	//		}
	//		return IronSourceConfig._instance;
	//	}
	//}

	//public IronSourceConfig()
	//{
	//	using (AndroidJavaClass androidJavaClass = new AndroidJavaClass(IronSourceConfig.AndroidBridge))
	//	{
	//		IronSourceConfig._androidBridge = androidJavaClass.CallStatic<AndroidJavaObject>("getInstance", new object[0]);
	//	}
	//}

	//public void setLanguage(string language)
	//{
	//	IronSourceConfig._androidBridge.Call("setLanguage", new object[]
	//	{
	//		language
	//	});
	//}

	//public void setClientSideCallbacks(bool status)
	//{
	//	IronSourceConfig._androidBridge.Call("setClientSideCallbacks", new object[]
	//	{
	//		status
	//	});
	//}

	//public void setRewardedVideoCustomParams(Dictionary<string, string> rewardedVideoCustomParams)
	//{
	//	string text = Json.Serialize(rewardedVideoCustomParams);
	//	IronSourceConfig._androidBridge.Call("setRewardedVideoCustomParams", new object[]
	//	{
	//		text
	//	});
	//}

	//public void setOfferwallCustomParams(Dictionary<string, string> offerwallCustomParams)
	//{
	//	string text = Json.Serialize(offerwallCustomParams);
	//	IronSourceConfig._androidBridge.Call("setOfferwallCustomParams", new object[]
	//	{
	//		text
	//	});
	//}
}
