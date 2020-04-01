using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockHandler : MonoBehaviour {

    #region Public_variables

    public Text ClockText;

    #endregion

    #region Private_variables


    private int Clock = 90;
    private float t1;
    private float t2;

    #endregion

    // Use this for initialization
    void Start () {

        ClockText.text = Clock.ToString();
        t1 = Time.time;

	}
	
	// Update is called once per frame
	void Update () {

        //print(Time.time);

        t2 = Time.time;
        if ((t2 - t1) > 1)
        {
            Clock--;
            ClockText.text = Clock.ToString();
            t1 = Time.time;
        }

        if (Clock == -1)
        {
            //End of Match
        }


	}
}
