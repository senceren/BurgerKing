namespace BurgerKing
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }


        private void sipari�Olu�turToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new SiparisOlusturForm().ShowDialog();

        }

        private void sipari�BilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SiparisBilgileriForm().ShowDialog();
        }

        private void men�EkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MenuEkleForm().ShowDialog();
        }

        private void ekstraMalzemeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EkstraMalzemeEkleForm().ShowDialog();
        }
    }
}