using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alienlaunching : MonoBehaviour
{
<<<<<<< HEAD
    
    public GameObject alienz;
    public GameObject cow;


=======
   public GameObject alienz;
    // Start is called before the first frame update
    void Start()
    {
        
    }
>>>>>>> 4f67d5c3322b4d2a930933fed7f64b7b1ef1326c

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