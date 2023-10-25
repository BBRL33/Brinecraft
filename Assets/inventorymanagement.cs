using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventorymanagement : MonoBehaviour
{
    GameObject itemmodel;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(itemmodel, gameObject.transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
