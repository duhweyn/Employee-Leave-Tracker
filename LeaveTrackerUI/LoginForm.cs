using LeaveTrackerBusinessLogic;   // top of the file

namespace LeaveTrackerUI
{
    public partial class LoginForm : Form
    {
        AuthLogic auth = new AuthLogic();
        int attempts = 0;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // textBox1 = username, textBox2 = password (your Designer names)
            int index = auth.Login(textBox1.Text, textBox2.Text);

            if (index != -1)
            {
                // temporary test message, replaced when MainForm exists
                MessageBox.Show("Login successful. User index: " + index);
                return;
            }

            attempts++;

            if (attempts >= 3)
            {
                MessageBox.Show("Too many failed attempts.");
                Close();   // closing the only form ends the program
                return;
            }

            MessageBox.Show($"Wrong username or password. Attempts left: {3 - attempts}");
            textBox2.Clear();
            textBox2.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}