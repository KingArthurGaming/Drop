using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColor : MonoBehaviour
{
    public float H;
    public float V;
    public float S;
    public Material material;
    public void ColorSwitch()
    {
        material.color = Color.HSVToRGB(H,V,S);
    }
}
