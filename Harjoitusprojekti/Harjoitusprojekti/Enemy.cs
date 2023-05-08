using System;

namespace KnightsQuest
{
    class Enemy
    {
        
        public int Health { get; set; } = 50;

        public int Rithealth { get; set; } = 75;

        public int Lohhealth { get; set; } = 150;
        
        public int AttackDamage { get; set; } = 5;

        
        public bool IsWeakToAbility { get; set; } = false;

        
        public bool IsDefeated { get { return Health <= 0; } }
        public bool IsDefeatedloh { get { return Lohhealth <= 0; } }
        public bool IsDefeatedrit { get { return Rithealth <= 0; } }

        
        public void Attack(Player player)
        {
            int damage = AttackDamage;
            Console.WriteLine($"Vihollinen hyökkää sinuun ja tekee {damage} damagea!");
            player.TakeDamage(damage);
        }

        
        public void TakeDamage(int damage)
        {
            
            if (IsWeakToAbility)
            {
                damage *= 2;
                Console.WriteLine($"Sinä isket vihollisen heikkoon kohtaan ja teet {damage} damagea!");
            }
            else
            {
                Console.WriteLine($"Sinä isket viholliseen ja teet {damage} damagea!");
            }

            Health -= damage;
            Rithealth -= damage;
            Lohhealth -= damage;
        }
    }
}