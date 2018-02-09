using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//所有游戏物体的基类
public class BaseEntity : MonoBehaviour {	
	
	public float m_radius = 1.0f; //半径 
	public int m_hp = 1; //血量

	public float Radius
	{
		get { return m_radius; }
		set { m_radius = value; }
	}
	void Start()
	{
		
	}

	//物体名字
	public string getName()
	{
		return gameObject.name;
	}

	//物体id
	public int getID(){
		return gameObject.GetInstanceID();
	}
}
