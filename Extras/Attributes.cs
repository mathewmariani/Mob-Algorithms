using System;
namespace MOBAlgorithms.Desktop.Extras
{
    public class Attributes
    {
        private int totalHealth = 100;
        private int totalMana = 0;
        private int health = 0;
        private int mana = 0;

        private int strength;
        private int dexterity;
        private int constitution;
        private int intelligence;
        private int wisdom;
        private int charisma;

        public Attributes(int health, int mana, int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma)
        {
            this.health = health;
            this.mana = mana;
            this.strength = strength;
            this.dexterity = dexterity;
            this.constitution = constitution;
            this.intelligence = intelligence;
            this.wisdom = wisdom;
            this.charisma = charisma;
        }

        public Attributes()
        {}

        //Health
        public int getTotalHealth() { return totalHealth; }
        public void setTotalHealth(int totalHealth) { this.totalHealth = totalHealth; }
        public int getHealth() { return health; }
        public void setHealth(int health) { this.health = health; }
        public void recoverHealth(int points) { this.health = (this.health + points > totalHealth) ? totalHealth : this.health + points; }
        public void damage(int points) { this.health = (this.health - points > 0) ? this.health - points : 0; }

        //Mana
        public int getTotalMana() { return totalMana; }
        public void setTotalMana(int totalMana) { this.totalMana = totalMana; }
        public int getMana() { return mana; }
        public void setMana(int mana) { this.mana = mana; }
        public void recoverMana(int points) { this.mana = (this.mana + points > totalMana) ? totalMana : this.mana + points; }
        public void expendMana(int points) { this.mana = (this.mana - points > 0) ? this.mana - points : 0; }
        public void manaDrain() { this.mana = 0; }


        //Skills
        public int getStr() { return strength; }
        public void setStr(int strength) { this.strength = strength; }

        public int getDex() { return dexterity; }
        public void setDex(int dexterity) { this.dexterity = dexterity; }

        public int getCon() { return constitution; }
        public void setCon(int constitution) { this.constitution = constitution; }

        public int getInt() { return intelligence; }
        public void setInt(int intelligence) { this.intelligence = intelligence; }

        public int getWis() { return wisdom; }
        public void setWis(int wisdom) { this.wisdom = wisdom; }

        public int getChar() { return charisma; }
        public void setChar(int charisma) { this.charisma = charisma; }
    }
}
