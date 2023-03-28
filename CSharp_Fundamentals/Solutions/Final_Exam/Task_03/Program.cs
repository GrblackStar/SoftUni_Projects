using System;
using System.Collections.Generic;

namespace Task_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> sentMessages = new Dictionary<string, int>();
            Dictionary<string, int> recievedMessages = new Dictionary<string, int>();
            Dictionary<string, int> totalMessages = new Dictionary<string, int>();


            // possible solution:
            // a list of users 
            // for the print we itterate through the list for printing
            List<string> usernames = new List<string>();



            int totalPossible = int.Parse(Console.ReadLine());
            string input;
            while ((input = Console.ReadLine()) != "Statistics")
            {
                string[] commandArgs = input.Split('=');




                if (commandArgs[0] == "Add")
                {
                    string username = commandArgs[1];
                    int sentM = int.Parse(commandArgs[2]);
                    int recievedM = int.Parse(commandArgs[3]);


                    if (!usernames.Contains(username))
                    {
                        usernames.Add(username);
                        sentMessages.Add(username, sentM);
                        recievedMessages.Add(username, recievedM);
                        totalMessages.Add(username, totalPossible);
                    }


                }
                else if (commandArgs[0] == "Message")
                {
                    string sender = commandArgs[1];
                    string reciever = commandArgs[2];

                    if (sentMessages.ContainsKey(sender)   &&   recievedMessages.ContainsKey(reciever))
                    {
                        sentMessages[sender]++;
                        recievedMessages[reciever]++;


                        // check limit for sender:
                        if ((sentMessages[sender] + recievedMessages[sender])  >= totalMessages[sender])
                        {
                            Console.WriteLine($"{sender} reached the capacity!");

                            usernames.Remove(sender);
                            sentMessages.Remove(sender);
                            recievedMessages.Remove(sender);
                            totalMessages.Remove(sender);

                        }
                        // check limit for reciever:
                        if ((sentMessages[reciever] + recievedMessages[reciever]) >= totalMessages[reciever])
                        {
                            Console.WriteLine($"{reciever} reached the capacity!");

                            usernames.Remove(reciever);
                            sentMessages.Remove(reciever);
                            recievedMessages.Remove(reciever);
                            totalMessages.Remove(reciever);

                        }


                    }






                }
                else if (commandArgs[0] == "Empty")
                {
                    string user = commandArgs[1];

                    if (user == "All")
                    {
                        usernames.Clear();
                        sentMessages.Clear();
                        recievedMessages.Clear();
                        totalMessages.Clear();
                    }
                    else
                    {
                        usernames.Remove(user);
                        sentMessages.Remove(user);
                        recievedMessages.Remove(user);
                        totalMessages.Remove(user);
                    }



                }


            }


            int counter = 0;
            foreach (string item in usernames)
            {
                counter++;
            }

            Console.WriteLine($"Users count: {counter}");


            foreach (string item in usernames)
            {
                int totalSentAndRecieved = (sentMessages[item]) + (recievedMessages[item]);
                Console.WriteLine($"{item} - {totalSentAndRecieved}");

            }



        }
    }
}
