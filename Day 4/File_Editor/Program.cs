using System;
using System.IO;
using System.Collections.Generic;


namespace Program
{

    class Program
    {
        static void Main()
        {
            bool running = true;
            int action;
            string path = "./";
            string file_name;
            while (running)
            {
                Console.WriteLine(@"--Hello to the File Editor--
What you want to do?
1-Create a file
2-Delete a file
3-Write a file
4-Read a file
5- Exit
");
                action = Convert.ToInt32(Console.ReadLine());
                switch (action)
                {
                    case (1):
                        Console.Write("Enter File name: ");
                        file_name = Console.ReadLine();
                        File.AppendAllText(file_name, "");
                        break;
                    case (2):
                        Console.Write("Enter File name: ");
                        file_name = Console.ReadLine();
                        path = path + file_name;
                        if (File.Exists(path))
                        {
                            File.Delete(path);
                        }
                        break;
                    case (3):
                        Console.Write("Enter File name: ");
                        file_name = Console.ReadLine();
                        path = path + file_name;
                        if (File.Exists(path))
                        {
                            string input;

                            StreamWriter w = new StreamWriter(path, append:true);
                            Console.WriteLine("Write what you want in the file: ");
                            while (!String.IsNullOrEmpty(input = Console.ReadLine()))
                            {
                                w.WriteLine(input);
                            }
                            w.Close();
                        }
                        break;
                    case (4):
                        Console.Write("Enter File name: ");
                        file_name = Console.ReadLine();
                        path = path + file_name;
                        if (File.Exists(path))
                        {
                            string[] readlines = File.ReadAllLines(path);
                            foreach (string x in readlines) {
                                Console.WriteLine(x);
                            }
                        }
                        break;
                    case (5):
                        running = false;
                        break;
                }
            }
        }
    }
}