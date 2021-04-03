using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzariaWebsite
{
    public static class SessionManager
    {
        static List<string> sesList = new List<string>();

        public static void AddSession(string sessionId)
        {
            sesList.Add(sessionId);
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

        public static string GetAllPizzaId(string sessionId)
        {
            string temp = "";
            for (int i = 0; i < sesList.Count; i++)
            {
                if (sesList[i].Contains(sessionId))
                {
                    temp += sessionId;
                }
            }

            return temp;
        }

        public static string GetAllSessionId()
        {
            string temp = "";
            for (int i = 0; i < sesList.Count; i++)
            {
                temp += sesList[i];
            }
            return temp;
        }

        public static string FindSessionId(string sessionId)
        {
            for (int i = 0; i < sesList.Count; i++)
            {
                if (sessionId == sesList[i])
                {
                    return sessionId;
                }
            }
            return null;
        }
    }
}