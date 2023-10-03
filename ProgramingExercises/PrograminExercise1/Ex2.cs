using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPrograminLesson
{
    internal class Ex2
    {
        public string NameSurnameUpper(string name, string surname)
        {
            return ($"{name.ToUpper()} {surname.ToUpper()}");
        }
    }
}
