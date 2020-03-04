using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	public class Logger
	{
		public void ShowBattle(Participant fighter1, Participant fighter2)
		{
			Console.WriteLine(fighter1.GetName() + " " + fighter1.GetHealth() + "%" + " vs " + fighter2.GetName() + " " + fighter2.GetHealth() + "%");
		}

		public void ShowWinner(Participant winner)
		{
			Console.WriteLine(winner.GetName() + " is winner!");
			Console.ReadKey();
		}

		public void ShowHit(Participant fighter)
		{
			Console.WriteLine(fighter.GetName() + " hits " + fighter.CalculateDamage() + "% of damage");
		}
	}
}
