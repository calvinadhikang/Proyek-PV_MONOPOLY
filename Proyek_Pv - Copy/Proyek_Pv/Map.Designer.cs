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
            this.panelDice.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMaps
            // 
            this.panelMaps.Location = new System.Drawing.Point(13, 13);
            this.panelMaps.Name = "panelMaps";
            this.panelMaps.Size = new System.Drawing.Size(1478, 889);
            this.panelMaps.TabIndex = 0;
            this.panelMaps.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMaps_Paint);
            // 
            // buttonBuy
            // 
            this.buttonBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuy.Location = new System.Drawing.Point(656, 908);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(303, 87);
            this.buttonBuy.TabIndex = 1;
            this.buttonBuy.Text = "Buy";
            this.buttonBuy.UseVisualStyleBackColor = true;
            // 
            // buttonAsset
            // 
            this.buttonAsset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAsset.Location = new System.Drawing.Point(1137, 912);
            this.buttonAsset.Name = "buttonAsset";
            this.buttonAsset.Size = new System.Drawing.Size(289, 78);
            this.buttonAsset.TabIndex = 2;
            this.buttonAsset.Text = "Asset";
            this.buttonAsset.UseVisualStyleBackColor = true;
            // 
            // panelDice
            // 
            this.panelDice.Controls.Add(this.buttonRoll);
            this.panelDice.Location = new System.Drawing.Point(1522, 684);
            this.panelDice.Name = "panelDice";
            this.panelDice.Size = new System.Drawing.Size(273, 306);
            this.panelDice.TabIndex = 3;
            this.panelDice.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDice_Paint);
            // 
            // buttonRoll
            // 
            this.buttonRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRoll.Location = new System.Drawing.Point(78, 210);
            this.buttonRoll.Name = "buttonRoll";
            this.buttonRoll.Size = new System.Drawing.Size(146, 53);
            this.buttonRoll.TabIndex = 4;
            this.buttonRoll.Text = "Roll";
            this.buttonRoll.UseVisualStyleBackColor = true;
            this.buttonRoll.Click += new System.EventHandler(this.button1_Click);
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1807, 995);
            this.Controls.Add(this.panelDice);
            this.Controls.Add(this.buttonAsset);
            this.Controls.Add(this.buttonBuy);
            this.Controls.Add(this.panelMaps);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
    }
}