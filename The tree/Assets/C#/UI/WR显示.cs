using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WR显示 : MonoBehaviour
{
	public int water;
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		water = GameObject.Find("游戏管理").GetComponent<WATER>().water;
		Debug.Log ("water=" + water);
		this.GetComponent<Text> ().text = water.ToString();
	}
}

