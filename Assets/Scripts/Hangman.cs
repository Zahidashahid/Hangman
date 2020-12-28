using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//[System.Serializable]
public class Hangman : MonoBehaviour
 {
     public Button keyboardBtn;
    private string word = "Hello Zahi I am Java";// word to guess
    private char[] correctWordLetters;
    public Text wordToGuess;
    private char[] guessedLetters; //letters player will guess
    int i = 0;

   // private int lengthOfWord = word.Length; //
    public bool ISNotComplete = true;// not guess all letters
    //     // 
    //     // private string wordGuessed = 0;
    private int retry = 0;
    public Text gameOverText;
    public GameObject gameOverPanel;
    public GameObject hangmanPanel;
    public GameObject[] hangmanParts = new GameObject[8];
    public GameObject restartButton;
   // private int score;  //   
    //     // private bool complete; 
    //  ]   //char[] Letter = new char[LengthOfWord];
    public void Start()
    { 
        gameOverPanel.SetActive(false);
      // hangmanPanel.SetActive(false);
        word = word.ToUpper();
         //hangmanParts[0] =GameObject.Find("stage");
        correctWordLetters = word.ToCharArray();
        guessedLetters = new char[correctWordLetters.Length];// length of guess must be greater than correctWordLetters.Length incase of storing wrong charecter
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
          
    public void Check(char ch)
    {
        //while(ISNotComplete == true)
        
        if(ISNotComplete == true && retry< 8 )
        {
            Debug.Log(" now trial "+retry);
          
             
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
                hangmanParts[retry].SetActive(true); // Set hangman if select wrong character 
                keyboardBtn.gameObject.SetActive(false);
                Debug.Log("Not Match!");
                retry++;
                Debug.Log("  after worng "+retry);
            }
        }
        else
        {
           // setMan();
            Debug.Log("  Game End now trial "+retry);
           GameOver();
        }
        IsCompleteWord();
    }
  

    public void SetWordToGuessText(string text)
    {
        wordToGuess.text = text;
        
    }

    // public void setMan()
    // {
    //     // for(int i =0;i < 6;i++)
    //     // {
    //         // hangmanParts[0] =GameObject.Find("stage");//i.ToString()
    //         // hangmanParts[0].SetActive(true);
    //    // }
    // }

    void GameOver()
    {
        Debug.Log(" Just entered");
        //keyboardBtn.SetActive(false);
        if (retry >=8)
        {
            SetGameOverText("Game Over!");
            //Debug.Log(" In win Loop ");
           
        }
        
        else
        {
            SetGameOverText("You did it!");
            //Debug.Log("  In over loop ");
        }
        Debug.Log(" below if");
       // restartButton.SetActive(true);
    }
    public void SetGameOverText(string text)
    {
          gameOverPanel.SetActive(true);
          gameOverText.text = text;
    }
    // public void SetHangedman()
    // {
    //     hangmanPanel.SetActive(true);
    //    //i.ToString()
    //     //hangmanParts[0].SetActive(true);
       
    // }
    // public void Reset()
    // {
    //    // score = 0;
    //     complete = false;
    //     private int retry = 6;
    //     public bool ISNotComplete = true;
    // }

}
