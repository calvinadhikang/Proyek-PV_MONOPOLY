namespace Proyek_Pv
{
    partial class Map
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Map));
            this.panelMaps = new System.Windows.Forms.Panel();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.buttonAsset = new System.Windows.Forms.Button();
            this.panelDice = new System.Windows.Forms.Panel();
            this.buttonRoll = new System.Windows.Forms.Button();
            this.btn_endturn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelDice.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMaps
            // 
            this.panelMaps.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMaps.BackgroundImage")));
            this.panelMaps.Location = new System.Drawing.Point(9, 8);
            this.panelMaps.Margin = new System.Windows.Forms.Padding(2);
            this.panelMaps.Name = "panelMaps";
            this.panelMaps.Size = new System.Drawing.Size(900, 900);
            this.panelMaps.TabIndex = 0;
            this.panelMaps.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMaps_Paint);
            // 
            // buttonBuy
            // 
            this.buttonBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuy.Location = new System.Drawing.Point(11, 917);
            this.buttonBuy.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(202, 57);
            this.buttonBuy.TabIndex = 1;
            this.buttonBuy.Text = "Buy";
            this.buttonBuy.UseVisualStyleBackColor = true;
            // 
            // buttonAsset
            // 
            this.buttonAsset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAsset.Location = new System.Drawing.Point(217, 917);
            this.buttonAsset.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAsset.Name = "buttonAsset";
            this.buttonAsset.Size = new System.Drawing.Size(202, 57);
            this.buttonAsset.TabIndex = 2;
            this.buttonAsset.Text = "Asset";
            this.buttonAsset.UseVisualStyleBackColor = true;
            // 
            // panelDice
            // 
            this.panelDice.Controls.Add(this.buttonRoll);
            this.panelDice.Location = new System.Drawing.Point(925, 741);
            this.panelDice.Margin = new System.Windows.Forms.Padding(2);
            this.panelDice.Name = "panelDice";
            this.panelDice.Size = new System.Drawing.Size(269, 233);
            this.panelDice.TabIndex = 3;
            this.panelDice.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDice_Paint);
            // 
            // buttonRoll
            // 
            this.buttonRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRoll.Location = new System.Drawing.Point(90, 187);
            this.buttonRoll.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRoll.Name = "buttonRoll";
            this.buttonRoll.Size = new System.Drawing.Size(97, 34);
            this.buttonRoll.TabIndex = 4;
            this.buttonRoll.Text = "Roll";
            this.buttonRoll.UseVisualStyleBackColor = true;
            this.buttonRoll.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_endturn
            // 
            this.btn_endturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_endturn.Location = new System.Drawing.Point(707, 917);
            this.btn_endturn.Margin = new System.Windows.Forms.Padding(2);
            this.btn_endturn.Name = "btn_endturn";
            this.btn_endturn.Size = new System.Drawing.Size(202, 57);
            this.btn_endturn.TabIndex = 4;
            this.btn_endturn.Text = "End Turn";
            this.btn_endturn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(987, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 985);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_endturn);
            this.Controls.Add(this.panelDice);
            this.Controls.Add(this.buttonAsset);
            this.Controls.Add(this.buttonBuy);
            this.Controls.Add(this.panelMaps);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Map";
            this.Text = "Map";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Map_Load);
            this.panelDice.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMaps;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.Button buttonAsset;
        private System.Windows.Forms.Panel panelDice;
        private System.Windows.Forms.Button buttonRoll;
        private System.Windows.Forms.Button btn_endturn;
        private System.Windows.Forms.Button button1;
    }
}