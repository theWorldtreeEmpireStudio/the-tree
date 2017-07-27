using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class branch : MonoBehaviour {
    public GameObject a;
    Vector3 offset;
    public bool set = true;
    private void OnMouseDown()
    {
        if (set)
        {
            offset = a.transform.position - Input.mousePosition;
        }
        
    }
    private void OnMouseDrag()
    {
        if (set)
        {
            a.transform.position = Input.mousePosition + offset;
        }
        
    }




}
