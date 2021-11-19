﻿using System.Collections.Generic;

namespace Dashboard.Server.Telemetry
{
    public class SessionAnalytics
    {
        /// Stores the userCount(int) at every time stamp(DateTime)
        public Dictionary<int, int> UserCountAtAnyTime;

        /// Stores the chat count(int) for each user(UserData) 
        public Dictionary<int, int> ChatCountForEachUser;

        /// returns the users who were present in the session for less than the minimum time(threshold time)
        public List<int> InsincereMembers;
    }
}