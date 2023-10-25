using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectorcontroller : MonoBehaviour
{
    public GameObject[] selectors;
    public int lastpressednum;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 1; i <= 9; i++)
        {
            if (Input.GetKeyDown(i.ToString()))
            {
                lastpressednum = i - 1;
            }
        }
        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            lastpressednum += lastpressednum == 8 ? -8 : 1;
        }
        else if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            lastpressednum -= lastpressednum == 0 ? -8 : 1;
        }
        for (int index = 0; index <= 8; index++)
        {
            if (index != lastpressednum)
            {
                selectors[index].gameObject.SetActive(false);
            }
            else
            {
                selectors[lastpressednum].gameObject.SetActive(true);
            }
        }
    }
}
