namespace Registros_CUN
{
    partial class Registro
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            pct_logo = new PictureBox();
            lbl_texto_1 = new Label();
            label1 = new Label();
            tbx_nombres = new TextBox();
            tbx_apellidos = new TextBox();
            label2 = new Label();
            label3 = new Label();
            tbx_numero_documento = new TextBox();
            label4 = new Label();
            label5 = new Label();
            btn_agregar = new Button();
            lbl_estado_db = new Label();
            tmr_estado_db = new System.Windows.Forms.Timer(components);
            cbx_rol = new ComboBox();
            cbx_tipo_documento = new ComboBox();
            btn_regresar = new Button();
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
            pct_logo.TabIndex = 1;
            pct_logo.TabStop = false;
            // 
            // lbl_texto_1
            // 
            lbl_texto_1.Anchor = AnchorStyles.None;
            lbl_texto_1.AutoSize = true;
            lbl_texto_1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_texto_1.Location = new Point(443, 237);
            lbl_texto_1.Margin = new Padding(4, 0, 4, 0);
            lbl_texto_1.Name = "lbl_texto_1";
            lbl_texto_1.Size = new Size(112, 32);
            lbl_texto_1.TabIndex = 2;
            lbl_texto_1.Text = "Nombres";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(221, 33);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(385, 54);
            label1.TabIndex = 3;
            label1.Text = "Registro de Personal";
            // 
            // tbx_nombres
            // 
            tbx_nombres.Anchor = AnchorStyles.None;
            tbx_nombres.Location = new Point(443, 274);
            tbx_nombres.Margin = new Padding(4, 5, 4, 5);
            tbx_nombres.Name = "tbx_nombres";
            tbx_nombres.Size = new Size(269, 31);
            tbx_nombres.TabIndex = 4;
            // 
            // tbx_apellidos
            // 
            tbx_apellidos.Anchor = AnchorStyles.None;
            tbx_apellidos.Location = new Point(810, 274);
            tbx_apellidos.Margin = new Padding(4, 5, 4, 5);
            tbx_apellidos.Name = "tbx_apellidos";
            tbx_apellidos.Size = new Size(269, 31);
            tbx_apellidos.TabIndex = 6;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(810, 237);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(112, 32);
            label2.TabIndex = 5;
            label2.Text = "Apellidos";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(63, 418);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(194, 32);
            label3.TabIndex = 7;
            label3.Text = "Tipo Documento";
            // 
            // tbx_numero_documento
            // 
            tbx_numero_documento.Anchor = AnchorStyles.None;
            tbx_numero_documento.Location = new Point(443, 457);
            tbx_numero_documento.Margin = new Padding(4, 5, 4, 5);
            tbx_numero_documento.Name = "tbx_numero_documento";
            tbx_numero_documento.Size = new Size(269, 31);
            tbx_numero_documento.TabIndex = 10;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(443, 420);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(179, 32);
            label4.TabIndex = 9;
            label4.Text = "No Documento";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(63, 235);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(47, 32);
            label5.TabIndex = 11;
            label5.Text = "Rol";
            // 
            // btn_agregar
            // 
            btn_agregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_agregar.Font = new Font("Segoe UI", 13F);
            btn_agregar.Location = new Point(928, 651);
            btn_agregar.Margin = new Padding(4, 5, 4, 5);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(176, 59);
            btn_agregar.TabIndex = 13;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // lbl_estado_db
            // 
            lbl_estado_db.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_estado_db.AutoSize = true;
            lbl_estado_db.Font = new Font("Segoe UI", 12F);
            lbl_estado_db.ForeColor = Color.Green;
            lbl_estado_db.Location = new Point(1019, 33);
            lbl_estado_db.Margin = new Padding(4, 0, 4, 0);
            lbl_estado_db.Name = "lbl_estado_db";
            lbl_estado_db.Size = new Size(85, 32);
            lbl_estado_db.TabIndex = 14;
            lbl_estado_db.Text = "estado";
            lbl_estado_db.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tmr_estado_db
            // 
            tmr_estado_db.Tick += tmr_estado_db_Tick;
            // 
            // cbx_rol
            // 
            cbx_rol.Anchor = AnchorStyles.None;
            cbx_rol.FormattingEnabled = true;
            cbx_rol.Location = new Point(63, 272);
            cbx_rol.Margin = new Padding(4, 5, 4, 5);
            cbx_rol.Name = "cbx_rol";
            cbx_rol.Size = new Size(269, 33);
            cbx_rol.TabIndex = 15;
            // 
            // cbx_tipo_documento
            // 
            cbx_tipo_documento.Anchor = AnchorStyles.None;
            cbx_tipo_documento.FormattingEnabled = true;
            cbx_tipo_documento.Location = new Point(63, 455);
            cbx_tipo_documento.Margin = new Padding(4, 5, 4, 5);
            cbx_tipo_documento.Name = "cbx_tipo_documento";
            cbx_tipo_documento.Size = new Size(269, 33);
            cbx_tipo_documento.TabIndex = 16;
            // 
            // btn_regresar
            // 
            btn_regresar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_regresar.Font = new Font("Segoe UI", 13F);
            btn_regresar.Location = new Point(40, 651);
            btn_regresar.Margin = new Padding(4, 5, 4, 5);
            btn_regresar.Name = "btn_regresar";
            btn_regresar.Size = new Size(176, 59);
            btn_regresar.TabIndex = 17;
            btn_regresar.Text = "Regresar";
            btn_regresar.UseVisualStyleBackColor = true;
            btn_regresar.Click += btn_regresar_Click;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(btn_regresar);
            Controls.Add(cbx_tipo_documento);
            Controls.Add(cbx_rol);
            Controls.Add(lbl_estado_db);
            Controls.Add(btn_agregar);
            Controls.Add(label5);
            Controls.Add(tbx_numero_documento);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tbx_apellidos);
            Controls.Add(label2);
            Controls.Add(tbx_nombres);
            Controls.Add(label1);
            Controls.Add(lbl_texto_1);
            Controls.Add(pct_logo);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Registro";
            Text = "Registro";
            Load += Registro_Load;
            ((System.ComponentModel.ISupportInitialize)pct_logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pct_logo;
        private Label lbl_texto_1;
        private Label label1;
        private TextBox tbx_nombres;
        private TextBox tbx_apellidos;
        private Label label2;
        private Label label3;
        private TextBox tbx_numero_documento;
        private Label label4;
        private Label label5;
        private Button btn_agregar;
        private Label lbl_estado_db;
        private System.Windows.Forms.Timer tmr_estado_db;
        private ComboBox cbx_rol;
        private ComboBox cbx_tipo_documento;
        private Button btn_regresar;
    }
}