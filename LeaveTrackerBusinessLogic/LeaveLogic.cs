using LeaveTrackerData;

namespace LeaveTrackerBusinessLogic
{
    public class LeaveLogic
    {
        private EmployeeData data = new EmployeeData();

        public int GetBalance(int userIndex)
        {
            return data.GetBalances()[userIndex];
        }

        public bool RequestLeave(int userIndex, int days, out string message)
        {
            List<int> balances = data.GetBalances();

            if (days < 1)
            {
                message = "Enter at least 1 day.";
                return false;
            }

            if (days > balances[userIndex])
            {
                message = "Not enough balance. You have " + balances[userIndex] + " day(s).";
                return false;
            }

            balances[userIndex] -= days;
            message = "Approved. Remaining balance: " + balances[userIndex];
            return true;
        }
    }
}