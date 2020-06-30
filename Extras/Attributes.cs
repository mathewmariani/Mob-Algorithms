using System;
namespace MOBAlgorithms.Desktop.Extras
{
    public class Attributes
    {      
        public Attributes(int health, int mana, int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma)
        {
            this.Health = health;
            this.Mana = mana;
            this.Strength = strength;
            this.Dexterity = dexterity;
            this.Constitution = constitution;
            this.Intelligence = intelligence;
            this.Wisdom = wisdom;
            this.Charisma = charisma;
        }

        public int Health { get; set; } = 0;
        public int Mana { get; set; } = 0;
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }

        public int TotalHealth { get; set; } = 100;
        public int TotalMana { get; set; } = 0;

        // Health helper functions
        public void recoverHealth(int points) { this.Health = (this.Health + points > this.TotalHealth) ? this.TotalHealth : this.Health + points; }
        public void damage(int points) { this.Health = (this.Health - points > 0) ? this.Health - points : 0; }

        // Mana helper functions
        public void recoverMana(int points) { this.Mana = (this.Mana + points > this.TotalMana) ? this.TotalMana : this.Mana + points; }
        public void expendMana(int points) { this.Mana = (this.Mana - points > 0) ? this.Mana - points : 0; }
        public void manaDrain() { this.Mana = 0; }
    }
}
