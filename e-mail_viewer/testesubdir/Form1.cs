using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MsgReader.Mime.Header;
using MsgReader.Outlook;
using MsgReader.Mime;
using System.Diagnostics;
using System.Web;
using System.Text;

namespace emailViewer {
    public partial class Form1 : Form {
        public Form1(string _arg) {
            arg = _arg;
            InitializeComponent();
        }

        string arg = "", config = Path.GetDirectoryName(Application.ExecutablePath) + "\\Email_Viewer.conf";
        string arquivoEscolhido, mensagem, body, html, html1;
        string anexosDir = Environment.ExpandEnvironmentVariables(@"%temp%\anexosEmailViewer\");
        public static string _senha;
        Attachment attachment;
        List<string> anexos = new List<string>();
        string email = "", nome = "", usuario = "", senha = "";
        List<LinkLabel> linkLabels = new List<LinkLabel>();
        List<string> anexados = new List<string>();

        private string EscolherArquivo(string filtro = "Arquivo de e-mail|*.msg; *.eml") {
            OpenFileDialog Caminho = new OpenFileDialog();
            Caminho.Filter = filtro;
            Caminho.FilterIndex = 1;
            Caminho.InitialDirectory = @"%userprofile%";
            if (Caminho.ShowDialog() == DialogResult.OK)
                return Caminho.FileName;
            else
                return "";
        }

        private string EscolherPasta() {
            OpenFileDialog folderBrowser = new OpenFileDialog();
            folderBrowser.ValidateNames = false;
            folderBrowser.CheckFileExists = false;
            folderBrowser.CheckPathExists = true;
            folderBrowser.FileName = "[Pasta]";
            if (folderBrowser.ShowDialog() == DialogResult.OK)
                return Path.GetDirectoryName(folderBrowser.FileName);
            else
                return "";
        }

        void LegendaBotao(Control botao, string legenda) {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(botao, legenda);
        }

        private void Form1_Load(object sender, EventArgs e) {
            LegendaBotao(btnEditarMail, "Editar e-mail");
            LegendaBotao(label5, "Editar e-mail");
            if (Config()) {
                if (!Directory.Exists(anexosDir))
                    Directory.CreateDirectory(anexosDir);
                txtDe.Text = email;
                if (arg != "") {
                    arquivoEscolhido = arg;
                    AbriuArquivo();
                }
            } else {
                MessageBox.Show("O e-mail não foi configurado, favor abra o programa novamente e configure", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        bool Config(bool apagar = false) {
            bool retorno = false;
            if (!File.Exists(config) || apagar) {
                string final = "";
                Entry entry = new Entry();
                Entry.texto = "Digite o nome do seu e-mail";
                if (entry.ShowDialog() == DialogResult.OK) {
                    final += "email=" + Form1._senha;
                    Entry.texto = "Digite o usuário de e-mail:";
                    if (entry.ShowDialog() == DialogResult.OK) {
                        final += Environment.NewLine + "user=" + Form1._senha;
                        Entry.texto = "Digite a senha do e-mail:";
                        if (entry.ShowDialog() == DialogResult.OK) {
                            final += Environment.NewLine + "pass=" + Form1._senha;
                            Entry.texto = "Digite seu nome:";
                            if (entry.ShowDialog() == DialogResult.OK) {
                                final += Environment.NewLine + "name=" + Form1._senha;
                                File.WriteAllText(config, final);
                                Program.CriptArquivo(config, "mail");
                            }
                        }
                    }
                    if (apagar)
                        try {
                            File.Delete(config);
                        } catch (Exception ex) {
                            MessageBox.Show("Ocorreu um erro ao tentar editar o arquivo " + config + Environment.NewLine + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Application.Exit();
                        }
                }
            }

            if (File.Exists(config)) {
                Program.DescriptArquivo(config, "mail");
                string[] linhas = File.ReadAllLines(config);
                Program.CriptArquivo(config, "mail");
                foreach (string linha in linhas)
                    if (linha.Contains("email="))
                        email = linha.Split('=')[1];
                    else if (linha.Contains("user="))
                        usuario = linha.Split('=')[1];
                    else if (linha.Contains("pass="))
                        senha = linha.Split('=')[1];
                    else if (linha.Contains("name="))
                        nome = linha.Split('=')[1];
                retorno = true;
            }
            return retorno;
        }

        void AtalhoAbrir(KeyEventArgs e) {
            if (e.KeyCode == Keys.F5)
                btnAtualizar.PerformClick();
            else if ((ModifierKeys & Keys.Control) == Keys.Control)
                if (e.KeyCode == Keys.O)
                    btnOpen1.PerformClick();
        }

        private void txtDe_KeyDown(object sender, KeyEventArgs e) {
            AtalhoAbrir(e);
        }

        private void txtPara_KeyDown(object sender, KeyEventArgs e) {
            AtalhoAbrir(e);
        }

        private void txtMensagem_KeyDown(object sender, KeyEventArgs e) {
            AtalhoAbrir(e);
        }

        private void txtAssunto_KeyDown(object sender, KeyEventArgs e) {
            AtalhoAbrir(e);
        }

        private void txtCaminho_KeyDown(object sender, KeyEventArgs e) {
            AtalhoAbrir(e);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e) {
            AtalhoAbrir(e);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start(anexos[0]);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start(anexos[1]);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start(anexos[2]);
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start(anexos[3]);
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start(anexos[4]);
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start(anexos[5]);
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start(anexos[6]);
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start(anexos[7]);
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start(anexos[8]);
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start(anexos[9]);
        }

        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start(anexos[10]);
        }

        private void linkLabel12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start(anexos[11]);
        }

        void DeletarArquivos() {
            foreach (string file in Directory.GetFiles(anexosDir))
                File.Delete(file); //Deleta os aruqivo de anexo
        }

        void MsgEml(string arquivo) {
            DateTime dateTime = new DateTime();
            string de = "", para = "", cc = "", assunto = "";

            if (Path.GetExtension(arquivo) == ".msg") {
                using (var msg = new Storage.Message(arquivoEscolhido)) {
                    para = msg.GetEmailRecipients(RecipientType.To, true, false);
                    cc = msg.GetEmailRecipients(RecipientType.Cc, true, false);
                    de = msg.GetEmailSender(true, false);
                    assunto = msg.Subject;
                    dateTime = Convert.ToDateTime(msg.SentOn); //Escreve a data em extenso                    
                    html = msg.BodyHtml; //pega o html

                    foreach (object obj in msg.Attachments) {
                        Storage.Attachment attach = obj as Storage.Attachment;
                        byte[] attachBytes = attach.Data;
                        File.WriteAllBytes(anexosDir + attach.FileName, attachBytes);
                    }
                }
            }
            else if (Path.GetExtension(arquivo) == ".eml") {
                using (var stream = File.Open(arquivoEscolhido, FileMode.Open, FileAccess.Read)) {
                    var message = MsgReader.Mime.Message.Load(stream);
                    var bodyPart = message.HtmlBody ?? message.TextBody;
                    if (bodyPart != null) html = bodyPart.GetBodyAsText();
                    html = html.Replace("charset=iso-8859-1", "charset=utf-8");

                    List<RfcMailAddress> mailAddresses = new List<RfcMailAddress>();
                    mailAddresses = message.Headers.To;
                    foreach (var i in mailAddresses)
                        para = para + i.ToString() + " ";
                    mailAddresses = message.Headers.Cc;
                    foreach (var i in mailAddresses)
                        cc = cc + i.ToString() + " ";
                        de = message.Headers.From.ToString();
                        assunto = message.Headers.Subject.ToString();
                    try {
                        dateTime = Convert.ToDateTime(message.Headers.Date);
                    } catch { dateTime = DateTime.Parse(Regex.Split(message.Headers.Date, "0000 ")[0].Split('+')[0]); }

                    foreach (MessagePart attachment in message.Attachments)
                        File.WriteAllBytes(anexosDir + attachment.FileName, attachment.Body);
                }
            }

            html = html.ToLower();
            body = "<body" + Regex.Split(html, "<body")[1].Split('>')[0] + ">";
            html1 = "---------- Menssagem encaminhada ---------<br>" + "<b>De:</b> " + de + "<br>" +
                "<b>Enviado em:</b> " + ConverterData(dateTime) + "<br>" +
                "<b>Para:</b> " + para + "<br>" +
                "<b>Cc:</b> " + cc + "<br>" +
                "<b>Assunto:</b> " + assunto + "<br><br>";
            webBrowser1.DocumentText = Regex.Replace(html, body, body + html1); //Une as informações ao html
            File.WriteAllText(anexosDir + "Mensagem.html", HttpUtility.HtmlDecode(Regex.Replace(html, body, body + html1)), Encoding.UTF8); //Corrige os acentos e escreve num arquivo
            txtAssunto.Text = assunto;

            try {
                anexos.Clear();
                for (int i = 0; i <= 12; i++) {
                    linkLabels[i].Visible = false;
                    linkLabels[i].Text = "";
                }
                //linkLabels.Clear();
            } catch { }            

            linkLabels.Add(linkLabel1);
            linkLabels.Add(linkLabel2);
            linkLabels.Add(linkLabel3);
            linkLabels.Add(linkLabel4);
            linkLabels.Add(linkLabel5);
            linkLabels.Add(linkLabel6);
            linkLabels.Add(linkLabel7);
            linkLabels.Add(linkLabel8);
            linkLabels.Add(linkLabel9);
            linkLabels.Add(linkLabel10);
            linkLabels.Add(linkLabel11);
            linkLabels.Add(linkLabel12);

            int n = 0;
            foreach (string anexo in Directory.GetFiles(anexosDir)) {
                if (Path.GetFileName(anexo) != "Mensagem.html") {
                    linkLabels[n].Visible = true;
                    linkLabels[n].Text = Path.GetFileName(anexo);
                    anexos.Add(anexo);
                    n++;
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            try {
                //Process.Start(@"C:\arquivos de programa\frontpage\fpxpress.exe", anexosDir + "Mensagem.html");
                Process.Start(@"wps", anexosDir + "Mensagem.html");
            } catch {
                try {
                    Process.Start(@"winword", anexosDir + "Mensagem.html");
                } catch {
                    Process.Start(anexosDir + "Mensagem.html");
                }
            }
        }

        private void txtMensagem_TextChanged(object sender, EventArgs e) {
            lbEnviando.Visible = false;
            if (!string.IsNullOrEmpty(txtMensagem.Text))
                btnEnviar.Enabled = true;
            else
                btnEnviar.Enabled = false;
        }

        private void btnEditarMail_Click(object sender, EventArgs e) {
            if (!Config(true)) {
                MessageBox.Show("O e-mail não foi configurado, favor abra o programa novamente e configure", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void txtDe_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = (char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsPunctuation(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsControl(e.KeyChar));
        }

        private void txtPara_TextChanged(object sender, EventArgs e) {
            lbEnviando.Visible = false;
        }

        private void txtAssunto_TextChanged(object sender, EventArgs e) {
            lbEnviando.Visible = false;
        }

        private void label5_Click(object sender, EventArgs e) {
            Process.Start("explorer", anexosDir);
        }

        private void btnAnexo_Click(object sender, EventArgs e) {
            string arquivoAnexado = EscolherArquivo("Arquivos|*.*");
            if (arquivoAnexado != "")
                if (linkLabel1.Visible == false) {
                    linkLabel1.Text = Path.GetFileNameWithoutExtension(arquivoAnexado);
                    linkLabel1.Links.Add(0, 100, arquivoAnexado);
                    linkLabel1.Visible = true;
                    anexados.Add(arquivoAnexado);
                } else if (linkLabel2.Visible == false) {
                    linkLabel2.Text = Path.GetFileNameWithoutExtension(arquivoAnexado);
                    linkLabel1.Links.Add(14, 9, arquivoAnexado);
                    linkLabel2.Visible = true;
                    anexados.Add(arquivoAnexado);
                } else if (linkLabel3.Visible == false) {
                    linkLabel3.Text = Path.GetFileNameWithoutExtension(arquivoAnexado);
                    linkLabel1.Links.Add(14, 9, arquivoAnexado);
                    linkLabel3.Visible = true;
                    anexados.Add(arquivoAnexado);
                } else if (linkLabel4.Visible == false) {
                    linkLabel4.Text = Path.GetFileNameWithoutExtension(arquivoAnexado);
                    linkLabel1.Links.Add(14, 9, arquivoAnexado);
                    linkLabel4.Visible = true;
                    anexados.Add(arquivoAnexado);
                } else if (linkLabel5.Visible == false) {
                    linkLabel5.Text = Path.GetFileNameWithoutExtension(arquivoAnexado);
                    linkLabel1.Links.Add(14, 9, arquivoAnexado);
                    linkLabel5.Visible = true;
                    anexados.Add(arquivoAnexado);
                } else if (linkLabel6.Visible == false) {
                    linkLabel6.Text = Path.GetFileNameWithoutExtension(arquivoAnexado);
                    linkLabel1.Links.Add(14, 9, arquivoAnexado);
                    linkLabel6.Visible = true;
                    anexados.Add(arquivoAnexado);
                } else if (linkLabel7.Visible == false) {
                    linkLabel7.Text = Path.GetFileNameWithoutExtension(arquivoAnexado);
                    linkLabel1.Links.Add(14, 9, arquivoAnexado);
                    linkLabel7.Visible = true;
                    anexados.Add(arquivoAnexado);
                } else if (linkLabel8.Visible == false) {
                    linkLabel8.Text = Path.GetFileNameWithoutExtension(arquivoAnexado);
                    linkLabel1.Links.Add(14, 9, arquivoAnexado);
                    linkLabel8.Visible = true;
                    anexados.Add(arquivoAnexado);
                } else if (linkLabel9.Visible == false) {
                    linkLabel9.Text = Path.GetFileNameWithoutExtension(arquivoAnexado);
                    linkLabel1.Links.Add(14, 9, arquivoAnexado);
                    linkLabel9.Visible = true;
                    anexados.Add(arquivoAnexado);
                } else if (linkLabel10.Visible == false) {
                    linkLabel10.Text = Path.GetFileNameWithoutExtension(arquivoAnexado);
                    linkLabel1.Links.Add(14, 9, arquivoAnexado);
                    linkLabel10.Visible = true;
                    anexados.Add(arquivoAnexado);
                } else if (linkLabel11.Visible == false) {
                    linkLabel11.Text = Path.GetFileNameWithoutExtension(arquivoAnexado);
                    linkLabel1.Links.Add(14, 9, arquivoAnexado);
                    linkLabel11.Visible = true;
                    anexados.Add(arquivoAnexado);
                } else if (linkLabel12.Visible == false) {
                    linkLabel12.Text = Path.GetFileNameWithoutExtension(arquivoAnexado);
                    linkLabel1.Links.Add(14, 9, arquivoAnexado);
                    linkLabel12.Visible = true;
                    anexados.Add(arquivoAnexado);
                }
        }

        private void btnAtualizar_Click(object sender, EventArgs e) {
            webBrowser1.DocumentText = File.ReadAllText(anexosDir + "Mensagem.html");
        }

        void Esperar(int milisegundos) {
            DateTime Tthen = DateTime.Now;
            do {
                Application.DoEvents();
            } while (Tthen.AddMilliseconds(milisegundos) > DateTime.Now);
        }

        void AbriuArquivo() {
            try {
                MsgEml(arquivoEscolhido);
                //btnOpen1.Enabled = false;
                btnAnexo.Enabled = true;
                btnEdit.Enabled = true;
                btnAtualizar.Enabled = true;
                btnEnviar.Enabled = true;
                txtMensagem.Visible = false;
                webBrowser1.Visible = true;
            } catch (Exception) {
                MessageBox.Show("Parece que esse não é um arquivo de e-mail, verifique a extensão");
                //btnOpen1.Enabled = true;
                btnAnexo.Enabled = false;
                btnEdit.Enabled = false;
                btnAtualizar.Enabled = false;
                btnEnviar.Enabled = false;
                txtMensagem.Visible = true;
                webBrowser1.Visible = false;
            }
        }

        private void btnOpen1_Click(object sender, EventArgs e) {
            lbEnviando.Visible = false;
            DeletarArquivos();
            arquivoEscolhido = EscolherArquivo();
            if (arquivoEscolhido != "")
                AbriuArquivo();
        }

        string ConverterData(DateTime dateTime) {
            CultureInfo culture = new CultureInfo("pt-BR");
            DateTimeFormatInfo dtfi = culture.DateTimeFormat;
            int dia = dateTime.Day;
            int ano = dateTime.Year;
            int hora = dateTime.Hour;
            int min = dateTime.Minute;
            int sec = dateTime.Second;
            string mes = culture.TextInfo.ToTitleCase(dtfi.GetMonthName(dateTime.Month));
            string diasemana = culture.TextInfo.ToTitleCase(dtfi.GetDayName(dateTime.DayOfWeek));
            string data = dia.ToString().PadLeft(2, '0') + " de " + mes.PadLeft(2, '0') + " de " + ano + ", às " + hora.ToString().PadLeft(2, '0') + ":" + min.ToString().PadLeft(2, '0') + ":" + sec.ToString().PadLeft(2, '0');
            return data;
        }

        void EnviarEmail() {
            string assunto = txtAssunto.Text;
            string remetente = txtDe.Text;
            string destinatario = txtPara.Text;
            ServicePointManager.ServerCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(remetente, nome);
            mail.To.Add(destinatario);
            mail.Subject = assunto;
            mail.IsBodyHtml = true;
            if (txtMensagem.Visible == true)
                mail.Body = txtMensagem.Text;
            else
                mail.Body = File.ReadAllText(anexosDir + "Mensagem.html");
            //mail.Body = mensagem;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(usuario, senha);

            foreach (string anexo in Directory.GetFiles(anexosDir)) {
                attachment = new Attachment(anexo);
                mail.Attachments.Add(attachment);
            }
            try {
                smtp.Send(mail);
            } catch (Exception) {
                MessageBox.Show("Ocorreu um erro ao enviar o e-mail." + Environment.NewLine + "Verifique se digitou o endereço do remetente correto:" + Environment.NewLine + "Verifique se a senha está correta" + Environment.NewLine + "Verifique as permissões");
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e) {
            if (txtAssunto.Text != "" && txtDe.Text.Contains("@") && txtDe.Text.Contains(".") && txtPara.Text.Contains("@") && txtPara.Text.Contains(".")) {
                lbEnviando.Text = " - Enviando...";
                lbEnviando.Visible = true;
                /*
                Entry senha = new Entry();
                if (senha.ShowDialog() == DialogResult.OK) {
                    mensagem = "<pre><font face=\"times new roman\" size=\"3\">" + txtMensagem.Text + "</font></pre><br><br>"; //preformatar o texto
                    mensagem = Regex.Replace(html, body, body + mensagem + html1);//Une a mesnagem que o usuário digitou ao html
                    EnviarEmail(_senha);
                    MessageBox.Show("Mensagem enviada!");
                }*/
                if (webBrowser1.Visible == true) {
                    mensagem = "<pre><font face=\"times new roman\" size=\"3\">" + txtMensagem.Text + "</font></pre><br><br>"; //preformatar o texto
                    mensagem = Regex.Replace(html, body, body + mensagem + html1);//Une a mesnagem que o usuário digitou ao html
                }
                if (txtMensagem.Visible == true) {
                    DeletarArquivos();
                    foreach (string anexo in anexados)
                        File.Copy(anexo, Path.Combine(anexosDir, Path.GetFileName(anexo)));
                }
                EnviarEmail();
                lbEnviando.Text = " - Concluído !";
                lbEnviando.Visible = true;
            }
            else
                MessageBox.Show("Verifique os emails e o assunto.");
        }
    }
}