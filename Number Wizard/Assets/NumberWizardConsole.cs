using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class NumberWizardConsole : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int maxNum = 1000;
        int minNum = 1;
        int guessNum = (maxNum + minNum) / 2;
        bool guessCorrect = false;

        Debug.Log("Welcome to Number Wizard!");
        Debug.Log("Please pick a number between 1 and 1000 and do not tell me...");
        Debug.Log("Have you chosen yet? Press any key to continue...");
        Console.ReadKey();
        if (guessCorrect == false)
        {
            Debug.Log("Is your number... " + guessNum + "?");
            Debug.Log("Press 'y' for yes or 'n' for no");
            char input = Console.ReadKey().KeyChar;
            if (input == 'y')
            {
                guessCorrect = true;
            } else if (input == 'n')
            {
                guessCorrect = false;
                maxNum = guessNum;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
