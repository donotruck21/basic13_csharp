using System;

namespace ConsoleApplication
{
    public class Program
    {
        // Print 1-255
        public static void print255(){
            for(int i = 1; i <=255; i++){
                Console.WriteLine(i);
            }
        }


        // Print odd numbers between 1-255
        public static void printOdds(){
            for(int i = 1; i <=255; i+=2){
                Console.WriteLine(i);
            }
        }

        // Print Sum
        public static void printSums(){
            int sum = 0;
            for(int i = 1; i <=255; i++){
                sum += i;
                Console.WriteLine("New Number: " + i + " - New Sum: " + sum);
            }

        }
        
        // Iterating through an Array
        public static void printArray(int[] arr){
            for( int i = 0; i < arr.Length; i++){
                Console.WriteLine(arr[i]);
            }
        }


        // Find Max
        public static void findMax(int[] arr){
            int max = arr[0];
            for( int i = 1; i < arr.Length; i++){
                if(arr[i] > max){
                    max = arr[i];
                }
            }
            Console.WriteLine(max);
        }


        // Get Average
        public static void average(int[] arr){
            int sum = 0;
            for( int i = 0; i < arr.Length; i++){
                sum = sum + arr[i];
            }
            Console.WriteLine(sum/arr.Length);
        }        




        
        
        
        
        
        
        
        
        
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] myArray = {1,3,52,7,9,13};
            // print255();
            // printOdds();
            // printSums();
            // printArray(myArray);
            // findMax(myArray);
            average(myArray);
        }
    }
}
