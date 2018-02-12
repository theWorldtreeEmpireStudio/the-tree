using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class year显示 : MonoBehaviour {
    public int year;
    GameObject scr;
    // Use this for initialization
    void Start () {
        scr = GameObject.FindGameObjectWithTag("fscontrol");
    }
	
	// Update is called once per frame
	void Update () {
        this.GetComponent<Text>().text = scr.GetComponent<TIME>().year.ToString();
    }
}
