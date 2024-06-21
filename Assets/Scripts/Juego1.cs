using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Juego1 : MonoBehaviour
{

    [Header("Lenguaje de señas")]
    public List<Sprite> images;
    public TextMeshProUGUI valor1;
    public TextMeshProUGUI valor2;
    public TextMeshProUGUI valor3;

    public int numero1 = 2;
    public int numero2 = 3;
    public int numero3 = 4;

    public GameObject button1;
    public GameObject button2;
    public GameObject button3;

    public List<Image> buttonSprite;
    void Start()
    {
        ButtonDato b1 = button1.GetComponent<ButtonDato>();
        ButtonDato b2 = button2.GetComponent<ButtonDato>();
        ButtonDato b3 = button3.GetComponent<ButtonDato>();
        Button btn1 = button1.GetComponent<Button>();
        btn1.onClick.AddListener(() => OnButtonClick(button1));
        Button btn2 = button2.GetComponent<Button>();
        btn2.onClick.AddListener(() => OnButtonClick(button2));
        Button btn3 = button3.GetComponent<Button>();
        btn3.onClick.AddListener(() => OnButtonClick(button3));
        numero1 = Random.Range(0,8);
        numero2 = numero1 + 1;
        numero3 = numero1 + 2;
        valor1.text = numero1.ToString();
        valor2.text = numero2.ToString();
        valor3.text = "?";

        int respuesta = Random.Range(0, buttonSprite.Count);
        switch (respuesta)
        {
            case 0:
                buttonSprite[0].sprite = images[numero3];
                if(numero1 >= 0 && numero1 < 5)
                {
                    buttonSprite[1].sprite = images[numero1+4];
                    buttonSprite[2].sprite = images[numero2+4];
                }
                else
                {
                    buttonSprite[1].sprite = images[numero1 - 4];
                    buttonSprite[2].sprite = images[numero2 - 4];
                }
                b1.ConvertImageToInt();
                b2.ConvertImageToInt();
                b3.ConvertImageToInt();

                break;
            case 1:
                buttonSprite[1].sprite = images[numero3];
                if (numero1 >= 0 && numero1 < 5)
                {
                    buttonSprite[0].sprite = images[numero1 + 4];
                    buttonSprite[2].sprite = images[numero2 + 4];
                }
                else
                {
                    buttonSprite[0].sprite = images[numero1 - 4];
                    buttonSprite[2].sprite = images[numero2 - 4];
                }
                b1.ConvertImageToInt();
                b2.ConvertImageToInt();
                b3.ConvertImageToInt();
                break;
            case 2:
                buttonSprite[2].sprite = images[numero3];
                if (numero1 >= 0 && numero1 < 5)
                {
                    buttonSprite[1].sprite = images[numero1 + 4];
                    buttonSprite[0].sprite = images[numero2 + 4];
                }
                else
                {
                    buttonSprite[1].sprite = images[numero1 - 4];
                    buttonSprite[0].sprite = images[numero2 - 4];
                }
                b1.ConvertImageToInt();
                b2.ConvertImageToInt();
                b3.ConvertImageToInt();
                break;
        }
    }

    public void OnButtonClick(GameObject button)
    {
        ButtonDato buttonDato = button.GetComponent<ButtonDato>();

        Debug.Log(buttonDato.dato);

        if (buttonDato.dato == numero3)
        {
            valor3.text = numero3.ToString();
        }
    }

    void Update()
    {
           
    }
}
