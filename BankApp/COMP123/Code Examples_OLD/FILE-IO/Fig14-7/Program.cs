using System;
using System.IO;

public class WriteSomeText
{
    

    public static void Main()
    {
        //FileStream outFile;
        //StreamWriter writer;
        //try
        //{
            FileStream outFile = new FileStream(@"C:\Mydir\Myfile.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);
            Console.Write("Enter some text >> ");
            string text = Console.ReadLine();
            writer.WriteLine(text);
            // Error occurs if the next two statements are reversed
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine("Error: " + ex.Message);
        //}
        //finally
       // {
        //    writer.Close();
        //    outFile.Close();
       // }
            writer.Close();
            outFile.Close();
    }
}