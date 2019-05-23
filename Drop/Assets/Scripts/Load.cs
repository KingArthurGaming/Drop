using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Load : MonoBehaviour
{
    public Slider Slider;
    public GameObject slider;

    public void start(int SceneIndex)
    {
        slider.SetActive(true);
        StartCoroutine(LoadAsynchronously(SceneIndex));
    }
    IEnumerator LoadAsynchronously(int SceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(SceneIndex);
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            Slider.value = progress;

            yield return null;
        }
    }
}
