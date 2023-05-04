namespace MyFirstFormAppProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            InvalidText.ForeColor = Color.IndianRed;
            if (Username.Text != "Admin" && Password.Text != "1234")
            {
                InvalidText.Text = "Girdi�iniz Bilgiler Hatal�";
            }
            else if (Username.Text != "Admin")
            {
                InvalidText.Text = "Kullan�c� Ad� Hatal�";
            }
            else if (Password.Text != "1234")
            {
                InvalidText.Text = "�ifre Hatal�";
            }
            else
            {
                InvalidText.Text = "Ho�geldiniz " + Username.Text;
                InvalidText.ForeColor = Color.DarkGreen;
            }
            InvalidText.Visible = true;
        }
    }
}