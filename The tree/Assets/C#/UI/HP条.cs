using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class HP条 : MonoBehaviour {
    GameObject scr;
	// Use this for initialization
	void Start () {
        scr = GameObject.FindGameObjectWithTag("fscontrol");
    }
	
	// Update is called once per frame
	void Update () {
		GetComponent<RectTransform> ().sizeDelta = new Vector2 ((float)scr.GetComponent<HP> ().hp / (float)scr.GetComponent<HP> ().maxhp * 164, 21);
	}
}
