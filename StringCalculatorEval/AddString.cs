using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringCalculatorEval
{
    public class AddString
    {
        public static int Add(string entrée)

        {
            var part = entrée.Split(',');
            return part.Select(int.Parse).Sum();


        }


        

    }

   



}
