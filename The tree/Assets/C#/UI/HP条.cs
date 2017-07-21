using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class HP条 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<RectTransform> ().sizeDelta = new Vector2 ((float)GameObject.Find ("游戏管理").GetComponent<HP> ().hp / (float)GameObject.Find ("游戏管理").GetComponent<HP> ().maxhp * 164, 21);
	}
}
