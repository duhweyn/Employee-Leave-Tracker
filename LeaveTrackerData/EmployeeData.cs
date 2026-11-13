using System;
using System.Collections.Generic;
using System.Text;

namespace LeaveTrackerData
{
    public class EmployeeData
    {
        private List<string> usernames = new List<string> { "Dwayne", "Nicole" };
        private List<string> passwords = new List<string> { "1234", "abcd" };
        public List<string> GetUsernames() { return usernames; }
        public List<string> GetPasswords() { return passwords; }
        private static List<int> balances = new List<int> { 15, 15 };
        public List<int> GetBalances() { return balances; }
    }
}
