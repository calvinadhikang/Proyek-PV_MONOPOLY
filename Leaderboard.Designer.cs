﻿namespace Proyek_Pv
{
    partial class Leaderboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelKedua = new System.Windows.Forms.Label();
            this.labelTiga = new System.Windows.Forms.Label();
            this.labelPertama = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Leaderboard";
            // 
            // labelKedua
            // 
            this.labelKedua.AutoSize = true;
            this.labelKedua.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKedua.Location = new System.Drawing.Point(191, 234);
            this.labelKedua.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelKedua.Name = "labelKedua";
            this.labelKedua.Size = new System.Drawing.Size(200, 55);
            this.labelKedua.TabIndex = 1;
            this.labelKedua.Text = "Player 2";
            // 
            // labelTiga
            // 
            this.labelTiga.AutoSize = true;
            this.labelTiga.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTiga.Location = new System.Drawing.Point(191, 330);
            this.labelTiga.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTiga.Name = "labelTiga";
            this.labelTiga.Size = new System.Drawing.Size(200, 55);
            this.labelTiga.TabIndex = 2;
            this.labelTiga.Text = "Player 3";
            // 
            // labelPertama
            // 
            this.labelPertama.AutoSize = true;
            this.labelPertama.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPertama.Location = new System.Drawing.Point(191, 145);
            this.labelPertama.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPertama.Name = "labelPertama";
            this.labelPertama.Size = new System.Drawing.Size(200, 55);
            this.labelPertama.TabIndex = 3;
            this.labelPertama.Text = "Player 1";
            // 
            // Leaderboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 457);
            this.Controls.Add(this.labelPertama);
            this.Controls.Add(this.labelTiga);
            this.Controls.Add(this.labelKedua);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Leaderboard";
            this.Text = "Leaderboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Leaderboard_FormClosing);
            this.Load += new System.EventHandler(this.Leaderboard_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Leaderboard_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelKedua;
        private System.Windows.Forms.Label labelTiga;
        private System.Windows.Forms.Label labelPertama;
    }
}