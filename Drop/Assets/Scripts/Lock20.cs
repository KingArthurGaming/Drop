using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Lock20 : MonoBehaviour
{
    GameObject thisObject;
    public GameObject needMoney;
    public int locked;
    void Start()
    {
        thisObject = gameObject;
        //PlayerPrefs.SetInt(thisObject.name, 1);
        locked = PlayerPrefs.GetInt(thisObject.name);
        if (locked == 1)
        {
            Destroy(gameObject);
        }
    }
    IEnumerator Example()
    {
        needMoney.SetActive(true);
        yield return new WaitForSeconds(3);
        needMoney.SetActive(false);
    }

    public void Buy()
    {
        if (PlayerPrefs.GetInt("Player Score") >= 20)
        {
            int temp = PlayerPrefs.GetInt("Player Score");
            PlayerPrefs.SetInt("Player Score", temp - 20);
            PlayerPrefs.SetInt(thisObject.name, 1);
            Debug.Log(thisObject.name);
            Destroy(gameObject);
        }
        else
        {
            StartCoroutine(Example());
        }
    }
}
