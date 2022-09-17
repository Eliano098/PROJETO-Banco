namespace Banco
{
    partial class FrmSaque
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
            this.txtsenhaSaque = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcontaSaque = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdValidar = new System.Windows.Forms.Button();
            this.txtvalorSaque = new System.Windows.Forms.TextBox();
            this.cmdSaque = new System.Windows.Forms.Button();
            this.cmdVoltar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
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
            // txtsenhaSaque
            // 
            this.txtsenhaSaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsenhaSaque.Location = new System.Drawing.Point(3, 100);
            this.txtsenhaSaque.Name = "txtsenhaSaque";
            this.txtsenhaSaque.Size = new System.Drawing.Size(100, 22);
            this.txtsenhaSaque.TabIndex = 19;
            this.txtsenhaSaque.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Senha";
            // 
            // txtcontaSaque
            // 
            this.txtcontaSaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontaSaque.Location = new System.Drawing.Point(3, 41);
            this.txtcontaSaque.Name = "txtcontaSaque";
            this.txtcontaSaque.Size = new System.Drawing.Size(100, 22);
            this.txtcontaSaque.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "N° conta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Saque";
            // 
            // cmdValidar
            // 
            this.cmdValidar.BackColor = System.Drawing.Color.LightGray;
            this.cmdValidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdValidar.Location = new System.Drawing.Point(6, 148);
            this.cmdValidar.Name = "cmdValidar";
            this.cmdValidar.Size = new System.Drawing.Size(82, 31);
            this.cmdValidar.TabIndex = 29;
            this.cmdValidar.Text = "Validar";
            this.cmdValidar.UseVisualStyleBackColor = false;
            this.cmdValidar.Click += new System.EventHandler(this.cmdValidar_Click);
            // 
            // txtvalorSaque
            // 
            this.txtvalorSaque.Enabled = false;
            this.txtvalorSaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalorSaque.Location = new System.Drawing.Point(279, 41);
            this.txtvalorSaque.Name = "txtvalorSaque";
            this.txtvalorSaque.Size = new System.Drawing.Size(100, 22);
            this.txtvalorSaque.TabIndex = 31;
            // 
            // cmdSaque
            // 
            this.cmdSaque.BackColor = System.Drawing.Color.LightGray;
            this.cmdSaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSaque.Location = new System.Drawing.Point(303, 170);
            this.cmdSaque.Name = "cmdSaque";
            this.cmdSaque.Size = new System.Drawing.Size(82, 31);
            this.cmdSaque.TabIndex = 32;
            this.cmdSaque.Text = "Processar";
            this.cmdSaque.UseVisualStyleBackColor = false;
            this.cmdSaque.Click += new System.EventHandler(this.cmdSaque_Click);
            // 
            // cmdVoltar
            // 
            this.cmdVoltar.BackColor = System.Drawing.Color.LightGray;
            this.cmdVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVoltar.Location = new System.Drawing.Point(12, 12);
            this.cmdVoltar.Name = "cmdVoltar";
            this.cmdVoltar.Size = new System.Drawing.Size(82, 31);
            this.cmdVoltar.TabIndex = 33;
            this.cmdVoltar.Text = "Voltar";
            this.cmdVoltar.UseVisualStyleBackColor = false;
            this.cmdVoltar.Click += new System.EventHandler(this.cmdVoltar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtcontaSaque);
            this.panel1.Controls.Add(this.cmdSaque);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtvalorSaque);
            this.panel1.Controls.Add(this.txtsenhaSaque);
            this.panel1.Controls.Add(this.cmdValidar);
            this.panel1.Location = new System.Drawing.Point(12, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 215);
            this.panel1.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "R$";
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
            this.label9.Location = new System.Drawing.Point(490, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Data:";
            // 
            // lbldata
            // 
            this.lbldata.AutoSize = true;
            this.lbldata.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldata.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbldata.Location = new System.Drawing.Point(536, 12);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(75, 13);
            this.lbldata.TabIndex = 37;
            this.lbldata.Text = "00/00/0000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(490, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Hora:";
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblInicio.Location = new System.Drawing.Point(534, 30);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(57, 13);
            this.lblInicio.TabIndex = 35;
            this.lblInicio.Text = "00:00:00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Banco.Properties.Resources.conjunto_de_icones_do_sistema_bancario_1284_14615__5_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(119, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 63);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // FrmSaque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(617, 338);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbldata);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmdVoltar);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSaque";
            this.Text = "Saque";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsenhaSaque;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcontaSaque;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdValidar;
        private System.Windows.Forms.TextBox txtvalorSaque;
        private System.Windows.Forms.Button cmdSaque;
        private System.Windows.Forms.Button cmdVoltar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbldata;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}