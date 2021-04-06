using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzariaWebsite
{
    public static class SessionManager
    {
        public static List<int> sesList = new List<int>();
        public static int SessionId { get; set; }
        public static void AddSession(int sessionId)
        {
            sesList.Add(sessionId);
        }

        public static List<int> GetList()
        {
            return sesList;
        }

        public static void RemoveSessionId(int sessionId)
        {
            for (int i = 0; i < sesList.Count; i++)
            {
                if (sesList[i] == sessionId)
                {
                    sesList.Remove(sessionId);
                }
            }
        }

        public static string GetAllPizzaId(int sessionId)
        {
            string temp = "";
            for (int i = 0; i < sesList.Count; i++)
            {
                //if (sesList[i].Contains(sessionId))
                //{
                //    temp += sessionId;
                //}
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

        public static int FindSessionId(int sessionId)
        {
            for (int i = 0; i < sesList.Count; i++)
            {
                if (sessionId == sesList[i])
                {
                    return sessionId;
                }
            }
            return 0;
        }
    }
}