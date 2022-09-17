namespace Banco
{
    partial class FrmConsulta
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsenhaConsulta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcontaConsulta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdNovaConsulta = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cmdVoltar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdValidarConsulta = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.lbldata = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consutar conta";
            // 
            // txtsenhaConsulta
            // 
            this.txtsenhaConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsenhaConsulta.Location = new System.Drawing.Point(3, 97);
            this.txtsenhaConsulta.Name = "txtsenhaConsulta";
            this.txtsenhaConsulta.Size = new System.Drawing.Size(100, 22);
            this.txtsenhaConsulta.TabIndex = 15;
            this.txtsenhaConsulta.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Senha";
            // 
            // txtcontaConsulta
            // 
            this.txtcontaConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontaConsulta.Location = new System.Drawing.Point(3, 38);
            this.txtcontaConsulta.Name = "txtcontaConsulta";
            this.txtcontaConsulta.Size = new System.Drawing.Size(100, 22);
            this.txtcontaConsulta.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "N° conta";
            // 
            // cmdNovaConsulta
            // 
            this.cmdNovaConsulta.BackColor = System.Drawing.Color.LightGray;
            this.cmdNovaConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNovaConsulta.Location = new System.Drawing.Point(283, 170);
            this.cmdNovaConsulta.Name = "cmdNovaConsulta";
            this.cmdNovaConsulta.Size = new System.Drawing.Size(107, 31);
            this.cmdNovaConsulta.TabIndex = 17;
            this.cmdNovaConsulta.Text = "Nova consulta";
            this.cmdNovaConsulta.UseVisualStyleBackColor = false;
            this.cmdNovaConsulta.Click += new System.EventHandler(this.cmdNovaConsulta_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(181, 29);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(191, 116);
            this.listBox1.TabIndex = 18;
            // 
            // cmdVoltar
            // 
            this.cmdVoltar.BackColor = System.Drawing.Color.LightGray;
            this.cmdVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVoltar.Location = new System.Drawing.Point(12, 12);
            this.cmdVoltar.Name = "cmdVoltar";
            this.cmdVoltar.Size = new System.Drawing.Size(82, 31);
            this.cmdVoltar.TabIndex = 19;
            this.cmdVoltar.Text = "Voltar";
            this.cmdVoltar.UseVisualStyleBackColor = false;
            this.cmdVoltar.Click += new System.EventHandler(this.cmdVoltar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmdValidarConsulta);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtcontaConsulta);
            this.panel1.Controls.Add(this.cmdNovaConsulta);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtsenhaConsulta);
            this.panel1.Location = new System.Drawing.Point(12, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 215);
            this.panel1.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(218, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Dados da conta";
            // 
            // cmdValidarConsulta
            // 
            this.cmdValidarConsulta.BackColor = System.Drawing.Color.LightGray;
            this.cmdValidarConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdValidarConsulta.Location = new System.Drawing.Point(6, 151);
            this.cmdValidarConsulta.Name = "cmdValidarConsulta";
            this.cmdValidarConsulta.Size = new System.Drawing.Size(82, 31);
            this.cmdValidarConsulta.TabIndex = 30;
            this.cmdValidarConsulta.Text = "Validar";
            this.cmdValidarConsulta.UseVisualStyleBackColor = false;
            this.cmdValidarConsulta.Click += new System.EventHandler(this.cmdValidarConsulta_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(487, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "Data:";
            // 
            // lbldata
            // 
            this.lbldata.AutoSize = true;
            this.lbldata.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldata.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbldata.Location = new System.Drawing.Point(533, 9);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(75, 13);
            this.lbldata.TabIndex = 44;
            this.lbldata.Text = "00/00/0000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(487, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "Hora:";
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblInicio.Location = new System.Drawing.Point(531, 27);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(57, 13);
            this.lblInicio.TabIndex = 42;
            this.lblInicio.Text = "00:00:00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Banco.Properties.Resources.download__1_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(120, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 63);
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // FrmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(617, 338);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbldata);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmdVoltar);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConsulta";
            this.Text = "Consulta Conta";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsenhaConsulta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcontaConsulta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdNovaConsulta;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button cmdVoltar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdValidarConsulta;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbldata;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}