using System;
using System.Windows.Forms;

namespace emailViewer {
    public partial class Inicio : Form {
        public Inicio() {
            InitializeComponent();
        }

        string arquivoEscolhido;
        public bool open;

        private string EscolherArquivo() {
            OpenFileDialog Caminho = new OpenFileDialog();
            Caminho.Filter = "Arquivo de e-mail|*.msg; *.eml";
            Caminho.FilterIndex = 1;
            Caminho.InitialDirectory = @"%userprofile%";
            if (Caminho.ShowDialog() == DialogResult.OK)
                return Caminho.FileName;
            else
                return "";
        }

        private void btnOpen1_Click(object sender, EventArgs e) {
            arquivoEscolhido = EscolherArquivo();
            if (arquivoEscolhido != "") {
                Form1 form1 = new Form1("");
                form1.Show();
                this.Hide();
            }
        }

        private void Inicio_Load(object sender, EventArgs e) {
            if (open) {
                btnOpen1.PerformClick();
                open = false;
            }
        }
    }
}
