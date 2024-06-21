using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool SoundActive;
    private static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                // Busca una instancia existente del GameManager en la escena
                _instance = FindObjectOfType<GameManager>();

                // Si no se encuentra una instancia, crea un nuevo GameObject y le añade el GameManager
                if (_instance == null)
                {
                    GameObject singleton = new GameObject(typeof(GameManager).ToString());
                    _instance = singleton.AddComponent<GameManager>();
                }

                // Asegura que el GameManager persista entre escenas
                DontDestroyOnLoad(_instance.gameObject);
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

    private void Start()
    {
        SoundActive = true;
    }
}
