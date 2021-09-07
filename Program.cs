﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace heist_two
{
    class Program
    {
        static void Main(string[] args)
        {
            int alarmRan = new Random().Next(0,100);
            int vaultRan = new Random().Next(0,100);
            int securityRan = new Random().Next(0,100);
            int cashRan = new Random().Next(50000,1000000);

            Bank PNFP = new Bank{
                Name = "Tennessee Bank",
                AlarmScore =alarmRan,
                CashOnHand = cashRan,
                SecurityGuardScore = securityRan,
                VaultScore = vaultRan
            };

            BankReport();

            Hacker John = new Hacker{
                Name = "John",
                SkillLevel = 50,
                PercentageCut = 20
            
            };

            LockSpecialist James = new LockSpecialist{
                Name = "James",
                SkillLevel = 20,
                PercentageCut = 10
            };
            Muscle Jeff = new Muscle{
                Name = "Jeff",
                SkillLevel = 23,
                PercentageCut = 13
            };

            List<IRobber> rolodex = new List<IRobber>{
                John, James, Jeff
            };

            foreach (IRobber r in rolodex)
            {
                r.PerformSkill(PNFP);
                Console.WriteLine($"{r.Name} has a skill level of {r.SkillLevel} and gets a {r.PercentageCut} percent cut.");
            };

            var bankPropertiesList = new List<int>{PNFP.AlarmScore, PNFP.SecurityGuardScore, PNFP.VaultScore};
            Recon();
        void Recon()
          {
                if (bankPropertiesList.Max() == PNFP.AlarmScore)
                {
                    Console.WriteLine("Most Secure: Alarm");
                }
                else if (bankPropertiesList.Max() == PNFP.SecurityGuardScore)
                {
                    Console.WriteLine("Most Secure: Security Gaurd");
                }
                else
                {
                    Console.WriteLine("Most Secure: Vault");
                }

                if (bankPropertiesList.Min() == PNFP.AlarmScore)
                {
                    Console.WriteLine("Least Secure: Alarm");
                }
                else if (bankPropertiesList.Min() == PNFP.SecurityGuardScore)
                {
                    Console.WriteLine("Least Secure: Security Gaurd");
                }
                else
                {
                    Console.WriteLine("Least Secure: Vault");
                }
          } 

            BankReport();
            void BankReport()
            {
                Console.WriteLine($"{PNFP.Name} has {PNFP.CashOnHand} cash on hand with an Alarm Score of {PNFP.AlarmScore}. Security Score of {PNFP.SecurityGuardScore} and a vault score of {PNFP.VaultScore} {PNFP.IsSecure}");
            }
        }

    }
}
