using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 伐木工 : NPC属性 {
	void FixedUpdate(){
		transform.Translate(Vector2.left*Time.deltaTime*maxspeed);
	}
}
