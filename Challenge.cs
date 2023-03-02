using System;

namespace Quest
{
    // An instance of the Challenge class is an occurrence of a single challenge
    public class Challenge
    {
        // These private fields hold the "state" of an individual challenge object.
        // The values stored in these fields are not accessible outside the class,
        //  but can be used by methods or properties within the class
        private string _text;
        private int _correctAnswer;
        private int _awesomenessChange;


        // A constructor for the Challenge
        // We can tell it's a constructor because it has the same name as the class 
        // and it doesn't specify a return type
        // Note the constructor parameters and what is done with them
        public Challenge(string text, int correctAnswer, int awesomenessChange)
        {
            _text = text;
            _correctAnswer = correctAnswer;
            _awesomenessChange = awesomenessChange;
        }

        // This method will take an Adventurer object and make that Adventurer perform the challenge
        public void RunChallenge(Adventurer adventurer)
        {
            Console.Write($"{_text}: ");
            string answer = Console.ReadLine();

            int numAnswer;
            bool isNumber = int.TryParse(answer, out numAnswer);

            Console.WriteLine();
            if (isNumber && numAnswer == _correctAnswer)
            {
                Console.WriteLine("Well Done!");

                // Note how we access an Adventurer object's property
                adventurer.Awesomeness += _awesomenessChange;
            }
            else
            {
                Console.WriteLine("You have failed the challenge, there will be consequences.");
                adventurer.Awesomeness -= _awesomenessChange;
            }

            // Note how we call an Adventurer object's method
            Console.WriteLine(adventurer.GetAdventurerStatus());
            Console.WriteLine();
        }
    }
}

/*
Let's make the challenges a little more interesting. Add 2 to 5 more challenges to the program and then add code to randomly select 5 challenges for our adventurer to face. If the user chooses to repeat the quest another random selection of challenges should happen.

//Create 3 new instances of 3  seperate challenges on the program.cs file DONE
// Add the 3 new instances of the challenges to the list of challenges on the program.cs file DONE
// add code to randomly select 5 challenges for our adventurer to face.
    - create method to get a random integer between the number of challenges
    -  create a method to accept the list of challenges as a parameter and the random number as a parameter
    - create an empty List to accept the 5 random challenges index
    - 
// If the user chooses to repeat the quest another random selection of challenges should happen.
    - invoke the challenges method if the user chooses to continue.

List<int> ListNumbers = new List<int>();
            Random rnd = new Random();
            int number;
            for (int i = 0; i < 3; i++)
            {
                do
                {
                    // this will generate a random number as long as the number is already in the list.
                    number = rnd.Next(0, affirmations.Count - 1);
                } while (ListNumbers.Contains(number));
                ListNumbers.Add(number);
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Kaci's Affirmations");
            for (var i = 0; i < ListNumbers.Count; i++)
            {
                var index = ListNumbers[i];
                Console.WriteLine(affirmations[index]);
            };
        }
    }
}

*/