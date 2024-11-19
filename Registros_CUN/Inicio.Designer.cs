namespace Registros_CUN
{
    partial class Inicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            pct_logo = new PictureBox();
            lbl_texto_1 = new Label();
            lbl_text_2 = new Label();
            btn_entrar = new Button();
            tbx_documento = new TextBox();
            lnkRegistrate = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pct_logo).BeginInit();
            SuspendLayout();
            // 
            // pct_logo
            // 
            pct_logo.Image = (Image)resources.GetObject("pct_logo.Image");
            pct_logo.Location = new Point(17, 20);
            pct_logo.Margin = new Padding(4, 5, 4, 5);
            pct_logo.Name = "pct_logo";
            pct_logo.Size = new Size(187, 92);
            pct_logo.SizeMode = PictureBoxSizeMode.StretchImage;
            pct_logo.TabIndex = 0;
            pct_logo.TabStop = false;
            // 
            // lbl_texto_1
            // 
            lbl_texto_1.Anchor = AnchorStyles.None;
            lbl_texto_1.AutoSize = true;
            lbl_texto_1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_texto_1.Location = new Point(474, 316);
            lbl_texto_1.Margin = new Padding(4, 0, 4, 0);
            lbl_texto_1.Name = "lbl_texto_1";
            lbl_texto_1.Size = new Size(179, 32);
            lbl_texto_1.TabIndex = 1;
            lbl_texto_1.Text = "No Documento";
            // 
            // lbl_text_2
            // 
            lbl_text_2.Anchor = AnchorStyles.Bottom;
            lbl_text_2.AutoSize = true;
            lbl_text_2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_text_2.Location = new Point(409, 690);
            lbl_text_2.Margin = new Padding(4, 0, 4, 0);
            lbl_text_2.Name = "lbl_text_2";
            lbl_text_2.Size = new Size(209, 32);
            lbl_text_2.TabIndex = 3;
            lbl_text_2.Text = "No te encuentras?";
            // 
            // btn_entrar
            // 
            btn_entrar.Anchor = AnchorStyles.Bottom;
            btn_entrar.BackColor = Color.Green;
            btn_entrar.FlatAppearance.BorderSize = 0;
            btn_entrar.FlatStyle = FlatStyle.Flat;
            btn_entrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_entrar.ForeColor = Color.White;
            btn_entrar.Location = new Point(474, 546);
            btn_entrar.Margin = new Padding(4, 5, 4, 5);
            btn_entrar.Name = "btn_entrar";
            btn_entrar.Size = new Size(200, 60);
            btn_entrar.TabIndex = 5;
            btn_entrar.Text = "Buscar";
            btn_entrar.UseVisualStyleBackColor = false;
            btn_entrar.Click += btn_entrar_Click;
            // 
            // tbx_documento
            // 
            tbx_documento.Anchor = AnchorStyles.None;
            tbx_documento.Location = new Point(413, 366);
            tbx_documento.Margin = new Padding(4, 5, 4, 5);
            tbx_documento.Name = "tbx_documento";
            tbx_documento.Size = new Size(317, 31);
            tbx_documento.TabIndex = 6;
            // 
            // lnkRegistrate
            // 
            lnkRegistrate.Anchor = AnchorStyles.Bottom;
            lnkRegistrate.AutoSize = true;
            lnkRegistrate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lnkRegistrate.LinkColor = Color.Green;
            lnkRegistrate.Location = new Point(614, 690);
            lnkRegistrate.Name = "lnkRegistrate";
            lnkRegistrate.Size = new Size(119, 32);
            lnkRegistrate.TabIndex = 7;
            lnkRegistrate.TabStop = true;
            lnkRegistrate.Text = "Regístrate";
            lnkRegistrate.LinkClicked += lnkRegistrate_LinkClicked;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(lnkRegistrate);
            Controls.Add(tbx_documento);
            Controls.Add(btn_entrar);
            Controls.Add(lbl_text_2);
            Controls.Add(lbl_texto_1);
            Controls.Add(pct_logo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Inicio";
            Text = "Inicio";
            Load += Inicio_Load;
            ((System.ComponentModel.ISupportInitialize)pct_logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pct_logo;
        private Label lbl_texto_1;
        private Label lbl_text_2;
        private Button btn_entrar;
        private TextBox tbx_documento;
        private LinkLabel lnkRegistrate;
    }
}