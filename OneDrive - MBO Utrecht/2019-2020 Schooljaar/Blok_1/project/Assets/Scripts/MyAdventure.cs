using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAdventure : MonoBehaviour
{
    private enum States
    {
        start,
        intro,
        //keuze
        gesprek,
        andtwoord,
        klaarmaken,
        date,
        huis,
        waarheid,
        //keuze
        denken,

    }

    private States currentState = States.start;
    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu();
    }

    void ShowMainMenu()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Halloween Datenight");
        Terminal.WriteLine("Dit is een Type Based Game");
        Terminal.WriteLine("Typ start om te beginnen");

    }
    // Update is called once per frame
    void Update()
    {

    }

    void OnUserInput(string input)
    {

        switch (currentState)
        {
            case States.start:
                if (input == "start")
                {
                    StartIntro();
                }
                else if (input == "1337")
                {
                    Terminal.WriteLine("Jij bent leet");
                }
                else
                {
                    Terminal.WriteLine("Je moet start typen om te beginnen Nub");
                }
                break;
            case States.intro:
                if (input == "verder lopen")
                {
                    Gesprek();
                }
                break;
            case States.gesprek:
                if (input == "ja")
                {
                    zegja();
                }
                else if (input == "nee")
                {
                    zegnee();
                }
                break;
                case States.andtwoord:
                if (input == "date")
                {
                    Datenight();
                }
            break;
            case States.huis:
            if (input == "waarheid")
            {
                waarheid1();
            }
            break;
            case 
            default:
                Terminal.WriteLine("Deze state bestaat niet");
                break;
        }
    } 
     void StartIntro()
     {
         Terminal.ClearScreen();
         Terminal.WriteLine ("Het is Woensdag 30 October ook wel halloween genoemd");
         Terminal.WriteLine ("ook wel halloween genoemd");
         Terminal.WriteLine ("Jij loopt door de stad om een leuke outfit te zoeken");
         Terminal.WriteLine("typ om verder lopen om door te gaan");
         currentState = States.intro;
     }
    void Gesprek()
    {
       Terminal.ClearScreen();
       Terminal.WriteLine ("Dus je ziet een meisje en ze vraagt je om een date");
       Terminal.WriteLine ("Typ Ja of Nee om andtwoord te geven");
       currentState = States.gesprek;
    }
    
    void zegja()
    {
     Terminal.ClearScreen();   
     Terminal.WriteLine ("Je zegt ja en maakt je klaar voor de date");
     Terminal.WriteLine ("om nu na de date toe te gaan typ date");
     currentState = States.andtwoord;
    }
    void zegnee ()
    {
     Terminal.ClearScreen(); 
     Terminal.WriteLine ("Je zegt dat het je spijt maar nee moet zeggen");   
     Terminal.WriteLine ("Uiteindelijk besluit je toch te gaan en vraag ");
     Terminal.WriteLine ("Je haar mee uit en zij zegt natuurlijk ja hier");
     Terminal.WriteLine ("blij meer en typ je meteen date");
      currentState = States.andtwoord;
    }
    void Datenight()
   {
    Terminal.ClearScreen();
    Terminal.WriteLine ("Je bent je nu bij de date en je hebt");
    Terminal.WriteLine ("het je plezier en na de date vraagt");
    Terminal.WriteLine ("ze je je om na jou huis te gaan jij zegt");
    Terminal.WriteLine ("jij zegt natuurlijk geen nee tegen haar");
    Terminal.WriteLine ("Typ Huis om door te gaan");
    currentState = States.date;
   }
   void waarheid1()
   {
       Terminal.ClearScreen();
       Terminal.WriteLine ("Bij jou thuis kom je erachter dat");
       Terminal.WriteLine ("ze een echte vampier is dit zet je");
       Terminal.WriteLine ("denken Typ keuzen om verder te gaan");
       currentState = States.waarheid;
   }
}
