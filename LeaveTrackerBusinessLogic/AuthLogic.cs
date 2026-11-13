using LeaveTrackerData;

namespace LeaveTrackerBusinessLogic
{
    public class AuthLogic
    {
        private EmployeeData data = new EmployeeData();
        public int Login(string username, string password)
        {
            List<string> usernames = data.GetUsernames();
            List<string> passwords = data.GetPasswords();
            int index = usernames.IndexOf(username);
            if (index != -1 && passwords[index] == password)
            {
                return index;
            }
            return -1;
        }
    }
}
