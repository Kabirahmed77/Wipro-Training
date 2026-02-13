using System;

namespace FilesQuestions
{
    [Serializable] 
    internal class Employ
    {
       
        public int Empno { get; set; }
        public string Name { get; set; }
        public string Dept { get; set; }
        public string Desig { get; set; }
        public double Basic { get; set; }

        public Employ() { }
    }
}