using System;
using System.Collections.Generic;
using System.Text;

namespace _29MartTask2
{
    internal class Student
    {
        public Student(string groupNo ,string fullName)
        {
            this.GroupNo = groupNo;
            this.Fullname = fullName;
        }
        private string _groupNo;
        private string _fullName;
        public string Fullname { get=> _fullName; 
            set
            {
                if (CheckFullName(value)== true)
                {
                    _fullName = value;
                }
            }
                
                
        }
        public string GroupNo { get=> _groupNo;
            set
            {
                if (CheckGroupNo(value)== true)
                    _groupNo = value;
            }
        
        }
        public int age { get; set; }


        public static bool CheckGroupNo(string str)
        {
            if (char.IsUpper(str[0])&& char.IsDigit(str[1])&& char.IsDigit(str[2])&& char.IsDigit(str[3]))
            {
                return true;
            }
            return false;
        }
        public static bool CheckFullName(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLetter(str[i]))
                {
                    count++;
                }
            }
            
            if (count == str.Length-1)
            {
                var result = str.Split(' ');
                if (!String.IsNullOrWhiteSpace(result[0])&& !String.IsNullOrWhiteSpace(result[1]) && result.Length == 2)
                {
                    return true;
                }
            }
                
                return false;

            



        }
    }
}
