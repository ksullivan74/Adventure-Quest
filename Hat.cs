/*
Create a new class called Hat in its own file. DONE
Add a mutable integer property called ShininessLevel to indicate how shiny the hat is. DONE
Add a computed string property called ShininessDescription to return a text description of the hat's shininess according to the following rules.
A ShininessLevel less than 2 should be "dull"
A ShininessLevel between 2 and 5 should be "noticeable"
A ShininessLevel between 6 and 9 should be "bright"
A ShininessLevel greater than 9 should be "blinding" DONE
Add a Hat property and constructor parameter to the Adventurer class. DONE
Update the Adventurer's GetDescription method to include the description of the hat. DONE
Update the Program.cs file to create a Hat and pass it to the Adventurer's constructor
*/
using System;

namespace Quest
{
    public class Hat
    {
        public int ShininessLevel { get; set; }
        public string ShininessDescription(int shinyParam)
        {
            string shiny = "";
            if (shinyParam < 2)
            {
                shiny = "dull";
            }
            else if (shinyParam <= 5)
            {
                shiny = "noticeable";
            }
            else if (shinyParam <= 9)
            {
                shiny = "bright"; ;
            }
            else if (shinyParam > 9)
            {
                shiny = "blinding";
            }

            return shiny;
        }
    }
}
