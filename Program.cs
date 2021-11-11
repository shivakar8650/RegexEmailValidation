using System;

namespace RegexPatternMaching
{
    class Program
    {
        static void Main(string[] args)
        {
            Pattern pattern = new Pattern();

            bool result=(pattern.validatePinCode("abc-100@abc.net"));
            if (result)
                Console.WriteLine(" Valid Email!");
            else
                Console.WriteLine("Invalid Email!");
            //valid:-
            //abc@yahoo.com
            // "abc.100@yahoo.com"
            //"abc-100@yahoo.com"
            //"abc111@abc.com"
            //"abc-100@abc.net"
            //"abc.100@abc.com.au"
            //"abc@1.com"
            // "abc@gmail.com.com"
            // "abc+100@gmail.com"


            //invalid:-
            // "abc()*@gmail.com"
            //"abc@%*.com"
            //"abc..2002@gmail.com"
            //"abc@abc@gmail.com"
            //"abc@gmail.com.1a"
            //"abc@gmail.com.aa.au"
        }
    }
}
