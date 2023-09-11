﻿using OOP.Game.Intefraces;

namespace OOP.Game.AbstractClasses
{
    /// <summary>
    /// Абстрактный базовый класс для препятствий в игре.
    /// </summary>
    abstract class Obstacle : IGameElement, IObstacle
    {
        public int X { get; set; }

        public int Y { get; set; }

        public int HealthDamage { get; set; }

        public Obstacle(int healthDamage)
        {
            HealthDamage = healthDamage;
        }

        /// <summary>
        /// Метод для нанесения урона персонажу при столкновении с препятствием.
        /// </summary>
        /// <param name="person">Персонаж, который получает урон.</param>
        public virtual void DamagePerson(Person person)
        {
            Console.WriteLine($"{GetType().Name} наносит {HealthDamage} урона персонажу {person.GetType().Name}.");

            person.HP -= HealthDamage;
        }
    }
}
