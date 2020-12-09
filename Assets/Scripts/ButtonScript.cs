using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonScript : MonoBehaviour
{
    public Button keyboardBtn;
    public Text btnText;
    public Text texttoshow; 
    public char ans;
  
   // public Hangman hangman;
    Hangman hangman = new Hangman();

    public void GetText()
    {

      btnText= keyboardBtn.GetComponentInChildren<Text>();
      Debug.Log(btnText.text);
      keyboardBtn.interactable = false;

      ans = GetText(btnText.text);
      

      char.TryParse(wordToGuess.text ,out  ans);
      if(hangman.word.charAt[0] == ans)
      {
          wordToGuess.GetComponent<Text>().text = ans.ToString();
      }
      //SetHangmanReferenceOnButtons();

    }
        
      // void SetHangmanReferenceOnButtons()
      // {       
      //   keyboardBtn.GetComponentInParent<ButtonScript>().SetHangmanReference(this);

      // }
    // public void SetHangmanReference(GameObject controller)
    // {
    //   hangman = controller;
    // }
}
