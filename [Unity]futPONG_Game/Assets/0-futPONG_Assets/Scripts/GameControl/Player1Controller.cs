using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Controller : MonoBehaviour {

    #region Private_variables

    private Rigidbody2D rb2d;
    private float speed = 8f;
    private Vector2 PlayerVelocity;

    #endregion


    // Use this for initialization
    void Start () {

        rb2d = GetComponent<Rigidbody2D>();//Getting the rigid body 2d of the object with this script attached
        PlayerVelocity = new Vector2(0, speed);//Movement along y axis

    }
	
	// Update is called once per frame
	void FixedUpdate () {//Do this in Update if something wrong happens

        //Programming the movement:
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb2d.velocity = PlayerVelocity;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            rb2d.velocity = -PlayerVelocity;
        }
        else
        {
            rb2d.velocity = new Vector2(0, 0);//do not move the player
        }


	}
}
