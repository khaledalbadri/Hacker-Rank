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

    // Complete the makeAnagram function below.
    static int makeAnagram(string a, string b) {
        Dictionary<char, int> s1Frequency = new Dictionary<char, int>();
        Dictionary<char, int> s2Frequency = new Dictionary<char, int>();
        int deletions = 0;

      for(int i = 'a'; i <= 'z'; i++)
        {
            s1Frequency.Add((char)i, 0);
            s2Frequency.Add((char)i, 0);
        }
foreach(char c in a)
 s1Frequency[c]++;

 foreach(char c in b)
 s2Frequency[c]++;

        List<char> list = new List<char>(s1Frequency.Keys);
        // Loop through list.
        foreach (char k in list)
        {
           int f1 = s1Frequency[k];
            int f2 = s2Frequency[k];
            
            deletions += Math.Abs(f1 - f2);
        }

        return deletions;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string a = Console.ReadLine();

        string b = Console.ReadLine();

        int res = makeAnagram(a, b);

        textWriter.WriteLine(res);

        textWriter.Flush();
        textWriter.Close();
    }
}
