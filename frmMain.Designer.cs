
namespace AS2122_4E_INF_TogniEmanuele_Palestra
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPersone = new System.Windows.Forms.TextBox();
            this.chkSpinning = new System.Windows.Forms.CheckBox();
            this.chkPesi = new System.Windows.Forms.CheckBox();
            this.chkDanza = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSconto = new System.Windows.Forms.Label();
            this.lblPreventivo = new System.Windows.Forms.Label();
            this.nudMesi = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudMesi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero persone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mesi";
            // 
            // txtPersone
            // 
            this.txtPersone.Location = new System.Drawing.Point(139, 30);
            this.txtPersone.Name = "txtPersone";
            this.txtPersone.Size = new System.Drawing.Size(100, 23);
            this.txtPersone.TabIndex = 2;
            // 
            // chkSpinning
            // 
            this.chkSpinning.AutoSize = true;
            this.chkSpinning.Location = new System.Drawing.Point(37, 132);
            this.chkSpinning.Name = "chkSpinning";
            this.chkSpinning.Size = new System.Drawing.Size(127, 19);
            this.chkSpinning.TabIndex = 4;
            this.chkSpinning.Text = "Spinning 40€/mese";
            this.chkSpinning.UseVisualStyleBackColor = true;
            // 
            // chkPesi
            // 
            this.chkPesi.AutoSize = true;
            this.chkPesi.Location = new System.Drawing.Point(37, 182);
            this.chkPesi.Name = "chkPesi";
            this.chkPesi.Size = new System.Drawing.Size(101, 19);
            this.chkPesi.TabIndex = 6;
            this.chkPesi.Text = "Pesi 45€/mese";
            this.chkPesi.UseVisualStyleBackColor = true;
            // 
            // chkDanza
            // 
            this.chkDanza.AutoSize = true;
            this.chkDanza.Location = new System.Drawing.Point(37, 157);
            this.chkDanza.Name = "chkDanza";
            this.chkDanza.Size = new System.Drawing.Size(112, 19);
            this.chkDanza.TabIndex = 7;
            this.chkDanza.Text = "Danza 50€/mese";
            this.chkDanza.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calcola";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sconto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Totale preventivo:";
            // 
            // lblSconto
            // 
            this.lblSconto.AutoSize = true;
            this.lblSconto.Location = new System.Drawing.Point(90, 292);
            this.lblSconto.Name = "lblSconto";
            this.lblSconto.Size = new System.Drawing.Size(14, 15);
            this.lblSconto.TabIndex = 12;
            this.lblSconto.Text = "#";
            // 
            // lblPreventivo
            // 
            this.lblPreventivo.AutoSize = true;
            this.lblPreventivo.Location = new System.Drawing.Point(139, 317);
            this.lblPreventivo.Name = "lblPreventivo";
            this.lblPreventivo.Size = new System.Drawing.Size(14, 15);
            this.lblPreventivo.TabIndex = 13;
            this.lblPreventivo.Text = "#";
            // 
            // nudMesi
            // 
            this.nudMesi.Location = new System.Drawing.Point(75, 85);
            this.nudMesi.Name = "nudMesi";
            this.nudMesi.Size = new System.Drawing.Size(120, 23);
            this.nudMesi.TabIndex = 14;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 375);
            this.Controls.Add(this.nudMesi);
            this.Controls.Add(this.lblPreventivo);
            this.Controls.Add(this.lblSconto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chkDanza);
            this.Controls.Add(this.chkPesi);
            this.Controls.Add(this.chkSpinning);
            this.Controls.Add(this.txtPersone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudMesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPersone;
        private System.Windows.Forms.CheckBox chkSpinning;
        private System.Windows.Forms.CheckBox chkPesi;
        private System.Windows.Forms.CheckBox chkDanza;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSconto;
        private System.Windows.Forms.Label lblPreventivo;
        private System.Windows.Forms.NumericUpDown nudMesi;
    }
}

