namespace BurgerKing
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }


        private void sipariþOluþturToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new SiparisOlusturForm().ShowDialog();

        }

        private void sipariþBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SiparisBilgileriForm().ShowDialog();
        }

        private void menüEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MenuEkleForm().ShowDialog();
        }

        private void ekstraMalzemeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EkstraMalzemeEkleForm().ShowDialog();
        }
    }
}