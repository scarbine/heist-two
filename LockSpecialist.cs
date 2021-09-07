using System;

namespace heist_two
{
    public class LockSpecialist : IRobber
    {
            public string Name {get; set;}
        public int SkillLevel {get; set;}
        public int PercentageCut {get; set;}

        public void PerformSkill(Bank bank)
        {
            bank.VaultScore -= SkillLevel;
        }

         public string ListSpeciality
        {
            get{
            return $"{Name} is a master of the Locks with a skill level of {SkillLevel} and gets {PercentageCut} of the total take.";
            }
        }

    }
}