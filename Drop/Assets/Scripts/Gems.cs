using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Gems : MonoBehaviour
{
    TextMeshProUGUI TextMesh;
    public int temp;
    int Score;
    //int Stoper = 0;
   // public Text MenuScore;
    public bool points;
    public GameObject filal;
    
    public void Count()
    {
        PlayerPrefs.SetInt("Player Score", temp++) ;
        Score++;
    }
    public void Back()
    {
        FindObjectOfType<Pause>().Back();
    }
    private void Start()
    {
        temp = PlayerPrefs.GetInt("Player Score");
        temp++;
        TextMesh = GetComponent<TextMeshProUGUI>();
        Score = 0;
    }
    public void Update()
    {
        if (Score == 20 && points == true)
        {
            filal.SetActive(true);
            Time.timeScale = 0.1f;
            Invoke("back", .1f);
            
        }
        if (Score == 50 && points == false)
        {
            filal.SetActive(true);
            Time.timeScale = 0.1f;
            Invoke("back", .1f);
        }
        //MenuScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        TextMesh.text = Score.ToString();

        //if (Score > PlayerPrefs.GetInt("HighScore", 0))
        //{
        //    PlayerPrefs.SetInt("HighScore", Score);
        //}

    }
}