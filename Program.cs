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
                Name = "Tennessee Bank",
                AlarmScore =alarmRan,
                CashOnHand = cashRan,
                SecurityGuardScore = securityRan,
                VaultScore = vaultRan
            };

        

            Hacker John = new Hacker{
                Name = "John",
                SkillLevel = 50,
                PercentageCut = 20
            
            };
            Hacker Hector = new Hacker{
                Name = "Hector",
                SkillLevel = 50,
                PercentageCut = 20
            
            };

            LockSpecialist James = new LockSpecialist{
                Name = "James",
                SkillLevel = 20,
                PercentageCut = 10
            };
            LockSpecialist Seth = new LockSpecialist{
                Name = "Seth",
                SkillLevel = 20,
                PercentageCut = 10
            };
            Muscle Jeff = new Muscle{
                Name = "Jeff",
                SkillLevel = 23,
                PercentageCut = 13
            };
            Muscle Jimmy = new Muscle{
                Name = "Jimmy",
                SkillLevel = 23,
                PercentageCut = 13
            };

            List<IRobber> rolodex = new List<IRobber>{
                John, James, Jeff, Jimmy, Seth, Hector
            };

            List<IRobber> crew = new List<IRobber>();
            void ListPlayers()
            {
                int index = 0;
            foreach (IRobber r in rolodex)
            {
                // r.PerformSkill(PNFP);
                Console.WriteLine($"{index} ) {r.ListSpeciality}");
                index++;
            };
            }
            void ListCrew()
            {
                Console.WriteLine($"{crew.Count()}");
                int index = 0;
            foreach (IRobber c in crew)
            {
               
                Console.WriteLine($"{index} ) {c.ListSpeciality}");
                index++;
            };
            }
            var bankPropertiesList = new List<int>{PNFP.AlarmScore, PNFP.SecurityGuardScore, PNFP.VaultScore};
          
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

            
            void BankReport()
            {
                Console.WriteLine($"{PNFP.Name} has {PNFP.CashOnHand} cash on hand with an Alarm Score of {PNFP.AlarmScore}. Security Score of {PNFP.SecurityGuardScore} and a vault score of {PNFP.VaultScore} {PNFP.IsSecure}");
            }

            void NewTeamMember()
            {
                while (true)
                {
                    Console.WriteLine("Please enter a name for the new team member.");
                    string _newMember = Console.ReadLine();
                    if (_newMember == "")
                    {
                        break;
                    }
                    Console.WriteLine("Please choose specialty by number.");
                    Console.WriteLine("1) Hacker (Disables Alarm)");
                    Console.WriteLine("2) Muscle (Disarms Gaurd)");
                    Console.WriteLine("3) Lock Specialist (Cracks Vault)");
                    int _specialty = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter skill level. 0-100");
                    int _skillLevel = int.Parse(Console.ReadLine());
                    Console.WriteLine("What percent is the member asking? 0-100");
                    int _take = int.Parse(Console.ReadLine());
                    Console.WriteLine(_newMember);
                    Console.WriteLine(_take);
                    Console.WriteLine(_specialty);
                    Console.WriteLine(_skillLevel);

                    if (_specialty == 1)
                    {
                        Hacker h = new Hacker{
                            Name = _newMember,
                            SkillLevel = _skillLevel,
                            PercentageCut = _take
                        };
                        rolodex.Add(h);
                    }
                    else if (_specialty == 2)
                    {
                        Muscle m = new Muscle{
                            Name = _newMember,
                            SkillLevel = _skillLevel,
                            PercentageCut = _take
                        };
                        rolodex.Add(m);

                    }
                    else
                    {
                        LockSpecialist l = new LockSpecialist{
                            Name = _newMember,
                            SkillLevel = _skillLevel,
                            PercentageCut = _take
                        };
                        rolodex.Add(l);
                    }

                }
                

            }
            Game();
            void Game()
            {
                Console.WriteLine("Welcome to the Heist 2!");
                int _teamTotal = rolodex.Count();
                Console.WriteLine ($"The team currently has {_teamTotal} members.");
                // BankReport();
                Recon();
                ListPlayers();
                // BankReport();
                NewTeamMember();
                ListPlayers();
                
//  This block needs to be fixed so that it added the proper player chosen to the crew list. 
// Currently tryin to figure out how to access that with the current indexing method.
// May need to refactor the way that indexing is happeing on the roledex list
                while(true)
                {
                Console.WriteLine("Please enter the number of the operative you would like to add.");
                string selection = Console.ReadLine();
                if(selection == "")
                {
                    break ;
                }
                Console.WriteLine($"You Chose : {selection}");
                // This currently just adds John to the crew list
                crew.Add(John);
                }
                ListCrew();

                foreach (IRobber c in crew)
                {
                    c.PerformSkill(PNFP);
                }

                if (PNFP.IsSecure)
                {
                    Console.WriteLine("You were busted!");
                }
                else
                {
                    Console.WriteLine("You win!");
                }



            }
        }

    }
}
