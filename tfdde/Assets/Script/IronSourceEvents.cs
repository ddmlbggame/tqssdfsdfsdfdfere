//using IronSourceJSON;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading;
//using UnityEngine;

//public class IronSourceEvents : MonoBehaviour
//{
//	private const string ERROR_CODE = "error_code";

//	private const string ERROR_DESCRIPTION = "error_description";

//	private static event Action<IronSourceError> _onRewardedVideoAdShowFailedEvent
//	{
//		add
//		{
//			Action<IronSourceError> action = IronSourceEvents._onRewardedVideoAdShowFailedEvent;
//			Action<IronSourceError> action2;
//			do
//			{
//				action2 = action;
//				action = Interlocked.CompareExchange<Action<IronSourceError>>(ref IronSourceEvents._onRewardedVideoAdShowFailedEvent, (Action<IronSourceError>)Delegate.Combine(action2, value), action);
//			}
//			while (action != action2);
//		}
//		remove
//		{
//			Action<IronSourceError> action = IronSourceEvents._onRewardedVideoAdShowFailedEvent;
//			Action<IronSourceError> action2;
//			do
//			{
//				action2 = action;
//				action = Interlocked.CompareExchange<Action<IronSourceError>>(ref IronSourceEvents._onRewardedVideoAdShowFailedEvent, (Action<IronSourceError>)Delegate.Remove(action2, value), action);
//			}
//			while (action != action2);
//		}
//	}

//	public static event Action<IronSourceError> onRewardedVideoAdShowFailedEvent
//	{
//		add
//		{
//			if (IronSourceEvents._onRewardedVideoAdShowFailedEvent == null || !IronSourceEvents._onRewardedVideoAdShowFailedEvent.GetInvocationList().Contains(value))
//			{
//				IronSourceEvents._onRewardedVideoAdShowFailedEvent += value;
//			}
//		}
//		remove
//		{
//			if (IronSourceEvents._onRewardedVideoAdShowFailedEvent.GetInvocationList().Contains(value))
//			{
//				IronSourceEvents._onRewardedVideoAdShowFailedEvent -= value;
//			}
//		}
//	}

//	private static event Action _onRewardedVideoAdOpenedEvent
//	{
//		add
//		{
//			Action action = IronSourceEvents._onRewardedVideoAdOpenedEvent;
//			Action action2;
//			do
//			{
//				action2 = action;
//				action = Interlocked.CompareExchange<Action>(ref IronSourceEvents._onRewardedVideoAdOpenedEvent, (Action)Delegate.Combine(action2, value), action);
//			}
//			while (action != action2);
//		}
//		remove
//		{
//			Action action = IronSourceEvents._onRewardedVideoAdOpenedEvent;
//			Action action2;
//			do
//			{
//				action2 = action;
//				action = Interlocked.CompareExchange<Action>(ref IronSourceEvents._onRewardedVideoAdOpenedEvent, (Action)Delegate.Remove(action2, value), action);
//			}
//			while (action != action2);
//		}
//	}

//	public static event Action onRewardedVideoAdOpenedEvent
//	{
//		add
//		{
//			if (IronSourceEvents._onRewardedVideoAdOpenedEvent == null || !IronSourceEvents._onRewardedVideoAdOpenedEvent.GetInvocationList().Contains(value))
//			{
//				IronSourceEvents._onRewardedVideoAdOpenedEvent += value;
//			}
//		}
//		remove
//		{
//			if (IronSourceEvents._onRewardedVideoAdOpenedEvent.GetInvocationList().Contains(value))
//			{
//				IronSourceEvents._onRewardedVideoAdOpenedEvent -= value;
//			}
//		}
//	}

//	private static event Action _onRewardedVideoAdClosedEvent
//	{
//		add
//		{
//			Action action = IronSourceEvents._onRewardedVideoAdClosedEvent;
//			Action action2;
//			do
//			{
//				action2 = action;
//				action = Interlocked.CompareExchange<Action>(ref IronSourceEvents._onRewardedVideoAdClosedEvent, (Action)Delegate.Combine(action2, value), action);
//			}
//			while (action != action2);
//		}
//		remove
//		{
//			Action action = IronSourceEvents._onRewardedVideoAdClosedEvent;
//			Action action2;
//			do
//			{
//				action2 = action;
//				action = Interlocked.CompareExchange<Action>(ref IronSourceEvents._onRewardedVideoAdClosedEvent, (Action)Delegate.Remove(action2, value), action);
//			}
//			while (action != action2);
//		}
//	}

//	public static event Action onRewardedVideoAdClosedEvent
//	{
//		add
//		{
//			if (IronSourceEvents._onRewardedVideoAdClosedEvent == null || !IronSourceEvents._onRewardedVideoAdClosedEvent.GetInvocationList().Contains(value))
//			{
//				IronSourceEvents._onRewardedVideoAdClosedEvent += value;
//			}
//		}
//		remove
//		{
//			if (IronSourceEvents._onRewardedVideoAdClosedEvent.GetInvocationList().Contains(value))
//			{
//				IronSourceEvents._onRewardedVideoAdClosedEvent -= value;
//			}
//		}
//	}

//	private static event Action _onRewardedVideoAdStartedEvent
//	{
//		add
//		{
//			Action action = IronSourceEvents._onRewardedVideoAdStartedEvent;
//			Action action2;
//			do
//			{
//				action2 = action;
//				action = Interlocked.CompareExchange<Action>(ref IronSourceEvents._onRewardedVideoAdStartedEvent, (Action)Delegate.Combine(action2, value), action);
//			}
//			while (action != action2);
//		}
//		remove
//		{
//			Action action = IronSourceEvents._onRewardedVideoAdStartedEvent;
//			Action action2;
//			do
//			{
//				action2 = action;
//				action = Interlocked.CompareExchange<Action>(ref IronSourceEvents._onRewardedVideoAdStartedEvent, (Action)Delegate.Remove(action2, value), action);
//			}
//			while (action != action2);
//		}
//	}

//	public static event Action onRewardedVideoAdStartedEvent
//	{
//		add
//		{
//			if (IronSourceEvents._onRewardedVideoAdStartedEvent == null || !IronSourceEvents._onRewardedVideoAdStartedEvent.GetInvocationList().Contains(value))
//			{
//				IronSourceEvents._onRewardedVideoAdStartedEvent += value;
//			}
//		}
//		remove
//		{
//			if (IronSourceEvents._onRewardedVideoAdStartedEvent.GetInvocationList().Contains(value))
//			{
//				IronSourceEvents._onRewardedVideoAdStartedEvent -= value;
//			}
//		}
//	}

