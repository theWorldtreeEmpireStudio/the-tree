using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_move : MonoBehaviour {
    public float movespeed = 10.0f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.RightArrow)&&transform.localPosition.x<405)
        {
            transform.Translate(Vector2.right * Time.deltaTime * movespeed);
        }
        if (Input.GetKey(KeyCode.LeftArrow)&& transform.localPosition.x>-1100)
        {
            transform.Translate(Vector2.left * Time.deltaTime * movespeed);
        }
    }
}
