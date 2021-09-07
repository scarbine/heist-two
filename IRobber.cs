using System;

namespace heist_two
{
    public interface IRobber
    {
        string Name {get; set;}
        // public int Index {get; set;}
        int SkillLevel {get; set;}
        int PercentageCut {get; set;}

        void PerformSkill(Bank bank)
        {
          
        }
        string ListSpeciality {
            get
            {
                return "";
            }
        }

    }
}