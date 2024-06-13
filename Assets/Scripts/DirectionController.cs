using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionController : MonoBehaviour
{
    private static DirectionController _instance;

    public static DirectionController Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<DirectionController>();
                if (_instance == null)
                {
                    GameObject singletonObject = new GameObject();
                    _instance = singletonObject.AddComponent<DirectionController>();
                    singletonObject.name = typeof(DirectionController).ToString();
                    DontDestroyOnLoad(singletonObject);
                }
            }
            return _instance;
        }
    }

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    public void SetOrientationToLandscape()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }

    public void SetOrientationToPortrait()
    {
        Screen.orientation = ScreenOrientation.Portrait;
    }
}