//	private static event Action _onRewardedVideoAdEndedEvent
//	{
//		add
//		{
//			Action action = IronSourceEvents._onRewardedVideoAdEndedEvent;
//			Action action2;
//			do
//			{
//				action2 = action;
//				action = Interlocked.CompareExchange<Action>(ref IronSourceEvents._onRewardedVideoAdEndedEvent, (Action)Delegate.Combine(action2, value), action);
//			}
//			while (action != action2);
//		}
//		remove
//		{
//			Action action = IronSourceEvents._onRewardedVideoAdEndedEvent;
//			Action action2;
//			do
//			{
//				action2 = action;
//				action = Interlocked.CompareExchange<Action>(ref IronSourceEvents._onRewardedVideoAdEndedEvent, (Action)Delegate.Remove(action2, value), action);
//			}
//			while (action != action2);
//		}
//	}

//	public static event Action onRewardedVideoAdEndedEvent
//	{
//		add
//		{
//			if (IronSourceEvents._onRewardedVideoAdEndedEvent == null || !IronSourceEvents._onRewardedVideoAdEndedEvent.GetInvocationList().Contains(value))
//			{
//				IronSourceEvents._onRewardedVideoAdEndedEvent += value;
//			}
//		}
//		remove
//		{
//			if (IronSourceEvents._onRewardedVideoAdEndedEvent.GetInvocationList().Contains(value))
//			{
//				IronSourceEvents._onRewardedVideoAdEndedEvent -= value;
//			}
//		}
//	}

//	private static event Action<IronSourcePlacement> _onRewardedVideoAdRewardedEvent
//	{
//		add
//		{
//			Action<IronSourcePlacement> action = IronSourceEvents._onRewardedVideoAdRewardedEvent;
//			Action<IronSourcePlacement> action2;
//			do
//			{
//				action2 = action;
//				action = Interlocked.CompareExchange<Action<IronSourcePlacement>>(ref IronSourceEvents._onRewardedVideoAdRewardedEvent, (Action<IronSourcePlacement>)Delegate.Combine(action2, value), action);
//			}
//			while (action != action2);
//		}
//		remove
//		{
//			Action<IronSourcePlacement> action = IronSourceEvents._onRewardedVideoAdRewardedEvent;
//			Action<IronSourcePlacement> action2;
//			do
//			{
//				action2 = action;
//				action = Interlocked.CompareExchange<Action<IronSourcePlacement>>(ref IronSourceEvents._onRewardedVideoAdRewardedEvent, (Action<IronSourcePlacement>)Delegate.Remove(action2, value), action);
//			}
//			while (action != action2);
//		}
//	}

//	public static event Action<IronSourcePlacement> onRewardedVideoAdRewardedEvent
//	{
//		add
//		{
//			if (IronSourceEvents._onRewardedVideoAdRewardedEvent == null || !IronSourceEvents._onRewardedVideoAdRewardedEvent.GetInvocationList().Contains(value))
//			{
//				IronSourceEvents._onRewardedVideoAdRewardedEvent += value;
//			}
//		}
//		remove
//		{
//			if (IronSourceEvents._onRewardedVideoAdRewardedEvent.GetInvocationList().Contains(value))
//			{
//				IronSourceEvents._onRewardedVideoAdRewardedEvent -= value;
//			}
//		}
//	}

//	private static event Action<IronSourcePlacement> _onRewardedVideoAdClickedEvent
//	{
//		add
//		{
//			Action<IronSourcePlacement> action = IronSourceEvents._onRewardedVideoAdClickedEvent;
//			Action<IronSourcePlacement> action2;
//			do
//			{
//				action2 = action;
//				action = Interlocked.CompareExchange<Action<IronSourcePlacement>>(ref IronSourceEvents._onRewardedVideoAdClickedEvent, (Action<IronSourcePlacement>)Delegate.Combine(action2, value), action);
//			}
//			while (action != action2);
//		}
//		remove
//		{
//			Action<IronSourcePlacement> action = IronSourceEvents._onRewardedVideoAdClickedEvent;
//			Action<IronSourcePlacement> action2;
//			do
//			{
//				action2 = action;
//				action = Interlocked.CompareExchange<Action<IronSourcePlacement>>(ref IronSourceEvents._onRewardedVideoAdClickedEvent, (Action<IronSourcePlacement>)Delegate.Remove(action2, value), action);
//			}
//			while (action != action2);
//		}
//	}

//	public static event Action<IronSourcePlacement> onRewardedVideoAdClickedEvent
//	{
//		add
//		{
//			if (IronSourceEvents._onRewardedVideoAdClickedEvent == null || !IronSourceEvents._onRewardedVideoAdClickedEvent.GetInvocationList().Contains(value))
//			{
//				IronSourceEvents._onRewardedVideoAdClickedEvent += value;
//			}
//		}
//		remove
//		{
//			if (IronSourceEvents._onRewardedVideoAdClickedEvent.GetInvocationList().Contains(value))
//			{
//				IronSourceEvents._onRewardedVideoAdClickedEvent -= value;
//			}
//		}
//	}

//	private static event Action<bool> _onRewardedVideoAvailabilityChangedEvent
//	{
//		add
//		{
//			Action<bool> action = IronSourceEvents._onRewardedVideoAvailabilityChangedEvent;
//			Action<bool> action2;
//			do
//			{
//				action2 = action;
//				action = Interlocked.CompareExchange<Action<bool>>(ref IronSourceEvents._onRewardedVideoAvailabilityChangedEvent, (Action<bool>)Delegate.Combine(action2, value), action);
//			}
//			while (action != action2);
//		}
//		remove
//		{
//			Action<bool> action = IronSourceEvents._onRewardedVideoAvailabilityChangedEvent;
//			Action<bool> action2;
//			do
//			{
//				action2 = action;
//				action = Interlocked.CompareExchange<Action<bool>>(ref IronSourceEvents._onRewardedVideoAvailabilityChangedEvent, (Action<bool>)Delegate.Remove(action2, value), action);
//			}
//			while (action != action2);
//		}
//	}

//	public static event Action<bool> onRewardedVideoAvailabilityChangedEvent
//	{
//		add
//		{
//			if (IronSourceEvents._onRewardedVideoAvailabilityChangedEvent == null || !IronSourceEvents._onRewardedVideoAvailabilityChangedEvent.GetInvocationList().Contains(value))
//			{
//				IronSourceEvents._onRewardedVideoAvailabilityChangedEvent += value;
//			}
//		}
//		remove
//		{
//			if (IronSourceEvents._onRewardedVideoAvailabilityChangedEvent.GetInvocationList().Contains(value))
//			{
//				IronSourceEvents._onRewardedVideoAvailabilityChangedEvent -= value;
//			}
//		}
//	}

