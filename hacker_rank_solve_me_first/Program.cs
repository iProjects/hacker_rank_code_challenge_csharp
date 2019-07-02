/*
 * Created by SharpDevelop.
 * User: USER
 * Date: 06/11/2019
 * Time: 09:51 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Collections.Generic;
using System.IO;

namespace hacker_rank_solve_me_first
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("hacker rank in c# <<<<<<<<<<!!!!!!!!!!!!>>>>>>>>>>>");
			solveMeFirst_function();
			read_input_and_write_output();
			data_types_function();
			sum_arrays_fucntion();
	        Console.ReadLine();
		}
			
		static void solveMeFirst_function(){
			Console.WriteLine("enter two number to perform addition....");
			int val1 = Convert.ToInt32(Console.ReadLine());
	        int val2 = Convert.ToInt32(Console.ReadLine());
	        int sum = solveMeFirst(val1,val2);
	        Console.WriteLine(val1 + " plus " + val2 + " equals " + sum); 
		}
		
	    static int solveMeFirst(int a, int b) { 
	      // Hint: Type return a+b; below  
	      return a + b;
	    }
		
		static void read_input_and_write_output(){
			Console.WriteLine("enter a string literal to see its output....");
			// Declare a variable named 'inputString' to hold our input.
	        String inputString; 
	        
	        // Read a full line of input from stdin (cin) and save it to our variable, input_string.
	        inputString = Console.ReadLine(); 
	        
	        // Print a string literal saying "Hello, World." to stdout using cout.
	        Console.WriteLine("Hello, World.");
	        
	        // TODO: Write a line of code here that prints the contents of input_string to stdout.
	        Console.WriteLine("you entered [ " + inputString + " ]"); 
		}
		
		static void data_types_function(){
			int i = 4;
	        double d = 4.0;
	        string s = "HackerRank ";
	        
	        // Declare second integer, double, and String variables.
	        // Read and save an integer, double, and String to your variables. 
	        Console.WriteLine("enter one integer to perform addition with " + i + "....");
			int int1 = Convert.ToInt32(Console.ReadLine()); 
	        // Print the sum of both integer variables on a new line.
	        int _sum_int = i + int1;
	        Console.WriteLine(i + " plus " + int1 + " equals " + _sum_int); 
	        Console.WriteLine("enter one double to perform addition with " + d + "....");
			double double1 = Convert.ToDouble(Console.ReadLine()); 
	        // Print the sum of the double variables on a new line.
	        double _sum_double = d + double1;
	        Console.WriteLine(d + " plus " + double1 + " equals " + _sum_double); 
	        Console.WriteLine("enter string to perform concatenation....");
			string string1 = Convert.ToString(Console.ReadLine());  
	        // Concatenate and print the String variables on a new line
	        // The 's' variable above should be printed first.
	        Console.WriteLine(s + string1); 
		}
				
		static void sum_arrays_fucntion(){			
			Console.WriteLine("enter the array size");
			//The first line contains an integer, , denoting the size of the array. 
	    	int arCount = Convert.ToInt32(Console.ReadLine());
	        Console.WriteLine("enter space-separated integers representing the array's elements");
			//The second line contains space-separated integers representing the array's elements.
			int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
	        ;
			
			//Print the sum of the array's elements as a single integer.
	        int sum = 0;
	        string str_arr = "";
	        int count = 0;
	        for(int i = 0; i < ar.Length; i++){
	        	sum += ar[i];
	        	count++;
	        	if(count == ar.Length){
	        		str_arr += "[" + ar[i] + "]";
	        	}else{
	        		str_arr += "[" + ar[i] + "] + ";
	        	}
	        }
	        Console.WriteLine(str_arr + " equals " + sum); 
	        
		}
		
		static void sum_arrays_fucntion(){	
			
		}
 
		
		
		
		
		


	}
}



 