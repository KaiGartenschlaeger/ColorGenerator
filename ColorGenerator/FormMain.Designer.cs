namespace ColorGenerator
{
    partial class FormMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.flpColors = new System.Windows.Forms.FlowLayoutPanel();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.btnCode = new System.Windows.Forms.Button();
            this.chbSelectAll = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(394, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // flpColors
            // 
            this.flpColors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpColors.AutoScroll = true;
            this.flpColors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpColors.Location = new System.Drawing.Point(12, 12);
            this.flpColors.Name = "flpColors";
            this.flpColors.Size = new System.Drawing.Size(462, 274);
            this.flpColors.TabIndex = 1;
            // 
            // nudAmount
            // 
            this.nudAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudAmount.Location = new System.Drawing.Point(12, 329);
            this.nudAmount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudAmount.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(78, 20);
            this.nudAmount.TabIndex = 2;
            this.nudAmount.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // btnCode
            // 
            this.btnCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCode.Location = new System.Drawing.Point(308, 321);
            this.btnCode.Name = "btnCode";
            this.btnCode.Size = new System.Drawing.Size(80, 28);
            this.btnCode.TabIndex = 3;
            this.btnCode.Text = "Code";
            this.btnCode.UseVisualStyleBackColor = true;
            this.btnCode.Click += new System.EventHandler(this.btnCode_Click);
            // 
            // chbSelectAll
            // 
            this.chbSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chbSelectAll.AutoSize = true;
            this.chbSelectAll.Location = new System.Drawing.Point(12, 292);
            this.chbSelectAll.Name = "chbSelectAll";
            this.chbSelectAll.Size = new System.Drawing.Size(43, 17);
            this.chbSelectAll.TabIndex = 4;
            this.chbSelectAll.Text = "Alle";
            this.chbSelectAll.UseVisualStyleBackColor = true;
            this.chbSelectAll.CheckedChanged += new System.EventHandler(this.chbSelectAll_CheckedChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 361);
            this.Controls.Add(this.chbSelectAll);
            this.Controls.Add(this.btnCode);
            this.Controls.Add(this.nudAmount);
            this.Controls.Add(this.flpColors);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PastelColorGenerator";
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flpColors;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.Button btnCode;
        private System.Windows.Forms.CheckBox chbSelectAll;
    }
}

