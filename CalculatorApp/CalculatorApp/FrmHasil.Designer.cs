
namespace CalculatorApp
{
    partial class FrmHasil
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
            this.lvwHasil = new System.Windows.Forms.ListView();
            this.btnHitung = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwHasil
            // 
            this.lvwHasil.HideSelection = false;
            this.lvwHasil.Location = new System.Drawing.Point(17, 29);
            this.lvwHasil.Name = "lvwHasil";
            this.lvwHasil.Size = new System.Drawing.Size(457, 300);
            this.lvwHasil.TabIndex = 0;
            this.lvwHasil.UseCompatibleStateImageBehavior = false;
            this.lvwHasil.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btnHitung
            // 
            this.btnHitung.Location = new System.Drawing.Point(43, 385);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(498, 41);
            this.btnHitung.TabIndex = 1;
            this.btnHitung.Text = "Hitung";
            this.btnHitung.UseVisualStyleBackColor = true;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvwHasil);
            this.groupBox1.Location = new System.Drawing.Point(43, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 341);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[Hasil]";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // FrmHasil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnHitung);
            this.Name = "FrmHasil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasil Perhitungan";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwHasil;
        private System.Windows.Forms.Button btnHitung;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

