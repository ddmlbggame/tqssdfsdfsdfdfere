using System;
using UnityEngine;

public class AspectAdjuster : MonoBehaviour
{
	public Camera cam;

	public float aspect;

	private void Start()
	{
		this.aspect = this.cam.aspect;
		int pixelHeight = this.cam.pixelHeight;
		int pixelWidth = this.cam.pixelWidth;
		Debug.Log(string.Concat(new object[]
		{
			"Width: ",
			pixelWidth,
			"  Height: ",
			pixelHeight,
			"  Aspect: ",
			this.aspect
		}));
		base.transform.localScale = new Vector3(this.aspect * base.transform.localScale.z, base.transform.localScale.y, base.transform.localScale.z);
	}

	private void Update()
	{
	}
}
