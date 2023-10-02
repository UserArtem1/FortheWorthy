using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitcherRight : MonoBehaviour
{
    public GameObject ghost;
    
    public Vector3 V3;
    // Start is called before the first frame update
    void Start()
    {
        V3 = this.transform.position;
        
    }

    
    // Update is called once per frame
    void FixedUpdate()
    {
        
    }


   
    public void Invisible()
    {
        
        ghost.transform.position = new Vector3(10000, 10000,10000);
    }


    public void Visible()
    {
        ghost.transform.position = new Vector3(V3.x, V3.y,V3.z);
    }

    public void Call()
    {
        StartCoroutine("StartInvisibleVisible");
    }

    public void StartInvisibleVisible()
    {
        if (ghost.transform.position.x !=10000)
        {
            StartCoroutine("Invisible");
        }
        else
        { 
            StartCoroutine("Visible");
            
        }

    }


}
