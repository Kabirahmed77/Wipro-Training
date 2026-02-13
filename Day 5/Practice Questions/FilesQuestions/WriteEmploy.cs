﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FilesQuestions
{
    internal class WriteEmploy
    {
        static void Main()
        {
            Employ employ = new Employ();
            employ.Empno = 1;
            employ.Name = "Tushar";
            employ.Dept = "Java";
            employ.Desig = "Programmer";
            employ.Basic = 82833;
            FileStream fs = new FileStream("employdata.txt", FileMode.Create, FileAccess.Write);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(fs, employ);
            fs.Close();
            Console.WriteLine("Employ Data Stored in File...");
        }
     
    }
}