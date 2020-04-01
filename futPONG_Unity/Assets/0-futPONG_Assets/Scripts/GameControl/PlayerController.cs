
using UnityEngine;

public class PlayerController : MonoBehaviour {

    #region ***** Public fields *****

    public enum playerList {
        Player1 = 1,
        Player2 = 2
    };
    public playerList selectedPlayer = playerList.Player1;
    public float playerSpeed = 8f;

    #endregion

    #region ***** Private fields *****

    private Rigidbody2D rb2d;
    private Vector2 PlayerVelocity;

    #endregion


    void Start ()
    {

        rb2d = GetComponent<Rigidbody2D>();//Getting the rigid body 2d of the object with this script attached

    }
	
	void FixedUpdate ()
    {

        //Player movement:
        float input = 0; ;
        if(selectedPlayer == playerList.Player1)
        {
            //Get vertical Input
            input = Input.GetAxisRaw("Vertical");
        }
        else if(selectedPlayer == playerList.Player2)
        {
            //Get vertical2 Input
            input = Input.GetAxisRaw("Vertical2");
        }
        rb2d.velocity = new Vector2(rb2d.velocity.x, input * playerSpeed);

	}
}
