using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzariaWebsite
{
    public static class SessionManager
    {
        public static List<string> sesList = new List<string>();
        public static int SessionId { get; set; }
        public static void AddSession(string sessionId)
        {
            sesList.Add(sessionId);
        }

        public static List<string> GetList()
        {
            return sesList;
        }

        public static void RemoveSessionId(string sessionId)
        {
            for (int i = 0; i < sesList.Count; i++)
            {
                if (sesList[i] == sessionId)
                {
                    sesList.Remove(sessionId);
                }
            }
        }

        public static int FindSessionId(string sessionId)
        {
            for (int i = 0; i < sesList.Count; i++)
            {
                if (sessionId == sesList[i])
                {
                    //return sessionId;
                }
            }
            return 0;
        }
    }
}