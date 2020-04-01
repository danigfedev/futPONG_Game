using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Android_MenuHandler : MonoBehaviour
{
    
    public void PlayFriendlyMatch()
    {
        //TODO Load additively match scene
        //TODO unload this scene

        //For now I'll just do a simple load scene
        SceneManager.LoadScene(1);
    }

}
