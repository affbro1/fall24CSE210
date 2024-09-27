using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the grade percent?");
        string grade = Console.ReadLine(); 
        int percent = int.Parse(grade);

        if (percent >= 90){
            Console.WriteLine("The entered grade is an A");}
        else if (percent >=80){
            Console.WriteLine("The entered grade is a B");
        } 
        else if (percent >=70){
            Console.WriteLine("The entered grade is a C");
        }
        else if (percent >= 60){
            Console.WriteLine("The entered grade is a D");
        }
        else Console.WriteLine("The enetered grade is an F");
    }
}