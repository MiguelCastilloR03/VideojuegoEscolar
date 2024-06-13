using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum OrientacionUI
{
    horizontal,
    vertical
}
public class Orientacion : MonoBehaviour
{
    public OrientacionUI ui;
    // Start is called before the first frame update
    void Start()
    {
        switch (ui)
        {
            case OrientacionUI.horizontal:
                DirectionController.Instance.SetOrientationToLandscape();
                break;
            case OrientacionUI.vertical:
                DirectionController.Instance.SetOrientationToPortrait();
                break;
        }
    }
}
