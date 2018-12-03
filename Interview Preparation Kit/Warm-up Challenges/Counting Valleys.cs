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

    // Complete the countingValleys function below.
    static int countingValleys(int n, string s) {
        var seaLevel = 0;
        var valleyCount = 0;
        var totalNumberOfSteps = n;
        var garyStepRecord = s;
        var isValleyActive = false;

        for (int i = 0; i < totalNumberOfSteps; i++)
        {
            if (garyStepRecord[i] == 'U')
            {
                seaLevel++;
            }
            else
            {
                seaLevel--;
            }

            if (!isValleyActive && seaLevel < 0)
            {
                isValleyActive = true;
            }

            if (isValleyActive && seaLevel == 0)
            {
                valleyCount++;
                isValleyActive = false;
            }
        }
        return valleyCount;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        string s = Console.ReadLine();

        int result = countingValleys(n, s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
