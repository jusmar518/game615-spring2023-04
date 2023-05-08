using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ventis : MonoBehaviour
{
    int score = 0;
    // Start is called before the first frame update
<<<<<<< HEAD
   // void Start()
  //  {
  //      score = 0;
        
 //   }

    // Update is called once per frame
  //  void Update()
  //  { if(other.CompareTag("enemy"));
  //       score -= 1;
        
  //  }
}
=======
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
>>>>>>> 4f67d5c3322b4d2a930933fed7f64b7b1ef1326c
