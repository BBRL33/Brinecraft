using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class droppedblock : MonoBehaviour
{
    public GameObject prefab;
    public Transform Itemholder;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Instantiate(prefab, Itemholder);
            Debug.Log("Ouch! You picked me up");
            //Destroy(gameObject);
        }
    }
}
