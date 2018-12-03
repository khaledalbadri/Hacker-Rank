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

    // Complete the isValid function below.
    static string isValid(string s) {

        int del_count = 0;
        string result="YES";
        Dictionary<char, int> frequencies = new Dictionary<char, int>();
        foreach(char letter in s)
        if(frequencies.ContainsKey(letter))
                frequencies[letter]++;
            else
                frequencies.Add(letter, 1);
 int current = 0;

 foreach (KeyValuePair<char, int> count  in frequencies) {
   if(current == 0)
   {
                current = count.Value;
            }
            else
            {
                int diff = Math.Abs(current - count.Value);
                if(count.Value > 1 && diff > 0){
                    del_count += diff;
                }else if(count.Value == 1 && diff > 0){
                    del_count++;
                }
            }
}
      

  if(del_count > 1){
            result = "NO";
        }
        return result;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = isValid(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
