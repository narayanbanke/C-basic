﻿using System;
using System.IO;
using System.Text;

class Test
{
    public static void Main()
    {
        // Create a temporary file, and put some data into it.
        WriteAccess();
        ReadAccess();
    }

    static void  WriteAccess()
    {
        string path = Path.GetTempFileName();
        using (FileStream fs = File.Open(path, FileMode.Open, FileAccess.Write, FileShare.None))
        {
            Byte[] info = new UTF8Encoding(true).GetBytes("This is some text in the file.");
            // Add some information to the file.
            fs.Write(info, 0, info.Length);
        }

        // Open the stream and read it back.
        using (FileStream fs = File.Open(path, FileMode.Open))
        {
            byte[] b = new byte[1024];
            UTF8Encoding temp = new UTF8Encoding(true);

            while (fs.Read(b, 0, b.Length) > 0)
            {
                Console.WriteLine(temp.GetString(b));
            }
        }
    }
    static void ReadAccess()
    {
        // This sample assumes that you have a folder named "c:\temp" on your computer.
        string filePath = @"c:\temp\MyTest.txt";

        // Delete the file if it exists.
        if (File.Exists(filePath))
        {
            File.Delete(filePath);
        }

        // Create the file.
        using (FileStream fs = File.Create(filePath))
        {
            Byte[] info = new UTF8Encoding(true).GetBytes("This is some text in the file.");
            // Add some information to the file.
            fs.Write(info, 0, info.Length);
        }

        // Open the stream and read it back.
        using (FileStream fs = File.Open(filePath, FileMode.Open, FileAccess.Read))
        {
            byte[] b = new byte[1024];
            UTF8Encoding temp = new UTF8Encoding(true);

            while (fs.Read(b, 0, b.Length) > 0)
            {
                Console.WriteLine(temp.GetString(b));
            }

            try
            {
                // Try to write to the file.
                fs.Write(b, 0, b.Length);
            }
            catch (Exception e)
            {
                Console.WriteLine("Writing was disallowed, as expected: {0}", e.ToString());
            }
        }
    }


}
 