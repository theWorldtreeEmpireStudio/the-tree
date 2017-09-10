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
    public int currentbranch;

    public int[,] rectangle = {
            { -900,-800,167,226}
        };


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
    public void savebranch(int index)
    {
        Vector3 pos = temp.transform.position;

        if (pos.x>rectangle[index,0]&&pos.x< rectangle[index, 1] && pos.y> rectangle[index, 2] && pos.y< rectangle[index, 3])
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
