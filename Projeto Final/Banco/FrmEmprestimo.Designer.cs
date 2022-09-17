namespace Banco
{
    partial class FrmEmprestimo
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rb5 = new System.Windows.Forms.RadioButton();
            this.rb = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.cmdEmprestimo = new System.Windows.Forms.Button();
            this.cmdValidarEmprestimo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcontaEmprestimo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsenhaEmprestimo = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdVoltar = new System.Windows.Forms.Button();
            this.lblInicio = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbldata = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Empréstimo";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.cmdEmprestimo);
            this.panel1.Controls.Add(this.cmdValidarEmprestimo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtcontaEmprestimo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtsenhaEmprestimo);
            this.panel1.Location = new System.Drawing.Point(12, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 299);
            this.panel1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(194, 38);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(185, 172);
            this.richTextBox1.TabIndex = 39;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(190, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 24);
            this.label2.TabIndex = 38;
            this.label2.Text = "Rex Bank Informa";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.rb5);
            this.groupBox1.Controls.Add(this.rb);
            this.groupBox1.Controls.Add(this.rb3);
            this.groupBox1.Controls.Add(this.rb2);
            this.groupBox1.Controls.Add(this.rb1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(396, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 228);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tabela de empréstimo";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(43, 205);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(61, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "100000";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // rb5
            // 
            this.rb5.AutoSize = true;
            this.rb5.BackColor = System.Drawing.Color.White;
            this.rb5.Location = new System.Drawing.Point(43, 165);
            this.rb5.Name = "rb5";
            this.rb5.Size = new System.Drawing.Size(55, 17);
            this.rb5.TabIndex = 4;
            this.rb5.TabStop = true;
            this.rb5.Text = "50000";
            this.rb5.UseVisualStyleBackColor = false;
            // 
            // rb
            // 
            this.rb.AutoSize = true;
            this.rb.BackColor = System.Drawing.Color.White;
            this.rb.Location = new System.Drawing.Point(43, 132);
            this.rb.Name = "rb";
            this.rb.Size = new System.Drawing.Size(55, 17);
            this.rb.TabIndex = 3;
            this.rb.TabStop = true;
            this.rb.Text = "20000";
            this.rb.UseVisualStyleBackColor = false;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.BackColor = System.Drawing.Color.White;
            this.rb3.Location = new System.Drawing.Point(43, 92);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(55, 17);
            this.rb3.TabIndex = 2;
            this.rb3.TabStop = true;
            this.rb3.Text = "10000";
            this.rb3.UseVisualStyleBackColor = false;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.BackColor = System.Drawing.Color.White;
            this.rb2.Location = new System.Drawing.Point(43, 59);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(49, 17);
            this.rb2.TabIndex = 1;
            this.rb2.TabStop = true;
            this.rb2.Text = "5000";
            this.rb2.UseVisualStyleBackColor = false;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.BackColor = System.Drawing.Color.White;
            this.rb1.Location = new System.Drawing.Point(43, 27);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(49, 17);
            this.rb1.TabIndex = 0;
            this.rb1.TabStop = true;
            this.rb1.Text = "2000";
            this.rb1.UseVisualStyleBackColor = false;
            // 
            // cmdEmprestimo
            // 
            this.cmdEmprestimo.BackColor = System.Drawing.Color.LightGray;
            this.cmdEmprestimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEmprestimo.Location = new System.Drawing.Point(506, 255);
            this.cmdEmprestimo.Name = "cmdEmprestimo";
            this.cmdEmprestimo.Size = new System.Drawing.Size(82, 31);
            this.cmdEmprestimo.TabIndex = 36;
            this.cmdEmprestimo.Text = "Processar";
            this.cmdEmprestimo.UseVisualStyleBackColor = false;
            this.cmdEmprestimo.Click += new System.EventHandler(this.cmdEmprestimo_Click);
            // 
            // cmdValidarEmprestimo
            // 
            this.cmdValidarEmprestimo.BackColor = System.Drawing.Color.LightGray;
            this.cmdValidarEmprestimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdValidarEmprestimo.Location = new System.Drawing.Point(6, 146);
            this.cmdValidarEmprestimo.Name = "cmdValidarEmprestimo";
            this.cmdValidarEmprestimo.Size = new System.Drawing.Size(82, 31);
            this.cmdValidarEmprestimo.TabIndex = 35;
            this.cmdValidarEmprestimo.Text = "Validar";
            this.cmdValidarEmprestimo.UseVisualStyleBackColor = false;
            this.cmdValidarEmprestimo.Click += new System.EventHandler(this.cmdValidarEmprestimo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "N° conta";
            // 
            // txtcontaEmprestimo
            // 
            this.txtcontaEmprestimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontaEmprestimo.Location = new System.Drawing.Point(3, 33);
            this.txtcontaEmprestimo.Name = "txtcontaEmprestimo";
            this.txtcontaEmprestimo.Size = new System.Drawing.Size(100, 22);
            this.txtcontaEmprestimo.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "Senha";
            // 
            // txtsenhaEmprestimo
            // 
            this.txtsenhaEmprestimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsenhaEmprestimo.Location = new System.Drawing.Point(3, 92);
            this.txtsenhaEmprestimo.Name = "txtsenhaEmprestimo";
            this.txtsenhaEmprestimo.Size = new System.Drawing.Size(100, 22);
            this.txtsenhaEmprestimo.TabIndex = 34;
            this.txtsenhaEmprestimo.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Banco.Properties.Resources.conjunto_de_icones_do_sistema_bancario_1284_14615__2_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(174, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 63);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // cmdVoltar
            // 
            this.cmdVoltar.BackColor = System.Drawing.Color.LightGray;
            this.cmdVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVoltar.Location = new System.Drawing.Point(12, 12);
            this.cmdVoltar.Name = "cmdVoltar";
            this.cmdVoltar.Size = new System.Drawing.Size(96, 31);
            this.cmdVoltar.TabIndex = 24;
            this.cmdVoltar.Text = "Voltar";
            this.cmdVoltar.UseVisualStyleBackColor = false;
            this.cmdVoltar.Click += new System.EventHandler(this.cmdVoltar_Click);
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblInicio.Location = new System.Drawing.Point(549, 27);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(57, 13);
            this.lblInicio.TabIndex = 19;
            this.lblInicio.Text = "00:00:00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(505, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Hora:";
            // 
            // lbldata
            // 
            this.lbldata.AutoSize = true;
            this.lbldata.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldata.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbldata.Location = new System.Drawing.Point(551, 9);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(75, 13);
            this.lbldata.TabIndex = 21;
            this.lbldata.Text = "00/00/0000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(505, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Data:";
            // 
            // FrmEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(635, 412);
            this.Controls.Add(this.cmdVoltar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbldata);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEmprestimo";
            this.Text = "Empréstimo";
            this.Load += new System.EventHandler(this.FrmEmprestimo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdValidarEmprestimo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcontaEmprestimo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsenhaEmprestimo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb5;
        private System.Windows.Forms.RadioButton rb;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.Button cmdEmprestimo;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cmdVoltar;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbldata;
        private System.Windows.Forms.Label label9;
    }
}