using UnityEngine;
using UnityEngine.Advertisements;

public class AdToShow : MonoBehaviour
{
    private void Start()
    {
        if (PlayerPrefs.GetInt("Player Score") < 10)
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
    public void ShowAd()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show("rewardedVideo");
            PlayerPrefs.SetInt("Player Score", PlayerPrefs.GetInt("Player Score") + 10);
            gameObject.SetActive(false);

        }
    }
}
