using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Pause : MonoBehaviour
{
    //public GameObject Restart;
    public GameObject Panel;
    bool Stop;

    public void pause()
    {
        if (Stop == false)
        {
            Stop = true;
            Time.timeScale = 0;
            //Restart.SetActive(true);
            Panel.SetActive(true);
        }
        else if (Stop == true)
        {
            Stop = false;
            Time.timeScale = 1;
            //Restart.SetActive(false);
            Panel.SetActive(false);
        }
    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        pause();
    }

    public void Back()
    {
        SceneManager.LoadSceneAsync(0);
        Invoke("pause", 0.005f);
    }
}
