using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GP显示 : MonoBehaviour
{
	public int gp;
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		gp = GameObject.Find("游戏管理").GetComponent<GP>().gp;
		Debug.Log ("gp=" + gp);
		this.GetComponent<Text> ().text = gp.ToString();
	}
}

