using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	public class ParticipantManager
	{
		public static Human CreateHuman()
		{
			Human _human = new Human("Sonya", 30, 10);

			return _human;
		}

		public static Monster CreateMonster()
		{
			Monster _monster = new Monster("Subzero", 30, 15);

			return _monster;
		}

	}
}
