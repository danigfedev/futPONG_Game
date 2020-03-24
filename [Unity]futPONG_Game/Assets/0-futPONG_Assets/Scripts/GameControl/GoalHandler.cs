using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalHandler : MonoBehaviour
{
    #region ***** Public fields *****

    public enum goalSides
    {
        Player1, //always home team
        Player2 //always away team
    };
    public goalSides goalSide = goalSides.Player1;
    //TODO Replace with TextMeshPro
    public Text homeTeamScoreBoard; 
    public Text awayTeamScoreBoard;

    #endregion 

    #region ***** Private fields *****

    private int homeScore = 0;
    private int awayScore = 0;

    #endregion

    void Start()
    {
        UpdateScoreBoard(homeScore, awayScore);
    }

    //Description: Event that triggers when the ball enters the collider (set as trigger)
    //Arguments: 
    //_collision: a reference to the hitting object's collider component
    private void OnTriggerEnter2D(Collider2D _collision)
    {
        if(goalSide == goalSides.Player1) // Hit Player1 collider. Player2 scores 
        {
            awayScore++;
        }
        else // Hit Player2 collider. Player1 scores  
        {
            homeScore++;
            
        }
        UpdateScoreBoard(homeScore, awayScore);
    }

    //Description: Updates values in scoreboard
    //Arguments: 
    //_home: home team result
    //_away: away team result
    private void UpdateScoreBoard(int _home, int _away)
    {
        homeTeamScoreBoard.text = _home.ToString();
        awayTeamScoreBoard.text = _away.ToString();
    }

}
