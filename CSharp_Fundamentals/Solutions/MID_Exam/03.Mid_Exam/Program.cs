using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Mid_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> messages = new List<string>();

            string command;
            //string pinnedM;
            //bool isPinnedM = false;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string cmdType = cmdArgs[0];

                if (cmdType == "Chat")
                {
                    messages.Add(cmdArgs[1]);
                }
                else if (cmdType == "Delete")
                {
                    string msgToDelete = cmdArgs[1];
                    if (messages.Contains(msgToDelete))
                    {
                        messages.RemoveAll(x => x == msgToDelete);
                    }

                }
                else if (cmdType == "Edit")
                {
                    string toEdit = cmdArgs[1];
                    string editedVersion = cmdArgs[2];

                    int indexToEdit = messages.IndexOf(toEdit);

                    if (messages.Contains(toEdit))
                    {
                        // list.Where(w => w.Name == "height").ToList().ForEach(s => s.Value = 30);
                        // messages.Where(x => x == toEdit).ToList().ForEach(s => s = editedVersion);
                        messages[indexToEdit] = editedVersion;
                        // if that doesn't work -> delete the edit and insert the new at it's index
                    }

                }
                else if (cmdType == "Pin")
                {
                    string pinnedM = cmdArgs[1];
                    if (messages.Contains(pinnedM))
                    {
                        messages.Remove(pinnedM);
                        //isPinnedM = true;
                        messages.Insert(messages.Count, pinnedM);
                    }

                }
                else if (cmdType == "Spam")
                {
                    for(int i = 1; i < cmdArgs.Length; i++)
                    {
                        messages.Add(cmdArgs[i]);
                    } 

                }

                /*
                if (isPinnedM)
                {
                    messages.Add(pinnedM);
                }
                */

            }


            Console.WriteLine(string.Join(Environment.NewLine, messages));

        }
    }
}
