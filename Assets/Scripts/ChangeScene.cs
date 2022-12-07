using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void MoveNext(int SceneID) {
        //Every Scene Has a Unique ID
        SceneManager.LoadScene(SceneID);
        Debug.Log("Next Scene:"+ SceneID);
    }

    public void QuitGame()
    {
        //End Game
     
        Application.Quit();
        Debug.Log("Game End");
    }
}
