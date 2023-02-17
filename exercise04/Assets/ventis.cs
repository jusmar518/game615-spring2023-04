using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ventis : MonoBehaviour
{
    int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;

    }

    // Update is called once per frame
    void Update()
    {


    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("enemy"))
        {
            score -= 1;
        }
    }
}