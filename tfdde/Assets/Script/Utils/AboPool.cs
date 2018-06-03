/// 这是一个简单的对象池. 
/// 是为了解决UI中的对象复用问题
/// Abo, 2016.04.20

using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

namespace SimplePool
{
	public class Pool<T> where T : class, IAboPool<T>, new()
	{
		public Pool()
		{
			m_Objects = new List<T>();
			m_UnusedObjects = new Stack<T>();
		}

		protected List<T> m_Objects;
		protected Stack<T> m_UnusedObjects;
		public List<T> Objects
		{
			get
			{
				return m_Objects;
			}
		}
		public T GetObject()
		{
			T obj;
			if (m_UnusedObjects.Count > 0)
			{
				obj = m_UnusedObjects.Pop();
				obj.OnRecycle();
			}
			else
			{
				obj = new T();
				obj = obj.Create();
				obj.Init();
			}
			m_Objects.Add(obj);
			return obj;
		}

		public void DeleteObject(T obj)
		{
			if (m_Objects.Contains(obj))
			{
				m_Objects.Remove(obj);
				m_UnusedObjects.Push(obj);
				obj.OnDelete();
			}
		}
		/// <summary>
		/// 清空所有对象
		/// </summary>
		/// <param name="isClearAll">true清除所有,false回收所有</param>
		public void ClearUp(bool isClearAll = false)
		{
			if (isClearAll)
			{
				for (int i = m_Objects.Count - 1; i >= 0; i--)
				{
					m_Objects[i].OnDelete();
				}
				m_Objects.Clear();
				m_UnusedObjects.Clear();
			}
			else
			{
				for (int i = m_Objects.Count - 1; i >= 0; i--)
				{
					DeleteObject(m_Objects[i]);
				}
			}
		}

	}

	public interface IAboPool<T>
	{
		bool Init();
		void OnRecycle();
		void OnDelete();
		T Create();
	}

}
