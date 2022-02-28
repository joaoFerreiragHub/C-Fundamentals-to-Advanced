using System;

namespace Cast
{
    class Parse
    {
        static void Main(string[] args)
        {

            //Define few variables
            int age = 31;
            string name = "Afonoso";
            string job = "Developer";

            // 1. String concatenation
            Console.WriteLine("String concatenation");
            Console.WriteLine("Hello my name is " + name + ", I am " + age + " old");

            // 2. String formatting.
            // String formatting uses index

            Console.WriteLine("String Formatting");
            Console.WriteLine("Hello my name is {0} , I am {1} years old. I'm a {2}", name, age, job);


            // 3. String Interpolation
            //string Interpolation uses $ at the start which will allow us to write our
            // variables like this {variableName}

            Console.WriteLine("String Interpolation");
            Console.WriteLine($"Hello my name is {name}, and I'm {age} years old.");


            // 4. Verbatim strings.
            // verbatim strings start with @ and tells the compiler to take the string
            // literrally and ignore any spaces and escape characters like \n

            Console.WriteLine("Verbatim Strings");
            Console.WriteLine(@"Funciona maelhor com texto grande porque permite formatar
                a vontade");



        }
    }
}
