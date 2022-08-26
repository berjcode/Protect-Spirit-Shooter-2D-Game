using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
   
  
    public float speed;

    private Transform playerPos;
    private int healt=5;

    void Start()
    {
        playerPos= GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position,
        playerPos.position,
        speed * Time.deltaTime
        );


        if(healt <= 0)
        {
            Destroy(gameObject);
            ScorManager.Instance.score++;
            ScorManager.Instance.scorText.text =  ScorManager.Instance.score.ToString();
        }
    }


    private void OnTriggerEnter2D(Collider2D  col)
    {
        if(col.tag =="Bullet")
        {
            healt--;
        }

        
    }

/*
    public void Killer()
    {
        if(healt == 0)
        {
            Destroy(gameObject);
        }

    }
    */

}
