namespace MilkProperties
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.milkType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.volume = new System.Windows.Forms.TextBox();
            this.resButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lacContent = new System.Windows.Forms.Label();
            this.fatCon = new System.Windows.Forms.Label();
            this.fatC = new System.Windows.Forms.Label();
            this.carbCon = new System.Windows.Forms.Label();
            this.enCon = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // milkType
            // 
            this.milkType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.milkType.FormattingEnabled = true;
            this.milkType.Items.AddRange(new object[] {
            "Skim milk",
            "Reduced fat milk",
            "Regular milk",
            "Whole milk",
            "Raw milk"});
            this.milkType.Location = new System.Drawing.Point(52, 174);
            this.milkType.Name = "milkType";
            this.milkType.Size = new System.Drawing.Size(304, 50);
            this.milkType.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select milk type";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // volume
            // 
            this.volume.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.volume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volume.Location = new System.Drawing.Point(52, 385);
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(304, 44);
            this.volume.TabIndex = 2;
            // 
            // resButton
            // 
            this.resButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.resButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resButton.Location = new System.Drawing.Point(52, 564);
            this.resButton.Name = "resButton";
            this.resButton.Size = new System.Drawing.Size(304, 88);
            this.resButton.TabIndex = 3;
            this.resButton.Text = "CALCULATE";
            this.resButton.UseVisualStyleBackColor = true;
            this.resButton.Click += new System.EventHandler(this.resButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 51);
            this.label2.TabIndex = 4;
            this.label2.Text = "Input volume";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(362, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 51);
            this.label3.TabIndex = 5;
            this.label3.Text = "ml";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(738, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(355, 51);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lactose content:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(738, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(261, 51);
            this.label5.TabIndex = 7;
            this.label5.Text = "Fat content:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(738, 410);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(331, 51);
            this.label6.TabIndex = 8;
            this.label6.Text = "Carbohydrates:";
            // 
            // lacContent
            // 
            this.lacContent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lacContent.AutoSize = true;
            this.lacContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lacContent.Location = new System.Drawing.Point(740, 187);
            this.lacContent.Name = "lacContent";
            this.lacContent.Size = new System.Drawing.Size(37, 37);
            this.lacContent.TabIndex = 9;
            this.lacContent.Text = "--";
            // 
            // fatCon
            // 
            this.fatCon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fatCon.AutoSize = true;
            this.fatCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fatCon.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.fatCon.Location = new System.Drawing.Point(738, 564);
            this.fatCon.Name = "fatCon";
            this.fatCon.Size = new System.Drawing.Size(348, 51);
            this.fatCon.TabIndex = 10;
            this.fatCon.Text = "Energetic value:";
            // 
            // fatC
            // 
            this.fatC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fatC.AutoSize = true;
            this.fatC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fatC.Location = new System.Drawing.Point(740, 346);
            this.fatC.Name = "fatC";
            this.fatC.Size = new System.Drawing.Size(37, 37);
            this.fatC.TabIndex = 11;
            this.fatC.Text = "--";
            // 
            // carbCon
            // 
            this.carbCon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.carbCon.AutoSize = true;
            this.carbCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carbCon.Location = new System.Drawing.Point(740, 500);
            this.carbCon.Name = "carbCon";
            this.carbCon.Size = new System.Drawing.Size(37, 37);
            this.carbCon.TabIndex = 12;
            this.carbCon.Text = "--";
            // 
            // enCon
            // 
            this.enCon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.enCon.AutoSize = true;
            this.enCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enCon.Location = new System.Drawing.Point(740, 648);
            this.enCon.Name = "enCon";
            this.enCon.Size = new System.Drawing.Size(37, 37);
            this.enCon.TabIndex = 13;
            this.enCon.Text = "--";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(999, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 51);
            this.label7.TabIndex = 14;
            this.label7.Text = "g";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(999, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 51);
            this.label8.TabIndex = 15;
            this.label8.Text = "g";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(999, 500);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 51);
            this.label9.TabIndex = 16;
            this.label9.Text = "g";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(999, 636);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 51);
            this.label10.TabIndex = 17;
            this.label10.Text = "kcal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1288, 729);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.enCon);
            this.Controls.Add(this.carbCon);
            this.Controls.Add(this.fatC);
            this.Controls.Add(this.fatCon);
            this.Controls.Add(this.lacContent);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resButton);
            this.Controls.Add(this.volume);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.milkType);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1314, 800);
            this.MinimumSize = new System.Drawing.Size(1200, 753);
            this.Name = "Form1";
            this.Text = "Milk Properties Calculator v1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox milkType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox volume;
        private System.Windows.Forms.Button resButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lacContent;
        private System.Windows.Forms.Label fatCon;
        private System.Windows.Forms.Label fatC;
        private System.Windows.Forms.Label carbCon;
        private System.Windows.Forms.Label enCon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

