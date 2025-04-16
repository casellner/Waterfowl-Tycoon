namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void shopButton_Click(object sender, EventArgs e)
        {
            ShopForm shop = new();
            shop.Show();
        }
    }
}
