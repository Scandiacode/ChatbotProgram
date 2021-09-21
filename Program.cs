using System;

namespace ChatBot
{
    class Program
    {
        static void Main(string[] args)
        {
            string starterInput;
            string mainInput;
            bool byeAnswer = false;

            string doubleSay = "";

            while (!byeAnswer)
            {
                Console.WriteLine("What do you want to say to the bot?\n");
                
                starterInput = Console.ReadLine();
                mainInput = starterInput.ToLower();

                if (!mainInput.Equals(doubleSay))
                {
                    //Console.WriteLine(mainInput);


                    if (mainInput.Equals("hello"))
                    {
                        Console.WriteLine("Hi good to see you!\n");
                        
                    }
                    else if (mainInput.Equals("sup"))
                    {
                        Console.WriteLine("I am good.\n");
                        
                    }
                    else if (mainInput.Equals("hello there"))
                    {
                        Console.WriteLine("General Kenobi!\n");
                       
                    }
                    else
                    {
                        byeAnswer = true;
                    }


                    doubleSay = mainInput;


                }
                else
                {
                    Console.WriteLine("I'm sorry but you have already said that.\n");
                    
                }
            }
            

            Console.WriteLine("Good bye!");
            
        }
    }
}
