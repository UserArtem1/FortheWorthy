using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitcherLeft : MonoBehaviour
{
    public GameObject ghost2;

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

        ghost2.transform.position = new Vector3(10000, 10000, 10000);
    }


    public void Visible()
    {
        ghost2.transform.position = new Vector3(V3.x, V3.y, V3.z);
    }

    public void Call()
    {
        StartCoroutine("StartInvisibleVisible");
    }

    public void StartInvisibleVisible()
    {
        if (ghost2.transform.position.x != 10000)
        {
            StartCoroutine("Invisible");
        }
        else
        {
            StartCoroutine("Visible");

        }

    }


}
