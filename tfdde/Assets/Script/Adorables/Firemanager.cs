using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Adorables.Ball
{
	public class Firemanager : MonoBehaviour
	{
		//[CompilerGenerated]
		//private sealed class <WaitFu>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		//{
		//	internal Firemanager $this;

		//	internal object $current;

		//	internal bool $disposing;

		//	internal int $PC;

		//	object IEnumerator<object>.Current
		//	{
		//		[DebuggerHidden]
		//		get
		//		{
		//			return this.$current;
		//		}
		//	}

		//	object IEnumerator.Current
		//	{
		//		[DebuggerHidden]
		//		get
		//		{
		//			return this.$current;
		//		}
		//	}

		//	[DebuggerHidden]
		//	public <WaitFu>c__Iterator0()
		//	{
		//	}

		//	public bool MoveNext()
		//	{
		//		uint num = (uint)this.$PC;
		//		this.$PC = -1;
		//		switch (num)
		//		{
		//		case 0u:
		//			this.$current = new WaitForSeconds(0.2f);
		//			if (!this.$disposing)
		//			{
		//				this.$PC = 1;
		//			}
		//			return true;
		//		case 1u:
		//			this.$this.Fumo.SetActive(true);
		//			this.$this.Fumo.GetComponent<ParticleSystem>().Play();
		//			this.$PC = -1;
		//			break;
		//		}
		//		return false;
		//	}

		//	[DebuggerHidden]
		//	public void Dispose()
		//	{
		//		this.$disposing = true;
		//		this.$PC = -1;
		//	}

		//	[DebuggerHidden]
		//	public void Reset()
		//	{
		//		throw new NotSupportedException();
		//	}
		//}

		//[CompilerGenerated]
		//private sealed class <WaitF>c__Iterator1 : IEnumerator, IDisposable, IEnumerator<object>
		//{
		//	internal Firemanager $this;

		//	internal object $current;

		//	internal bool $disposing;

		//	internal int $PC;

		//	object IEnumerator<object>.Current
		//	{
		//		[DebuggerHidden]
		//		get
		//		{
		//			return this.$current;
		//		}
		//	}

		//	object IEnumerator.Current
		//	{
		//		[DebuggerHidden]
		//		get
		//		{
		//			return this.$current;
		//		}
		//	}

		//	[DebuggerHidden]
		//	public <WaitF>c__Iterator1()
		//	{
		//	}

		//	public bool MoveNext()
		//	{
		//		uint num = (uint)this.$PC;
		//		this.$PC = -1;
		//		switch (num)
		//		{
		//		case 0u:
		//			this.$current = new WaitForSeconds(0.2f);
		//			if (!this.$disposing)
		//			{
		//				this.$PC = 1;
		//			}
		//			return true;
		//		case 1u:
		//			this.$this.Fumo.GetComponent<ParticleSystem>().Stop();
		//			this.$this.Fumo.SetActive(false);
		//			this.$this.Fire.SetActive(true);
		//			this.$this.Fire.GetComponent<ParticleSystem>().Play();
		//			this.$PC = -1;
		//			break;
		//		}
		//		return false;
		//	}

		//	[DebuggerHidden]
		//	public void Dispose()
		//	{
		//		this.$disposing = true;
		//		this.$PC = -1;
		//	}

		//	[DebuggerHidden]
		//	public void Reset()
		//	{
		//		throw new NotSupportedException();
		//	}
		//}

		//[CompilerGenerated]
		//private sealed class <Waitp2>c__Iterator2 : IEnumerator, IDisposable, IEnumerator<object>
		//{
		//	internal Firemanager $this;

		//	internal object $current;

		//	internal bool $disposing;

		//	internal int $PC;

		//	object IEnumerator<object>.Current
		//	{
		//		[DebuggerHidden]
		//		get
		//		{
		//			return this.$current;
		//		}
		//	}

		//	object IEnumerator.Current
		//	{
		//		[DebuggerHidden]
		//		get
		//		{
		//			return this.$current;
		//		}
		//	}

		//	[DebuggerHidden]
		//	public <Waitp2>c__Iterator2()
		//	{
		//	}

		//	public bool MoveNext()
		//	{
		//		uint num = (uint)this.$PC;
		//		this.$PC = -1;
		//		switch (num)
		//		{
		//		case 0u:
		//			this.$current = new WaitForSeconds(0.2f);
		//			if (!this.$disposing)
		//			{
		//				this.$PC = 1;
		//			}
		//			return true;
		//		case 1u:
		//			this.$this.Fumo.GetComponent<ParticleSystem>().Stop();
		//			this.$this.Fumo.SetActive(false);
		//			this.$this.P2.SetActive(true);
		//			this.$this.P2.GetComponent<ParticleSystem>().Play();
		//			this.$PC = -1;
		//			break;
		//		}
		//		return false;
		//	}

		//	[DebuggerHidden]
		//	public void Dispose()
		//	{
		//		this.$disposing = true;
		//		this.$PC = -1;
		//	}

		//	[DebuggerHidden]
		//	public void Reset()
		//	{
		//		throw new NotSupportedException();
		//	}
		//}

		//[CompilerGenerated]
		//private sealed class <Waitp3>c__Iterator3 : IEnumerator, IDisposable, IEnumerator<object>
		//{
		//	internal Firemanager $this;

		//	internal object $current;

		//	internal bool $disposing;

		//	internal int $PC;

		//	object IEnumerator<object>.Current
		//	{
		//		[DebuggerHidden]
		//		get
		//		{
		//			return this.$current;
		//		}
		//	}

		//	object IEnumerator.Current
		//	{
		//		[DebuggerHidden]
		//		get
		//		{
		//			return this.$current;
		//		}
		//	}

		//	[DebuggerHidden]
		//	public <Waitp3>c__Iterator3()
		//	{
		//	}

		//	public bool MoveNext()
		//	{
		//		uint num = (uint)this.$PC;
		//		this.$PC = -1;
		//		switch (num)
		//		{
		//		case 0u:
		//			this.$current = new WaitForSeconds(0.2f);
		//			if (!this.$disposing)
		//			{
		//				this.$PC = 1;
		//			}
		//			return true;
		//		case 1u:
		//			this.$this.Fumo.GetComponent<ParticleSystem>().Stop();
		//			this.$this.Fumo.SetActive(false);
		//			this.$this.P3.SetActive(true);
		//			this.$this.P3.GetComponent<ParticleSystem>().Play();
		//			this.$PC = -1;
		//			break;
		//		}
		//		return false;
		//	}

		//	[DebuggerHidden]
		//	public void Dispose()
		//	{
		//		this.$disposing = true;
		//		this.$PC = -1;
		//	}

		//	[DebuggerHidden]
		//	public void Reset()
		//	{
		//		throw new NotSupportedException();
		//	}
		//}

		//[CompilerGenerated]
		//private sealed class <Waitp4>c__Iterator4 : IEnumerator, IDisposable, IEnumerator<object>
		//{
		//	internal Firemanager $this;

		//	internal object $current;

		//	internal bool $disposing;

		//	internal int $PC;

		//	object IEnumerator<object>.Current
		//	{
		//		[DebuggerHidden]
		//		get
		//		{
		//			return this.$current;
		//		}
		//	}

		//	object IEnumerator.Current
		//	{
		//		[DebuggerHidden]
		//		get
		//		{
		//			return this.$current;
		//		}
		//	}

		//	[DebuggerHidden]
		//	public <Waitp4>c__Iterator4()
		//	{
		//	}

		//	public bool MoveNext()
		//	{
		//		uint num = (uint)this.$PC;
		//		this.$PC = -1;
		//		switch (num)
		//		{
		//		case 0u:
		//			this.$current = new WaitForSeconds(0.2f);
		//			if (!this.$disposing)
		//			{
		//				this.$PC = 1;
		//			}
		//			return true;
		//		case 1u:
		//			this.$this.Fumo.GetComponent<ParticleSystem>().Stop();
		//			this.$this.Fumo.SetActive(false);
		//			this.$this.P4.SetActive(true);
		//			this.$this.P4.GetComponent<ParticleSystem>().Play();
		//			this.$PC = -1;
		//			break;
		//		}
		//		return false;
		//	}

		//	[DebuggerHidden]
		//	public void Dispose()
		//	{
		//		this.$disposing = true;
		//		this.$PC = -1;
		//	}

		//	[DebuggerHidden]
		//	public void Reset()
		//	{
		//		throw new NotSupportedException();
		//	}
		//}

		//[CompilerGenerated]
		//private sealed class <Waitp5>c__Iterator5 : IEnumerator, IDisposable, IEnumerator<object>
		//{
		//	internal Firemanager $this;

		//	internal object $current;

		//	internal bool $disposing;

		//	internal int $PC;

		//	object IEnumerator<object>.Current
		//	{
		//		[DebuggerHidden]
		//		get
		//		{
		//			return this.$current;
		//		}
		//	}

		//	object IEnumerator.Current
		//	{
		//		[DebuggerHidden]
		//		get
		//		{
		//			return this.$current;
		//		}
		//	}

		//	[DebuggerHidden]
		//	public <Waitp5>c__Iterator5()
		//	{
		//	}

		//	public bool MoveNext()
		//	{
		//		uint num = (uint)this.$PC;
		//		this.$PC = -1;
		//		switch (num)
		//		{
		//		case 0u:
		//			this.$current = new WaitForSeconds(0.2f);
		//			if (!this.$disposing)
		//			{
		//				this.$PC = 1;
		//			}
		//			return true;
		//		case 1u:
		//			this.$this.Fumo.GetComponent<ParticleSystem>().Stop();
		//			this.$this.Fumo.SetActive(false);
		//			this.$this.P5.SetActive(true);
		//			this.$this.P5.GetComponent<ParticleSystem>().Play();
		//			this.$PC = -1;
		//			break;
		//		}
		//		return false;
		//	}

		//	[DebuggerHidden]
		//	public void Dispose()
		//	{
		//		this.$disposing = true;
		//		this.$PC = -1;
		//	}

		//	[DebuggerHidden]
		//	public void Reset()
		//	{
		//		throw new NotSupportedException();
		//	}
		//}

		//[CompilerGenerated]
		//private sealed class <Waitp6>c__Iterator6 : IEnumerator, IDisposable, IEnumerator<object>
		//{
		//	internal Firemanager $this;

		//	internal object $current;

		//	internal bool $disposing;

		//	internal int $PC;

		//	object IEnumerator<object>.Current
		//	{
		//		[DebuggerHidden]
		//		get
		//		{
		//			return this.$current;
		//		}
		//	}

		//	object IEnumerator.Current
		//	{
		//		[DebuggerHidden]
		//		get
		//		{
		//			return this.$current;
		//		}
		//	}

		//	[DebuggerHidden]
		//	public <Waitp6>c__Iterator6()
		//	{
		//	}

		//	public bool MoveNext()
		//	{
		//		uint num = (uint)this.$PC;
		//		this.$PC = -1;
		//		switch (num)
		//		{
		//		case 0u:
		//			this.$current = new WaitForSeconds(0.2f);
		//			if (!this.$disposing)
		//			{
		//				this.$PC = 1;
		//			}
		//			return true;
		//		case 1u:
		//			this.$this.Fumo.GetComponent<ParticleSystem>().Stop();
		//			this.$this.Fumo.SetActive(false);
		//			this.$this.P6.SetActive(true);
		//			this.$this.P6.GetComponent<ParticleSystem>().Play();
		//			this.$PC = -1;
		//			break;
		//		}
		//		return false;
		//	}

		//	[DebuggerHidden]
		//	public void Dispose()
		//	{
		//		this.$disposing = true;
		//		this.$PC = -1;
		//	}

		//	[DebuggerHidden]
		//	public void Reset()
		//	{
		//		throw new NotSupportedException();
		//	}
		//}

		//[CompilerGenerated]
		//private sealed class <Waitp7>c__Iterator7 : IEnumerator, IDisposable, IEnumerator<object>
		//{
		//	internal Firemanager $this;

		//	internal object $current;

		//	internal bool $disposing;

		//	internal int $PC;

		//	object IEnumerator<object>.Current
		//	{
		//		[DebuggerHidden]
		//		get
		//		{
		//			return this.$current;
		//		}
		//	}

		//	object IEnumerator.Current
		//	{
		//		[DebuggerHidden]
		//		get
		//		{
		//			return this.$current;
		//		}
		//	}

		//	[DebuggerHidden]
		//	public <Waitp7>c__Iterator7()
		//	{
		//	}

		//	public bool MoveNext()
		//	{
		//		uint num = (uint)this.$PC;
		//		this.$PC = -1;
		//		switch (num)
		//		{
		//		case 0u:
		//			this.$current = new WaitForSeconds(0.2f);
		//			if (!this.$disposing)
		//			{
		//				this.$PC = 1;
		//			}
		//			return true;
		//		case 1u:
		//			this.$this.Fumo.GetComponent<ParticleSystem>().Stop();
		//			this.$this.Fumo.SetActive(false);
		//			this.$this.P7.SetActive(true);
		//			this.$this.P7.GetComponent<ParticleSystem>().Play();
		//			this.$PC = -1;
		//			break;
		//		}
		//		return false;
		//	}

		//	[DebuggerHidden]
		//	public void Dispose()
		//	{
		//		this.$disposing = true;
		//		this.$PC = -1;
		//	}

		//	[DebuggerHidden]
		//	public void Reset()
		//	{
		//		throw new NotSupportedException();
		//	}
		//}

		//[CompilerGenerated]
		//private sealed class <Waitp8>c__Iterator8 : IEnumerator, IDisposable, IEnumerator<object>
		//{
		//	internal Firemanager $this;

		//	internal object $current;

		//	internal bool $disposing;

		//	internal int $PC;

		//	object IEnumerator<object>.Current
		//	{
		//		[DebuggerHidden]
		//		get
		//		{
		//			return this.$current;
		//		}
		//	}

		//	object IEnumerator.Current
		//	{
		//		[DebuggerHidden]
		//		get
		//		{
		//			return this.$current;
		//		}
		//	}

		//	[DebuggerHidden]
		//	public <Waitp8>c__Iterator8()
		//	{
		//	}

		//	public bool MoveNext()
		//	{
		//		uint num = (uint)this.$PC;
		//		this.$PC = -1;
		//		switch (num)
		//		{
		//		case 0u:
		//			this.$current = new WaitForSeconds(0.2f);
		//			if (!this.$disposing)
		//			{
		//				this.$PC = 1;
		//			}
		//			return true;
		//		case 1u:
		//			this.$this.Fumo.GetComponent<ParticleSystem>().Stop();
		//			this.$this.Fumo.SetActive(false);
		//			this.$this.P8.SetActive(true);
		//			this.$this.P8.GetComponent<ParticleSystem>().Play();
		//			this.$PC = -1;
		//			break;
		//		}
		//		return false;
		//	}

		//	[DebuggerHidden]
		//	public void Dispose()
		//	{
		//		this.$disposing = true;
		//		this.$PC = -1;
		//	}

		//	[DebuggerHidden]
		//	public void Reset()
		//	{
		//		throw new NotSupportedException();
		//	}
		//}

		//[CompilerGenerated]
		//private sealed class <Waitp9>c__Iterator9 : IEnumerator, IDisposable, IEnumerator<object>
		//{
		//	internal Firemanager $this;

		//	internal object $current;

		//	internal bool $disposing;

		//	internal int $PC;

		//	object IEnumerator<object>.Current
		//	{
		//		[DebuggerHidden]
		//		get
		//		{
		//			return this.$current;
		//		}
		//	}

		//	object IEnumerator.Current
		//	{
		//		[DebuggerHidden]
		//		get
		//		{
		//			return this.$current;
		//		}
		//	}

		//	[DebuggerHidden]
		//	public <Waitp9>c__Iterator9()
		//	{
		//	}

		//	public bool MoveNext()
		//	{
		//		uint num = (uint)this.$PC;
		//		this.$PC = -1;
		//		switch (num)
		//		{
		//		case 0u:
		//			this.$current = new WaitForSeconds(0.2f);
		//			if (!this.$disposing)
		//			{
		//				this.$PC = 1;
		//			}
		//			return true;
		//		case 1u:
		//			this.$this.Fumo.GetComponent<ParticleSystem>().Stop();
		//			this.$this.Fumo.SetActive(false);
		//			this.$this.P9.SetActive(true);
		//			this.$this.P9.GetComponent<ParticleSystem>().Play();
		//			this.$PC = -1;
		//			break;
		//		}
		//		return false;
		//	}

		//	[DebuggerHidden]
		//	public void Dispose()
		//	{
		//		this.$disposing = true;
		//		this.$PC = -1;
		//	}

		//	[DebuggerHidden]
		//	public void Reset()
		//	{
		//		throw new NotSupportedException();
		//	}
		//}

		//[CompilerGenerated]
		//private sealed class <Waitp10>c__IteratorA : IEnumerator, IDisposable, IEnumerator<object>
		//{
		//	internal Firemanager $this;

		//	internal object $current;

		//	internal bool $disposing;

		//	internal int $PC;

		//	object IEnumerator<object>.Current
		//	{
		//		[DebuggerHidden]
		//		get
		//		{
		//			return this.$current;
		//		}
		//	}

		//	object IEnumerator.Current
		//	{
		//		[DebuggerHidden]
		//		get
		//		{
		//			return this.$current;
		//		}
		//	}

		//	[DebuggerHidden]
		//	public <Waitp10>c__IteratorA()
		//	{
		//	}

		//	public bool MoveNext()
		//	{
		//		uint num = (uint)this.$PC;
		//		this.$PC = -1;
		//		switch (num)
		//		{
		//		case 0u:
		//			this.$current = new WaitForSeconds(0.2f);
		//			if (!this.$disposing)
		//			{
		//				this.$PC = 1;
		//			}
		//			return true;
		//		case 1u:
		//			this.$this.Fumo.GetComponent<ParticleSystem>().Stop();
		//			this.$this.Fumo.SetActive(false);
		//			this.$this.P10.SetActive(true);
		//			this.$this.P10.GetComponent<ParticleSystem>().Play();
		//			this.$PC = -1;
		//			break;
		//		}
		//		return false;
		//	}

		//	[DebuggerHidden]
		//	public void Dispose()
		//	{
		//		this.$disposing = true;
		//		this.$PC = -1;
		//	}

		//	[DebuggerHidden]
		//	public void Reset()
		//	{
		//		throw new NotSupportedException();
		//	}
		//}

		//[CompilerGenerated]
		//private sealed class <Waitp11>c__IteratorB : IEnumerator, IDisposable, IEnumerator<object>
		//{
		//	internal Firemanager $this;

		//	internal object $current;

		//	internal bool $disposing;

		//	internal int $PC;

		//	object IEnumerator<object>.Current
		//	{
		//		[DebuggerHidden]
		//		get
		//		{
		//			return this.$current;
		//		}
		//	}

		//	object IEnumerator.Current
		//	{
		//		[DebuggerHidden]
		//		get
		//		{
		//			return this.$current;
		//		}
		//	}

		//	[DebuggerHidden]
		//	public <Waitp11>c__IteratorB()
		//	{
		//	}

		//	public bool MoveNext()
		//	{
		//		uint num = (uint)this.$PC;
		//		this.$PC = -1;
		//		switch (num)
		//		{
		//		case 0u:
		//			this.$current = new WaitForSeconds(0.2f);
		//			if (!this.$disposing)
		//			{
		//				this.$PC = 1;
		//			}
		//			return true;
		//		case 1u:
		//			this.$this.Fumo.GetComponent<ParticleSystem>().Stop();
		//			this.$this.Fumo.SetActive(false);
		//			this.$this.P11.SetActive(true);
		//			this.$this.P11.GetComponent<ParticleSystem>().Play();
		//			this.$PC = -1;
		//			break;
		//		}
		//		return false;
		//	}

		//	[DebuggerHidden]
		//	public void Dispose()
		//	{
		//		this.$disposing = true;
		//		this.$PC = -1;
		//	}

		//	[DebuggerHidden]
		//	public void Reset()
		//	{
		//		throw new NotSupportedException();
		//	}
		//}

		//[CompilerGenerated]
		//private sealed class <Waitp12>c__IteratorC : IEnumerator, IDisposable, IEnumerator<object>
		//{
		//	internal Firemanager $this;

		//	internal object $current;

		//	internal bool $disposing;

		//	internal int $PC;

		//	object IEnumerator<object>.Current
		//	{
		//		[DebuggerHidden]
		//		get
		//		{
		//			return this.$current;
		//		}
		//	}

		//	object IEnumerator.Current
		//	{
		//		[DebuggerHidden]
		//		get
		//		{
		//			return this.$current;
		//		}
		//	}

		//	[DebuggerHidden]
		//	public <Waitp12>c__IteratorC()
		//	{
		//	}

		//	public bool MoveNext()
		//	{
		//		uint num = (uint)this.$PC;
		//		this.$PC = -1;
		//		switch (num)
		//		{
		//		case 0u:
		//			this.$current = new WaitForSeconds(0.2f);
		//			if (!this.$disposing)
		//			{
		//				this.$PC = 1;
		//			}
		//			return true;
		//		case 1u:
		//			this.$this.Fumo.GetComponent<ParticleSystem>().Stop();
		//			this.$this.Fumo.SetActive(false);
		//			this.$this.P12.SetActive(true);
		//			this.$this.P12.GetComponent<ParticleSystem>().Play();
		//			this.$PC = -1;
		//			break;
		//		}
		//		return false;
		//	}

		//	[DebuggerHidden]
		//	public void Dispose()
		//	{
		//		this.$disposing = true;
		//		this.$PC = -1;
		//	}

		//	[DebuggerHidden]
		//	public void Reset()
		//	{
		//		throw new NotSupportedException();
		//	}
		//}

		//[CompilerGenerated]
		//private sealed class <Waitp13>c__IteratorD : IEnumerator, IDisposable, IEnumerator<object>
		//{
		//	internal Firemanager $this;

		//	internal object $current;

		//	internal bool $disposing;

		//	internal int $PC;

		//	object IEnumerator<object>.Current
		//	{
		//		[DebuggerHidden]
		//		get
		//		{
		//			return this.$current;
		//		}
		//	}

		//	object IEnumerator.Current
		//	{
		//		[DebuggerHidden]
		//		get
		//		{
		//			return this.$current;
		//		}
		//	}

		//	[DebuggerHidden]
		//	public <Waitp13>c__IteratorD()
		//	{
		//	}

		//	public bool MoveNext()
		//	{
		//		uint num = (uint)this.$PC;
		//		this.$PC = -1;
		//		switch (num)
		//		{
		//		case 0u:
		//			this.$current = new WaitForSeconds(0.2f);
		//			if (!this.$disposing)
		//			{
		//				this.$PC = 1;
		//			}
		//			return true;
		//		case 1u:
		//			this.$this.Fumo.GetComponent<ParticleSystem>().Stop();
		//			this.$this.Fumo.SetActive(false);
		//			this.$this.P13.SetActive(true);
		//			this.$this.P13.GetComponent<ParticleSystem>().Play();
		//			this.$PC = -1;
		//			break;
		//		}
		//		return false;
		//	}

		//	[DebuggerHidden]
		//	public void Dispose()
		//	{
		//		this.$disposing = true;
		//		this.$PC = -1;
		//	}

		//	[DebuggerHidden]
		//	public void Reset()
		//	{
		//		throw new NotSupportedException();
		//	}
		//}

		//[CompilerGenerated]
		//private sealed class <Waitp14>c__IteratorE : IEnumerator, IDisposable, IEnumerator<object>
		//{
		//	internal Firemanager $this;

		//	internal object $current;

		//	internal bool $disposing;

		//	internal int $PC;

		//	object IEnumerator<object>.Current
		//	{
		//		[DebuggerHidden]
		//		get
		//		{
		//			return this.$current;
		//		}
		//	}

		//	object IEnumerator.Current
		//	{
		//		[DebuggerHidden]
		//		get
		//		{
		//			return this.$current;
		//		}
		//	}

		//	[DebuggerHidden]
		//	public <Waitp14>c__IteratorE()
		//	{
		//	}

		//	public bool MoveNext()
		//	{
		//		uint num = (uint)this.$PC;
		//		this.$PC = -1;
		//		switch (num)
		//		{
		//		case 0u:
		//			this.$current = new WaitForSeconds(0.2f);
		//			if (!this.$disposing)
		//			{
		//				this.$PC = 1;
		//			}
		//			return true;
		//		case 1u:
		//			this.$this.Fumo.GetComponent<ParticleSystem>().Stop();
		//			this.$this.Fumo.SetActive(false);
		//			this.$this.P14.SetActive(true);
		//			this.$this.P14.GetComponent<ParticleSystem>().Play();
		//			this.$PC = -1;
		//			break;
		//		}
		//		return false;
		//	}

		//	[DebuggerHidden]
		//	public void Dispose()
		//	{
		//		this.$disposing = true;
		//		this.$PC = -1;
		//	}

		//	[DebuggerHidden]
		//	public void Reset()
		//	{
		//		throw new NotSupportedException();
		//	}
		//}

		//[CompilerGenerated]
		//private sealed class <Waitp15>c__IteratorF : IEnumerator, IDisposable, IEnumerator<object>
		//{
		//	internal Firemanager $this;

		//	internal object $current;

		//	internal bool $disposing;

		//	internal int $PC;

		//	object IEnumerator<object>.Current
		//	{
		//		[DebuggerHidden]
		//		get
		//		{
		//			return this.$current;
		//		}
		//	}

		//	object IEnumerator.Current
		//	{
		//		[DebuggerHidden]
		//		get
		//		{
		//			return this.$current;
		//		}
		//	}

		//	[DebuggerHidden]
		//	public <Waitp15>c__IteratorF()
		//	{
		//	}

		//	public bool MoveNext()
		//	{
		//		uint num = (uint)this.$PC;
		//		this.$PC = -1;
		//		switch (num)
		//		{
		//		case 0u:
		//			this.$current = new WaitForSeconds(0.2f);
		//			if (!this.$disposing)
		//			{
		//				this.$PC = 1;
		//			}
		//			return true;
		//		case 1u:
		//			this.$this.Fumo.GetComponent<ParticleSystem>().Stop();
		//			this.$this.Fumo.SetActive(false);
		//			this.$this.P15.SetActive(true);
		//			this.$this.P15.GetComponent<ParticleSystem>().Play();
		//			this.$PC = -1;
		//			break;
		//		}
		//		return false;
		//	}

		//	[DebuggerHidden]
		//	public void Dispose()
		//	{
		//		this.$disposing = true;
		//		this.$PC = -1;
		//	}

		//	[DebuggerHidden]
		//	public void Reset()
		//	{
		//		throw new NotSupportedException();
		//	}
		//}

		//[CompilerGenerated]
		//private sealed class <Waitp16>c__Iterator10 : IEnumerator, IDisposable, IEnumerator<object>
		//{
		//	internal Firemanager $this;

		//	internal object $current;

		//	internal bool $disposing;

		//	internal int $PC;

		//	object IEnumerator<object>.Current
		//	{
		//		[DebuggerHidden]
		//		get
		//		{
		//			return this.$current;
		//		}
		//	}

		//	object IEnumerator.Current
		//	{
		//		[DebuggerHidden]
		//		get
		//		{
		//			return this.$current;
		//		}
		//	}

		//	[DebuggerHidden]
		//	public <Waitp16>c__Iterator10()
		//	{
		//	}

		//	public bool MoveNext()
		//	{
		//		uint num = (uint)this.$PC;
		//		this.$PC = -1;
		//		switch (num)
		//		{
		//		case 0u:
		//			this.$current = new WaitForSeconds(0.2f);
		//			if (!this.$disposing)
		//			{
		//				this.$PC = 1;
		//			}
		//			return true;
		//		case 1u:
		//			this.$this.Fumo.GetComponent<ParticleSystem>().Stop();
		//			this.$this.Fumo.SetActive(false);
		//			this.$this.P16.SetActive(true);
		//			this.$this.P16.GetComponent<ParticleSystem>().Play();
		//			this.$PC = -1;
		//			break;
		//		}
		//		return false;
		//	}

		//	[DebuggerHidden]
		//	public void Dispose()
		//	{
		//		this.$disposing = true;
		//		this.$PC = -1;
		//	}

		//	[DebuggerHidden]
		//	public void Reset()
		//	{
		//		throw new NotSupportedException();
		//	}
		//}

		//[CompilerGenerated]
		//private sealed class <Waitp17>c__Iterator11 : IEnumerator, IDisposable, IEnumerator<object>
		//{
		//	internal Firemanager $this;

		//	internal object $current;

		//	internal bool $disposing;

		//	internal int $PC;

		//	object IEnumerator<object>.Current
		//	{
		//		[DebuggerHidden]
		//		get
		//		{
		//			return this.$current;
		//		}
		//	}

		//	object IEnumerator.Current
		//	{
		//		[DebuggerHidden]
		//		get
		//		{
		//			return this.$current;
		//		}
		//	}

		//	[DebuggerHidden]
		//	public <Waitp17>c__Iterator11()
		//	{
		//	}

		//	public bool MoveNext()
		//	{
		//		uint num = (uint)this.$PC;
		//		this.$PC = -1;
		//		switch (num)
		//		{
		//		case 0u:
		//			this.$current = new WaitForSeconds(0.2f);
		//			if (!this.$disposing)
		//			{
		//				this.$PC = 1;
		//			}
		//			return true;
		//		case 1u:
		//			this.$this.Fumo.GetComponent<ParticleSystem>().Stop();
		//			this.$this.Fumo.SetActive(false);
		//			this.$this.P17.SetActive(true);
		//			this.$this.P17.GetComponent<ParticleSystem>().Play();
		//			this.$PC = -1;
		//			break;
		//		}
		//		return false;
		//	}

		//	[DebuggerHidden]
		//	public void Dispose()
		//	{
		//		this.$disposing = true;
		//		this.$PC = -1;
		//	}

		//	[DebuggerHidden]
		//	public void Reset()
		//	{
		//		throw new NotSupportedException();
		//	}
		//}

		//[CompilerGenerated]
		//private sealed class <Waitp18>c__Iterator12 : IEnumerator, IDisposable, IEnumerator<object>
		//{
		//	internal Firemanager $this;

		//	internal object $current;

		//	internal bool $disposing;

		//	internal int $PC;

		//	object IEnumerator<object>.Current
		//	{
		//		[DebuggerHidden]
		//		get
		//		{
		//			return this.$current;
		//		}
		//	}

		//	object IEnumerator.Current
		//	{
		//		[DebuggerHidden]
		//		get
		//		{
		//			return this.$current;
		//		}
		//	}

		//	[DebuggerHidden]
		//	public <Waitp18>c__Iterator12()
		//	{
		//	}

		//	public bool MoveNext()
		//	{
		//		uint num = (uint)this.$PC;
		//		this.$PC = -1;
		//		switch (num)
		//		{
		//		case 0u:
		//			this.$current = new WaitForSeconds(0.2f);
		//			if (!this.$disposing)
		//			{
		//				this.$PC = 1;
		//			}
		//			return true;
		//		case 1u:
		//			this.$this.Fumo.GetComponent<ParticleSystem>().Stop();
		//			this.$this.Fumo.SetActive(false);
		//			this.$this.P18.SetActive(true);
		//			this.$this.P18.GetComponent<ParticleSystem>().Play();
		//			this.$PC = -1;
		//			break;
		//		}
		//		return false;
		//	}

		//	[DebuggerHidden]
		//	public void Dispose()
		//	{
		//		this.$disposing = true;
		//		this.$PC = -1;
		//	}

		//	[DebuggerHidden]
		//	public void Reset()
		//	{
		//		throw new NotSupportedException();
		//	}
		//}

		//[CompilerGenerated]
		//private sealed class <Waitp19>c__Iterator13 : IEnumerator, IDisposable, IEnumerator<object>
		//{
		//	internal Firemanager $this;

		//	internal object $current;

		//	internal bool $disposing;

		//	internal int $PC;

		//	object IEnumerator<object>.Current
		//	{
		//		[DebuggerHidden]
		//		get
		//		{
		//			return this.$current;
		//		}
		//	}

		//	object IEnumerator.Current
		//	{
		//		[DebuggerHidden]
		//		get
		//		{
		//			return this.$current;
		//		}
		//	}

		//	[DebuggerHidden]
		//	public <Waitp19>c__Iterator13()
		//	{
		//	}

		//	public bool MoveNext()
		//	{
		//		uint num = (uint)this.$PC;
		//		this.$PC = -1;
		//		switch (num)
		//		{
		//		case 0u:
		//			this.$current = new WaitForSeconds(0.2f);
		//			if (!this.$disposing)
		//			{
		//				this.$PC = 1;
		//			}
		//			return true;
		//		case 1u:
		//			this.$this.Fumo.GetComponent<ParticleSystem>().Stop();
		//			this.$this.Fumo.SetActive(false);
		//			this.$this.P19.SetActive(true);
		//			this.$this.P19.GetComponent<ParticleSystem>().Play();
		//			this.$PC = -1;
		//			break;
		//		}
		//		return false;
		//	}

		//	[DebuggerHidden]
		//	public void Dispose()
		//	{
		//		this.$disposing = true;
		//		this.$PC = -1;
		//	}

		//	[DebuggerHidden]
		//	public void Reset()
		//	{
		//		throw new NotSupportedException();
		//	}
		//}

		//[CompilerGenerated]
		//private sealed class <Waitp1>c__Iterator14 : IEnumerator, IDisposable, IEnumerator<object>
		//{
		//	internal Firemanager $this;

		//	internal object $current;

		//	internal bool $disposing;

		//	internal int $PC;

		//	object IEnumerator<object>.Current
		//	{
		//		[DebuggerHidden]
		//		get
		//		{
		//			return this.$current;
		//		}
		//	}

		//	object IEnumerator.Current
		//	{
		//		[DebuggerHidden]
		//		get
		//		{
		//			return this.$current;
		//		}
		//	}

		//	[DebuggerHidden]
		//	public <Waitp1>c__Iterator14()
		//	{
		//	}

		//	public bool MoveNext()
		//	{
		//		uint num = (uint)this.$PC;
		//		this.$PC = -1;
		//		switch (num)
		//		{
		//		case 0u:
		//			this.$current = new WaitForSeconds(0.2f);
		//			if (!this.$disposing)
		//			{
		//				this.$PC = 1;
		//			}
		//			return true;
		//		case 1u:
		//			this.$this.Fumo.GetComponent<ParticleSystem>().Stop();
		//			this.$this.Fumo.SetActive(false);
		//			this.$this.P1.SetActive(true);
		//			this.$this.P1.GetComponent<ParticleSystem>().Play();
		//			this.$PC = -1;
		//			break;
		//		}
		//		return false;
		//	}

		//	[DebuggerHidden]
		//	public void Dispose()
		//	{
		//		this.$disposing = true;
		//		this.$PC = -1;
		//	}

		//	[DebuggerHidden]
		//	public void Reset()
		//	{
		//		throw new NotSupportedException();
		//	}
		//}

		public GameObject Player;

		public GameObject Fumo;

		public GameObject Fire;

		public GameObject P1;

		public GameObject P2;

		public GameObject P3;

		public GameObject P4;

		public GameObject P5;

		public GameObject P6;

		public GameObject P7;

		public GameObject P8;

		public GameObject P9;

		public GameObject P10;

		public GameObject P11;

		public GameObject P12;

		public GameObject P13;

		public GameObject P14;

		public GameObject P15;

		public GameObject P16;

		public GameObject P17;

		public GameObject P18;

		public GameObject P19;

		public static int p1;

		public static int p2;

		public static int p3;

		public static int p4;

		public static int p5;

		public static int p6;

		public static int p7;

		public static int p8;

		public static int p9;

		public static int p10;

		public static int p11;

		public static int p12;

		public static int p13;

		public static int p14;

		public static int p15;

		public static int p16;

		public static int p17;

		public static int p18;

		public static int p19;

		public int l1;

		public int l2;

		public int l3;

		public int l4;

		public int l5;

		public int l6;

		public int l7;

		public int l8;

		public int l9;

		public int l10;

		public int l11;

		public int l12;

		public int l13;

		public int l14;

		public int l15;

		public int l16;

		public int l17;

		public int l18;

		public int l19;

		public int l20;

		public int l21;

		public void Start()
		{
			this.l1 = 1;
			this.l2 = 1;
			this.l3 = 1;
			this.l4 = 1;
			this.l5 = 1;
			this.l6 = 1;
			this.l7 = 1;
			this.l8 = 1;
			this.l9 = 1;
			this.l10 = 1;
			this.l11 = 1;
			this.l12 = 1;
			this.l13 = 1;
			this.l14 = 1;
			this.l15 = 1;
			this.l16 = 1;
			this.l17 = 1;
			this.l18 = 1;
			this.l19 = 1;
			this.l20 = 1;
			this.l21 = 1;
		}

		public void Update()
		{
			if (Utils.Currentscore >= 10 && this.l1 == 1)
			{
				this.l1 = 0;
				this.Tim();
			}
			else if (Utils.Currentscore <= 10)
			{
				return;
			}
			if (Utils.Currentscore >= 20 && this.l2 == 1 && shopScript.B1 == 1 && shopScript.BAllCurrent == 1)
			{
				this.l2 = 0;
				this.Fuoco();
			}
			else if (Utils.Currentscore <= 20)
			{
				return;
			}
			if (Utils.Currentscore >= 20 && this.l3 == 1 && shopScript.B2 == 1 && shopScript.BAllCurrent == 2)
			{
				this.l3 = 0;
				this.Pl1();
			}
			else if (Utils.Currentscore <= 20)
			{
				return;
			}
			if (Utils.Currentscore >= 20 && this.l4 == 1 && shopScript.B3 == 1 && shopScript.BAllCurrent == 3)
			{
				this.l4 = 0;
				this.Pl2();
			}
			else if (Utils.Currentscore <= 20)
			{
				return;
			}
			if (Utils.Currentscore >= 20 && this.l5 == 1 && shopScript.B4 == 1 && shopScript.BAllCurrent == 4)
			{
				this.l5 = 0;
				this.Pl3();
			}
			else if (Utils.Currentscore <= 20)
			{
				return;
			}
			if (Utils.Currentscore >= 20 && this.l6 == 1 && shopScript.B5 == 1 && shopScript.BAllCurrent == 5)
			{
				this.l6 = 0;
				this.Pl4();
			}
			else if (Utils.Currentscore <= 20)
			{
				return;
			}
			if (Utils.Currentscore >= 20 && this.l7 == 1 && shopScript.B6 == 1 && shopScript.BAllCurrent == 6)
			{
				this.l7 = 0;
				this.Pl5();
			}
			else if (Utils.Currentscore <= 20)
			{
				return;
			}
			if (Utils.Currentscore >= 20 && this.l8 == 1 && shopScript.B7 == 1 && shopScript.BAllCurrent == 7)
			{
				this.l8 = 0;
				this.Pl6();
			}
			else if (Utils.Currentscore <= 20)
			{
				return;
			}
			if (Utils.Currentscore >= 20 && this.l9 == 1 && shopScript.B8 == 1 && shopScript.BAllCurrent == 8)
			{
				this.l9 = 0;
				this.Pl7();
			}
			else if (Utils.Currentscore <= 20)
			{
				return;
			}
			if (Utils.Currentscore >= 20 && this.l10 == 1 && shopScript.B9 == 1 && shopScript.BAllCurrent == 9)
			{
				this.l10 = 0;
				this.Pl8();
			}
			else if (Utils.Currentscore <= 20)
			{
				return;
			}
			if (Utils.Currentscore >= 20 && this.l11 == 1 && shopScript.B10 == 1 && shopScript.BAllCurrent == 10)
			{
				this.l11 = 0;
				this.Pl9();
			}
			else if (Utils.Currentscore <= 20)
			{
				return;
			}
			if (Utils.Currentscore >= 20 && this.l12 == 1 && shopScript.B11 == 1 && shopScript.BAllCurrent == 11)
			{
				this.l12 = 0;
				this.Pl10();
			}
			else if (Utils.Currentscore <= 20)
			{
				return;
			}
			if (Utils.Currentscore >= 20 && this.l13 == 1 && shopScript.B12 == 1 && shopScript.BAllCurrent == 12)
			{
				this.l13 = 0;
				this.Pl11();
			}
			else if (Utils.Currentscore <= 20)
			{
				return;
			}
			if (Utils.Currentscore >= 20 && this.l14 == 1 && shopScript.B13 == 1 && shopScript.BAllCurrent == 13)
			{
				this.l14 = 0;
				this.Pl12();
			}
			else if (Utils.Currentscore <= 20)
			{
				return;
			}
			if (Utils.Currentscore >= 20 && this.l15 == 1 && shopScript.B14 == 1 && shopScript.BAllCurrent == 14)
			{
				this.l15 = 0;
				this.Pl13();
			}
			else if (Utils.Currentscore <= 20)
			{
				return;
			}
			if (Utils.Currentscore >= 20 && this.l16 == 1 && shopScript.B15 == 1 && shopScript.BAllCurrent == 15)
			{
				this.l16 = 0;
				this.Pl14();
			}
			else if (Utils.Currentscore <= 20)
			{
				return;
			}
			if (Utils.Currentscore >= 20 && this.l17 == 1 && shopScript.B16 == 1 && shopScript.BAllCurrent == 16)
			{
				this.l17 = 0;
				this.Pl15();
			}
			else if (Utils.Currentscore <= 20)
			{
				return;
			}
			if (Utils.Currentscore >= 20 && this.l18 == 1 && shopScript.B17 == 1 && shopScript.BAllCurrent == 17)
			{
				this.l18 = 0;
				this.Pl16();
			}
			else if (Utils.Currentscore <= 20)
			{
				return;
			}
			if (Utils.Currentscore >= 20 && this.l19 == 1 && shopScript.B18 == 1 && shopScript.BAllCurrent == 18)
			{
				this.l19 = 0;
				this.Pl17();
			}
			else if (Utils.Currentscore <= 20)
			{
				return;
			}
			if (Utils.Currentscore >= 20 && this.l20 == 1 && shopScript.B19 == 1 && shopScript.BAllCurrent == 19)
			{
				this.l20 = 0;
				this.Pl18();
			}
			else if (Utils.Currentscore <= 20)
			{
				return;
			}
			if (Utils.Currentscore >= 20 && this.l21 == 1 && shopScript.B20 == 1 && shopScript.BAllCurrent == 20)
			{
				this.l21 = 0;
				this.Pl19();
			}
			else if (Utils.Currentscore <= 20)
			{
				return;
			}
		}

		public void StopAll()
		{
			this.Fumo.GetComponent<ParticleSystem>().Stop();
			this.Fire.GetComponent<ParticleSystem>().Stop();
			this.P1.GetComponent<ParticleSystem>().Stop();
			this.P2.GetComponent<ParticleSystem>().Stop();
			this.P3.GetComponent<ParticleSystem>().Stop();
			this.P4.GetComponent<ParticleSystem>().Stop();
			this.P5.GetComponent<ParticleSystem>().Stop();
			this.P6.GetComponent<ParticleSystem>().Stop();
			this.P6.SetActive(false);
			this.P7.GetComponent<ParticleSystem>().Stop();
			this.P7.SetActive(false);
			this.P8.GetComponent<ParticleSystem>().Stop();
			this.P8.SetActive(false);
			this.P9.GetComponent<ParticleSystem>().Stop();
			this.P9.SetActive(false);
			this.P10.GetComponent<ParticleSystem>().Stop();
			this.P10.SetActive(false);
			this.P11.GetComponent<ParticleSystem>().Stop();
			this.P11.SetActive(false);
			this.P12.GetComponent<ParticleSystem>().Stop();
			this.P12.SetActive(false);
			this.P13.GetComponent<ParticleSystem>().Stop();
			this.P13.SetActive(false);
			this.P14.GetComponent<ParticleSystem>().Stop();
			this.P14.SetActive(false);
			this.P15.GetComponent<ParticleSystem>().Stop();
			this.P15.SetActive(false);
			this.P16.GetComponent<ParticleSystem>().Stop();
			this.P16.SetActive(false);
			this.P17.GetComponent<ParticleSystem>().Stop();
			this.P17.SetActive(false);
			this.P18.GetComponent<ParticleSystem>().Stop();
			this.P18.SetActive(false);
			this.P19.GetComponent<ParticleSystem>().Stop();
			this.P19.SetActive(false);
			this.Player.GetComponent<TrailRenderer>().enabled = false;
			this.Fire.SetActive(false);
			this.Fumo.SetActive(false);
			this.P1.SetActive(false);
			this.P2.SetActive(false);
			this.P3.SetActive(false);
			this.P4.SetActive(false);
			this.P5.SetActive(false);
		}

		public void Fuoco()
		{
			this.StopAll();
			base.StartCoroutine(this.WaitF());
		}

		public void Pl1()
		{
			this.StopAll();
			base.StartCoroutine(this.Waitp1());
		}

		public void Pl2()
		{
			this.StopAll();
			base.StartCoroutine(this.Waitp2());
		}

		public void Pl3()
		{
			this.StopAll();
			base.StartCoroutine(this.Waitp3());
		}

		public void Pl4()
		{
			this.StopAll();
			base.StartCoroutine(this.Waitp4());
		}

		public void Pl5()
		{
			this.StopAll();
			base.StartCoroutine(this.Waitp5());
		}

		public void Pl6()
		{
			this.StopAll();
			base.StartCoroutine(this.Waitp6());
		}

		public void Pl7()
		{
			this.StopAll();
			base.StartCoroutine(this.Waitp7());
		}

		public void Pl8()
		{
			this.StopAll();
			base.StartCoroutine(this.Waitp8());
		}

		public void Pl9()
		{
			this.StopAll();
			base.StartCoroutine(this.Waitp9());
		}

		public void Pl10()
		{
			this.StopAll();
			base.StartCoroutine(this.Waitp10());
		}

		public void Pl11()
		{
			this.StopAll();
			base.StartCoroutine(this.Waitp11());
		}

		public void Pl12()
		{
			this.StopAll();
			base.StartCoroutine(this.Waitp12());
		}

		public void Pl13()
		{
			this.StopAll();
			base.StartCoroutine(this.Waitp13());
		}

		public void Pl14()
		{
			this.StopAll();
			base.StartCoroutine(this.Waitp14());
		}

		public void Pl15()
		{
			this.StopAll();
			base.StartCoroutine(this.Waitp15());
		}

		public void Pl16()
		{
			this.StopAll();
			base.StartCoroutine(this.Waitp16());
		}

		public void Pl17()
		{
			this.StopAll();
			base.StartCoroutine(this.Waitp17());
		}

		public void Pl18()
		{
			this.StopAll();
			base.StartCoroutine(this.Waitp18());
		}

		public void Pl19()
		{
			this.StopAll();
			base.StartCoroutine(this.Waitp19());
		}

		public void Tim()
		{
			this.Player.GetComponent<TrailRenderer>().enabled = false;
			this.StopAll();
			UnityEngine.Debug.Log("fumo");
			base.StartCoroutine(this.WaitFu());
		}

		[DebuggerHidden]
		private IEnumerator WaitFu()
		{
			yield return new WaitForSeconds(0.2f);
			this.Fumo.SetActive(true);
			this.Fumo.GetComponent<ParticleSystem>().Play();
			//Firemanager.<WaitFu>c__Iterator0 <WaitFu>c__Iterator = new Firemanager.<WaitFu>c__Iterator0();
			//<WaitFu>c__Iterator.$this = this;
			//return <WaitFu>c__Iterator;
		}

		[DebuggerHidden]
		private IEnumerator WaitF()
		{
			yield return new WaitForSeconds(0.2f);
			this.Fumo.GetComponent<ParticleSystem>().Stop();
			this.Fumo.SetActive(false);
			this.Fire.SetActive(true);
			this.Fire.GetComponent<ParticleSystem>().Play();
			//Firemanager.<WaitF>c__Iterator1 <WaitF>c__Iterator = new Firemanager.<WaitF>c__Iterator1();
			//<WaitF>c__Iterator.$this = this;
			//return <WaitF>c__Iterator;
		}

		[DebuggerHidden]
		private IEnumerator Waitp2()
		{
			yield return new WaitForSeconds(0.2f);
			this.Fumo.GetComponent<ParticleSystem>().Stop();
			this.Fumo.SetActive(false);
			this.P2.SetActive(true);
			this.P2.GetComponent<ParticleSystem>().Play();
			//Firemanager.<Waitp2>c__Iterator2 <Waitp2>c__Iterator = new Firemanager.<Waitp2>c__Iterator2();
			//<Waitp2>c__Iterator.$this = this;
			//return <Waitp2>c__Iterator;
		}

		[DebuggerHidden]
		private IEnumerator Waitp3()
		{
			yield return new WaitForSeconds(0.2f);
			this.Fumo.GetComponent<ParticleSystem>().Stop();
			this.Fumo.SetActive(false);
			this.P3.SetActive(true);
			this.P3.GetComponent<ParticleSystem>().Play();
			//Firemanager.<Waitp3>c__Iterator3 <Waitp3>c__Iterator = new Firemanager.<Waitp3>c__Iterator3();
			//<Waitp3>c__Iterator.$this = this;
			//return <Waitp3>c__Iterator;
		}

		[DebuggerHidden]
		private IEnumerator Waitp4()
		{
			yield return new WaitForSeconds(0.2f);
			this.Fumo.GetComponent<ParticleSystem>().Stop();
			this.Fumo.SetActive(false);
			this.P4.SetActive(true);
			this.P4.GetComponent<ParticleSystem>().Play();
			//Firemanager.<Waitp4>c__Iterator4 <Waitp4>c__Iterator = new Firemanager.<Waitp4>c__Iterator4();
			//<Waitp4>c__Iterator.$this = this;
			//return <Waitp4>c__Iterator;
		}

		[DebuggerHidden]
		private IEnumerator Waitp5()
		{
			yield return new WaitForSeconds(0.2f);
			this.Fumo.GetComponent<ParticleSystem>().Stop();
			this.Fumo.SetActive(false);
			this.P5.SetActive(true);
			this.P5.GetComponent<ParticleSystem>().Play();
			//Firemanager.<Waitp5>c__Iterator5 <Waitp5>c__Iterator = new Firemanager.<Waitp5>c__Iterator5();
			//<Waitp5>c__Iterator.$this = this;
			//return <Waitp5>c__Iterator;
		}

		[DebuggerHidden]
		private IEnumerator Waitp6()
		{
			yield return new WaitForSeconds(0.2f);
			this.Fumo.GetComponent<ParticleSystem>().Stop();
			this.Fumo.SetActive(false);
			this.P6.SetActive(true);
			this.P6.GetComponent<ParticleSystem>().Play();
			//Firemanager.<Waitp6>c__Iterator6 <Waitp6>c__Iterator = new Firemanager.<Waitp6>c__Iterator6();
			//<Waitp6>c__Iterator.$this = this;
			//return <Waitp6>c__Iterator;
		}

		[DebuggerHidden]
		private IEnumerator Waitp7()
		{
			yield return new WaitForSeconds(0.2f);
			this.Fumo.GetComponent<ParticleSystem>().Stop();
			this.Fumo.SetActive(false);
			this.P7.SetActive(true);
			this.P7.GetComponent<ParticleSystem>().Play();
			//Firemanager.<Waitp7>c__Iterator7 <Waitp7>c__Iterator = new Firemanager.<Waitp7>c__Iterator7();
			//<Waitp7>c__Iterator.$this = this;
			//return <Waitp7>c__Iterator;
		}

		[DebuggerHidden]
		private IEnumerator Waitp8()
		{
			yield return new WaitForSeconds(0.2f);
			this.Fumo.GetComponent<ParticleSystem>().Stop();
			this.Fumo.SetActive(false);
			this.P8.SetActive(true);
			this.P8.GetComponent<ParticleSystem>().Play();
			//Firemanager.<Waitp8>c__Iterator8 <Waitp8>c__Iterator = new Firemanager.<Waitp8>c__Iterator8();
			//<Waitp8>c__Iterator.$this = this;
			//return <Waitp8>c__Iterator;
		}

		[DebuggerHidden]
		private IEnumerator Waitp9()
		{
			yield return new WaitForSeconds(0.2f);
			this.Fumo.GetComponent<ParticleSystem>().Stop();
			this.Fumo.SetActive(false);
			this.P9.SetActive(true);
			this.P9.GetComponent<ParticleSystem>().Play();
			//Firemanager.<Waitp9>c__Iterator9 <Waitp9>c__Iterator = new Firemanager.<Waitp9>c__Iterator9();
			//<Waitp9>c__Iterator.$this = this;
			//return <Waitp9>c__Iterator;
		}

		[DebuggerHidden]
		private IEnumerator Waitp10()
		{
			yield return new WaitForSeconds(0.2f);
			this.Fumo.GetComponent<ParticleSystem>().Stop();
			this.Fumo.SetActive(false);
			this.P10.SetActive(true);
			this.P10.GetComponent<ParticleSystem>().Play();
			//Firemanager.<Waitp10>c__IteratorA <Waitp10>c__IteratorA = new Firemanager.<Waitp10>c__IteratorA();
			//<Waitp10>c__IteratorA.$this = this;
			//return <Waitp10>c__IteratorA;
		}

		[DebuggerHidden]
		private IEnumerator Waitp11()
		{
			yield return new WaitForSeconds(0.2f);
			this.Fumo.GetComponent<ParticleSystem>().Stop();
			this.Fumo.SetActive(false);
			this.P11.SetActive(true);
			this.P11.GetComponent<ParticleSystem>().Play();
			//Firemanager.<Waitp11>c__IteratorB <Waitp11>c__IteratorB = new Firemanager.<Waitp11>c__IteratorB();
			//<Waitp11>c__IteratorB.$this = this;
			//return <Waitp11>c__IteratorB;
		}

		[DebuggerHidden]
		private IEnumerator Waitp12()
		{
			yield return new WaitForSeconds(0.2f);
			this.Fumo.GetComponent<ParticleSystem>().Stop();
			this.Fumo.SetActive(false);
			this.P12.SetActive(true);
			this.P12.GetComponent<ParticleSystem>().Play();
			//Firemanager.<Waitp12>c__IteratorC <Waitp12>c__IteratorC = new Firemanager.<Waitp12>c__IteratorC();
			//<Waitp12>c__IteratorC.$this = this;
			//return <Waitp12>c__IteratorC;
		}

		[DebuggerHidden]
		private IEnumerator Waitp13()
		{
			yield return new WaitForSeconds(0.2f);
			this.Fumo.GetComponent<ParticleSystem>().Stop();
			this.Fumo.SetActive(false);
			this.P13.SetActive(true);
			this.P13.GetComponent<ParticleSystem>().Play();
			//Firemanager.<Waitp13>c__IteratorD <Waitp13>c__IteratorD = new Firemanager.<Waitp13>c__IteratorD();
			//<Waitp13>c__IteratorD.$this = this;
			//return <Waitp13>c__IteratorD;
		}

		[DebuggerHidden]
		private IEnumerator Waitp14()
		{
			yield return new WaitForSeconds(0.2f);
			this.Fumo.GetComponent<ParticleSystem>().Stop();
			this.Fumo.SetActive(false);
			this.P14.SetActive(true);
			this.P14.GetComponent<ParticleSystem>().Play();
		}

		[DebuggerHidden]
		private IEnumerator Waitp15()
		{
			yield return new WaitForSeconds(0.2f);
			this.Fumo.GetComponent<ParticleSystem>().Stop();
			this.Fumo.SetActive(false);
			this.P15.SetActive(true);
			this.P15.GetComponent<ParticleSystem>().Play();
		}

		[DebuggerHidden]
		private IEnumerator Waitp16()
		{
			yield return new WaitForSeconds(0.2f);
			this.Fumo.GetComponent<ParticleSystem>().Stop();
			this.Fumo.SetActive(false);
			this.P16.SetActive(true);
			this.P16.GetComponent<ParticleSystem>().Play();
		}

		[DebuggerHidden]
		private IEnumerator Waitp17()
		{
			yield return new WaitForSeconds(0.2f);
			this.Fumo.GetComponent<ParticleSystem>().Stop();
			this.Fumo.SetActive(false);
			this.P17.SetActive(true);
			this.P17.GetComponent<ParticleSystem>().Play();
		}

		[DebuggerHidden]
		private IEnumerator Waitp18()
		{
			yield return new WaitForSeconds(0.2f);
			this.Fumo.GetComponent<ParticleSystem>().Stop();
			this.Fumo.SetActive(false);
			this.P18.SetActive(true);
			this.P18.GetComponent<ParticleSystem>().Play();
		}

		[DebuggerHidden]
		private IEnumerator Waitp19()
		{
			yield return new WaitForSeconds(0.2f);
			this.Fumo.GetComponent<ParticleSystem>().Stop();
			this.Fumo.SetActive(false);
			this.P19.SetActive(true);
			this.P19.GetComponent<ParticleSystem>().Play();
		}

		[DebuggerHidden]
		private IEnumerator Waitp1()
		{
			yield return new WaitForSeconds(0.2f);
			this.Fumo.GetComponent<ParticleSystem>().Stop();
			this.Fumo.SetActive(false);
			this.P1.SetActive(true);
			this.P1.GetComponent<ParticleSystem>().Play();
			//Firemanager.<Waitp1>c__Iterator14 <Waitp1>c__Iterator = new Firemanager.<Waitp1>c__Iterator14();
			//<Waitp1>c__Iterator.$this = this;
			//return <Waitp1>c__Iterator;
		}
	}
}