//	private static event Action _onInterstitialAdReadyEvent
//	{
//		add
//		{
//			Action action = IronSourceEvents._onInterstitialAdReadyEvent;
//			Action action2;
//			do
//			{
//				action2 = action;
//				action = Interlocked.CompareExchange<Action>(ref IronSourceEvents._onInterstitialAdReadyEvent, (Action)Delegate.Combine(action2, value), action);
//			}
//			while (action != action2);
//		}
//		remove
//		{
//			Action action = IronSourceEvents._onInterstitialAdReadyEvent;
//			Action action2;
//			do
//			{
//				action2 = action;
//				action = Interlocked.CompareExchange<Action>(ref IronSourceEvents._onInterstitialAdReadyEvent, (Action)Delegate.Remove(action2, value), action);
//			}
//			while (action != action2);
//		}
//	}

//	public static event Action onInterstitialAdReadyEvent
//	{
//		add
//		{
//			if (IronSourceEvents._onInterstitialAdReadyEvent == null || !IronSourceEvents._onInterstitialAdReadyEvent.GetInvocationList().Contains(value))
//			{
//				IronSourceEvents._onInterstitialAdReadyEvent += value;
//			}
//		}
//		remove
//		{
//			if (IronSourceEvents._onInterstitialAdReadyEvent.GetInvocationList().Contains(value))
//			{
//				IronSourceEvents._onInterstitialAdReadyEvent -= value;
//			}
//		}
//	}

//	private static event Action<IronSourceError> _onInterstitialAdLoadFailedEvent
//	{
//		add
//		{
//			Action<IronSourceError> action = IronSourceEvents._onInterstitialAdLoadFailedEvent;
//			Action<IronSourceError> action2;
//			do
//			{
//				action2 = action;
//				action = Interlocked.CompareExchange<Action<IronSourceError>>(ref IronSourceEvents._onInterstitialAdLoadFailedEvent, (Action<IronSourceError>)Delegate.Combine(action2, value), action);
//			}
//			while (action != action2);
//		}
//		remove
//		{
//			Action<IronSourceError> action = IronSourceEvents._onInterstitialAdLoadFailedEvent;
//			Action<IronSourceError> action2;
//			do
//			{
//				action2 = action;
//				action = Interlocked.CompareExchange<Action<IronSourceError>>(ref IronSourceEvents._onInterstitialAdLoadFailedEvent, (Action<IronSourceError>)Delegate.Remove(action2, value), action);
//			}
//			while (action != action2);
//		}
//	}

//	public static event Action<IronSourceError> onInterstitialAdLoadFailedEvent
//	{
//		add
//		{
//			if (IronSourceEvents._onInterstitialAdLoadFailedEvent == null || !IronSourceEvents._onInterstitialAdLoadFailedEvent.GetInvocationList().Contains(value))
//			{
//				IronSourceEvents._onInterstitialAdLoadFailedEvent += value;
//			}
//		}
//		remove
//		{
//			if (IronSourceEvents._onInterstitialAdLoadFailedEvent.GetInvocationList().Contains(value))
//			{
//				IronSourceEvents._onInterstitialAdLoadFailedEvent -= value;
//			}
//		}
//	}

//	private static event Action _onInterstitialAdOpenedEvent
//	{
//		add
//		{
//			Action action = IronSourceEvents._onInterstitialAdOpenedEvent;
//			Action action2;
//			do
//			{
//				action2 = action;
//				action = Interlocked.CompareExchange<Action>(ref IronSourceEvents._onInterstitialAdOpenedEvent, (Action)Delegate.Combine(action2, value), action);
//			}
//			while (action != action2);
//		}
//		remove
//		{
//			Action action = IronSourceEvents._onInterstitialAdOpenedEvent;
//			Action action2;
//			do
//			{
//				action2 = action;
//				action = Interlocked.CompareExchange<Action>(ref IronSourceEvents._onInterstitialAdOpenedEvent, (Action)Delegate.Remove(action2, value), action);
//			}
//			while (action != action2);
//		}
//	}

//	public static event Action onInterstitialAdOpenedEvent
//	{
//		add
//		{
//			if (IronSourceEvents._onInterstitialAdOpenedEvent == null || !IronSourceEvents._onInterstitialAdOpenedEvent.GetInvocationList().Contains(value))
//			{
//				IronSourceEvents._onInterstitialAdOpenedEvent += value;
//			}
//		}
//		remove
//		{
//			if (IronSourceEvents._onInterstitialAdOpenedEvent.GetInvocationList().Contains(value))
//			{
//				IronSourceEvents._onInterstitialAdOpenedEvent -= value;
//			}
//		}
//	}

//	private static event Action _onInterstitialAdClosedEvent
//	{
//		add
//		{
//			Action action = IronSourceEvents._onInterstitialAdClosedEvent;
//			Action action2;
//			do
//			{
//				action2 = action;
//				action = Interlocked.CompareExchange<Action>(ref IronSourceEvents._onInterstitialAdClosedEvent, (Action)Delegate.Combine(action2, value), action);
//			}
//			while (action != action2);
//		}
//		remove
//		{
//			Action action = IronSourceEvents._onInterstitialAdClosedEvent;
//			Action action2;
//			do
//			{
//				action2 = action;
//				action = Interlocked.CompareExchange<Action>(ref IronSourceEvents._onInterstitialAdClosedEvent, (Action)Delegate.Remove(action2, value), action);
//			}
//			while (action != action2);
//		}
//	}

//	public static event Action onInterstitialAdClosedEvent
//	{
//		add
//		{
//			if (IronSourceEvents._onInterstitialAdClosedEvent == null || !IronSourceEvents._onInterstitialAdClosedEvent.GetInvocationList().Contains(value))
//			{
//				IronSourceEvents._onInterstitialAdClosedEvent += value;
//			}
//		}
//		remove
//		{
//			if (IronSourceEvents._onInterstitialAdClosedEvent.GetInvocationList().Contains(value))
//			{
//				IronSourceEvents._onInterstitialAdClosedEvent -= value;
//			}
//		}
//	}

//	private static event Action _onInterstitialAdShowSucceededEvent
//	{
//		add
//		{
//			Action action = IronSourceEvents._onInterstitialAdShowSucceededEvent;
//			Action action2;
//			do
//			{
//				action2 = action;
//				action = Interlocked.CompareExchange<Action>(ref IronSourceEvents._onInterstitialAdShowSucceededEvent, (Action)Delegate.Combine(action2, value), action);
//			}
//			while (action != action2);
//		}
//		remove
//		{
//			Action action = IronSourceEvents._onInterstitialAdShowSucceededEvent;
//			Action action2;
//			do
//			{
//				action2 = action;
//				action = Interlocked.CompareExchange<Action>(ref IronSourceEvents._onInterstitialAdShowSucceededEvent, (Action)Delegate.Remove(action2, value), action);
//			}
//			while (action != action2);
//		}
//	}

