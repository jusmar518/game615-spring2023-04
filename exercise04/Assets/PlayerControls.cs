using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public float forwardSpeed = 35f;
    public float rotateSpeed = 90f;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rotate = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * Time.deltaTime * rotateSpeed * rotate);

        float move = Input.GetAxis("Vertical");
        transform.position += transform.forward * Time.deltaTime * forwardSpeed * move;

        gameObject.transform.Rotate(0, rotateSpeed * Time.deltaTime, 0, Space.Self);
       // gameObject.transform.Translate(transform.forward * forwardSpeed * Time.deltaTime, Space.World);

       
       if (Input.GetKey(KeyCode.D))
        {
            transform.position -= Vector3.up * Time.deltaTime * forwardSpeed;
        }
    }

   
}

