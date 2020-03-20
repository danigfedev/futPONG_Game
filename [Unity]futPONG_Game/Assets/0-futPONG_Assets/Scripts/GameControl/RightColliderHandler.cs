using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RightColliderHandler : MonoBehaviour {

    #region Public_variables

    public Text LocalScoreText;

    #endregion

    #region Private_variables

    private int LocalScore;
    #endregion


    // Use this for initialization
    void Start()
    {

        //Initializing the score and printing it.
        LocalScore = 0;
        LocalScoreText.text = LocalScore.ToString();
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Away team scores. Increment the away score and print it
        LocalScore++;
        LocalScoreText.text = LocalScore.ToString();

        //Add animation here, just to try with states or just play the animation
    }
}
