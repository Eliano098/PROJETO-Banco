namespace Banco
{
    partial class FrmTransferencia
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
            this.cmdVoltar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.cmdTransferencia = new System.Windows.Forms.Button();
            this.cmdValidarTrans = new System.Windows.Forms.Button();
            this.txtValorTrans = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNomeTrans = new System.Windows.Forms.TextBox();
            this.txtcontaTrans2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsenhaTrans = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcontaTrans = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.lbldata = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
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
            this.label1.Location = new System.Drawing.Point(229, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Transferência";
            // 
            // cmdVoltar
            // 
            this.cmdVoltar.BackColor = System.Drawing.Color.LightGray;
            this.cmdVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVoltar.Location = new System.Drawing.Point(12, 12);
            this.cmdVoltar.Name = "cmdVoltar";
            this.cmdVoltar.Size = new System.Drawing.Size(82, 31);
            this.cmdVoltar.TabIndex = 30;
            this.cmdVoltar.Text = "Voltar";
            this.cmdVoltar.UseVisualStyleBackColor = false;
            this.cmdVoltar.Click += new System.EventHandler(this.cmdVoltar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cmdTransferencia);
            this.panel1.Controls.Add(this.cmdValidarTrans);
            this.panel1.Controls.Add(this.txtValorTrans);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtNomeTrans);
            this.panel1.Controls.Add(this.txtcontaTrans2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtsenhaTrans);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtcontaTrans);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 264);
            this.panel1.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(319, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "R$";
            // 
            // cmdTransferencia
            // 
            this.cmdTransferencia.BackColor = System.Drawing.Color.LightGray;
            this.cmdTransferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdTransferencia.Location = new System.Drawing.Point(427, 230);
            this.cmdTransferencia.Name = "cmdTransferencia";
            this.cmdTransferencia.Size = new System.Drawing.Size(82, 31);
            this.cmdTransferencia.TabIndex = 38;
            this.cmdTransferencia.Text = "Processar";
            this.cmdTransferencia.UseVisualStyleBackColor = false;
            this.cmdTransferencia.Click += new System.EventHandler(this.cmdTransferencia_Click);
            // 
            // cmdValidarTrans
            // 
            this.cmdValidarTrans.BackColor = System.Drawing.Color.LightGray;
            this.cmdValidarTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdValidarTrans.Location = new System.Drawing.Point(15, 192);
            this.cmdValidarTrans.Name = "cmdValidarTrans";
            this.cmdValidarTrans.Size = new System.Drawing.Size(82, 31);
            this.cmdValidarTrans.TabIndex = 37;
            this.cmdValidarTrans.Text = "Validar";
            this.cmdValidarTrans.UseVisualStyleBackColor = false;
            this.cmdValidarTrans.Click += new System.EventHandler(this.cmdValidarTrans_Click);
            // 
            // txtValorTrans
            // 
            this.txtValorTrans.Enabled = false;
            this.txtValorTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTrans.Location = new System.Drawing.Point(319, 201);
            this.txtValorTrans.Name = "txtValorTrans";
            this.txtValorTrans.Size = new System.Drawing.Size(100, 22);
            this.txtValorTrans.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(316, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "Nome";
            // 
            // txtNomeTrans
            // 
            this.txtNomeTrans.Enabled = false;
            this.txtNomeTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeTrans.Location = new System.Drawing.Point(319, 140);
            this.txtNomeTrans.Name = "txtNomeTrans";
            this.txtNomeTrans.Size = new System.Drawing.Size(175, 22);
            this.txtNomeTrans.TabIndex = 31;
            // 
            // txtcontaTrans2
            // 
            this.txtcontaTrans2.AcceptsTab = true;
            this.txtcontaTrans2.Enabled = false;
            this.txtcontaTrans2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontaTrans2.Location = new System.Drawing.Point(319, 81);
            this.txtcontaTrans2.Name = "txtcontaTrans2";
            this.txtcontaTrans2.Size = new System.Drawing.Size(100, 22);
            this.txtcontaTrans2.TabIndex = 30;
            this.txtcontaTrans2.Leave += new System.EventHandler(this.txtcontaTrans2_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(319, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "N° conta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(319, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Contato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Informe os dados do titular";
            // 
            // txtsenhaTrans
            // 
            this.txtsenhaTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsenhaTrans.Location = new System.Drawing.Point(15, 140);
            this.txtsenhaTrans.Name = "txtsenhaTrans";
            this.txtsenhaTrans.Size = new System.Drawing.Size(100, 22);
            this.txtsenhaTrans.TabIndex = 24;
            this.txtsenhaTrans.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Senha";
            // 
            // txtcontaTrans
            // 
            this.txtcontaTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontaTrans.Location = new System.Drawing.Point(15, 81);
            this.txtcontaTrans.Name = "txtcontaTrans";
            this.txtcontaTrans.Size = new System.Drawing.Size(100, 22);
            this.txtcontaTrans.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "N° conta";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(483, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 45;
            this.label10.Text = "Data:";
            // 
            // lbldata
            // 
            this.lbldata.AutoSize = true;
            this.lbldata.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldata.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbldata.Location = new System.Drawing.Point(529, 12);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(75, 13);
            this.lbldata.TabIndex = 44;
            this.lbldata.Text = "00/00/0000";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(483, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 43;
            this.label11.Text = "Hora:";
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblInicio.Location = new System.Drawing.Point(527, 30);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(57, 13);
            this.lblInicio.TabIndex = 42;
            this.lblInicio.Text = "00:00:00";
            this.lblInicio.Click += new System.EventHandler(this.lblInicio_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Banco.Properties.Resources.conjunto_de_icones_do_sistema_bancario_1284_14615__6_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(123, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 63);
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // FrmTransferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(617, 366);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbldata);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmdVoltar);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTransferencia";
            this.Text = "Transferência";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdVoltar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtValorTrans;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNomeTrans;
        private System.Windows.Forms.TextBox txtcontaTrans2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsenhaTrans;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcontaTrans;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdValidarTrans;
        private System.Windows.Forms.Button cmdTransferencia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbldata;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}