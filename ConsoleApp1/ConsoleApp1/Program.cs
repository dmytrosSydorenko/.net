using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Human _human = ParticipantManager.CreateHuman();
			Monster _monster = ParticipantManager.CreateMonster();
			Logger _logger = new Logger();

			FightManager battle = new FightManager(_human, _monster, _logger);

			_logger.ShowBattle(_human, _monster);

			Participant winner = battle.Fight();

			_logger.ShowWinner(winner);
		}

		
	}
}
