using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    int max;
    int min;
    int guess;

	// Use this for initialization
	void Start () 
    {
        StartGame();
	}
	
    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = (min + max) / 2;

        Debug.Log("Welcome to Number Wizard young aprentice");
        Debug.Log("Please pick a numer and don't tell me...");
        Debug.Log("The highest number you can pick is: " + max);
        Debug.Log("The lowest number you can pick is: " + min);
        Debug.Log("I guess your number is " + guess);
        Debug.Log("Push Up if it's higher, push Down if it's lower or push Enter if it's correct!");

        max = max + 1;
    }

	// Update is called once per frame
	void Update () 
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Ha! So your number was " + guess);
            Debug.Log("I knew it! :)");
            StartGame();
        }
	}

    void NextGuess()
    {
        guess = (min + max) / 2;
        Debug.Log("I guess your number is " + guess);
        Debug.Log("Push Up if it's higher, push Down if it's lower or push Enter if it's correct!");
    }
}
