using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //public int sceneNumber; /*If adding more scenes*/
    public void StartGrame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
    public void QuitGame()
    {
        Debug.Log("Closing Application...");
        Application.Quit();
    }

    public void DelPrefs()
    {
        Debug.Log("Deleting PlayerPrefs");
        PlayerPrefs.DeleteAll();
    }
}
