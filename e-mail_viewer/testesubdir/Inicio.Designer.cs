namespace emailViewer {
    partial class Inicio {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnOpen1 = new System.Windows.Forms.ToolStripButton();
            this.btnEnviar = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpen1,
            this.btnEnviar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(595, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
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
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 518);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Email Viewer";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnOpen1;
        private System.Windows.Forms.ToolStripButton btnEnviar;
    }
}