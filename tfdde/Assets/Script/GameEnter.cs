using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AppAdvisory.BallX;
public class GameEnter : MonoBehaviour {
	public GameManager game;
	private string sceneid = "";

	public void Awake()
	{
		GameManager.Gonext = 1;
	}
	public void OnGUI()
	{
		//用户名  
		//GUI.Label(new Rect(20, 20, 50, 50), "关卡");
		//sceneid = GUI.TextField(new Rect(80, 20, 100, 50), sceneid, 15);//15为最大字符串长度  
		GUILayout.BeginHorizontal();
		GUILayout.EndHorizontal();
		if (GUI.Button(new Rect(0, 100, 200, 50), "开始"))
		{
			game.OnPlayButtonClicked();
		}
		if (GUI.Button(new Rect(0, 300, 200, 50), "effect"))
		{
			GameManager.ContinuaReward = 1;
		}
		
	}
}
