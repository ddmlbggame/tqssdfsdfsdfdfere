using System;
using UnityEngine;

namespace AppAdvisory.BallX
{
	public class Resolution : MonoBehaviour
	{
		public void Update()
		{
			float num = (float)Screen.height / Screen.dpi;
			if ((double)num < 3.1)
			{
				Debug.Log("phone");
			}
		}
	}
}
