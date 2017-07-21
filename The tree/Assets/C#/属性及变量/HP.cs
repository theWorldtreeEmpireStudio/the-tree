using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour {

	public int hp;
	public float hp1 = 20.0f;
	public int hp2 = 0;
	public int maxhp = 20;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		hp = (int)hp1;
		if (hp1 > (float)maxhp)
			hp1 = (float)maxhp;
		if (hp2 == 0)
			hp1 += Time.deltaTime;
		if (hp2 == 1)
			hp1 += Time.deltaTime * 2.0f;
		if (hp2 == 2)
			hp1 += Time.deltaTime * 3.0f;
		if (hp1 < 0.0f) {
			hp1 = 0.0f;
		}
		/////////////////////////////////////////////////////////////////////////////////
		/// weather system                                                           ///
		////////////////////////////////////////////////////////////////////////////////
		if (this.gameObject.GetComponent<WEATHER> ().weather == 5)
			hp1 -= Time.deltaTime*1.5f;
		if (this.gameObject.GetComponent<WEATHER> ().weather == 6)
			hp1 -= Time.deltaTime*1.5f;
		if (this.gameObject.GetComponent<WEATHER> ().weather == 9)
			hp1 -= Time.deltaTime*3.0f;
	}
}
