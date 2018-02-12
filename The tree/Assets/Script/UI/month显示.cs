using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class month显示 : MonoBehaviour {
    public int month;
    GameObject scr;
    // Use this for initialization
    void Start () {
        scr = GameObject.FindGameObjectWithTag("fscontrol");
    }
	
	// Update is called once per frame
	void Update () {
        this.GetComponent<Text>().text = scr.GetComponent<TIME>().month.ToString();
    }
}
