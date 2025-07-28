using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks.Dataflow;
using System.Runtime.InteropServices;




namespace Program
{

    interface IFile_operations
    {
        abstract void write_in_file();
        abstract void read_from_file();
        abstract void delete_file();
        abstract void create_file();

    };

    public class File_opeartions : IFile_operations
    {
        private string file_name;
        public File_opeartions(string name)
        {
            file_name = name;
        }

        public string get_file_name()
        {
            return file_name;
        }

        public void set_file_name(string x)
        {
            file_name = x;
        }
        public void write_in_file()
        {
            string path = "./" + file_name;
            if (File.Exists(path))
            {
                string input;

                StreamWriter w = new StreamWriter(path, append: true);
                Console.WriteLine("Write what you want in the file: ");
                while (!String.IsNullOrEmpty(input = Console.ReadLine()))
                {
                    w.WriteLine(input);
                }
                w.Close();
            }
        }
        public void read_from_file()
        {
            string path = "./" + file_name;
            if (File.Exists(path))
            {
                string[] readlines = File.ReadAllLines(path);
                foreach (string x in readlines)
                {
                    Console.WriteLine(x);
                }
            }
        }
        public void delete_file()
        {
            string path = "./" + file_name;
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }
        public void create_file()
        {
            File.AppendAllText(file_name, "");
        }
    };

    class AppInterface
    {
        private int action;
        public void start()
        {
            Console.WriteLine(@"--Hello to the File Editor--
What you want to do?
1-Create a file
2-Delete a file
3-Write a file
4-Read a file
5- Exit
");
            string file_name = "";
            File_opeartions file_manager = new File_opeartions(" ");
            action = Convert.ToInt32(Console.ReadLine());
            switch (action)
            {
                case (1):
                    Console.Write("Enter File name: ");
                    file_name = Console.ReadLine();
                    file_manager.set_file_name(file_name);
                    file_manager.create_file();
                    break;
                case (2):
                    Console.Write("Enter File name: ");
                    file_name = Console.ReadLine();
                    file_manager.set_file_name(file_name);
                    file_manager.delete_file();
                    break;
                case (3):
                    Console.Write("Enter File name: ");
                    file_name = Console.ReadLine();
                    file_manager.set_file_name(file_name);
                    file_manager.write_in_file();
                    break;
                case (4):
                    Console.Write("Enter File name: ");
                    file_name = Console.ReadLine();
                    file_manager.set_file_name(file_name);
                    file_manager.read_from_file();
                    break;
                case (5):
                    break;

            }
            restart(action);
        }
        private void restart(int x)
        {
            if (x < 5)
            {
                start();
            }

        }
    }
    class Program
    {
        static void Main()
        {
            AppInterface x = new AppInterface();
            x.start();
        }
    }

}