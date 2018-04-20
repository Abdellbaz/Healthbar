using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoHealth1 : MonoBehaviour {
   // public int x =0;
    public float w = 0f;
   

    // Use this for initialization
    void Start () {

        transform.localScale = new Vector3(w, 1, 1);
        //transform.localPosition = new Vector3(x, 0, 0);
    }
	
	// Update is called once per frame
	void Update () {
        
            if (w < 1)
            {
                //x -= 1;
                w += 1f / 50;
            }
            else
            {
                //x = 0;
                w = 0;
            }
            transform.localScale = new Vector3(w, 1, 1);
            //transform.localPosition = new Vector3(x, 0, 0);
    
        }

  

    }
  

