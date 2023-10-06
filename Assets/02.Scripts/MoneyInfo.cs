using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyInfo : MonoBehaviour
{
	// 원 단위로 금액 기록
	private float m_won = 0;

	public float manWon
	{
		get { return m_won * 0.0001f; }
		set
		{
			if (value <= 0) m_won = 0;
			else m_won = value * 10000f;
		}
	}

	public float cheonWon
	{
		get { return m_won * 0.001f; }
		set
		{
			if (value <= 0) m_won = 0;
			else m_won = value * 1000f;
		}
	}

	public float won
	{
		get { return m_won; }
		set
		{
			if (value <= 0) m_won = 0;
			else m_won = value;
		}
	}
}
