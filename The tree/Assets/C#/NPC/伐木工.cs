using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 伐木工 : NPC属性 {

    public int gm;
    public int yd;
    public int hd;

    private void Start()
    {
        hp = 20.0f;
    }
    void FixedUpdate(){
		transform.Translate(Vector2.left*Time.deltaTime*maxspeed);
	}
   void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "灌木丛") {
            if (gm == 0) {
                maxspeed = maxspeed * 0.8f;
            }
            if (gm == 1) {
                maxspeed = maxspeed * 0.5f;
            }
            if (gm == 2) {
                maxspeed = maxspeed * 0.2f;
            }
            if (gm == 3) {
                maxspeed = maxspeed * 0.2f;
                hp -= Time.deltaTime*0.5f;
            }
            if (gm == 4) {
                maxspeed = 0;
                hp -= Time.deltaTime*0.5f;
            }
            if (gm == 5) {
                maxspeed = 0;
                hp -= Time.deltaTime;
            }
        }//碰到灌木丛的效果
        if (collider.tag == "叶堆") {
            if (yd == 0) {
                maxspeed = maxspeed * Time.deltaTime * 0.85f;
                hd = Random.Range(1, 10);
                if (hd == 3) {
                    hp = 0;
                    Debug.Log("hd=" + hd);
                }
            }
            if (yd == 1) {
                maxspeed = maxspeed * Time.deltaTime * 0.75f;
                hd = Random.Range(1, 5);
                if (hd == 3) {
                    hp = 0;
                    Debug.Log("hd=" + hd);
                }
            }
            if (yd == 2) {
                maxspeed = maxspeed * Time.deltaTime * 0.5f;
                hd = Random.Range(1, 2);
                if (hd == 2) {
                    hp = 0;
                    Debug.Log("hd=" + hd);
                }
            }
        }//碰到叶堆的效果
    }
}
