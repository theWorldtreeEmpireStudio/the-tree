using UnityEngine;
using System.Collections;

public class GP : MonoBehaviour
{

	public int gp;
	public float gp1 = 0.0f;
	public int gp2 = 0;

	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		gp = (int)gp1;
		if (gp2 == 0)
			gp1 += Time.deltaTime;
		if (gp2 == 1)
			gp1 += Time.deltaTime * 2.0f;
		if (gp2 == 2)
			gp1 += Time.deltaTime * 3.0f;
		if (gp1 < 0.0f)
			gp1 = 0.0f;
		if (this.gameObject.GetComponent<WEATHER> ().weather == 7)
			gp1 -= Time.deltaTime;
	}
}

