using System;

namespace ATMGame 
{
    public class Program
    {

        public static decimal balance = 500 ;

        static void Main(string[] args)
        {
            UserInterface();
        }

        public static void UserInterface()
        {
            try
            {
                Console.WriteLine("Welcome to ATM system game\n Enter the number of the action you would like to select.");
                Console.WriteLine(" 1 To view your balance. \n 2 To withdraw from your balance. \n 3 To deposit tp your balance. \n 4 To end game!");
                String action = Console.ReadLine();
                bool runATM = true;
                while (runATM == true)
                {
                    switch (action)
                    {
                        case "1":
                            Console.WriteLine("Your Balance : " + ViewBalance());
                            break;
                        case "2":
                            Console.WriteLine("Please inter your withdraw");
                            decimal withdraw = Convert.ToDecimal(Console.ReadLine());
                            Console.WriteLine("Your balance after withdawing :" + Withdraw(withdraw));
                            break;
                        case "3":
                            Console.WriteLine("How much you want to deposit ?");
                            decimal deposit = Convert.ToDecimal(Console.ReadLine());
                            Console.WriteLine("Your balance after withdawing :" + Deposit(deposit));
                            break;
                        case "4":
                            runATM = false;
                            Console.WriteLine("Press enter to exit");

                            break;
                        default:
                            Console.WriteLine("Please inter the number between 1 to 4");
                            break;
                    }
                    action = Console.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("The program is end");
            }
        }


        public static decimal ViewBalance()
        {            
            return balance;
        }
        public static decimal Withdraw(decimal withdraw) 
        {
            decimal newBalance;
            if (withdraw > 0)
            {
                if (withdraw < balance)
                {
                    newBalance = balance - withdraw;
                    balance = newBalance;
                    return newBalance;
                }
                else
                {
                    Console.WriteLine("You cannot withdraw more than your balance, To know your balance press 1");
                    return balance;
                }
            }
            else
            {
                Console.WriteLine("You cannot withdraw less than zero");
                return balance;
            }
        }

        public static decimal Deposit(decimal deposit)
        {
            decimal newBalance;
            newBalance = balance + deposit;
            balance = newBalance;
            return newBalance;
        }
    }
}