//	public static event Action onInterstitialAdShowSucceededEvent
//	{
//		add
//		{
//			if (IronSourceEvents._onInterstitialAdShowSucceededEvent == null || !IronSourceEvents._onInterstitialAdShowSucceededEvent.GetInvocationList().Contains(value))
//			{
//				IronSourceEvents._onInterstitialAdShowSucceededEvent += value;
//			}
//		}
//		remove
//		{
//			if (IronSourceEvents._onInterstitialAdShowSucceededEvent.GetInvocationList().Contains(value))
//			{
//				IronSourceEvents._onInterstitialAdShowSucceededEvent -= value;
//			}
//		}
//	}

//	private static event Action<IronSourceError> _onInterstitialAdShowFailedEvent
//	{
//		add
//		{
//			Action<IronSourceError> action = IronSourceEvents._onInterstitialAdShowFailedEvent;
//			Action<IronSourceError> action2;
//			do
//			{
//				action2 = action;
//				action = Interlocked.CompareExchange<Action<IronSourceError>>(ref IronSourceEvents._onInterstitialAdShowFailedEvent, (Action<IronSourceError>)Delegate.Combine(action2, value), action);
//			}
//			while (action != action2);
//		}
//		remove
//		{
//			Action<IronSourceError> action = IronSourceEvents._onInterstitialAdShowFailedEvent;
//			Action<IronSourceError> action2;
//			do
//			{
//				action2 = action;
//				action = Interlocked.CompareExchange<Action<IronSourceError>>(ref IronSourceEvents._onInterstitialAdShowFailedEvent, (Action<IronSourceError>)Delegate.Remove(action2, value), action);
//			}
//			while (action != action2);
//		}
//	}

//	public static event Action<IronSourceError> onInterstitialAdShowFailedEvent
//	{
//		add
//		{
//			if (IronSourceEvents._onInterstitialAdShowFailedEvent == null || !IronSourceEvents._onInterstitialAdShowFailedEvent.GetInvocationList().Contains(value))
//			{
//				IronSourceEvents._onInterstitialAdShowFailedEvent += value;
//			}
//		}
//		remove
//		{
//			if (IronSourceEvents._onInterstitialAdShowFailedEvent.GetInvocationList().Contains(value))
//			{
//				IronSourceEvents._onInterstitialAdShowFailedEvent -= value;
//			}
//		}
//	}

//	private static event Action _onInterstitialAdClickedEvent
//	{
//		add
//		{
//			Action action = IronSourceEvents._onInterstitialAdClickedEvent;
//			Action action2;
//			do
//			{
//				action2 = action;
//				action = Interlocked.CompareExchange<Action>(ref IronSourceEvents._onInterstitialAdClickedEvent, (Action)Delegate.Combine(action2, value), action);
//			}
//			while (action != action2);
//		}
//		remove
//		{
//			Action action = IronSourceEvents._onInterstitialAdClickedEvent;
//			Action action2;
//			do
//			{
//				action2 = action;
//				action = Interlocked.CompareExchange<Action>(ref IronSourceEvents._onInterstitialAdClickedEvent, (Action)Delegate.Remove(action2, value), action);
//			}
//			while (action != action2);
//		}
//	}

//	public static event Action onInterstitialAdClickedEvent
//	{
//		add
//		{
//			if (IronSourceEvents._onInterstitialAdClickedEvent == null || !IronSourceEvents._onInterstitialAdClickedEvent.GetInvocationList().Contains(value))
//			{
//				IronSourceEvents._onInterstitialAdClickedEvent += value;
//			}
//		}
//		remove
//		{
//			if (IronSourceEvents._onInterstitialAdClickedEvent.GetInvocationList().Contains(value))
//			{
//				IronSourceEvents._onInterstitialAdClickedEvent -= value;
//			}
//		}
//	}

//	private static event Action _onInterstitialAdRewardedEvent
//	{
//		add
//		{
//			Action action = IronSourceEvents._onInterstitialAdRewardedEvent;
//			Action action2;
//			do
//			{
//				action2 = action;
//				action = Interlocked.CompareExchange<Action>(ref IronSourceEvents._onInterstitialAdRewardedEvent, (Action)Delegate.Combine(action2, value), action);
//			}
//			while (action != action2);
//		}
//		remove
//		{
//			Action action = IronSourceEvents._onInterstitialAdRewardedEvent;
//			Action action2;
//			do
//			{
//				action2 = action;
//				action = Interlocked.CompareExchange<Action>(ref IronSourceEvents._onInterstitialAdRewardedEvent, (Action)Delegate.Remove(action2, value), action);
//			}
//			while (action != action2);
//		}
//	}

//	public static event Action onInterstitialAdRewardedEvent
//	{
//		add
//		{
//			if (IronSourceEvents._onInterstitialAdRewardedEvent == null || !IronSourceEvents._onInterstitialAdRewardedEvent.GetInvocationList().Contains(value))
//			{
//				IronSourceEvents._onInterstitialAdRewardedEvent += value;
//			}
//		}
//		remove
//		{
//			if (IronSourceEvents._onInterstitialAdRewardedEvent.GetInvocationList().Contains(value))
//			{
//				IronSourceEvents._onInterstitialAdRewardedEvent -= value;
//			}
//		}
//	}

//	private static event Action _onOfferwallOpenedEvent
//	{
//		add
//		{
//			Action action = IronSourceEvents._onOfferwallOpenedEvent;
//			Action action2;
//			do
//			{
//				action2 = action;
//				action = Interlocked.CompareExchange<Action>(ref IronSourceEvents._onOfferwallOpenedEvent, (Action)Delegate.Combine(action2, value), action);
//			}
//			while (action != action2);
//		}
//		remove
//		{
//			Action action = IronSourceEvents._onOfferwallOpenedEvent;
//			Action action2;
//			do
//			{
//				action2 = action;
//				action = Interlocked.CompareExchange<Action>(ref IronSourceEvents._onOfferwallOpenedEvent, (Action)Delegate.Remove(action2, value), action);
//			}
//			while (action != action2);
//		}
//	}

//	public static event Action onOfferwallOpenedEvent
//	{
//		add
//		{
//			if (IronSourceEvents._onOfferwallOpenedEvent == null || !IronSourceEvents._onOfferwallOpenedEvent.GetInvocationList().Contains(value))
//			{
//				IronSourceEvents._onOfferwallOpenedEvent += value;
//			}
//		}
//		remove
//		{
//			if (IronSourceEvents._onOfferwallOpenedEvent.GetInvocationList().Contains(value))
//			{
//				IronSourceEvents._onOfferwallOpenedEvent -= value;
//			}
//		}
//	}

