using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health2 : MonoBehaviour
{
    public int x = 0;
    public float w = 1f;
    public int t = 0;
    public

    // Use this for initialization
    void Start()
    {
        transform.localScale = new Vector3(w, 1, 1);
        transform.localPosition = new Vector3(x, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        

    }
    public void b2()
    {
        if (x > -50 && w > 0 && t == 0)
        {
            x -= 1;
            w -= 1f / 50;
            t = 0;
        }
        else
        {
            x += 1;
            w += 1f / 50;
            t = 1;
            if (x == 0 && w == 1f)
            {
                t = 0;
            }

        }
        transform.localScale = new Vector3(w, 1, 1);
        transform.localPosition = new Vector3(x, 0, 0);
    }
}
