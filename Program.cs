﻿using System;
using System.Collections.Generic;

// Every class in the program is defined within the "Quest" namespace
// Classes within the same namespace refer to one another without a "using" statement
namespace Quest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Our adventurer is currently named "Jack". Studies show that "Jack" is probably not the application user's name. Update the code to prompt the user for their name and pass that name to the Adventurer constructor when creating the new Adventurer object.

            Console.WriteLine("Please Identify yourself Adventurer");
            string adventurerName = Console.ReadLine();


            //This quest is so much fun that everyone is sure to want to do it more than once. Update the code to ask the user if they'd like to repeat the quest after the it has been completed. If the user says "yes", start the quest over. Otherwise, end the program.
            string X = "Y";
            while (X == "Y")
            {
                // Create a few challenges for our Adventurer's quest
                // The "Challenge" Constructor takes three arguments
                //   the text of the challenge
                //   a correct answer
                //   a number of awesome points to gain or lose depending on the success of the challenge
                Challenge twoPlusTwo = new Challenge("2 + 2?", 4, 10);
                Challenge theAnswer = new Challenge(
                    "What's the answer to life, the universe and everything?", 42, 25);
                Challenge whatSecond = new Challenge(
                    "What is the current second?", DateTime.Now.Second, 50);

                int randomNumber = new Random().Next() % 10;
                Challenge guessRandom = new Challenge("What number am I thinking of?", randomNumber, 25);
                Console.WriteLine($"{randomNumber}");

                //Create 3 new instances of 3  seperate challenges on the program.cs file
                Challenge neptunesRevenge = new Challenge("How many awesome teammates are in Novel Neptunians?", 4, 5);
                Challenge secretPassCode = new Challenge("What is the secret Pass Code?", 0000, 20);
                Challenge whatsTheAge = new Challenge("What is Neil's Age?", 25, 75);



                Robe newRobe = new Robe();
                newRobe.Colors = "Purple";
                newRobe.Length = 3;

                Hat newHat = new Hat();
                newHat.ShininessLevel = 4;

                // In Program.cs create an instance of the Prize.
                Prize newPrize = new Prize("Neil, Cassie, John, and Jade are the greatest!");


                Challenge favoriteBeatle = new Challenge(
                    @"Who's your favorite Beatle?
                    1) John
                    2) Paul
                    3) George
                    4) Ringo
                ",
                    4, 20
                );

                // "Awesomeness" is like our Adventurer's current "score"
                // A higher Awesomeness is better

                // Here we set some reasonable min and max values.
                //  If an Adventurer has an Awesomeness greater than the max, they are truly awesome
                //  If an Adventurer has an Awesomeness less than the min, they are terrible
                int minAwesomeness = 0;
                int maxAwesomeness = 100;

                // Make a new "Adventurer" object using the "Adventurer" class
                Adventurer theAdventurer = new Adventurer(adventurerName, newRobe, newHat);
                Console.WriteLine($"{theAdventurer.GetDescription()}");

                // A list of challenges for the Adventurer to complete
                // Note we can use the List class here because have the line "using System.Collections.Generic;" at the top of the file.
                List<Challenge> challenges = new List<Challenge>()
                {
                    twoPlusTwo,
                    theAnswer,
                    whatSecond,
                    guessRandom,
                    favoriteBeatle,
                    neptunesRevenge,
                    secretPassCode,
                    whatsTheAge
                };

                List<int> ChallengeNumbers = new List<int>();
                List<Challenge> RandomChallenges = new List<Challenge>();
                Random rnd = new Random();
                int number;
                for (int i = 0; i < 5; i++)
                {
                    do
                    {
                        number = rnd.Next(0, challenges.Count - 1);
                    }
                    while (ChallengeNumbers.Contains(number));
                    ChallengeNumbers.Add(number);

                }
                foreach (int num in ChallengeNumbers)
                {
                    RandomChallenges.Add(challenges[num]);
                }
                // Loop through all the challenges and subject the Adventurer to them
                foreach (Challenge challenge in RandomChallenges)
                {
                    challenge.RunChallenge(theAdventurer);
                }

                // This code examines how Awesome the Adventurer is after completing the challenges
                // And praises or humiliates them accordingly
                Console.Clear();
                if (theAdventurer.Awesomeness >= maxAwesomeness)
                {
                    Console.WriteLine("YOU DID IT! You are truly awesome!");
                }
                else if (theAdventurer.Awesomeness <= minAwesomeness)
                {
                    Console.WriteLine("Get out of my sight. Your lack of awesomeness offends me!");
                }
                else
                {
                    Console.WriteLine("I guess you did...ok? ...sorta. Still, you should get out of my sight.");
                }

                //At the end of the quest (before you ask if the user wants to repeat the quest) call the ShowPrize method.
                newPrize.ShowPrize(theAdventurer);

                Console.WriteLine("Would you like to adventure, Y/N?");
                X = Console.ReadLine().ToUpper();
            };
        }
    }
}
