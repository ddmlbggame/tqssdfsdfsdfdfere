//using System;
//using UnityEngine;

//public class IronSourc : MonoBehaviour
//{
//	public int Pausa;

//	private void Start()
//	{
//		IronSource.Agent.init("69eabf75");
//		IronSource.Agent.validateIntegration();
//	}

//	private void OnApplicationPause(bool isPaused)
//	{
//		IronSource.Agent.onApplicationPause(isPaused);
//		this.Pausa = 1;
//	}

//	private void Update()
//	{
//		if (Input.GetKeyDown(KeyCode.Escape) && this.Pausa != 1)
//		{
//			this.OnApplicationPause(true);
//			Time.timeScale = 0f;
//		}
//		else if (Input.GetKeyDown(KeyCode.Escape) && this.Pausa == 1)
//		{
//			this.OnApplicationPause(false);
//			Time.timeScale = 1f;
//			this.Pausa = 0;
//		}
//	}
//}
