using System;
using System.Collections.Generic;
using System.Text;

namespace _1JunePractiseP227
{
    class Citizen
    {
        private string _name;
        private string _surname;
        public byte Age;
        public string Name
        {
            get
            {
                return _name;
            } 
            set
            {
                if (!String.IsNullOrWhiteSpace(value) && Char.IsUpper(value[0]))
                {
                    bool check1 = false;
                    for (int i = 0; i < value.Length; i++)
                    {
                        if (Char.IsDigit(value[i]))
                        {
                            check1 = true;
                            break;
                        }            
                    }
                    if (check1 == false)
                    {
                        _name = value;
                    }
                }
              


            }
        }
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {     
                if (!String.IsNullOrWhiteSpace(value) && Char.IsUpper(value[0]))
                {
                    bool check = false;
                    for (int i = 0; i < value.Length; i++)
                    {
                        if (Char.IsDigit(value[i]))
                        {
                            check = true;
                            break;
                        }       
                    }
                    if (check == false)
                    {
                        _surname = value;
                    }
                }
            }
        }
    }
}
