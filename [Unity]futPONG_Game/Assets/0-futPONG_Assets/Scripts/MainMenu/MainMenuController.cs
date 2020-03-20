using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour {


    #region Private Variables
    private enum MenuBTN { Match, League, Cup, Shop, Config };//config optional
    private MenuBTN CurrentBTN;

    #endregion

    #region Public Variables

    public GameObject MatchBTN;
    public GameObject LeagueBTN;
    public GameObject CupBTN;
    public GameObject ShopBTN;
    public GameObject ConfigBTN;

    #endregion





    // Use this for initialization
    void Start () {

        CurrentBTN = MenuBTN.Match;

    }
	
	// Update is called once per frame
	void Update () {

        print(CurrentBTN);


        if (CurrentBTN == MenuBTN.Match)
        {
            
            MatchBTNenabled();

        }   
        else if (CurrentBTN == MenuBTN.League)
        {
            LeagueBTNenabled();
        } 
        else if (CurrentBTN == MenuBTN.Cup)
        {
            CupBTNenabled();
        }
        else if (CurrentBTN == MenuBTN.Shop)
        {
            ShopBTNenabled();
        }
        else if (CurrentBTN == MenuBTN.Config)
        {

        }

	}


    private void MatchBTNenabled()
    {
        GameObject child = MatchBTN.transform.GetChild(2).gameObject;
        child.SetActive(true);



        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            
            child.SetActive(false);
            CurrentBTN = MenuBTN.League;
            //Disable selected panel
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            child.SetActive(false);
            CurrentBTN = MenuBTN.Cup;

        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            //Application.LoadLevel(1);
            SceneManager.LoadScene(1);
        }

    }

    private void LeagueBTNenabled()
    {
        GameObject child = LeagueBTN.transform.GetChild(2).gameObject;
        child.SetActive(true);

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            child.SetActive(false);
            CurrentBTN = MenuBTN.Match;
            
            //Disable selected panel
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            CurrentBTN = MenuBTN.Shop;
            child.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            
            //SceneManager.LoadScene(1);
        }

    }


    private void CupBTNenabled()
    {
        GameObject child = CupBTN.transform.GetChild(2).gameObject;
        child.SetActive(true);



        if (Input.GetKeyDown(KeyCode.RightArrow))
        {

            child.SetActive(false);
            CurrentBTN = MenuBTN.Shop;
            //Disable selected panel
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            child.SetActive(false);
            CurrentBTN = MenuBTN.Match;

        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            //Application.LoadLevel(1);
            //SceneManager.LoadScene(1);
        }

    }


    private void ShopBTNenabled()
    {
        GameObject child = ShopBTN.transform.GetChild(2).gameObject;
        child.SetActive(true);



        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

            child.SetActive(false);
            CurrentBTN = MenuBTN.Cup;
            //Disable selected panel
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            child.SetActive(false);
            CurrentBTN = MenuBTN.League;

        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            //Application.LoadLevel(1);
            //SceneManager.LoadScene(1);
        }

    }


}
