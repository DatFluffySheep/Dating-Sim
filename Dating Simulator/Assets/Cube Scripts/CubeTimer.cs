using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CubeTimer : MonoBehaviour
{
    public float timeRemaining = 10;
    public string scenename;
    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else if (timeRemaining <= 0)
        {
            SceneManager.LoadScene(scenename);
        }
    }
}
