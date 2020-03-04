using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	public abstract class Participant
	{
		public string _name;
		public int _health = 100;
		public int _force;

		public Participant(string name, int force)
		{
			_name = name;
			_force = force;
		}

		public virtual void SuffferDamage(int damage)
		{
			_health -= damage;

			if (_health < 0)
			{
				_health = 0;
			}
		}

		public virtual int CalculateDamage()
		{
			return _force;
		}

		public int GetHealth()
		{
			return _health;
		}

		public string GetName()
		{
			return _name;
		}

		public bool IsAlive()
		{
			return GetHealth() > 0;
		}

	}

	public class Human : Participant
	{
		int _blessing;

		public Human(string name, int force, int blessing) : base(name, force)
		{
			_blessing = blessing;
		}

		public override void SuffferDamage(int damage)
		{
			int _damage = damage - _blessing;

			if (_damage < 0)
			{
				_damage = 0;
			}

			base.SuffferDamage(_damage);
		}
	}

	public class Monster : Participant
	{
		int _fury;

		public Monster(string name, int force, int fury) : base(name, force)
		{
			_fury = fury;
		}

		public override int CalculateDamage()
		{
			return _force + _fury;
		}
	}
}
