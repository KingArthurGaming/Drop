using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hide : MonoBehaviour
{

    public GameObject ObjectToHide;
    public GameObject ObjectToShow;
    public void hide()
    {
        ObjectToHide.SetActive(false);
    }
    public void Show()
    {
        ObjectToShow.SetActive(true);
    }
}
