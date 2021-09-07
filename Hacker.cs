using System;

namespace heist_two
{
    public class Hacker : IRobber
    {
    public string Name {get; set;}
        public int SkillLevel {get; set;}
        public int PercentageCut {get; set;}

        public void PerformSkill(Bank bank)
        {
            bank.AlarmScore -= SkillLevel;
        }
    }
}