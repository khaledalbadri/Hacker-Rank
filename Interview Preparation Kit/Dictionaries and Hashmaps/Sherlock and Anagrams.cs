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

    // Complete the sherlockAndAnagrams function below.
    static int sherlockAndAnagrams(string s) {

        var sd = new Dictionary<char, int>();
        var total = new Dictionary<int, int>();
        var sb = new StringBuilder();

           
            // substring length
            for(var i = 1; i < s.Length; i++) {
                for(var j = 0; j <= s.Length - i; j++) {
                    sd.Clear();
                    for (var k = j; k < j + i; k++) {
                        // get hashcode of substring
                        if(sd.ContainsKey(s[k])) {
                            sd[s[k]] ++;
                        }
                        else {
                            sd.Add(s[k], 1);
                        }
                    }
                    // convert to hash code
                    sb.Clear();
                    foreach(var item in sd.OrderBy(x => x.Key)) {
                        sb.Append(item.Key + item.Value.ToString());
                    }
                    var key = sb.ToString().GetHashCode();
                    if(total.ContainsKey(key)) {
                        total[key] ++;
                    }
                    else {
                        total.Add(key, 1);
                    }
                }
            }
            // get pairs
            int result = 0;
            foreach(var item in total) {
                result += item.Value * (item.Value - 1) / 2;
            }
            return result;

    }
    

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++) {
            string s = Console.ReadLine();

            int result = sherlockAndAnagrams(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
