// referans, value tip ancag value oturur,biri deyisse o biri deyismir
// string referance typedir,amma stackdeki deyeri immutabledir.
// stringbuilder ile mutabledir (mutable olanlar thread safe deyil)
// ref,out yazanda value type referance type olur
// refde yuxaridaki mustdi,ashagi nicetohave
// out ,yuxarida initialize nicetohave,ashagi must ,yuxari da teyin etmesek de olar
// isnullorempty is isnullorwhitespace



using System.ComponentModel.DataAnnotations;

namespace Test
{
    public static class Program
    {
        
    
    public static void Main(string [] args)
    {

        // task1
        int product=FindProduct(12,23);
        Console.WriteLine(product);
        // task2
        int sqr=FindSqr(12);
        Console.WriteLine(sqr);
        // task3
        int[] array1={12,12,23};
        int sum1=FindSum(array1);
        Console.WriteLine(sum1);
        // task4
        PrintWelcomeMessage("Raksana","Allahverdiyeva");
        // task5
        string word1=ReverseWord("CodeAcademy");
        Console.WriteLine(word1);
        // task6
        CheckDivision(22);
        // task7
        int triangle=FindPerimeter(3,4,5);
        int square=FindPerimeter(7);
        Console.WriteLine(triangle);
        Console.WriteLine(square);
        // task11
        int counts= FindCountOfSpaces("salam usaqlar necesiz");
        Console.WriteLine(counts);



    }
    // task1
    public static int FindProduct(int a,int b){
            return a*b;

    }
    // task2
    public static int FindSqr(int a){
        return a*a;
    }
    // task3
    public static int FindSum(int[] array){
        int sum=0;
        foreach(var item in array){
            sum+=item;
        }
        return sum;
    }
    // task4
    public static void PrintWelcomeMessage(string name,string surname){
        Console.WriteLine($"Welcome to the page {name} {surname}!");

    }
    // task5
    public static string ReverseWord(string word){
        string reversed="";
        for(int i=word.Length-1;i>=0;i--){
            reversed+=word[i];
        }
        return reversed;
    }
    // task6
    public static void CheckDivision(int a){
        if (a%7==0){
            Console.WriteLine($"{a} ededi 7-e bolunur" ); 
        }
        else{
            
            int number=a/7;
            int answer=7*(number+1);
            int answer2=7*number;
            if (answer-a>a-answer2){
                    Console.WriteLine($"{answer2}" );

            }
            else{
                Console.WriteLine($"{answer} " );
            }
            

        }
    }
    // task7
    public static int FindPerimeter(int a, int b, int c){
        return a+b+c;
    }
    public static int FindPerimeter(int a){
        return a*4;
    }
    // task11
    public static int FindCountOfSpaces(string sentence){
        int count=0;
        for(int i=sentence.Length-1;i>=0;i--){
            if (sentence[i]==' '){
                count+=1;
            }
        }
        return count;
    }


    






}
}

