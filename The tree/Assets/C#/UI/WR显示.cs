using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WR显示 : MonoBehaviour
{
	public int water;
    GameObject scr;
    // Use this for initialization
    void Start ()
	{
        scr = GameObject.FindGameObjectWithTag("fscontrol");

    }
	
	// Update is called once per frame
	void Update ()
	{
		this.GetComponent<Text> ().text = scr.GetComponent<WATER>().water.ToString();
	}
}

