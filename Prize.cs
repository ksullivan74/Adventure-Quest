/*
Create a new class called Prize. DONE
Create a private field in the class called _text to contain a textual description of the prize. DONE
Create a constructor in the class that takes a text parameter and uses it to set the _text field. 
Create a method in the class called ShowPrize. DONE
The method should accept an Adventurer as a parameter. DONE
If the adventurer's Awesomeness is greater than zero, write the _text field to the console the same number of times as the value of the Awesomeness property. DONE
If the adventurer's Awesomeness is zero or less than zero, write a message of pity to the console. DONE
In Program.cs create an instance of the Prize.
At the end of the quest (before you ask if the user wants to repeat the quest) call the ShowPrize method.
*/
using System;

namespace Quest
{
    public class Prize
    {
        private string _text;

        public Prize(string textParam)
        {
            _text = textParam;
        }

        public void ShowPrize(Adventurer adventurerParam)
        {
            if (adventurerParam.Awesomeness > 0)
            {
                for (int i = 0; i < adventurerParam.Awesomeness; i++)
                {
                    Console.WriteLine($"{_text}");
                }
            }
            else
            {
                Console.WriteLine("We are so sorry, but you are soooooo not awesome, get out of my sight.");
            }
        }

    }
}