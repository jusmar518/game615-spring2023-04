using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    float forwardSpeed = 35;
    float rotateSpeed = 30;
    [SerializeField] float moveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(0, rotateSpeed * Time.deltaTime, 0, Space.Self);
        gameObject.transform.Translate(transform.forward * forwardSpeed * Time.deltaTime, Space.World);
    }

    void Moving()
    {
        float xValue = Input.GetAxis("Horizontal")*Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical")*Time.deltaTime * moveSpeed;

        transform.Translate(xValue,0,zValue);
    }
}

