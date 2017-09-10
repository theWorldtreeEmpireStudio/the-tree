using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_move : MonoBehaviour {
    public float movespeed = 400.0f;
    public bool jnmb = false;
    GameObject scr;
    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update() {

        if (jnmb == false)
        {
            if (Input.GetKey(KeyCode.RightArrow) && transform.localPosition.x < 2450)
            {
                transform.Translate(Vector2.right * Time.deltaTime * movespeed);
            }
            if (Input.GetKey(KeyCode.LeftArrow) && transform.localPosition.x > -1350)
            {
                transform.Translate(Vector2.left * Time.deltaTime * movespeed);
            }
            if (Input.GetKey(KeyCode.DownArrow) && transform.localPosition.y > -211)
            {
                transform.Translate(Vector2.down * Time.deltaTime * movespeed);
            }
            if (Input.GetKey(KeyCode.UpArrow) && transform.localPosition.y < 690)
            {
                transform.Translate(Vector2.up * Time.deltaTime * movespeed);
            }
            if (Input.GetAxis("Mouse ScrollWheel") < 0 && transform.localPosition.z > -970)
            {
                transform.Translate(Vector3.back * Time.deltaTime * movespeed * 0.5f);
            }
            if (Input.GetAxis("Mouse ScrollWheel") > 0 && transform.localPosition.z < -351)
            {
                transform.Translate(Vector3.forward * Time.deltaTime * movespeed * 2);
            }
        }else {

        }
    }
}
