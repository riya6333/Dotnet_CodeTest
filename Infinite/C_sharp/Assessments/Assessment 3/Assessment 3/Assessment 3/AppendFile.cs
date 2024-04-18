using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


class AppendFile
    {
    public static void AppendTextToFile(string filePath, string textToAppend)
    {
       
        if (!File.Exists(filePath))
        {
            
            using (StreamWriter writer = File.CreateText(filePath))
            {
              
                writer.WriteLine("Initial content of the file.");
            }
        }

        
        using (StreamWriter writer = File.AppendText(filePath))
        {
            writer.WriteLine(textToAppend);
        }
    }
}

