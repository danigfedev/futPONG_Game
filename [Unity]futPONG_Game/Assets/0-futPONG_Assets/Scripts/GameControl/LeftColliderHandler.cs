using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeftColliderHandler : MonoBehaviour {

    #region Public_variables

    public Text AwayScoreText;

    #endregion

    #region Private_variables

    private int AwayScore;
    #endregion


    // Use this for initialization
    void Start () {

        //Initializing the score and printing it.
        AwayScore = 0;
        AwayScoreText.text = AwayScore.ToString();
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Away team scores. Increment the away score and print it
        AwayScore++;
        AwayScoreText.text = AwayScore.ToString();

        //Add animation here, just to try with states or just play the animation
    }
}
