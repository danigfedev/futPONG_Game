using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Android_PlayerController : MonoBehaviour
{
    public float playerSpeed = 5;

    #region ***** Private fields *****

    private Rigidbody2D rb;
    private bool leftButtonPressed = false;
    private bool rightButtonPressed = false;
    
    #endregion

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Vector2 horDirection = GetinputAxisDirection();
        rb.velocity = new Vector2(horDirection.x * playerSpeed, rb.velocity.y);

    }

    //Description: Handles Left button's Pointer UDownp event
    public void LeftButton_PointerDown()
    {
        leftButtonPressed = true;
    }

    //Description: Handles Left button's Pointer Up event
    public void LeftButton_PointerUp()
    {
        leftButtonPressed = false;
    }

    //Description: Handles Right button's Pointer Down Event
    public void RightButton_PointerDown()
    {
        rightButtonPressed = true;
    }

    //Description: Handles Right button's Pointer Up event
    public void RightButton_PointerUp()
    {
        rightButtonPressed = false;
    }


    //Description: Checks control buttons' status and calculates player's horizontal direction
    //Outputs: horizontal direction.
    private Vector2 GetinputAxisDirection()
    {
        if (leftButtonPressed) return new Vector2(-1, 0);
        else if (rightButtonPressed) return new Vector2(1, 0);
        return new Vector2(0, 0);
   
    }
}
