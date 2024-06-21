using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public GameObject[] fondos;

    public void Derecha()
    {
        foreach (GameObject fondo in fondos)
        {
            RectTransform rectTransform = fondo.GetComponent<RectTransform>();
            if (rectTransform != null)
            {
                rectTransform.anchoredPosition += new Vector2(980, 0);
            }
        }
    }

    public void Izquierda()
    {
        foreach (GameObject fondo in fondos)
        {
            RectTransform rectTransform = fondo.GetComponent<RectTransform>();
            if (rectTransform != null)
            {
                rectTransform.anchoredPosition += new Vector2(-980, 0);
            }
        }
    }
}
