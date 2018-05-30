using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        ShowMenu();
    }

    void ShowMenu()
    {
        Terminal.ClearScreen();
        Output("What would you like to hack into?");
        Output("Press 1 for the local library");
        Output("Press 2 for the police station");
        Output("Enter your selection:");
    }

    void Output(string line)
    {
        Terminal.WriteLine(line);
    }

    void OnUserInput(string input)
    {
        if (input == "menu")
        {
            ShowMenu();
        }
        else if (input == "007")
        {
            Output("Please select a level Mr Bond!");
        }
        else
        {
            Output("Please choose a valid level");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