//	private static event Action<IronSourceError> _onOfferwallShowFailedEvent
//	{
//		add
//		{
//			Action<IronSourceError> action = IronSourceEvents._onOfferwallShowFailedEvent;
//			Action<IronSourceError> action2;
//			do
//			{
//				action2 = action;
//				action = Interlocked.CompareExchange<Action<IronSourceError>>(ref IronSourceEvents._onOfferwallShowFailedEvent, (Action<IronSourceError>)Delegate.Combine(action2, value), action);
//			}
//			while (action != action2);
//		}
//		remove
//		{
//			Action<IronSourceError> action = IronSourceEvents._onOfferwallShowFailedEvent;
//			Action<IronSourceError> action2;
//			do
//			{
//				action2 = action;
//				action = Interlocked.CompareExchange<Action<IronSourceError>>(ref IronSourceEvents._onOfferwallShowFailedEvent, (Action<IronSourceError>)Delegate.Remove(action2, value), action);
//			}
//			while (action != action2);
//		}
//	}

//	public static event Action<IronSourceError> onOfferwallShowFailedEvent
//	{
//		add
//		{
//			if (IronSourceEvents._onOfferwallShowFailedEvent == null || !IronSourceEvents._onOfferwallShowFailedEvent.GetInvocationList().Contains(value))
//			{
//				IronSourceEvents._onOfferwallShowFailedEvent += value;
//			}
//		}
//		remove
//		{
//			if (IronSourceEvents._onOfferwallShowFailedEvent.GetInvocationList().Contains(value))
//			{
//				IronSourceEvents._onOfferwallShowFailedEvent -= value;
//			}
//		}
//	}

//	private static event Action _onOfferwallClosedEvent
//	{
//		add
//		{
//			Action action = IronSourceEvents._onOfferwallClosedEvent;
//			Action action2;
//			do
//			{
//				action2 = action;
//				action = Interlocked.CompareExchange<Action>(ref IronSourceEvents._onOfferwallClosedEvent, (Action)Delegate.Combine(action2, value), action);
//			}
//			while (action != action2);
//		}
//		remove
//		{
//			Action action = IronSourceEvents._onOfferwallClosedEvent;
//			Action action2;
//			do
//			{
//				action2 = action;
//				action = Interlocked.CompareExchange<Action>(ref IronSourceEvents._onOfferwallClosedEvent, (Action)Delegate.Remove(action2, value), action);
//			}
//			while (action != action2);
//		}
//	}

//	public static event Action onOfferwallClosedEvent
//	{
//		add
//		{
//			if (IronSourceEvents._onOfferwallClosedEvent == null || !IronSourceEvents._onOfferwallClosedEvent.GetInvocationList().Contains(value))
//			{
//				IronSourceEvents._onOfferwallClosedEvent += value;
//			}
//		}
//		remove
//		{
//			if (IronSourceEvents._onOfferwallClosedEvent.GetInvocationList().Contains(value))
//			{
//				IronSourceEvents._onOfferwallClosedEvent -= value;
//			}
//		}
//	}

//	private static event Action<IronSourceError> _onGetOfferwallCreditsFailedEvent
//	{
//		add
//		{
//			Action<IronSourceError> action = IronSourceEvents._onGetOfferwallCreditsFailedEvent;
//			Action<IronSourceError> action2;
//			do
//			{
//				action2 = action;
//				action = Interlocked.CompareExchange<Action<IronSourceError>>(ref IronSourceEvents._onGetOfferwallCreditsFailedEvent, (Action<IronSourceError>)Delegate.Combine(action2, value), action);
//			}
//			while (action != action2);
//		}
//		remove
//		{
//			Action<IronSourceError> action = IronSourceEvents._onGetOfferwallCreditsFailedEvent;
//			Action<IronSourceError> action2;
//			do
//			{
//				action2 = action;
//				action = Interlocked.CompareExchange<Action<IronSourceError>>(ref IronSourceEvents._onGetOfferwallCreditsFailedEvent, (Action<IronSourceError>)Delegate.Remove(action2, value), action);
//			}
//			while (action != action2);
//		}
//	}

//	public static event Action<IronSourceError> onGetOfferwallCreditsFailedEvent
//	{
//		add
//		{
//			if (IronSourceEvents._onGetOfferwallCreditsFailedEvent == null || !IronSourceEvents._onGetOfferwallCreditsFailedEvent.GetInvocationList().Contains(value))
//			{
//				IronSourceEvents._onGetOfferwallCreditsFailedEvent += value;
//			}
//		}
//		remove
//		{
//			if (IronSourceEvents._onGetOfferwallCreditsFailedEvent.GetInvocationList().Contains(value))
//			{
//				IronSourceEvents._onGetOfferwallCreditsFailedEvent -= value;
//			}
//		}
//	}

//	private static event Action<Dictionary<string, object>> _onOfferwallAdCreditedEvent
//	{
//		add
//		{
//			Action<Dictionary<string, object>> action = IronSourceEvents._onOfferwallAdCreditedEvent;
//			Action<Dictionary<string, object>> action2;
//			do
//			{
//				action2 = action;
//				action = Interlocked.CompareExchange<Action<Dictionary<string, object>>>(ref IronSourceEvents._onOfferwallAdCreditedEvent, (Action<Dictionary<string, object>>)Delegate.Combine(action2, value), action);
//			}
//			while (action != action2);
//		}
//		remove
//		{
//			Action<Dictionary<string, object>> action = IronSourceEvents._onOfferwallAdCreditedEvent;
//			Action<Dictionary<string, object>> action2;
//			do
//			{
//				action2 = action;
//				action = Interlocked.CompareExchange<Action<Dictionary<string, object>>>(ref IronSourceEvents._onOfferwallAdCreditedEvent, (Action<Dictionary<string, object>>)Delegate.Remove(action2, value), action);
//			}
//			while (action != action2);
//		}
//	}

//	public static event Action<Dictionary<string, object>> onOfferwallAdCreditedEvent
//	{
//		add
//		{
//			if (IronSourceEvents._onOfferwallAdCreditedEvent == null || !IronSourceEvents._onOfferwallAdCreditedEvent.GetInvocationList().Contains(value))
//			{
//				IronSourceEvents._onOfferwallAdCreditedEvent += value;
//			}
//		}
//		remove
//		{
//			if (IronSourceEvents._onOfferwallAdCreditedEvent.GetInvocationList().Contains(value))
//			{
//				IronSourceEvents._onOfferwallAdCreditedEvent -= value;
//			}
//		}
//	}

//	private static event Action<bool> _onOfferwallAvailableEvent
//	{
//		add
//		{
//			Action<bool> action = IronSourceEvents._onOfferwallAvailableEvent;
//			Action<bool> action2;
//			do
//			{
//				action2 = action;
//				action = Interlocked.CompareExchange<Action<bool>>(ref IronSourceEvents._onOfferwallAvailableEvent, (Action<bool>)Delegate.Combine(action2, value), action);
//			}
//			while (action != action2);
//		}
//		remove
//		{
//			Action<bool> action = IronSourceEvents._onOfferwallAvailableEvent;
//			Action<bool> action2;
//			do
//			{
//				action2 = action;
//				action = Interlocked.CompareExchange<Action<bool>>(ref IronSourceEvents._onOfferwallAvailableEvent, (Action<bool>)Delegate.Remove(action2, value), action);
//			}
//			while (action != action2);
//		}
//	}

