using System;
using UnityEngine;
using UnityEngine.UI;

public class TextAdventure : MonoBehaviour
{
    public Text gameText;
    public InputField playerInput;

    private string currentLocation = "dom";

    private void Start()
    {
        DisplayLocationDescription();
    }

    public void ProcessInput()
    {
        string input = playerInput.text.ToLower();
        playerInput.text = "";

        switch (currentLocation)
        {
            case "dom":
                ProcessHomeInput(input);
                break;
            case "las":
                ProcessForestInput(input);
                break;
            default:
                gameText.text = "Nieznane polecenie.";
                break;
        }
    }

    private void ProcessHomeInput(string input)
    {
        switch (input)
        {
            case "rozejrzyj się":
                gameText.text = "Jesteś w swoim domu. Widzisz drzwi prowadzące na zewnątrz.";
                break;
            case "wyjdź":
                currentLocation = "las";
                DisplayLocationDescription();
                break;
            default:
                gameText.text = "Nie możesz tego zrobić tutaj.";
                break;
        }
    }

    private void ProcessForestInput(string input)
    {
        switch (input)
        {
            case "rozejrzyj się":
                gameText.text = "Jesteś w ciemnym lesie. Słyszysz dziwne dźwięki.";
                break;
            case "wróć":
                currentLocation = "dom";
                DisplayLocationDescription();
                break;
            default:
                gameText.text = "Nie możesz tego zrobić tutaj.";
                break;
        }
    }

    private void DisplayLocationDescription()
    {
        switch (currentLocation)
        {
            case "dom":
                gameText.text = "Jesteś w swoim domu.";
                break;
            case "las":
                gameText.text = "Jesteś w ciemnym lesie.";
                break;
            default:
                gameText.text = "Znajdujesz się w nieznanym miejscu.";
                break;
        }
    }
}
