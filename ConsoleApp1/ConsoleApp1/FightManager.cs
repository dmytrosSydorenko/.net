using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	public class FightManager
	{
		readonly Participant _firstFighter;
		readonly Participant _secondFighter;
		readonly Logger _logger;


		public FightManager(Participant firstFighter, Participant secondFighter, Logger logger)
		{
			_firstFighter = firstFighter;
			_secondFighter = secondFighter;
			_logger = logger;
		}

		public Participant Fight()
		{
			while (_firstFighter.IsAlive() && _secondFighter.IsAlive())
			{
				Hit();
			}

			return _firstFighter.IsAlive() ? _firstFighter : _secondFighter;
		}

		private void Hit()
		{
			Random random = new Random();

			int current = random.Next(1, 3);

			if (current == 1)
			{
				_secondFighter.SuffferDamage(_firstFighter.CalculateDamage());
				_logger.ShowHit(_firstFighter);
			}
			else
			{
				_firstFighter.SuffferDamage(_secondFighter.CalculateDamage());
				_logger.ShowHit(_secondFighter);
			}

			_logger.ShowBattle(_firstFighter, _secondFighter);
		}
	}
}
