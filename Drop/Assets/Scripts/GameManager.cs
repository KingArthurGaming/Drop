using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public int adCount;
    public float deley = 0f;
    private void Start()
    {
        adCount = PlayerPrefs.GetInt("Deads");
        adCount++;

        if (adCount >= 5 && Advertisement.IsReady())
        {

            Advertisement.Show("video");
            adCount = 0;

        }

        PlayerPrefs.SetInt("Deads", adCount);


    }
    public void CompleteLevel()
    {

        Debug.Log("level won");
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void EndGame()
    {

        Invoke("Restart", deley);
    }
}
