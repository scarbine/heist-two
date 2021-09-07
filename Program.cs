using System;
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
                Name = "PNFP",
                AlarmScore =alarmRan,
                CashOnHand = cashRan,
                SecurityGuardScore = securityRan,
                VaultScore = vaultRan
            };

            var bankPropertiesList = new List<int>{PNFP.AlarmScore, PNFP.SecurityGuardScore, PNFP.VaultScore};

            Console.WriteLine($"Most Secure: {bankPropertiesList.Max()}");
            Console.WriteLine($"Least Secure: {bankPropertiesList.Min()}");
            

            Console.WriteLine($"{PNFP.Name} has {PNFP.CashOnHand} cash on hand with an Alarm Score of {PNFP.AlarmScore}. Security Score of {PNFP.SecurityGuardScore} and a vault score of {PNFP.VaultScore}");
        }
    }
}
