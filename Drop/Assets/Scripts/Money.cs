using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Money : MonoBehaviour
{
    public TextMeshProUGUI TextMesh;
    public string TextBeforeCoins;
    
    void Update()
    {
        
        TextMesh.text =PlayerPrefs.GetInt("Player Score")+TextBeforeCoins;
    }

    
}
