using System;

namespace PowerupSystem
{
    public class Shield : IPowerup
    {
        public TimeSpan Duration { get; set; }
        public Vector2 Position { get; set; }
        public bool IsActive { get; set; }
        
        public Shield(TimeSpan duration, Vector2 position)
        {
            Duration = duration;
            Position = position;
        }

        public void SetActive(bool isActive, Player owner)
        {
            IsActive = isActive;
            
            if (IsActive)
            {
                Console.WriteLine($"Shield is active for {owner.Name}.");
                while (IsActive)
                {
                    var input = Console.ReadLine();
                    if (input == "k")
                    {
                        owner.Health -= 10;
                        Console.WriteLine($"{owner.Name}'s health: {owner.Health}");
                    }
                }
            }
            else
            {
                Console.WriteLine($"Shield is inactive for {owner.Name}.");
                while (!IsActive)
                {
                    var input = Console.ReadLine();
                    if (input == "k")
                    {
                        owner.Health -= 20;
                        Console.WriteLine($"{owner.Name}'s health: {owner.Health}");
                    }
                }
            }
        }
    }
}