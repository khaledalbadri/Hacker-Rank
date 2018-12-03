using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    // Complete the sockMerchant function below.
    static int sockMerchant(int n, int[] ar) 
    {
                
int count=0;
 var dict = new Dictionary<int, int>();

    foreach(int value in ar)
    {
        if (dict.ContainsKey(value))
            dict[value]++;
        else
            dict[value] = 1;
    }

    foreach(var pair in dict)
       {
           
           
           if(pair.Value % 2 == 0)
            count+=pair.Value / 2;
        else if (pair.Value > 1 )
            count+=pair.Value / 2;
        }
        return count;
    }   

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

  int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), x=>Int32.Parse(x.ToString().Trim())) ;
        int result = sockMerchant(n, ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
