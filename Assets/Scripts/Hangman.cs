using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Hangman : MonoBehaviour
 {

    public string word = "Hello Zahi";// word to guess,
    char[] letters;
    private char buttonPressedChar;
    //    // private int lengthOfWord = word.Length; //
    //     // private char[] guessedLetter ; //letters player will guess
    //     // private string wordGuessed = 0;
    //     // private int retry = 6;
    //     // //private int score;  //   
    //     // private bool complete; 

    // public Button keyboardBtn;
    // public Text btnText;
    public Text wordToGuess;


    //     //char[] Letter = new char[LengthOfWord];
    public void Start()
    {
       // complete = false;
        DisplayDashes();
        

        // Reset();
    }

        public void DisplayDashes()
        {  
            letters = word.ToCharArray();
                string dashes = "";
                for (int p = 0; p < letters.Length; p++)
                {
                    if(letters[p] == ' ')
                    {
                        dashes += "  ";
                    }
                    else 
                    {
                        dashes += "_ ";
                    }   
                }
                wordToGuess.text = dashes;
                Debug.Log("dashes");
        }
        // public void GetText(string text)
        // {
        //     buttonPressedChar = text[0];
        //     Debug.Log(buttonPressedChar);
        // }

        
    //     public void Check()
    //     {
    //         while (retry > 0  and  (complete == false))
    //         {
    //         //    Console.WriteLine(GuessedLetter);
    //         //     GuessedLetter.ToString().ToCharArray();
    //             for (int i = 1; i <= LengthOfWord; i++)
    //             {
    //                 Console.Write("{0} ", GuessedLetter);
    //             }
    //             Console.WriteLine("Enter a letter!");
    //             char letter = char.Parse(Console.ReadLine());
    //            // for( int i = 0; i < LengthOfWord  i++) // used for a letter  2 times in word
    //             //{
    //                 if (Word[i].Contains<char>(letter))
    //                 {
    //                     Console.Write(letters);
    //                 }
    //                 else
    //                 {
    //                     Console.Write("You guessed wrong!");

    //                 }
    //            // }


    //         }
    //    }

      //      public void Reset()
    //         // {
    //         //     score = 0;
    //         //     complete = false;
    //         //     for (int i = 0; i < hang)

    //         // }

}
