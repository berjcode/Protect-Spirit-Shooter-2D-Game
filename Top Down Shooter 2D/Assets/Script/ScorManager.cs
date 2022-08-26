using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScorManager : MonoBehaviour
{

    public static ScorManager Instance { get; private set; }
    public void Awake()
    {
        Instance = this;
    }
    public Text scorText;

    public int score;
   

   

    // Update is called once per frame
    void Update()
    {
        
    }
}
