using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alienlaunching : MonoBehaviour
{
    
    public GameObject alienz;
    public GameObject cow;



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            for (int i = 0; i < 3; i++)
            {
                GameObject car = Instantiate(alienz, gameObject.transform.position, Quaternion.identity);
                float rotXAmount = Random.Range(-89, -10);
                float rotYAmount = Random.Range(0, 360);
                alienz.transform.Rotate(rotXAmount, rotYAmount, 0);
                Rigidbody rb = alienz.GetComponent<Rigidbody>();
                rb.AddForce(alienz.transform.forward * 10);

                
            }
    
}
    
}
}