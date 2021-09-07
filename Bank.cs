using System;

namespace heist_two
{
    public class Bank
    { 
        public string Name {get; set;}
        
        public int CashOnHand {get; set;}

        public int AlarmScore {get;set;}

        public int VaultScore {get; set;}

        public int SecurityGuardScore {get; set;}

        public bool IsSecure 
        {
            get
        {
            if ( AlarmScore <=0 && VaultScore <=0 && SecurityGuardScore <=0 )
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        }
    }
}