using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMeniuScript : MonoBehaviour
{

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    public void PlayGame()
    {
        Debug.Log("Start");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


}
public class Globals {
public static string UserName;
    public static string UserID;
    public static string ConectionString;
}