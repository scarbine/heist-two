using System;

namespace heist_two
{
    public class Muscle : IRobber
    {
            public string Name {get; set;}
        public int SkillLevel {get; set;}
        public int PercentageCut {get; set;}
        // public int Index {get; set;} = 0;

        public void PerformSkill(Bank bank)
        {
            bank.SecurityGuardScore -= SkillLevel;
        }

          public string ListSpeciality
        {
            get{
            return $"{Name} is super strong with a skill level of {SkillLevel} and gets {PercentageCut} of the total take.";
            }
        }
    }
}