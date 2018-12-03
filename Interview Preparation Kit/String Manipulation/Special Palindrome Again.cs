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

    // Complete the substrCount function below.
    static long substrCount(int n, string s) {
    int counter = n;
    int consec = 1;
    int midIndex = -1;
    for (int i = 1; i < n; i++) {
        if (s[i] == s[i-1]) {
            counter += consec;
            consec++;
            if (midIndex > 0) {
                if ((midIndex-consec) > 0 && s[midIndex-consec] == s[i]) {
                    counter++;
                } else {
                    midIndex = -1; 
                }
            }
        } else {
            consec = 1;
            
            if (((i-2) >= 0) && s[i-2] == s[i]) {
                counter++; 
                midIndex = i-1;
            } else {
                midIndex = -1;
            }
        }
    }
    return counter;

 
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        string s = Console.ReadLine();

        long result = substrCount(n, s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