//	public static event Action<bool> onOfferwallAvailableEvent
//	{
//		add
//		{
//			if (IronSourceEvents._onOfferwallAvailableEvent == null || !IronSourceEvents._onOfferwallAvailableEvent.GetInvocationList().Contains(value))
//			{
//				IronSourceEvents._onOfferwallAvailableEvent += value;
//			}
//		}
//		remove
//		{
//			if (IronSourceEvents._onOfferwallAvailableEvent.GetInvocationList().Contains(value))
//			{
//				IronSourceEvents._onOfferwallAvailableEvent -= value;
//			}
//		}
//	}

//	private static event Action _onBannerAdLoadedEvent
//	{
//		add
//		{
//			Action action = IronSourceEvents._onBannerAdLoadedEvent;
//			Action action2;
//			do
//			{
//				action2 = action;
//				action = Interlocked.CompareExchange<Action>(ref IronSourceEvents._onBannerAdLoadedEvent, (Action)Delegate.Combine(action2, value), action);
//			}
//			while (action != action2);
//		}
//		remove
//		{
//			Action action = IronSourceEvents._onBannerAdLoadedEvent;
//			Action action2;
//			do
//			{
//				action2 = action;
//				action = Interlocked.CompareExchange<Action>(ref IronSourceEvents._onBannerAdLoadedEvent, (Action)Delegate.Remove(action2, value), action);
//			}
//			while (action != action2);
//		}
//	}

//	public static event Action onBannerAdLoadedEvent
//	{
//		add
//		{
//			if (IronSourceEvents._onBannerAdLoadedEvent == null || !IronSourceEvents._onBannerAdLoadedEvent.GetInvocationList().Contains(value))
//			{
//				IronSourceEvents._onBannerAdLoadedEvent += value;
//			}
//		}
//		remove
//		{
//			if (IronSourceEvents._onBannerAdLoadedEvent.GetInvocationList().Contains(value))
//			{
//				IronSourceEvents._onBannerAdLoadedEvent -= value;
//			}
//		}
//	}

//	private static event Action<IronSourceError> _onBannerAdLoadFailedEvent
//	{
//		add
//		{
//			Action<IronSourceError> action = IronSourceEvents._onBannerAdLoadFailedEvent;
//			Action<IronSourceError> action2;
//			do
//			{
//				action2 = action;
//				action = Interlocked.CompareExchange<Action<IronSourceError>>(ref IronSourceEvents._onBannerAdLoadFailedEvent, (Action<IronSourceError>)Delegate.Combine(action2, value), action);
//			}
//			while (action != action2);
//		}
//		remove
//		{
//			Action<IronSourceError> action = IronSourceEvents._onBannerAdLoadFailedEvent;
//			Action<IronSourceError> action2;
//			do
//			{
//				action2 = action;
//				action = Interlocked.CompareExchange<Action<IronSourceError>>(ref IronSourceEvents._onBannerAdLoadFailedEvent, (Action<IronSourceError>)Delegate.Remove(action2, value), action);
//			}
//			while (action != action2);
//		}
//	}

//	public static event Action<IronSourceError> onBannerAdLoadFailedEvent
//	{
//		add
//		{
//			if (IronSourceEvents._onBannerAdLoadFailedEvent == null || !IronSourceEvents._onBannerAdLoadFailedEvent.GetInvocationList().Contains(value))
//			{
//				IronSourceEvents._onBannerAdLoadFailedEvent += value;
//			}
//		}
//		remove
//		{
//			if (IronSourceEvents._onBannerAdLoadFailedEvent.GetInvocationList().Contains(value))
//			{
//				IronSourceEvents._onBannerAdLoadFailedEvent -= value;
//			}
//		}
//	}

//	private static event Action _onBannerAdClickedEvent
//	{
//		add
//		{
//			Action action = IronSourceEvents._onBannerAdClickedEvent;
//			Action action2;
//			do
//			{
//				action2 = action;
//				action = Interlocked.CompareExchange<Action>(ref IronSourceEvents._onBannerAdClickedEvent, (Action)Delegate.Combine(action2, value), action);
//			}
//			while (action != action2);
//		}
//		remove
//		{
//			Action action = IronSourceEvents._onBannerAdClickedEvent;
//			Action action2;
//			do
//			{
//				action2 = action;
//				action = Interlocked.CompareExchange<Action>(ref IronSourceEvents._onBannerAdClickedEvent, (Action)Delegate.Remove(action2, value), action);
//			}
//			while (action != action2);
//		}
//	}

//	public static event Action onBannerAdClickedEvent
//	{
//		add
//		{
//			if (IronSourceEvents._onBannerAdClickedEvent == null || !IronSourceEvents._onBannerAdClickedEvent.GetInvocationList().Contains(value))
//			{
//				IronSourceEvents._onBannerAdClickedEvent += value;
//			}
//		}
//		remove
//		{
//			if (IronSourceEvents._onBannerAdClickedEvent.GetInvocationList().Contains(value))
//			{
//				IronSourceEvents._onBannerAdClickedEvent -= value;
//			}
//		}
//	}

//	private static event Action _onBannerAdScreenPresentedEvent
//	{
//		add
//		{
//			Action action = IronSourceEvents._onBannerAdScreenPresentedEvent;
//			Action action2;
//			do
//			{
//				action2 = action;
//				action = Interlocked.CompareExchange<Action>(ref IronSourceEvents._onBannerAdScreenPresentedEvent, (Action)Delegate.Combine(action2, value), action);
//			}
//			while (action != action2);
//		}
//		remove
//		{
//			Action action = IronSourceEvents._onBannerAdScreenPresentedEvent;
//			Action action2;
//			do
//			{
//				action2 = action;
//				action = Interlocked.CompareExchange<Action>(ref IronSourceEvents._onBannerAdScreenPresentedEvent, (Action)Delegate.Remove(action2, value), action);
//			}
//			while (action != action2);
//		}
//	}

//	public static event Action onBannerAdScreenPresentedEvent
//	{
//		add
//		{
//			if (IronSourceEvents._onBannerAdScreenPresentedEvent == null || !IronSourceEvents._onBannerAdScreenPresentedEvent.GetInvocationList().Contains(value))
//			{
//				IronSourceEvents._onBannerAdScreenPresentedEvent += value;
//			}
//		}
//		remove
//		{
//			if (IronSourceEvents._onBannerAdScreenPresentedEvent.GetInvocationList().Contains(value))
//			{
//				IronSourceEvents._onBannerAdScreenPresentedEvent -= value;
//			}
//		}
//	}

