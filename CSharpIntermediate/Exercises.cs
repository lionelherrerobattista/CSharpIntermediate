using System;
using System.Diagnostics;

namespace CSharpIntermediate
{
    class Exercises
    {
        public static void ExerciseOne() // Stopwatch
        {
            int selectedOption;
            bool validInput;
            bool exit = false;
            Stopwatch stopwatch = new Stopwatch();

            do
            {
                // Options menu:
                Console.WriteLine("Choose an option: ");
                Console.WriteLine("1.Start stopwatch ");
                Console.WriteLine("2.Stop stopwatch ");
                Console.WriteLine("3.Exit");
                validInput = Int32.TryParse(Console.ReadLine(), out selectedOption);

                if (validInput)
                {
                    if (selectedOption == 1)
                    {
                        stopwatch.Start();
                    }
                    else if (selectedOption == 2)
                    {
                        stopwatch.Stop();
                        Console.WriteLine("Duration: " + stopwatch.Duration);
                    }
                    else
                    {
                        exit = true;
                    }
                }
                else
                {
                    exit = true;
                }
            } while (!exit);
        }


        public static void ExerciseTwo()
        {
            int selectedOption;
            string title;
            string description;
            bool validInput;
            bool exit = false;
            Post newPost = null;

            do
            {
                if(newPost == null)
                {
                    // Options menu:
                    Console.WriteLine("Choose an option: ");
                    Console.WriteLine("1.Create post");
                    Console.WriteLine("2.Exit");
                    Console.Write("Selected option: ");
                    validInput = Int32.TryParse(Console.ReadLine(), out selectedOption);
                    if (validInput)
                    {
                        if (selectedOption == 1)
                        {
                            Console.WriteLine("\nEnter a title: ");
                            title = Console.ReadLine();

                            Console.WriteLine("Enter a description: ");
                            description = Console.ReadLine();   

                            newPost = new Post(title, description);

                            Console.WriteLine("\nNew post created: ");
                            Console.WriteLine("Title: " + newPost.Title);
                            Console.WriteLine("Description: " + newPost.Description);
                            Console.WriteLine("Creation date: " + newPost.CreationDate);
                            Console.WriteLine("Votes: " + newPost.Votes);
                        }
                        else
                        {
                            exit = true;
                        }
                    }
                    else
                    {
                        exit = true;
                    }
                }
                else
                {
                    // Options menu:
                    Console.WriteLine("\nChoose an option: ");
                    Console.WriteLine("1.Upvote post");
                    Console.WriteLine("2.Downvote post");
                    Console.WriteLine("3.Exit");
                    Console.Write("Selected option: ");
                    validInput = Int32.TryParse(Console.ReadLine(), out selectedOption);

                    if (validInput)
                    {
                        if (selectedOption == 1)
                        {
                            newPost.UpVote();
                            Console.WriteLine("\nPost upvoted!");
                            Console.WriteLine("Number of votes: " + newPost.Votes);
                        }
                        else if (selectedOption == 2)
                        {
                            newPost.DownVote();
                            Console.WriteLine("\nPost downvoted!");
                            Console.WriteLine("Number of votes: " + newPost.Votes);
                        }
                        else
                        {
                            exit = true;
                        }
                    }
                    else
                    {
                        exit = true;
                    }
                }
            } while (!exit);
        }
    }
}
