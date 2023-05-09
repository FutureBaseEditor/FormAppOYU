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

        private void Username_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxes();
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxes();
        }

        void ValidateTextBoxes()
        {
            LoginButton.Enabled = Username.Text.Trim() != "" && Password.Text.Trim() != "";
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        //bool Kontrol()
        //{
        //    string[] kullaniciAdlari = { "Admin", "Mustafa", "Dila" };

        //    for (int i = 0; i < kullaniciAdlari.Length; i++)
        //    {
        //        if (Username.Text == kullaniciAdlari[i])
        //        {
        //            return true;
        //        }
        //    }

        //    return false;
        //}
    }
}