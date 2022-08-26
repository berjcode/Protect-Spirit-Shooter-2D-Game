using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScorManager : MonoBehaviour
{

    public static ScorManager Instance { get; private set; }
    public void Awake()
    {
        Instance = this;
    }
    public Text scorText;
   
    public int score;

    public int playerHealth =50;
    public Text healthText;
   



   

    // Update is called once per frame
    void Update()
    {
        PlayerKill();

      
    }



    public void PlayerKill()
   {
    if(playerHealth <=0)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }
   }
}
