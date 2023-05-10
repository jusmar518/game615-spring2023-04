using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class alienScore : MonoBehaviour
{ 
    int score = 0;
    public TMP_Text scoreText;
    // Start is called before the first frame update
    void Start()
    {  
       scoreText.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

   public void OnTriggerEnter(Collider other)
     {
        if (other.CompareTag("cow"))
        {
            Destroy(other.gameObject);
            score += 1;
            scoreText.text = score.ToString();


        }

    if (score > 6)
    {SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);}

}
}
