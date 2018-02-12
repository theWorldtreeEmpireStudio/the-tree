using UnityEngine;
using System.Collections;

//伐木工
public class WoodCutter : MovingEntity
{
	// Use this for initialization
	void Start ()
	{
		m_direction = new Vector3 (-1, 0, 0);
	}
	
	// Update is called once per frame
	void Update ()
	{
		Move (); // 移动
	}
}

