using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health3 : MonoBehaviour {

    // public int x =0;
    public float w = 0f;


    // Use this for initialization
    void Start()
    {

        transform.localScale = new Vector3(w, 1, 1);
        //transform.localPosition = new Vector3(x, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {

     

    }
    public void b3()
    {
        if (w > 0)
        {
            //x -= 1;
            w -= 1f / 50;
        }
        else
        {
            //x = 0;
            w = 1;
        }
        transform.localScale = new Vector3(w, 1, 1);
        //transform.localPosition = new Vector3(x, 0, 0);
    }



}


