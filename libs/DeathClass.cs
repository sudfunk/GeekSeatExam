using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekSeatExam.libs
{
    public class DeathClass
    {

        public static int iWizardUnderControl { get; set; }
        public static int DeathOfYear(int iYearDeath)
        {
            int iKilled = 0;
            int iNegKill= iYearDeath;
            int[] mmgKilled = new int[Math.Abs(iYearDeath)];
            if (iNegKill < 0 || iNegKill == iWizardUnderControl)
            {
                iKilled = -1;
            }
            else
            {
                for (int ix = 0; ix < iYearDeath; ix++)
                {
                    if (ix < 0)
                    {
                        iKilled = ix;
                    }
                    else if (ix == 0)
                    {
                        iKilled = 1;
                    }
                    else
                    {
                        mmgKilled[ix] = ix;
                        iKilled += mmgKilled[ix];
                    }

                }
            }

            return iKilled;
        }

        public static string IntValidator( bool bVal )
        {
            string sMsg = "";
           if ( !bVal )
            {
                sMsg = "Please fill the value";
            }
           else { }
            return sMsg;
        }

    }
}
