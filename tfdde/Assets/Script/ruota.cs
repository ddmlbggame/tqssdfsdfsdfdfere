using System;
using UnityEngine;

public class ruota : MonoBehaviour
{
	public int speed;

	private void Start()
	{
	}

	private void Update()
	{
		base.transform.Rotate(Vector3.up * (float)this.speed * Time.deltaTime);
	}
}
