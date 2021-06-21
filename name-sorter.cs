using System;
using System.IO;

namespace GlobalX
{
   class SortName
   {
      const string OutputFileName = "./sorted-names-list.txt";
      static void Main(string[] args)
      {
         //read input
         string InputFileName = args[0];
         string[] unsortedNames = File.ReadAllLines(InputFileName);
         //call merge sort
         string[] sortedNames = mergeSort(unsortedNames);
         //print to console
         for(int i = 0; i<sortedNames.Length; i++){
            Console.WriteLine(sortedNames[i]);
         }
         //write to file
         File.WriteAllLines(OutputFileName,sortedNames);
         Console.ReadKey();
      }


      public static string[] mergeSort(string[] arr){
         if(arr.Length==1){
            return arr;
         }
         
         int mid = arr.Length/2;
         //create and copy the left half array
         string[] left = new string[mid];
         for(int i = 0;i < mid; i++){
            left[i] = arr[i]; 
         }
         //create and copy the right halft array
         int index = 0;
         string[] right = new string[arr.Length - mid];
         for(int i = mid; i < arr.Length; i++){
            right[index] = arr[i];
            index++;
         }
         //recursive
         return merge(mergeSort(left),mergeSort(right));
      }

      public static string[] merge(string[] left, string[] right){
         //an array to store elements after merged
         string[] result = new string[left.Length + right.Length];
         int i = 0;
         int j = 0;
         int k = 0;
         
         while(i!=left.Length && j!=right.Length){
            if(myCompare(left[i], right[j])){
               result[k] = left[i];
               i++;
            }else{
               result[k] = right[j];
               j++;
            }
            k++;
         }
         //getting out of the while loop means you either exaust the left array or the right array
         //copy and past rest elements into result array
         if(i<left.Length){
            do{
               result[k] = left[i];
               i++;
               k++; 
            }while(i<left.Length);

         }else{
            do{
               result[k] = right[j];
               j++;
               k++;   
            }while(j<right.Length);
         }

         return result;
      }

      
      //myCompare returns true if s1 is before s2 alphabetically,
      //and returns false if s2 is before s1 alphabetically
      public static Boolean myCompare(string s1, string s2){
         string firstNameOfS1 = getFirstName(s1);
         string lastNameOfS1 = getLastName(s1);
      
         string firstNameOfS2 = getFirstName(s2);
         string lastNameOfS2 = getLastName(s2);

         int precedence1 = string.Compare(lastNameOfS1,lastNameOfS2);

         if(precedence1==0){//last name equal
            //then compare firstname precedence
            int precedence2 = string.Compare(firstNameOfS1,firstNameOfS2);
            if(precedence2==-1){
               return true;
            }
            else{
               return false;
            }

         }else if(precedence1==-1){//directly return true if last name is precedent
            return true;

         }else{
            return false;
         }
      }

      public static string getLastName(string str){
         string[] substrings = str.Split(' ');
         //the last element is always lastname
         int lastNameIndex = substrings.Length -1;
         return substrings[lastNameIndex];//equivalent to substrings[^1] in C#8
      }

      public static string getFirstName(string str){
         string[] substrings = str.Split(' ');
         int firstNameMaxIndex = substrings.Length -1;
         //all element(s) execept the last one is(are) firstname(s)
         string firstnameWithoutSpace = "";
         for(int i = 0; i< firstNameMaxIndex;i++){
            firstnameWithoutSpace+=substrings[i];
         }
         return firstnameWithoutSpace;
      }

   }
}