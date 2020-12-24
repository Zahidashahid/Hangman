using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//[System.Serializable]
public class Hangman : MonoBehaviour
 {
    private string word = "Hello Zahi I am Java";// word to guess
    private char[] correctWordLetters;
    public Text wordToGuess;
    private char[] guessedLetters; //letters player will guess
    int i = 0;

   // private int lengthOfWord = word.Length; //
    public bool ISNotComplete = true;// not guess all letters
    //     // 
    //     // private string wordGuessed = 0;
    private int retry = 6;
   // private int score;  //   
    //     // private bool complete; 
    //  ]   //char[] Letter = new char[LengthOfWord];
    public void Start()
    { 
        word = word.ToUpper();
        correctWordLetters = word.ToCharArray();
        guessedLetters = new char[correctWordLetters.Length];// length of guess must be greater than correctWordLetters.Length incase of storing wrong charecter
        DisplayDashes();
    }

    public void IsCompleteWord()// check all  latters are guessed
    {
        
        for(int p = 0; p < correctWordLetters.Length; p++)
        {
            if(guessedLetters[p] == correctWordLetters[p])
            {
                ISNotComplete = false;
            }
            else
            {
                ISNotComplete = true;
                break;
                
            }
                
        }
    }      
    public void DisplayDashes()
    {
        string dashes = "";
        for (int p = 0; p < correctWordLetters.Length; p++)
        {
            if (correctWordLetters[p] == ' ')
            {
                dashes += "  ";
                guessedLetters[p] = ' ';
            }
            else
            {
                dashes += "_ ";
                guessedLetters[p] = '_';
            }
        }
        dashes = dashes.TrimStart();
        dashes = dashes.TrimEnd();
        SetWordToGuessText(dashes);
    }

    public void Check(char ch)
    {
        if(retry>0 )
        {
            Debug.Log(" now trial "+retry);
          
            IsCompleteWord();
            bool found = false;
            int index; // check presence of gussed letter
            for (index = 0; index < correctWordLetters.Length; index++)
            {
                if (correctWordLetters[index] == ch)
                {
                    found = true;
                    break;
                }
            }
            if (found)
            {
                i++;
                guessedLetters[index] = correctWordLetters[index];
                for (int p = index; p < correctWordLetters.Length; p++) // again check for multiple presence of charecter
                {
                    if (correctWordLetters[p] == correctWordLetters[index])
                    {
                        guessedLetters[p] = correctWordLetters[p];
                    }
                }

                string currentWord = "";
                for (int p = 0; p < guessedLetters.Length; p++)
                {
                    if (guessedLetters[p] == ' ')
                    {
                        currentWord += " ";
                    }
                    else
                    {
                        currentWord += " " + guessedLetters[p] + " ";
                    }
                }
                currentWord = currentWord.TrimStart();
                currentWord = currentWord.TrimEnd();
                SetWordToGuessText(currentWord);
                Debug.Log(currentWord);
            }
            else
            {
            
                Debug.Log("Not Match!");
                retry--;
                Debug.Log("  after worng "+retry);
            }
        }
        else
        {
             Debug.Log("  Game End now trial "+retry);
        }
    }
           
        

    public void SetWordToGuessText(string text)
    {
        wordToGuess.text = text;
    }

    // public void Reset()
    // {
    //    // score = 0;
    //     complete = false;
    //     private int retry = 6;
    //     public bool ISNotComplete = true;
    // }

}
