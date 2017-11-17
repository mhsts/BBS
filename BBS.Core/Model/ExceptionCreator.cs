using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BBS
{
    public static class MessageBoxCreator
    {    	
	    public static void RaiseWarning(string str)
	    {
            Logger.Log(str);
            
            if (OnRaiseWarning != null)
            {
                OnRaiseWarning(str, "Waarschuwing");
            }
	    }

        public static void RaiseError(string txt, Exception e)
        {
            Logger.Log(txt + ":" + e.ToString());

            if (OnRaiseError != null)
            {
                OnRaiseError(txt, e.ToString());
            }
        }

        public static bool RaiseYesNo(string txt)
        {
            if (OnRaiseYesNo != null)
            {
                return OnRaiseYesNo(txt);
            }
            return false;
        }

        public static Action<string, string> OnRaiseError;
        public static Action<string, string> OnRaiseWarning;
        public static Func<string, bool> OnRaiseYesNo;
    }
}
