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
                MessageBox.Show("Hib�s Felhaszn�l�n�v Vagy Jelsz�");
            }
        }

        private void Bejelentkezes_Load(object sender, EventArgs e)
        {
            jelszoTextBox.PasswordChar = '*';
        }
    }
}
