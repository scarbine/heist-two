using System;

namespace heist_two
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank PNFP = new Bank{
                Name = "PNFP",
                AlarmScore =25,
                CashOnHand = 50000,
                SecurityGuardScore = 50,
                VaultScore = 75
            };

            Console.WriteLine($"{PNFP.Name} has {PNFP.CashOnHand} cash on hand with an Alarm Score of {PNFP.AlarmScore}. {PNFP.IsSecure}");
        }
    }
}
