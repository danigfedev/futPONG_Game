using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour {


    #region Private_variables

    private Rigidbody2D rb2d;
    private SpriteRenderer renderer;
    private float WaitTime = 0.3f;
    private float HitForce = 6f;

    #endregion

    // Use this for initialization
    void Start () {

        rb2d = GetComponent<Rigidbody2D>();
        renderer = GetComponent<SpriteRenderer>();
        StartCoroutine("Respawn");
        
    }
	
	// Update is called once per frame
	void Update () {

        //print(rb2d.velocity);
	}


    IEnumerator Respawn()
    {
        
        yield return new WaitForSeconds(WaitTime);
        renderer.enabled = false;
        yield return new WaitForSeconds(WaitTime);
        renderer.enabled = true;
        yield return new WaitForSeconds(WaitTime);
        renderer.enabled = false;
        yield return new WaitForSeconds(WaitTime);
        renderer.enabled = true;
        yield return new WaitForSeconds(WaitTime);
        renderer.enabled = false;
        yield return new WaitForSeconds(WaitTime);
        renderer.enabled = true;

        //Randomize the kick off:
        int[] Xvalues = new int[] { -1, 1 };
        int Xvel = Xvalues[Random.Range(0, 2)];
        int Yvel = Random.Range(-1, 2);

        //Away team scores. Local starts playing
        if (transform.position.x < 0)
        {
            
            rb2d.velocity = new Vector2(HitForce, Yvel * HitForce);

        }
        //Local team scores. Away starts playing
        else if (transform.position.x > 0)
        {

            rb2d.velocity = new Vector2(-HitForce, Yvel * HitForce);

        }
        //First ball in the middle of the pitch
        else
        {

            rb2d.velocity = new Vector2(Xvel * HitForce, Yvel * HitForce);

        }

        
    }//End Respawn coroutine



    private void OnCollisionEnter2D(Collision2D collision)
    {
                

        if (collision.gameObject.name == "Player1")
        {
            ContactPoint2D c = collision.contacts[0];

            if (c.collider.name == "P1Up")
            {
                rb2d.velocity = new Vector2(HitForce, HitForce);
            }
            else if(c.collider.name == "P1Middle")
            {
                rb2d.velocity = new Vector2(HitForce, Random.Range(-1f, 1f));
            }
            else if(c.collider.name == "P1Down")
            {
                rb2d.velocity = new Vector2(HitForce, -HitForce);
            }

        }

    }

}
