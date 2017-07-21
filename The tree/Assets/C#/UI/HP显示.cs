using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HP显示 : MonoBehaviour {
	public int hp;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		hp = GameObject.Find("游戏管理").GetComponent<HP>().hp;
		Debug.Log ("hp=" + hp);
		this.GetComponent<Text> ().text = hp.ToString();
	}
}
