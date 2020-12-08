using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ButtonScript : MonoBehaviour
{
    public Button keyboardBtn;
    public Text btnText;
    private char pressedButtonChar;

    public void GetText()
    {
        btnText = keyboardBtn.GetComponentInChildren<Text>();
        Char.TryParse(btnText.text, out pressedButtonChar);
        GameObject gameController = GameObject.Find("GameController");
        Hangman refScript = gameController.GetComponent<Hangman>();
        refScript.Check(pressedButtonChar);
        keyboardBtn.interactable = false;
    }
}
