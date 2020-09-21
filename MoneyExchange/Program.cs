﻿using System;

namespace MoneyExchange
{
    class Program
    {
		static void Main(string[] args)
		{
			Guy joe = new Guy() { Name = "Joe", Cash = 50 };
			Guy bob = new Guy() { Name = "Bob", Cash = 100 };

			while (true)
			{
				joe.WriteMyInfo();
				bob.WriteMyInfo();
				Console.Write("Enter an amount: ");
				string howMuch = Console.ReadLine();
				if (howMuch == "") return;
				if (int.TryParse(howMuch, out int amount))
				{
					Console.Write("Who should give the cash: ");
					string whichGuy = Console.ReadLine();
					if (whichGuy == "Joe")
					{
						int cashGiven = joe.GiveCash(amount);
						bob.ReceiveCash(cashGiven);
					}
					else if (whichGuy == "Bob")
					{
						int cashGiven = bob.GiveCash(amount);
						joe.ReceiveCash(cashGiven);
					}
					else
					{
						Console.WriteLine("Please enter 'Joe' or 'Bob'");
					}
				}
				else
				{
					Console.WriteLine("Please enter an amount (or a blank line to exit).");
				}
			}
		}
	}

    internal class Guy
    {
        public string Name { get; internal set; }
        public int Cash { get; internal set; }

        internal int GiveCash(int amount)
        {
            throw new NotImplementedException();
        }

        internal void ReceiveCash(int cashGiven)
        {
            throw new NotImplementedException();
        }

        internal void WriteMyInfo()
        {
            throw new NotImplementedException();
        }
    }
}
