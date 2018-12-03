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

    // Complete the commonChild function below.
    static int commonChild(string s1, string s2) {

        int[,] L= new int[s1.Length+1,s2.Length+1];
        for(int i=0;i<=s1.Length;i++){
            for(int j=0;j<=s2.Length;j++){
                if(i==0 || j==0)
                    L[i,j]=0;
                else if(s1[i-1]==s2[j-1]){
                    L[i,j] = L[i-1,j-1]+1;
                }
                else{
                    L[i,j] = Math.Max(L[i-1,j],L[i,j-1]);
                }
            }
        }
        return L[s1.Length,s2.Length];

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s1 = Console.ReadLine();

        string s2 = Console.ReadLine();

        int result = commonChild(s1, s2);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
