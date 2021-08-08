using System;
using System.Windows.Forms;

namespace emailViewer {
    public partial class Entry : Form {
        public Entry() {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e) {
            Form1._senha = txtSenha.Text;
            txtSenha.Text = "";
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
                btnOk.PerformClick();
        }

        public static string texto = "Digite a senha do e-mail:";

        private void Entry_Load(object sender, EventArgs e) {
            label1.Text = texto;
            if (texto.Contains("senha"))
                txtSenha.PasswordChar = '*';
            else
                txtSenha.PasswordChar = '\0';
        }
    }
}
