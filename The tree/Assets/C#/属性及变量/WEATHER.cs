using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WEATHER : MonoBehaviour {

	public int weather = 1;
	public int month;
	public int tq1;
	public int tq2 = 4;
	// Use this for initialization

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		month = this.gameObject.GetComponent<TIME> ().month;
		tq1 = month;
		if (month == 4) {
			if (tq1 == tq2)weather = Random.Range (1, 10);
			tq2 = 8;
		}
		if (month == 8) {
			if (tq1 == tq2) {
				weather = Random.Range (1, 10);
				tq2 = 12;
			}
		}
		if (month == 12) {
			if (tq1 == tq2) {
				weather = Random.Range (1, 10);
				tq2 = 4;
			}
		}
	}
}