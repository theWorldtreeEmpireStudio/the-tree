using UnityEngine;
using System.Collections;

public class WATER : MonoBehaviour
{
	public int water;
	public float water1 = 50.0f;
	public int water2 = 0;
	public int maxwater = 50;
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		water = (int)water1;
		if (water1 > (float)maxwater)
			water1 = (float)maxwater;
		if (water2 == 0)
			water1 += Time.deltaTime * 1.0f;
		if (water2 == 1)
			water1 += Time.deltaTime * 2.0f;
		if (water2 == 3)
			water1 += Time.deltaTime * 3.0f;
		if (water1 < 0.0f) {
			water1 = 0.0000000f;
		}
		/////////////////////////////////////////////////////////////////////////////////
		/// weather system                                                           ///
		////////////////////////////////////////////////////////////////////////////////
		if (this.gameObject.GetComponent<WEATHER> ().weather == 1)
			water1 -= Time.deltaTime*1.5f;
		if (this.gameObject.GetComponent<WEATHER> ().weather == 2)
			water1 -= Time.deltaTime*1.5f;
		if (this.gameObject.GetComponent<WEATHER> ().weather == 3)
			water1 -= Time.deltaTime*1.5f;
		if (this.gameObject.GetComponent<WEATHER> ().weather == 4)
			water1 -= Time.deltaTime*1.5f;
		if (this.gameObject.GetComponent<WEATHER> ().weather == 5)
			water1 += Time.deltaTime;
		if (this.gameObject.GetComponent<WEATHER> ().weather == 6)
			water1 += Time.deltaTime;
		if (this.gameObject.GetComponent<WEATHER> ().weather == 7)
			water1 -= Time.deltaTime;
		if (this.gameObject.GetComponent<WEATHER> ().weather == 8)
			water1 -= Time.deltaTime;
		if (this.gameObject.GetComponent<WEATHER> ().weather == 9)
			water1 += Time.deltaTime * 3.0f;
		if (this.gameObject.GetComponent<WEATHER> ().weather == 10)
			water1 -= Time.deltaTime;
	}
}

