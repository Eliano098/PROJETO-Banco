namespace Banco
{
    partial class FrmDeposito
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtcontaDeposito = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdDeposito = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtvalorDeposito = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsobrenomeDeposito = new System.Windows.Forms.TextBox();
            this.txtnomeDeposito = new System.Windows.Forms.TextBox();
            this.cmdValidarDeposito = new System.Windows.Forms.Button();
            this.cmdVoltar = new System.Windows.Forms.Button();
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "N° conta";
            // 
            // txtcontaDeposito
            // 
            this.txtcontaDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontaDeposito.Location = new System.Drawing.Point(3, 35);
            this.txtcontaDeposito.Name = "txtcontaDeposito";
            this.txtcontaDeposito.Size = new System.Drawing.Size(100, 22);
            this.txtcontaDeposito.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Depósito";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.cmdDeposito);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtvalorDeposito);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtsobrenomeDeposito);
            this.panel1.Controls.Add(this.txtnomeDeposito);
            this.panel1.Controls.Add(this.cmdValidarDeposito);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtcontaDeposito);
            this.panel1.Location = new System.Drawing.Point(15, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 215);
            this.panel1.TabIndex = 22;
            // 
            // cmdDeposito
            // 
            this.cmdDeposito.BackColor = System.Drawing.Color.LightGray;
            this.cmdDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDeposito.Location = new System.Drawing.Point(313, 166);
            this.cmdDeposito.Name = "cmdDeposito";
            this.cmdDeposito.Size = new System.Drawing.Size(82, 31);
            this.cmdDeposito.TabIndex = 37;
            this.cmdDeposito.Text = "Processar";
            this.cmdDeposito.UseVisualStyleBackColor = false;
            this.cmdDeposito.Click += new System.EventHandler(this.cmdDeposito_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "R$";
            // 
            // txtvalorDeposito
            // 
            this.txtvalorDeposito.Enabled = false;
            this.txtvalorDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalorDeposito.Location = new System.Drawing.Point(295, 35);
            this.txtvalorDeposito.Name = "txtvalorDeposito";
            this.txtvalorDeposito.Size = new System.Drawing.Size(100, 22);
            this.txtvalorDeposito.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Nome";
            // 
            // txtsobrenomeDeposito
            // 
            this.txtsobrenomeDeposito.Enabled = false;
            this.txtsobrenomeDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsobrenomeDeposito.Location = new System.Drawing.Point(109, 63);
            this.txtsobrenomeDeposito.Name = "txtsobrenomeDeposito";
            this.txtsobrenomeDeposito.Size = new System.Drawing.Size(100, 22);
            this.txtsobrenomeDeposito.TabIndex = 32;
            // 
            // txtnomeDeposito
            // 
            this.txtnomeDeposito.Enabled = false;
            this.txtnomeDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnomeDeposito.Location = new System.Drawing.Point(109, 35);
            this.txtnomeDeposito.Name = "txtnomeDeposito";
            this.txtnomeDeposito.Size = new System.Drawing.Size(100, 22);
            this.txtnomeDeposito.TabIndex = 31;
            // 
            // cmdValidarDeposito
            // 
            this.cmdValidarDeposito.BackColor = System.Drawing.Color.LightGray;
            this.cmdValidarDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdValidarDeposito.Location = new System.Drawing.Point(6, 112);
            this.cmdValidarDeposito.Name = "cmdValidarDeposito";
            this.cmdValidarDeposito.Size = new System.Drawing.Size(82, 31);
            this.cmdValidarDeposito.TabIndex = 30;
            this.cmdValidarDeposito.Text = "Validar";
            this.cmdValidarDeposito.UseVisualStyleBackColor = false;
            this.cmdValidarDeposito.Click += new System.EventHandler(this.cmdValidarDeposito_Click);
            // 
            // cmdVoltar
            // 
            this.cmdVoltar.BackColor = System.Drawing.Color.LightGray;
            this.cmdVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVoltar.Location = new System.Drawing.Point(15, 3);
            this.cmdVoltar.Name = "cmdVoltar";
            this.cmdVoltar.Size = new System.Drawing.Size(82, 31);
            this.cmdVoltar.TabIndex = 37;
            this.cmdVoltar.Text = "Voltar";
            this.cmdVoltar.UseVisualStyleBackColor = false;
            this.cmdVoltar.Click += new System.EventHandler(this.cmdVoltar_Click);
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
            this.label9.Location = new System.Drawing.Point(492, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Data:";
            // 
            // lbldata
            // 
            this.lbldata.AutoSize = true;
            this.lbldata.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldata.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbldata.Location = new System.Drawing.Point(538, 12);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(75, 13);
            this.lbldata.TabIndex = 40;
            this.lbldata.Text = "00/00/0000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(492, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Hora:";
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblInicio.Location = new System.Drawing.Point(536, 30);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(57, 13);
            this.lblInicio.TabIndex = 38;
            this.lblInicio.Text = "00:00:00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Banco.Properties.Resources.conjunto_de_icones_do_sistema_bancario_1284_14615__4_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(124, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 63);
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // FrmDeposito
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
            this.Controls.Add(this.cmdVoltar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDeposito";
            this.Text = "Depósito";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcontaDeposito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsobrenomeDeposito;
        private System.Windows.Forms.TextBox txtnomeDeposito;
        private System.Windows.Forms.Button cmdValidarDeposito;
        private System.Windows.Forms.TextBox txtvalorDeposito;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmdVoltar;
        private System.Windows.Forms.Button cmdDeposito;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbldata;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}