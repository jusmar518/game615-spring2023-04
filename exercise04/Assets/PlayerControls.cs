using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
<<<<<<< HEAD:exercise04/Assets/PlayerControls.cs
    float forwardSpeed = 35;
    float rotateSpeed = 30;
    [SerializeField] float moveSpeed = 10f;
=======
    float forwardSpeed = 50;
    float rotateSpeed = 20;
    public int score = 0;
    public bool lose = false;
>>>>>>> 4f67d5c3322b4d2a930933fed7f64b7b1ef1326c:exercise04/Assets/PlayerController.cs
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD:exercise04/Assets/PlayerControls.cs
        gameObject.transform.Rotate(0, rotateSpeed * Time.deltaTime, 0, Space.Self);
        gameObject.transform.Translate(transform.forward * forwardSpeed * Time.deltaTime, Space.World);
=======
        if (Input.GetKey(KeyCode.Space))
        {
            gameObject.transform.Rotate(0, rotateSpeed * Time.deltaTime, 0, Space.Self);
            gameObject.transform.Translate(transform.forward * forwardSpeed * Time.deltaTime, Space.World);
        }

    }
>>>>>>> 4f67d5c3322b4d2a930933fed7f64b7b1ef1326c:exercise04/Assets/PlayerController.cs
    }

    void Moving()
    {
        float xValue = Input.GetAxis("Horizontal")*Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical")*Time.deltaTime * moveSpeed;

        transform.Translate(xValue,0,zValue);
    }
}

