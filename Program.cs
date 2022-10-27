using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace if_statements_project_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // isaac newton
            int age;
            Console.WriteLine("please enter your age ");
            age = Convert.ToInt32(Console.ReadLine());
            if (age > 18)
            {
                Console.WriteLine("Adult");
            }
            else if (age <= 5)
            {
                Console.WriteLine("toddler");
            }
            else if (age <= 12)
            {
                Console.WriteLine("preteen");
            }
            else if (age > 12)
            {
                Console.WriteLine("teen");
            }
            Console.WriteLine("Part 2 enter the case of hurrican you have from 1 to 5 ");
            DisplayCatagory();

            Console.WriteLine("Part 3 ");
            double bet = 0, roll, roll2;
            double currency = 100;
            string guess;
            Random generator = new Random();
            Console.WriteLine("Place a bet of no more then 100$ ");
            bet = Int32.Parse(Console.ReadLine());
            Console.WriteLine("option # 1 is if both dice are the same then your bet doubles ");
            Console.WriteLine("option # 2 is if its not a double and if you guess that you win half your bet ");
            Console.WriteLine("option # 3 is if both the dice rolled add up to a even number you win your bet back ");
            Console.WriteLine("option # 4 is if both the dice rolled add up to a uneven number you win and get your bet back ");
            roll = generator.Next(1,7);
            roll2 = generator.Next(1,7);
            guess = Console.ReadLine();
            currency -= bet;
            double totalroll = roll + roll2;
            if (bet > currency)
            {
                Console.WriteLine("no the bet must be less then 100 ");
                bet = 0;
            }
            if (guess == "1")
            {
                if (roll == roll2)
                {
                    bet *= 2;
                    Console.WriteLine(" Good guess you won double your bet the dice were " + totalroll);
                    currency += bet;
                    Console.WriteLine(currency);
                }
                else 
                {
                    currency -= bet;
                    Console.WriteLine("unfourtunate the dice were " + totalroll);
                    Console.WriteLine(currency);
                }
            }
            if (guess == "2")
            {
                if (roll != roll2)
                {
                    bet /= 2;
                    Console.WriteLine(" Good guess but you only get half the bet back " + totalroll);
                    currency += bet;
                    Console.WriteLine(currency);
                }
                else
                {
                    currency -= bet;
                    Console.WriteLine("good try but the cards were the same the dice rolled cause the dice added to  " + totalroll);

                }
                if (guess == "3")
                {
                    if (totalroll == 2 || totalroll == 4 || totalroll == 6 || totalroll == 8 || totalroll == 10 || totalroll == 12)
                    {
                        Console.WriteLine(" Nice guess you get your bet becasue the dice rolled " + totalroll);
                        currency += bet;
                        Console.WriteLine(totalroll);
;                       Console.WriteLine(currency);
                    }
                    else
                    {
                        currency -= bet;
                        Console.WriteLine(" Tuff luck u lose your bet the dice rolled " + totalroll);
                    }
                    if (guess == "4")
                    {
                        if (totalroll == 1|| totalroll == 3|| totalroll == 5|| totalroll == 7|| totalroll == 9|| totalroll == 11)
                        {
                            currency += bet;
                            Console.WriteLine("Congrats you won your bet the dice rolled " + totalroll);
                            Console.WriteLine(currency);
                        }
                        else
                        {
                            currency -= bet;
                            Console.WriteLine("nicee try bet ter luck next time the dice rolled " + totalroll);
                            Console.WriteLine(currency);
                        }
                    }
                }
            }
            
            













            Console.ReadKey();


            }
              public static void DisplayCatagory()
            {
            int mesurement = 0;
            mesurement = Int32.Parse(Console.ReadLine());
            switch (mesurement)

                {

                    case 1:
                    Console.WriteLine("that must mean your hurricant is about 74-95 mph ");
                    break;
                    case 2:
                    Console.WriteLine("the second case seems to reach the speeds of about 96 -110mph ");
                    break;
                    case 3:
                    Console.WriteLine("so it seems you have the third case that must mean your winds are reaching about 111-130mph ");
                    break;
                    case 4:
                    Console.WriteLine("you said that your case 4 so that means that your winds are reaching about 131- 155mph jeez");
                    break;
                    case 5:
                    Console.WriteLine("holy moley your speeds are higher then 155mph thats insane are you going to be okay ");
                    break;
                default:
                    break;
                }
            }  
        }
    }

