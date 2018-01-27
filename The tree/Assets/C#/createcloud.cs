using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createcloud : MonoBehaviour {
    public GameObject c1;
    public GameObject c2;
    public GameObject c3;
    public GameObject c4;
    public GameObject c5;
    private LinkedList<Object> list;
    System.Random rand;

	// Use this for initialization
	void Start () {
        rand = new System.Random(System.DateTime.UtcNow.Millisecond);
        list  = new LinkedList<Object>();
        for (int i = 0; i < 20; i++)
        {
            createat(rand.Next(-500, 3000), rand.Next(350, 1200));
        }
        InvokeRepeating("create", 0, 4);
    }
	
	void createat(int x,int y)
    {
        GameObject temp;
        switch (rand.Next(0, 5))
        {
            case 1:
                temp = Instantiate(c1);
                list.AddLast(temp);
                temp.transform.localPosition = new Vector3(x, y, 0);
                break;
            case 2:
                temp = Instantiate(c2);
                list.AddLast(temp);
                temp.transform.localPosition = new Vector3(x, y, 0);
                break;
            case 3:
                temp = Instantiate(c3);
                list.AddLast(temp);
                temp.transform.localPosition = new Vector3(x, y, 0);
                break;
            case 4:
                temp = Instantiate(c4);
                list.AddLast(temp);
                temp.transform.localPosition = new Vector3(x, y, 0);
                break;
            default:
                temp = Instantiate(c5);
                list.AddLast(temp);
                temp.transform.localPosition = new Vector3(x, y, 0);
                break;
        }
    }
    void create()
    {
        Destroy((GameObject)list.First.Value);
        list.RemoveFirst();
        createat(2550, rand.Next(350, 1200));
    }
}
