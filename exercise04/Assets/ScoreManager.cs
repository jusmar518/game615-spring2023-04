using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public Text Scoretext;
    

    int score = 0;
    
    
    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        Scoretext.text = score.ToString() + "POINTS";
        
    }

   public void AddPoint() 
    {
        score += 1;
        Scoretext.text = score.ToString() + "POINTS";
    }
}
