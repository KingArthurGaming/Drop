using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour
{
    public GameObject Canvus;
    void Start()
    {
        Time.timeScale = 0;
    }

    public void time()
    {
        Time.timeScale = 1;
        Canvus.SetActive(false);
    }

}
