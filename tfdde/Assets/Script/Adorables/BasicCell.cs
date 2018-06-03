using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicCell : MonoBehaviour
{

	public int _count;
	public BasicCellType celltype;

}

public enum BasicCellType
{
	Coin,
	Ball,
	CircleCell,
	ZhengFangXing,
	PolygonCell,
	SanJiaoXingf,
}