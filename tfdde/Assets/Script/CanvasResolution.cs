using System;
using UnityEngine;

public class CanvasResolution : MonoBehaviour
{
	private void Awake()
	{
		if ((double)Camera.main.aspect < 1.7)
		{
			if ((double)Camera.main.aspect <= 1.6)
			{
				if ((double)Camera.main.aspect != 1.6)
				{
					if ((double)Camera.main.aspect >= 1.5)
					{
					}
				}
			}
		}
	}
}
