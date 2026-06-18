using System.Diagnostics;

namespace Sisetec_pdv
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void canalYoutubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string navegador = "\"C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe\"";
            string url = "https://www.youtube.com/@etecdanstaquaritinga8806";
            Process.Start(navegador, url);
        }
    }
}
