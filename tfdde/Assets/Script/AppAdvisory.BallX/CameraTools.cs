using System;
using UnityEngine;

namespace AppAdvisory.BallX
{
	public static class CameraTools
	{
		public static Rect GetScreenRect()
		{
			Camera main = Camera.main;
			float height = 2f * main.orthographicSize;
			float with = height * main.aspect;
			return new Rect(main.transform.position.x - with / 2f, main.transform.position.y - height / 2f, with, height);
		}
	}
}
