using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//所有移动物体的基类
public class MovingEntity : BaseEntity {

	public float m_speed = 1.0f; //速度
	public Vector3 m_direction; //方向

	// Use this for initialization
	void Start () {
		m_direction = new Vector3 (-1, 0,0); //向左边移动
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//移动
	protected void Move()
	{
		this.transform.position += m_speed * m_direction * Time.deltaTime;
	}
}
