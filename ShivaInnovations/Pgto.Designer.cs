﻿namespace ShivaInnovations
{
    partial class Pgto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pgto));
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ingressos = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.nomebox = new System.Windows.Forms.MaskedTextBox();
            this.email = new System.Windows.Forms.MaskedTextBox();
            this.telefone = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ingressos)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepPink;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Niagara Engraved", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(71, 506);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(482, 125);
            this.button1.TabIndex = 0;
            this.button1.Text = "Comprar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(94, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(448, 37);
            this.label3.TabIndex = 18;
            this.label3.Text = "Selecione a quantidade de ingressos";
            // 
            // ingressos
            // 
            this.ingressos.Location = new System.Drawing.Point(85, 453);
            this.ingressos.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.ingressos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ingressos.Name = "ingressos";
            this.ingressos.Size = new System.Drawing.Size(466, 20);
            this.ingressos.TabIndex = 17;
            this.ingressos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ingressos.ValueChanged += new System.EventHandler(this.ingressos_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DeepPink;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "CPF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DeepPink;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 14.25F);
            this.label4.Location = new System.Drawing.Point(81, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "E-mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DeepPink;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 14.25F);
            this.label5.Location = new System.Drawing.Point(81, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Telefone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DeepPink;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 14.25F);
            this.label2.Location = new System.Drawing.Point(81, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nome";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(185, 122);
            this.maskedTextBox1.Mask = "999.999.999-99";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(391, 20);
            this.maskedTextBox1.TabIndex = 24;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // nomebox
            // 
            this.nomebox.Location = new System.Drawing.Point(185, 165);
            this.nomebox.Mask = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            this.nomebox.Name = "nomebox";
            this.nomebox.Size = new System.Drawing.Size(391, 20);
            this.nomebox.TabIndex = 25;
            this.nomebox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.nomebox_MaskInputRejected);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(185, 208);
            this.email.Mask = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(391, 20);
            this.email.TabIndex = 26;
            this.email.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.email_MaskInputRejected);
            // 
            // telefone
            // 
            this.telefone.Location = new System.Drawing.Point(185, 250);
            this.telefone.Mask = "(99) 0000-0000";
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(391, 20);
            this.telefone.TabIndex = 27;
            this.telefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.telefone_MaskInputRejected);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Niagara Engraved", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(92, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(241, 51);
            this.label6.TabIndex = 28;
            this.label6.Text = "Valor do ingresso:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Niagara Engraved", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(339, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 51);
            this.label7.TabIndex = 29;
            this.label7.Text = "161,46 R$";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Niagara Engraved", 46F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(174, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(300, 66);
            this.label8.TabIndex = 30;
            this.label8.Text = "Insira seus dados";
            // 
            // Pgto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(609, 713);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.telefone);
            this.Controls.Add(this.email);
            this.Controls.Add(this.nomebox);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ingressos);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(625, 752);
            this.MinimumSize = new System.Drawing.Size(625, 726);
            this.Name = "Pgto";
            this.Text = "Pagamento";
            this.Load += new System.EventHandler(this.Pgto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ingressos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown ingressos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox nomebox;
        private System.Windows.Forms.MaskedTextBox email;
        private System.Windows.Forms.MaskedTextBox telefone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}