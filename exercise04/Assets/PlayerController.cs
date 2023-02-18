using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float forwardSpeed = 50;
    float rotateSpeed = 20;
    public int score = 0;
    public bool lose = false;
    // Start is called before the first frame update
    void Start()
    {score = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            gameObject.transform.Rotate(0, rotateSpeed * Time.deltaTime, 0, Space.Self);
            gameObject.transform.Translate(transform.forward * forwardSpeed * Time.deltaTime, Space.World);
        }

    }
    }