//	private static event Action _onBannerAdScreenDismissedEvent
//	{
//		add
//		{
//			Action action = IronSourceEvents._onBannerAdScreenDismissedEvent;
//			Action action2;
//			do
//			{
//				action2 = action;
//				action = Interlocked.CompareExchange<Action>(ref IronSourceEvents._onBannerAdScreenDismissedEvent, (Action)Delegate.Combine(action2, value), action);
//			}
//			while (action != action2);
//		}
//		remove
//		{
//			Action action = IronSourceEvents._onBannerAdScreenDismissedEvent;
//			Action action2;
//			do
//			{
//				action2 = action;
//				action = Interlocked.CompareExchange<Action>(ref IronSourceEvents._onBannerAdScreenDismissedEvent, (Action)Delegate.Remove(action2, value), action);
//			}
//			while (action != action2);
//		}
//	}

//	public static event Action onBannerAdScreenDismissedEvent
//	{
//		add
//		{
//			if (IronSourceEvents._onBannerAdScreenDismissedEvent == null || !IronSourceEvents._onBannerAdScreenDismissedEvent.GetInvocationList().Contains(value))
//			{
//				IronSourceEvents._onBannerAdScreenDismissedEvent += value;
//			}
//		}
//		remove
//		{
//			if (IronSourceEvents._onBannerAdScreenDismissedEvent.GetInvocationList().Contains(value))
//			{
//				IronSourceEvents._onBannerAdScreenDismissedEvent -= value;
//			}
//		}
//	}

//	private static event Action _onBannerAdLeftApplicationEvent
//	{
//		add
//		{
//			Action action = IronSourceEvents._onBannerAdLeftApplicationEvent;
//			Action action2;
//			do
//			{
//				action2 = action;
//				action = Interlocked.CompareExchange<Action>(ref IronSourceEvents._onBannerAdLeftApplicationEvent, (Action)Delegate.Combine(action2, value), action);
//			}
//			while (action != action2);
//		}
//		remove
//		{
//			Action action = IronSourceEvents._onBannerAdLeftApplicationEvent;
//			Action action2;
//			do
//			{
//				action2 = action;
//				action = Interlocked.CompareExchange<Action>(ref IronSourceEvents._onBannerAdLeftApplicationEvent, (Action)Delegate.Remove(action2, value), action);
//			}
//			while (action != action2);
//		}
//	}

//	public static event Action onBannerAdLeftApplicationEvent
//	{
//		add
//		{
//			if (IronSourceEvents._onBannerAdLeftApplicationEvent == null || !IronSourceEvents._onBannerAdLeftApplicationEvent.GetInvocationList().Contains(value))
//			{
//				IronSourceEvents._onBannerAdLeftApplicationEvent += value;
//			}
//		}
//		remove
//		{
//			if (IronSourceEvents._onBannerAdLeftApplicationEvent.GetInvocationList().Contains(value))
//			{
//				IronSourceEvents._onBannerAdLeftApplicationEvent -= value;
//			}
//		}
//	}

//	private static event Action<string> _onSegmentReceivedEvent
//	{
//		add
//		{
//			Action<string> action = IronSourceEvents._onSegmentReceivedEvent;
//			Action<string> action2;
//			do
//			{
//				action2 = action;
//				action = Interlocked.CompareExchange<Action<string>>(ref IronSourceEvents._onSegmentReceivedEvent, (Action<string>)Delegate.Combine(action2, value), action);
//			}
//			while (action != action2);
//		}
//		remove
//		{
//			Action<string> action = IronSourceEvents._onSegmentReceivedEvent;
//			Action<string> action2;
//			do
//			{
//				action2 = action;
//				action = Interlocked.CompareExchange<Action<string>>(ref IronSourceEvents._onSegmentReceivedEvent, (Action<string>)Delegate.Remove(action2, value), action);
//			}
//			while (action != action2);
//		}
//	}

//	public static event Action<string> onSegmentReceivedEvent
//	{
//		add
//		{
//			if (IronSourceEvents._onSegmentReceivedEvent == null || !IronSourceEvents._onSegmentReceivedEvent.GetInvocationList().Contains(value))
//			{
//				IronSourceEvents._onSegmentReceivedEvent += value;
//			}
//		}
//		remove
//		{
//			if (IronSourceEvents._onSegmentReceivedEvent.GetInvocationList().Contains(value))
//			{
//				IronSourceEvents._onSegmentReceivedEvent -= value;
//			}
//		}
//	}

//	private void Awake()
//	{
//		base.gameObject.name = "IronSourceEvents";
//		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
//	}

//	public void onRewardedVideoAdShowFailed(string description)
//	{
//		if (IronSourceEvents._onRewardedVideoAdShowFailedEvent != null)
//		{
//			IronSourceError errorFromErrorString = this.getErrorFromErrorString(description);
//			IronSourceEvents._onRewardedVideoAdShowFailedEvent(errorFromErrorString);
//		}
//	}

//	public void onRewardedVideoAdOpened(string empty)
//	{
//		if (IronSourceEvents._onRewardedVideoAdOpenedEvent != null)
//		{
//			IronSourceEvents._onRewardedVideoAdOpenedEvent();
//		}
//	}

//	public void onRewardedVideoAdClosed(string empty)
//	{
//		if (IronSourceEvents._onRewardedVideoAdClosedEvent != null)
//		{
//			IronSourceEvents._onRewardedVideoAdClosedEvent();
//		}
//	}

//	public void onRewardedVideoAdStarted(string empty)
//	{
//		if (IronSourceEvents._onRewardedVideoAdStartedEvent != null)
//		{
//			IronSourceEvents._onRewardedVideoAdStartedEvent();
//		}
//	}

//	public void onRewardedVideoAdEnded(string empty)
//	{
//		if (IronSourceEvents._onRewardedVideoAdEndedEvent != null)
//		{
//			IronSourceEvents._onRewardedVideoAdEndedEvent();
//		}
//	}

//	public void onRewardedVideoAdRewarded(string description)
//	{
//		if (IronSourceEvents._onRewardedVideoAdRewardedEvent != null)
//		{
//			IronSourcePlacement placementFromString = this.getPlacementFromString(description);
//			IronSourceEvents._onRewardedVideoAdRewardedEvent(placementFromString);
//		}
//	}

//	public void onRewardedVideoAdClicked(string description)
//	{
//		if (IronSourceEvents._onRewardedVideoAdClickedEvent != null)
//		{
//			IronSourcePlacement placementFromString = this.getPlacementFromString(description);
//			IronSourceEvents._onRewardedVideoAdClickedEvent(placementFromString);
//		}
//	}

//	public void onRewardedVideoAvailabilityChanged(string stringAvailable)
//	{
//		bool obj = stringAvailable == "true";
//		if (IronSourceEvents._onRewardedVideoAvailabilityChangedEvent != null)
//		{
//			IronSourceEvents._onRewardedVideoAvailabilityChangedEvent(obj);
//		}
//	}

