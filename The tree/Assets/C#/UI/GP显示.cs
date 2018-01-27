using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GP显示 : MonoBehaviour
{
    GameObject scr;
	// Use this for initialization
	void Start ()
	{
        scr = GameObject.FindGameObjectWithTag("fscontrol");
    }
	
	// Update is called once per frame
	void Update ()
	{
		this.GetComponent<Text> ().text = scr.GetComponent<GP>().gp.ToString();
	}
}

