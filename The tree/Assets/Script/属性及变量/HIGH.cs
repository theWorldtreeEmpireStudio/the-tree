using UnityEngine;
using System.Collections;

public class HIGH : MonoBehaviour
{
	public int high;
	public float high1 = 0.1f;
	public int high2 = 0;
	public float hp;
	public float water;
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		high = (int)high1;
        /////////////////////////////////////////////////////////////////////////////////
		/// weather system                                                           ///
		//////////////////////////////////////////////////////////////////////////////// 
		hp = this.gameObject.GetComponent<HP> ().hp1;
		water = this.gameObject.GetComponent<WATER> ().water1;
		if(high2 == 0){
			if (this.gameObject.GetComponent<WEATHER> ().weather == 1)
				high1 += hp * 0.003f * Time.deltaTime + water * 0.002f * Time.deltaTime;
			if (this.gameObject.GetComponent<WEATHER> ().weather == 2)
				high1 += hp * 0.003f * Time.deltaTime + water * 0.002f * Time.deltaTime;
			if (this.gameObject.GetComponent<WEATHER> ().weather == 3)
				high1 += hp * 0.003f * Time.deltaTime + water * 0.002f * Time.deltaTime;
			if (this.gameObject.GetComponent<WEATHER> ().weather == 4)
				high1 += hp * 0.003f * Time.deltaTime + water * 0.002f * Time.deltaTime;
			if (this.gameObject.GetComponent<WEATHER> ().weather == 5)
				high1 += hp * 0.001f * Time.deltaTime + water * 0.003f * Time.deltaTime;
			if (this.gameObject.GetComponent<WEATHER> ().weather == 6)
				high1 += hp * 0.001f * Time.deltaTime + water * 0.003f * Time.deltaTime;
			if (this.gameObject.GetComponent<WEATHER> ().weather == 7)
				high1 += hp * 0.002f * Time.deltaTime + water * 0.002f * Time.deltaTime;
			if (this.gameObject.GetComponent<WEATHER> ().weather == 8)
				high1 += hp * 0.002f * Time.deltaTime + water * 0.002f * Time.deltaTime;
			if (this.gameObject.GetComponent<WEATHER> ().weather == 9)
				high1 += hp * 0.001f * Time.deltaTime + water * 0.005f * Time.deltaTime;
			if (this.gameObject.GetComponent<WEATHER> ().weather == 10)
				high1 += hp * 0.001f * Time.deltaTime + water * 0.001f * Time.deltaTime;
		}
		if(high2 == 1){
			if (this.gameObject.GetComponent<WEATHER> ().weather == 1)
				high1 += hp * 0.004f * Time.deltaTime + water * 0.003f * Time.deltaTime;
			if (this.gameObject.GetComponent<WEATHER> ().weather == 2)
				high1 += hp * 0.004f * Time.deltaTime + water * 0.003f * Time.deltaTime;
			if (this.gameObject.GetComponent<WEATHER> ().weather == 3)
				high1 += hp * 0.004f * Time.deltaTime + water * 0.003f * Time.deltaTime;
			if (this.gameObject.GetComponent<WEATHER> ().weather == 4)
				high1 += hp * 0.004f * Time.deltaTime + water * 0.003f * Time.deltaTime;
			if (this.gameObject.GetComponent<WEATHER> ().weather == 5)
				high1 += hp * 0.002f * Time.deltaTime + water * 0.004f * Time.deltaTime;
			if (this.gameObject.GetComponent<WEATHER> ().weather == 6)
				high1 += hp * 0.002f * Time.deltaTime + water * 0.004f * Time.deltaTime;
			if (this.gameObject.GetComponent<WEATHER> ().weather == 7)
				high1 += hp * 0.003f * Time.deltaTime + water * 0.003f * Time.deltaTime;
			if (this.gameObject.GetComponent<WEATHER> ().weather == 8)
				high1 += hp * 0.003f * Time.deltaTime + water * 0.003f * Time.deltaTime;
			if (this.gameObject.GetComponent<WEATHER> ().weather == 9)
				high1 += hp * 0.002f * Time.deltaTime + water * 0.006f * Time.deltaTime;
			if (this.gameObject.GetComponent<WEATHER> ().weather == 10)
				high1 += hp * 0.002f * Time.deltaTime + water * 0.002f * Time.deltaTime;
		}
		if(high2 == 2){
			if (this.gameObject.GetComponent<WEATHER> ().weather == 1)
				high1 += hp * 0.005f * Time.deltaTime + water * 0.004f * Time.deltaTime;
			if (this.gameObject.GetComponent<WEATHER> ().weather == 2)
				high1 += hp * 0.005f * Time.deltaTime + water * 0.004f * Time.deltaTime;
			if (this.gameObject.GetComponent<WEATHER> ().weather == 3)
				high1 += hp * 0.005f * Time.deltaTime + water * 0.004f * Time.deltaTime;
			if (this.gameObject.GetComponent<WEATHER> ().weather == 4)
				high1 += hp * 0.005f * Time.deltaTime + water * 0.004f * Time.deltaTime;
			if (this.gameObject.GetComponent<WEATHER> ().weather == 5)
				high1 += hp * 0.003f * Time.deltaTime + water * 0.005f * Time.deltaTime;
			if (this.gameObject.GetComponent<WEATHER> ().weather == 6)
				high1 += hp * 0.003f * Time.deltaTime + water * 0.005f * Time.deltaTime;
			if (this.gameObject.GetComponent<WEATHER> ().weather == 7)
				high1 += hp * 0.004f * Time.deltaTime + water * 0.004f * Time.deltaTime;
			if (this.gameObject.GetComponent<WEATHER> ().weather == 8)
				high1 += hp * 0.004f * Time.deltaTime + water * 0.004f * Time.deltaTime;
			if (this.gameObject.GetComponent<WEATHER> ().weather == 9)
				high1 += hp * 0.003f * Time.deltaTime + water * 0.007f * Time.deltaTime;
			if (this.gameObject.GetComponent<WEATHER> ().weather == 10)
				high1 += hp * 0.003f * Time.deltaTime + water * 0.003f * Time.deltaTime;
		}
	}
}

