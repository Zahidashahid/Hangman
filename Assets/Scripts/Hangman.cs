using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Hangman : MonoBehaviour
 {
    private string word = "Hello Zahi I am Java";// word to guess
    private char[] correctWordLetters;
    public Text wordToGuess;
    private char[] guessedLetters; //letters player will guess

    //    // private int lengthOfWord = word.Length; //
    //     // 
    //     // private string wordGuessed = 0;
    //     // private int retry = 6;
    //     // //private int score;  //   
    //     // private bool complete; 



    //     //char[] Letter = new char[LengthOfWord];
    public void Start()
    {
        word = word.ToUpper();
        correctWordLetters = word.ToCharArray();
        guessedLetters = new char[correctWordLetters.Length];
        DisplayDashes();
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
        bool found = false;
        int index; 
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
            guessedLetters[index] = correctWordLetters[index];
            for (int p = index; p < correctWordLetters.Length; p++)
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
            Debug.Log("Not Match!");
    }

    public void SetWordToGuessText(string text)
    {
        wordToGuess.text = text;
    }

    //     // public void Check()
    //     // {
    //     //     while (retry > 0  and  lettersGuessed.Length < lengthOfWord)
    //     //     {
    //     //       /*  Console.WriteLine(GuessedLetter);
    //     //         GuessedLetter.ToString().ToCharArray();
    //     //         for (int i = 1; i <= LengthOfWord; i++)
    //     //         {
    //     //             Console.Write("{0} ", GuessedLetter);
    //     //         }*/
    //     //         Console.WriteLine("Enter a letter!");
    //     //         char letter = char.Parse(Console.ReadLine());
    //     //        // for( int i = 0; i < LengthOfWord  i++) // used for a letter  2 times in word
    //     //         //{
    //     //             if (Word[i].Contains<char>(letter))
    //     //             {
    //     //                 Console.Write(letters);
    //     //             }
    //     //             else
    //     //             {
    //     //                 Console.Write("You guessed wrong!");

    //     //             }
    //     //        // }


    //     //     }
    //    // }

    //         // public void Reset()
    //         // {
    //         //     score = 0;
    //         //     complete = false;
    //         //     for (int i = 0; i < hang)

    //         // }

}
