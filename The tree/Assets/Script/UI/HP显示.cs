using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HP显示 : MonoBehaviour {
	public int hp;
    GameObject scr;

    void Start () {
        scr = GameObject.FindGameObjectWithTag("fscontrol");
    }
	
	// Update is called once per frame
	void Update () {
		this.GetComponent<Text> ().text = scr.GetComponent<HP>().hp.ToString();
    }
}
