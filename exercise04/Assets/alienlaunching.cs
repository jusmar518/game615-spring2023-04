using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alienlaunching : MonoBehaviour
{
   public GameObject alienz;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {    if (Input.GetKeyDown(KeyCode.Space))
        {
            
            for (int i = 0; i < 10; i++)
            {
                GameObject alien = Instantiate(alienz, gameObject.transform.position, Quaternion.identity);
                float rotXAmount = Random.Range(-75, -10);
                float rotYAmount = Random.Range(0, 360);
                alien.transform.Rotate(rotXAmount, rotYAmount, 0);
                Rigidbody rb = alien.GetComponent<Rigidbody>();
                rb.AddForce(alien.transform.forward * 1000);

                Destroy(alien, 2f);
            }
        
    }
}
}
