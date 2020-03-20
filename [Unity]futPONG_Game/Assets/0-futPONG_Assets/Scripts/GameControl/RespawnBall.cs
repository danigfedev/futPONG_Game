using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnBall : MonoBehaviour {


    //public GameObject BallPrefab;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Instantiate(BallPrefab);
        GameObject NewBall = Instantiate(collision.gameObject);
        if (transform.position.x > 0)//Local player scores
        {
            NewBall.transform.position = new Vector2(5.74f, 0);
        }
        else if (transform.position.x < 0)//Away player scores
        {
            NewBall.transform.position = new Vector2(-5.74f, 0);
        }
        
        Destroy(collision.gameObject);//Destroy old ball
    }
}
