using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
    
    
{

    public void StartGame()
    {

        SceneManager.LoadScene(1);
    }
    public void Mainmenu()
    {
        Application.LoadLevel("HomeScene2");
    }
    public void QuitGame()
    {
        Application.Quit(3);
    }
    //Restart level
    public void Restart()
    {
        Application.LoadLevel("Scene1");
    }

}
