using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class SoundControl : MonoBehaviour
{
    public GameObject button;
    public Sprite Sound_On;
    public Sprite Sound_Off;

    private Image buttonImage;

    [System.Serializable]
    public class SoundStateEvent : UnityEvent { }

    public SoundStateEvent onSoundStateChanged;

    void Start()
    {
        buttonImage = button.GetComponent<Image>();
        UpdateButtonImage();
        button.GetComponent<Button>().onClick.AddListener(ToggleSound);
        onSoundStateChanged.Invoke();
    }

    void UpdateButtonImage()
    {
        if (GameManager.Instance.SoundActive)
        {
            buttonImage.sprite = Sound_On;
        }
        else
        {
            buttonImage.sprite = Sound_Off;
        }
    }

    void ToggleSound()
    {
        GameManager.Instance.SoundActive = !GameManager.Instance.SoundActive;
        UpdateButtonImage();
        onSoundStateChanged.Invoke();
    }
}
