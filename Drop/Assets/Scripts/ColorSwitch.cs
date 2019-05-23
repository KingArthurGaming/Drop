using UnityEngine;

public class ColorSwitch : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public float Hue;
    void Update()
    {
        Hue += 0.0005f;
        if (Hue>=1)
        {
            Hue = 0;
        }
        spriteRenderer.color = Color.HSVToRGB(Hue, 1f, 0.4f);
    }
}
