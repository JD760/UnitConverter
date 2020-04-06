namespace UnitConverter
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
            this.conversionPanel = new System.Windows.Forms.TableLayoutPanel();
            this.convertingLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.conversionInputBox = new System.Windows.Forms.TextBox();
            this.conversionOutputBox = new System.Windows.Forms.Label();
            this.unitInputDropdown = new System.Windows.Forms.ComboBox();
            this.unitOutputDropdown = new System.Windows.Forms.ComboBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.conversionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // conversionPanel
            // 
            this.conversionPanel.BackColor = System.Drawing.SystemColors.Control;
            this.conversionPanel.ColumnCount = 4;
            this.conversionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.conversionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.conversionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.conversionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.conversionPanel.Controls.Add(this.convertingLabel, 0, 0);
            this.conversionPanel.Controls.Add(this.toLabel, 2, 0);
            this.conversionPanel.Controls.Add(this.label1, 0, 1);
            this.conversionPanel.Controls.Add(this.label2, 2, 1);
            this.conversionPanel.Controls.Add(this.conversionInputBox, 1, 1);
            this.conversionPanel.Controls.Add(this.conversionOutputBox, 3, 1);
            this.conversionPanel.Controls.Add(this.unitInputDropdown, 1, 0);
            this.conversionPanel.Controls.Add(this.unitOutputDropdown, 3, 0);
            this.conversionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.conversionPanel.Location = new System.Drawing.Point(0, 0);
            this.conversionPanel.Name = "conversionPanel";
            this.conversionPanel.RowCount = 2;
            this.conversionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.conversionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.54546F));
            this.conversionPanel.Size = new System.Drawing.Size(483, 58);
            this.conversionPanel.TabIndex = 1;
            // 
            // convertingLabel
            // 
            this.convertingLabel.AutoSize = true;
            this.convertingLabel.BackColor = System.Drawing.SystemColors.Control;
            this.convertingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.convertingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertingLabel.Location = new System.Drawing.Point(3, 0);
            this.convertingLabel.Name = "convertingLabel";
            this.convertingLabel.Size = new System.Drawing.Size(114, 26);
            this.convertingLabel.TabIndex = 0;
            this.convertingLabel.Text = "Converting :";
            this.convertingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toLabel.Location = new System.Drawing.Point(243, 0);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(114, 26);
            this.toLabel.TabIndex = 1;
            this.toLabel.Text = "To :";
            this.toLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Input :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(243, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Output :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // conversionInputBox
            // 
            this.conversionInputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.conversionInputBox.Location = new System.Drawing.Point(123, 29);
            this.conversionInputBox.Name = "conversionInputBox";
            this.conversionInputBox.Size = new System.Drawing.Size(114, 20);
            this.conversionInputBox.TabIndex = 6;
            this.conversionInputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.conversionInputBox.TextChanged += new System.EventHandler(this.conversionInputBox_TextChanged);
            // 
            // conversionOutputBox
            // 
            this.conversionOutputBox.AutoSize = true;
            this.conversionOutputBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conversionOutputBox.Location = new System.Drawing.Point(363, 26);
            this.conversionOutputBox.Name = "conversionOutputBox";
            this.conversionOutputBox.Size = new System.Drawing.Size(117, 32);
            this.conversionOutputBox.TabIndex = 7;
            this.conversionOutputBox.Text = "placeholder";
            this.conversionOutputBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.conversionOutputBox.Click += new System.EventHandler(this.conversionOutputBox_Click);
            // 
            // unitInputDropdown
            // 
            this.unitInputDropdown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unitInputDropdown.FormattingEnabled = true;
            this.unitInputDropdown.Items.AddRange(new object[] {
            "Kilometre",
            "Metre",
            "Centimetre",
            "Millimeter",
            "Micrometre",
            "Nanometre",
            "Mile",
            "Yard",
            "Foot",
            "Inch",
            "Nautical Mile"});
            this.unitInputDropdown.Location = new System.Drawing.Point(123, 3);
            this.unitInputDropdown.Name = "unitInputDropdown";
            this.unitInputDropdown.Size = new System.Drawing.Size(114, 21);
            this.unitInputDropdown.TabIndex = 8;
            this.unitInputDropdown.Text = "please select a unit";
            this.unitInputDropdown.SelectedIndexChanged += new System.EventHandler(this.unitInputDropdown_SelectedIndexChanged);
            // 
            // unitOutputDropdown
            // 
            this.unitOutputDropdown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unitOutputDropdown.FormattingEnabled = true;
            this.unitOutputDropdown.Items.AddRange(new object[] {
            "Kilometre",
            "Metre",
            "Centimetre",
            "Millimeter",
            "Micrometre",
            "Nanometre",
            "Mile",
            "Yard",
            "Foot",
            "Inch",
            "Nautical Mile"});
            this.unitOutputDropdown.Location = new System.Drawing.Point(363, 3);
            this.unitOutputDropdown.Name = "unitOutputDropdown";
            this.unitOutputDropdown.Size = new System.Drawing.Size(117, 21);
            this.unitOutputDropdown.TabIndex = 9;
            this.unitOutputDropdown.Text = "Please select a unit";
            this.unitOutputDropdown.SelectedIndexChanged += new System.EventHandler(this.unitOutputDropdown_SelectedIndexChanged);
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(123, 64);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(119, 23);
            this.convertButton.TabIndex = 2;
            this.convertButton.Text = "convert units";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.convertButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 690);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.conversionPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(499, 714);
            this.Name = "Form1";
            this.Text = "Jacob\'s Unit Converter";
            this.conversionPanel.ResumeLayout(false);
            this.conversionPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel conversionPanel;
        private System.Windows.Forms.Label convertingLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox conversionInputBox;
        private System.Windows.Forms.Label conversionOutputBox;
        private System.Windows.Forms.ComboBox unitInputDropdown;
        private System.Windows.Forms.ComboBox unitOutputDropdown;
        private System.Windows.Forms.Button convertButton;
    }
}

