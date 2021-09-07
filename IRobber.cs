using System;

namespace heist_two
{
    public interface IRobber
    {
        public string Name {get; set;}
        // public int Index {get; set;}
        public int SkillLevel {get; set;}
        public int PercentageCut {get; set;}

        public void PerformSkill(Bank bank)
        {
          
        }
        public string ListSpeciality {
            get
            {
                return "";
            }
        }

    }
}