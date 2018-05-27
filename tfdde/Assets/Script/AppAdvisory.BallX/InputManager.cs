using System;
using System.Threading;
using UnityEngine;

namespace AppAdvisory.BallX
{
	public class InputManager : MonoBehaviour
	{
		private Vector3 startPosition;

		public static event Action<Vector3> OnSwipeStarted;

		public static event Action<Vector3> OnSwipe;
		public static event Action<Vector3> OnSwipeEnded;
		private void Update()
		{
			if (Input.GetMouseButtonDown(0) && GameManager.Gonext == 1)
			{
				this.startPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
				if (InputManager.OnSwipeStarted != null)
				{
					InputManager.OnSwipeStarted(this.startPosition);
				}
			}
			else if (Input.GetMouseButton(0) && GameManager.Gonext == 1)
			{
				Vector3 b = Camera.main.ScreenToWorldPoint(Input.mousePosition);
				Vector3 obj = this.startPosition - b;
				if (InputManager.OnSwipe != null)
				{
					InputManager.OnSwipe(obj);
				}
			}
			else if (Input.GetMouseButtonUp(0) && GameManager.Gonext == 1)
			{
				Vector3 b2 = Camera.main.ScreenToWorldPoint(Input.mousePosition);
				Vector3 obj2 = this.startPosition - b2;
				if (InputManager.OnSwipeEnded != null)
				{
					InputManager.OnSwipeEnded(obj2);
				}
			}
		}
	}
}