//	public void onInterstitialAdReady()
//	{
//		if (IronSourceEvents._onInterstitialAdReadyEvent != null)
//		{
//			IronSourceEvents._onInterstitialAdReadyEvent();
//		}
//	}

//	public void onInterstitialAdLoadFailed(string description)
//	{
//		if (IronSourceEvents._onInterstitialAdLoadFailedEvent != null)
//		{
//			IronSourceError errorFromErrorString = this.getErrorFromErrorString(description);
//			IronSourceEvents._onInterstitialAdLoadFailedEvent(errorFromErrorString);
//		}
//	}

//	public void onInterstitialAdOpened(string empty)
//	{
//		if (IronSourceEvents._onInterstitialAdOpenedEvent != null)
//		{
//			IronSourceEvents._onInterstitialAdOpenedEvent();
//		}
//	}

//	public void onInterstitialAdClosed(string empty)
//	{
//		if (IronSourceEvents._onInterstitialAdClosedEvent != null)
//		{
//			IronSourceEvents._onInterstitialAdClosedEvent();
//		}
//	}

//	public void onInterstitialAdShowSucceeded(string empty)
//	{
//		if (IronSourceEvents._onInterstitialAdShowSucceededEvent != null)
//		{
//			IronSourceEvents._onInterstitialAdShowSucceededEvent();
//		}
//	}

//	public void onInterstitialAdShowFailed(string description)
//	{
//		if (IronSourceEvents._onInterstitialAdShowFailedEvent != null)
//		{
//			IronSourceError errorFromErrorString = this.getErrorFromErrorString(description);
//			IronSourceEvents._onInterstitialAdShowFailedEvent(errorFromErrorString);
//		}
//	}

//	public void onInterstitialAdClicked(string empty)
//	{
//		if (IronSourceEvents._onInterstitialAdClickedEvent != null)
//		{
//			IronSourceEvents._onInterstitialAdClickedEvent();
//		}
//	}

//	public void onInterstitialAdRewarded(string empty)
//	{
//		if (IronSourceEvents._onInterstitialAdRewardedEvent != null)
//		{
//			IronSourceEvents._onInterstitialAdRewardedEvent();
//		}
//	}

//	public void onOfferwallOpened(string empty)
//	{
//		if (IronSourceEvents._onOfferwallOpenedEvent != null)
//		{
//			IronSourceEvents._onOfferwallOpenedEvent();
//		}
//	}

//	public void onOfferwallShowFailed(string description)
//	{
//		if (IronSourceEvents._onOfferwallShowFailedEvent != null)
//		{
//			IronSourceError errorFromErrorString = this.getErrorFromErrorString(description);
//			IronSourceEvents._onOfferwallShowFailedEvent(errorFromErrorString);
//		}
//	}

//	public void onOfferwallClosed(string empty)
//	{
//		if (IronSourceEvents._onOfferwallClosedEvent != null)
//		{
//			IronSourceEvents._onOfferwallClosedEvent();
//		}
//	}

//	public void onGetOfferwallCreditsFailed(string description)
//	{
//		if (IronSourceEvents._onGetOfferwallCreditsFailedEvent != null)
//		{
//			IronSourceError errorFromErrorString = this.getErrorFromErrorString(description);
//			IronSourceEvents._onGetOfferwallCreditsFailedEvent(errorFromErrorString);
//		}
//	}

//	public void onOfferwallAdCredited(string json)
//	{
//		if (IronSourceEvents._onOfferwallAdCreditedEvent != null)
//		{
//			IronSourceEvents._onOfferwallAdCreditedEvent(Json.Deserialize(json) as Dictionary<string, object>);
//		}
//	}

//	public void onOfferwallAvailable(string stringAvailable)
//	{
//		bool obj = stringAvailable == "true";
//		if (IronSourceEvents._onOfferwallAvailableEvent != null)
//		{
//			IronSourceEvents._onOfferwallAvailableEvent(obj);
//		}
//	}

//	public void onBannerAdLoaded()
//	{
//		if (IronSourceEvents._onBannerAdLoadedEvent != null)
//		{
//			IronSourceEvents._onBannerAdLoadedEvent();
//		}
//	}

//	public void onBannerAdLoadFailed(string description)
//	{
//		if (IronSourceEvents._onBannerAdLoadFailedEvent != null)
//		{
//			IronSourceError errorFromErrorString = this.getErrorFromErrorString(description);
//			IronSourceEvents._onBannerAdLoadFailedEvent(errorFromErrorString);
//		}
//	}

//	public void onBannerAdClicked()
//	{
//		if (IronSourceEvents._onBannerAdClickedEvent != null)
//		{
//			IronSourceEvents._onBannerAdClickedEvent();
//		}
//	}

//	public void onBannerAdScreenPresented()
//	{
//		if (IronSourceEvents._onBannerAdScreenPresentedEvent != null)
//		{
//			IronSourceEvents._onBannerAdScreenPresentedEvent();
//		}
//	}

//	public void onBannerAdScreenDismissed()
//	{
//		if (IronSourceEvents._onBannerAdScreenDismissedEvent != null)
//		{
//			IronSourceEvents._onBannerAdScreenDismissedEvent();
//		}
//	}

//	public void onBannerAdLeftApplication()
//	{
//		if (IronSourceEvents._onBannerAdLeftApplicationEvent != null)
//		{
//			IronSourceEvents._onBannerAdLeftApplicationEvent();
//		}
//	}

//	public void onSegmentReceived(string segmentName)
//	{
//		if (IronSourceEvents._onSegmentReceivedEvent != null)
//		{
//			IronSourceEvents._onSegmentReceivedEvent(segmentName);
//		}
//	}

//	public IronSourceError getErrorFromErrorString(string description)
//	{
//		IronSourceError result;
//		if (!string.IsNullOrEmpty(description))
//		{
//			Dictionary<string, object> dictionary = Json.Deserialize(description) as Dictionary<string, object>;
//			if (dictionary != null)
//			{
//				int errorCode = Convert.ToInt32(dictionary["error_code"].ToString());
//				string errorDescription = dictionary["error_description"].ToString();
//				result = new IronSourceError(errorCode, errorDescription);
//			}
//			else
//			{
//				result = new IronSourceError(-1, string.Empty);
//			}
//		}
//		else
//		{
//			result = new IronSourceError(-1, string.Empty);
//		}
//		return result;
//	}

//	public IronSourcePlacement getPlacementFromString(string jsonPlacement)
//	{
//		Dictionary<string, object> dictionary = Json.Deserialize(jsonPlacement) as Dictionary<string, object>;
//		int rewardAmount = Convert.ToInt32(dictionary["placement_reward_amount"].ToString());
//		string rewardName = dictionary["placement_reward_name"].ToString();
//		string placementName = dictionary["placement_name"].ToString();
//		return new IronSourcePlacement(placementName, rewardName, rewardAmount);
//	}
//}
