/*
Create new file called Robe.cs.
Inside the file define a Robe class.
The class should have the following mutable properties.
Colors - a list of strings to hold the colors of the robe
Length - an integer describing the length of the robe in inches
The class should not contain any methods or constructors.
Add a new immutable property to the Adventurer class called ColorfulRobe. The type of this property should be Robe.
Add a new constructor parameter to the Adventurer class to accept a Robe and to set the ColorfulRobe property.
Add a new method to the Adventurer class called GetDescription. This method should return a string that contains the adventurer's name and a description of their robe.
In Program.cs create a new instance of the Robe class and set its properties.
Pass the new Robe into the constructor of the Adventurer.
Before the adventurer starts their challenge, call the GetDescription method and print the results to the console.
*/

using System;

namespace Quest
{
    public class Robe
    {
        public string Colors { get; set; }
        public int Length { get; set; }
    }
}