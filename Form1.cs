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
                InvalidText.Text = "Girdiðiniz Bilgiler Hatalý";
            }
            else if (Username.Text != "Admin")
            {
                InvalidText.Text = "Kullanýcý Adý Hatalý";
            }
            else if (Password.Text != "1234")
            {
                InvalidText.Text = "Þifre Hatalý";
            }
            else
            {
                InvalidText.Text = "Hoþgeldiniz " + Username.Text;
                InvalidText.ForeColor = Color.DarkGreen;
            }
            InvalidText.Visible = true;
        }
    }
}