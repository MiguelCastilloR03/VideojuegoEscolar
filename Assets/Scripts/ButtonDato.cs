using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonDato : MonoBehaviour
{
    public int dato;
    public Image Image;
    public void ConvertImageToInt()
    {
        if (int.TryParse(Image.sprite.name, out int result))
        {
            dato = result;
        }
    }
}
