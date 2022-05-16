using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Diagrams_Ex1
{
    internal class Student
    {
        public string Name { get; private set; }

        int group;
        public int Group{
            get { return group; }
            private set
            {
                if((value >=1) && (value <=5))
                    group = value;
            }
        }
        static readonly char[] charlist = new char[] {'A','B','C','D','E','F'};
        
        char grade;
        public char Grade {
            get { return grade; } 
            private set {
                if (charlist.Contains(value))
                {
                    grade = value;
                }
                
            } 
        }
        
        private string secretNickName = "MySecretNickName";

        public Student(string name, int group, char grade)
        {
            Name = name;
            Group = group;
            Grade = grade;
        }

        public void upgrade()
        {
            int position = Array.IndexOf(charlist, grade);
            if(position != (charlist.Length)-1)  Grade = charlist[position + 1];
        }

        public void downgrade()
        {
            int position = Array.IndexOf(charlist, grade);
            if (position != 0) Grade = charlist[position - 1];

        }

    }
}
