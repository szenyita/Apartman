namespace Apartman
{
    public partial class Bejelentkezes : Form
    {
        public Bejelentkezes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (felhasznaloNevTextBox.Text == "admin" && jelszoTextBox.Text == "1234")
            {
                new Foglalas().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hibás Felhasználónév Vagy Jelszó");
            }
        }

        private void Bejelentkezes_Load(object sender, EventArgs e)
        {
            jelszoTextBox.PasswordChar = '*';
        }
    }
}
