using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    internal static object GetActiveScene()
    {
        throw new NotImplementedException();
    }

    internal static void LoadScene(object name, string name1)
    {
        throw new NotImplementedException();
    }

    internal static void LoadScene(string v)
    {
        throw new NotImplementedException();
    }

    internal static void LoadScene(int v)
    {
        throw new NotImplementedException();
    }

    public void changeScene()
    {
        Application.LoadLevel("Scene1");
    }
    public void GameoverScene()
    {
       Application.LoadLevel("GameoverScene");
    }
    
}
