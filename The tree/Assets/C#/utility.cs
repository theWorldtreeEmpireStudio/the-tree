using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class utility : MonoBehaviour{
    public GameObject par;
    public GameObject firstscene;

	// Use this for initialization
	public void exit()
    {
        Application.Quit();
    }
    public void tofirstscene()
    {
        Instantiate(firstscene);
        Destroy(par);
        
    }
}
