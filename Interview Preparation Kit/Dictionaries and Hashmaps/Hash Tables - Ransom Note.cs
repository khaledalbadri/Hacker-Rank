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

    // Complete the checkMagazine function below.
    static void checkMagazine(string[] magazine, string[] note) {
        Dictionary<string,int> mag = new Dictionary<string,int>();
        Dictionary<string,int> ransom = new Dictionary<string,int>();
        
        
         mag = ConvertArray(magazine);
         ransom = ConvertArray(note);
       
       bool result = true;
            
       foreach(KeyValuePair<string,int> item in ransom){
             
           if(!mag.Contains(item)){
               if(mag.ContainsKey(item.Key) && mag[item.Key] < item.Value)
               result = false;
              
           }
        }
            
            if(result == true){
                Console.WriteLine("Yes");
            
            }else{
                Console.WriteLine("No");
            }
            
    }
static private Dictionary<string,int> ConvertArray(string[] arr){
         Dictionary<string,int> dic = new Dictionary<string,int>();
            foreach(string word in arr){
                if(dic.ContainsKey(word)){
                    dic[word]++;
                
                }else{
                    dic.Add(word,1);
                
                
                }

            }
            return dic;
         }        
    static void Main(string[] args) {
        string[] mn = Console.ReadLine().Split(' ');

        int m = Convert.ToInt32(mn[0]);

        int n = Convert.ToInt32(mn[1]);

        string[] magazine = Console.ReadLine().Split(' ');

        string[] note = Console.ReadLine().Split(' ');

        checkMagazine(magazine, note);
    }
}
