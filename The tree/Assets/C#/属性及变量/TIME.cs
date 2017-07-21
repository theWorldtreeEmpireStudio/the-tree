using UnityEngine;
using System.Collections;

public class TIME : MonoBehaviour
{
	public int month;
	public float month1 = 1.0f;
	public int year = 0;
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		month = (int)month1;
		month1 += Time.deltaTime * 0.0666666667f;
		if(month1 > 12.0f){
			year += 1;
			month1 = 1.0f;
			month = 1;
		}
	}
}

