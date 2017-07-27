using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class utility : MonoBehaviour{
    public GameObject par;
    public GameObject firstscene;
    public GameObject tree;
    public GameObject branch;
    public GameObject branch2;
    LinkedList<GameObject> branches;
    GameObject temp;
    GameObject temp2;
    bool issettingbranch = false;
    SphereCollider k;
    public int branchleft = 0;

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
    public void createbranch()
    {
        if (branchleft>0)
        {
            issettingbranch = true;
            temp = Instantiate(branch);
            temp.transform.position = tree.transform.position;
        }
        
    }
    public void savebranch()
    {
        Vector3 pos = temp.transform.position;
        if (pos.x>-707&&pos.x<-639&&pos.y>133&&pos.y<183)
        {
            temp2 = Instantiate(branch2);
            temp2.transform.position = new Vector3(temp.transform.position.x, temp.transform.position.y);
            branchleft--;
            Destroy(temp);
            temp = null;

        }
        else
        {
            Destroy(temp);
            temp = null;
        }
        issettingbranch = false;
    }
}
