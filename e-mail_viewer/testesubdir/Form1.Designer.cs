namespace emailViewer
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtMensagem = new System.Windows.Forms.RichTextBox();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPara = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.txtCaminho = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel12 = new System.Windows.Forms.LinkLabel();
            this.linkLabel11 = new System.Windows.Forms.LinkLabel();
            this.linkLabel10 = new System.Windows.Forms.LinkLabel();
            this.linkLabel9 = new System.Windows.Forms.LinkLabel();
            this.linkLabel8 = new System.Windows.Forms.LinkLabel();
            this.linkLabel7 = new System.Windows.Forms.LinkLabel();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lbEnviando = new System.Windows.Forms.ToolStripLabel();
            this.btnEditarMail = new System.Windows.Forms.Button();
            this.btnOpen1 = new System.Windows.Forms.ToolStripButton();
            this.btnEnviar = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnAnexo = new System.Windows.Forms.ToolStripButton();
            this.btnAtualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Assunto:";
            // 
            // txtMensagem
            // 
            this.txtMensagem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMensagem.Location = new System.Drawing.Point(10, 143);
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(573, 319);
            this.txtMensagem.TabIndex = 4;
            this.txtMensagem.Text = "";
            this.txtMensagem.TextChanged += new System.EventHandler(this.txtMensagem_TextChanged);
            this.txtMensagem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMensagem_KeyDown);
            // 
            // txtAssunto
            // 
            this.txtAssunto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAssunto.Location = new System.Drawing.Point(12, 88);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(571, 20);
            this.txtAssunto.TabIndex = 3;
            this.txtAssunto.TextChanged += new System.EventHandler(this.txtAssunto_TextChanged);
            this.txtAssunto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAssunto_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mensagem:";
            this.label2.Visible = false;
            // 
            // txtDe
            // 
            this.txtDe.Location = new System.Drawing.Point(12, 49);
            this.txtDe.Name = "txtDe";
            this.txtDe.Size = new System.Drawing.Size(249, 20);
            this.txtDe.TabIndex = 1;
            this.txtDe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDe_KeyDown);
            this.txtDe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDe_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "De:";
            // 
            // txtPara
            // 
            this.txtPara.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPara.Location = new System.Drawing.Point(301, 49);
            this.txtPara.Name = "txtPara";
            this.txtPara.Size = new System.Drawing.Size(282, 20);
            this.txtPara.TabIndex = 2;
            this.txtPara.TextChanged += new System.EventHandler(this.txtPara_TextChanged);
            this.txtPara.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPara_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Para:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpen1,
            this.btnEnviar,
            this.btnEdit,
            this.btnAnexo,
            this.btnAtualizar,
            this.lbEnviando});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(595, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // txtCaminho
            // 
            this.txtCaminho.Enabled = false;
            this.txtCaminho.Location = new System.Drawing.Point(522, 5);
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.Size = new System.Drawing.Size(59, 20);
            this.txtCaminho.TabIndex = 11;
            this.txtCaminho.Visible = false;
            this.txtCaminho.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCaminho_KeyDown);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 476);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Anexos:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(15, 143);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(568, 319);
            this.webBrowser1.TabIndex = 5;
            this.webBrowser1.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Mensagem:";
            // 
            // linkLabel12
            // 
            this.linkLabel12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel12.AutoSize = true;
            this.linkLabel12.Location = new System.Drawing.Point(185, 504);
            this.linkLabel12.Name = "linkLabel12";
            this.linkLabel12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.linkLabel12.Size = new System.Drawing.Size(35, 13);
            this.linkLabel12.TabIndex = 50;
            this.linkLabel12.TabStop = true;
            this.linkLabel12.Text = "link12";
            this.linkLabel12.Visible = false;
            this.linkLabel12.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel12_LinkClicked);
            // 
            // linkLabel11
            // 
            this.linkLabel11.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.linkLabel11.AutoSize = true;
            this.linkLabel11.Location = new System.Drawing.Point(125, 504);
            this.linkLabel11.Name = "linkLabel11";
            this.linkLabel11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.linkLabel11.Size = new System.Drawing.Size(35, 13);
            this.linkLabel11.TabIndex = 49;
            this.linkLabel11.TabStop = true;
            this.linkLabel11.Text = "link11";
            this.linkLabel11.Visible = false;
            this.linkLabel11.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel11_LinkClicked);
            // 
            // linkLabel10
            // 
            this.linkLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel10.AutoSize = true;
            this.linkLabel10.Location = new System.Drawing.Point(63, 504);
            this.linkLabel10.Name = "linkLabel10";
            this.linkLabel10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.linkLabel10.Size = new System.Drawing.Size(35, 13);
            this.linkLabel10.TabIndex = 48;
            this.linkLabel10.TabStop = true;
            this.linkLabel10.Text = "link10";
            this.linkLabel10.Visible = false;
            this.linkLabel10.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel10_LinkClicked);
            // 
            // linkLabel9
            // 
            this.linkLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel9.AutoSize = true;
            this.linkLabel9.Location = new System.Drawing.Point(185, 491);
            this.linkLabel9.Name = "linkLabel9";
            this.linkLabel9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.linkLabel9.Size = new System.Drawing.Size(29, 13);
            this.linkLabel9.TabIndex = 47;
            this.linkLabel9.TabStop = true;
            this.linkLabel9.Text = "link9";
            this.linkLabel9.Visible = false;
            this.linkLabel9.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel9_LinkClicked);
            // 
            // linkLabel8
            // 
            this.linkLabel8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.linkLabel8.AutoSize = true;
            this.linkLabel8.Location = new System.Drawing.Point(125, 491);
            this.linkLabel8.Name = "linkLabel8";
            this.linkLabel8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.linkLabel8.Size = new System.Drawing.Size(29, 13);
            this.linkLabel8.TabIndex = 46;
            this.linkLabel8.TabStop = true;
            this.linkLabel8.Text = "link8";
            this.linkLabel8.Visible = false;
            this.linkLabel8.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel8_LinkClicked);
            // 
            // linkLabel7
            // 
            this.linkLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel7.AutoSize = true;
            this.linkLabel7.Location = new System.Drawing.Point(63, 491);
            this.linkLabel7.Name = "linkLabel7";
            this.linkLabel7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.linkLabel7.Size = new System.Drawing.Size(29, 13);
            this.linkLabel7.TabIndex = 45;
            this.linkLabel7.TabStop = true;
            this.linkLabel7.Text = "link7";
            this.linkLabel7.Visible = false;
            this.linkLabel7.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel7_LinkClicked);
            // 
            // linkLabel6
            // 
            this.linkLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.Location = new System.Drawing.Point(185, 478);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.linkLabel6.Size = new System.Drawing.Size(29, 13);
            this.linkLabel6.TabIndex = 44;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "link6";
            this.linkLabel6.Visible = false;
            this.linkLabel6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel6_LinkClicked);
            // 
            // linkLabel5
            // 
            this.linkLabel5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Location = new System.Drawing.Point(125, 478);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.linkLabel5.Size = new System.Drawing.Size(29, 13);
            this.linkLabel5.TabIndex = 43;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "link5";
            this.linkLabel5.Visible = false;
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // linkLabel4
            // 
            this.linkLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(63, 478);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.linkLabel4.Size = new System.Drawing.Size(29, 13);
            this.linkLabel4.TabIndex = 42;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "link4";
            this.linkLabel4.Visible = false;
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(185, 465);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.linkLabel3.Size = new System.Drawing.Size(29, 13);
            this.linkLabel3.TabIndex = 41;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "link3";
            this.linkLabel3.Visible = false;
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(125, 465);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.linkLabel2.Size = new System.Drawing.Size(29, 13);
            this.linkLabel2.TabIndex = 40;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "link2";
            this.linkLabel2.Visible = false;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(63, 465);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.linkLabel1.Size = new System.Drawing.Size(29, 13);
            this.linkLabel1.TabIndex = 39;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "link1";
            this.linkLabel1.Visible = false;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lbEnviando
            // 
            this.lbEnviando.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEnviando.Name = "lbEnviando";
            this.lbEnviando.Size = new System.Drawing.Size(77, 22);
            this.lbEnviando.Text = " - Enviando...";
            this.lbEnviando.Visible = false;
            // 
            // btnEditarMail
            // 
            this.btnEditarMail.Image = global::emailViewer.Properties.Resources.edit;
            this.btnEditarMail.Location = new System.Drawing.Point(268, 49);
            this.btnEditarMail.Name = "btnEditarMail";
            this.btnEditarMail.Size = new System.Drawing.Size(20, 20);
            this.btnEditarMail.TabIndex = 51;
            this.btnEditarMail.UseVisualStyleBackColor = true;
            this.btnEditarMail.Click += new System.EventHandler(this.btnEditarMail_Click);
            // 
            // btnOpen1
            // 
            this.btnOpen1.Image = global::emailViewer.Properties.Resources.open_file1;
            this.btnOpen1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpen1.Name = "btnOpen1";
            this.btnOpen1.Size = new System.Drawing.Size(53, 22);
            this.btnOpen1.Text = "Abrir";
            this.btnOpen1.ToolTipText = "Ctrl+O";
            this.btnOpen1.Click += new System.EventHandler(this.btnOpen1_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Enabled = false;
            this.btnEnviar.Image = global::emailViewer.Properties.Resources.shurtcut1;
            this.btnEnviar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(59, 22);
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Image = global::emailViewer.Properties.Resources.edit;
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(57, 22);
            this.btnEdit.Text = "Editar";
            this.btnEdit.ToolTipText = "Editar Mensagem";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAnexo
            // 
            this.btnAnexo.Image = global::emailViewer.Properties.Resources.import;
            this.btnAnexo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAnexo.Name = "btnAnexo";
            this.btnAnexo.Size = new System.Drawing.Size(64, 22);
            this.btnAnexo.Text = "Anexar";
            this.btnAnexo.ToolTipText = "Pasta Anexos";
            this.btnAnexo.Click += new System.EventHandler(this.btnAnexo_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Enabled = false;
            this.btnAtualizar.Image = global::emailViewer.Properties.Resources.update1;
            this.btnAtualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(73, 22);
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.ToolTipText = "Atualizar após editar (F5)";
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 518);
            this.Controls.Add(this.btnEditarMail);
            this.Controls.Add(this.linkLabel12);
            this.Controls.Add(this.linkLabel11);
            this.Controls.Add(this.linkLabel10);
            this.Controls.Add(this.linkLabel9);
            this.Controls.Add(this.linkLabel8);
            this.Controls.Add(this.linkLabel7);
            this.Controls.Add(this.linkLabel6);
            this.Controls.Add(this.linkLabel5);
            this.Controls.Add(this.linkLabel4);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCaminho);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtPara);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAssunto);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Email Viewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtMensagem;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPara;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnOpen1;
        private System.Windows.Forms.ToolStripButton btnEnviar;
        private System.Windows.Forms.TextBox txtCaminho;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabel12;
        private System.Windows.Forms.LinkLabel linkLabel11;
        private System.Windows.Forms.LinkLabel linkLabel10;
        private System.Windows.Forms.LinkLabel linkLabel9;
        private System.Windows.Forms.LinkLabel linkLabel8;
        private System.Windows.Forms.LinkLabel linkLabel7;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnAnexo;
        private System.Windows.Forms.ToolStripButton btnAtualizar;
        private System.Windows.Forms.Button btnEditarMail;
        private System.Windows.Forms.ToolStripLabel lbEnviando;
    }
}

