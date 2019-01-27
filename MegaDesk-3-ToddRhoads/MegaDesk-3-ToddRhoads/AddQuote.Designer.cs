namespace MegaDesk_3_ToddRhoads
{
    partial class AddQuote
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
            this.MaterialCombo = new System.Windows.Forms.ComboBox();
            this.WidthBox = new System.Windows.Forms.TextBox();
            this.DepthBox = new System.Windows.Forms.TextBox();
            this.drawerNumberBox = new System.Windows.Forms.TextBox();
            this.CreateQuote = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.normalRadio = new System.Windows.Forms.RadioButton();
            this.threeDayRadio = new System.Windows.Forms.RadioButton();
            this.fiveDayRadio = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.sevenDayRadio = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // MaterialCombo
            // 
            this.MaterialCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.MaterialCombo.FormattingEnabled = true;
            this.MaterialCombo.Items.AddRange(new object[] {
            "Oak  \t ",
            "Laminate  \t ",
            "Pine  \t ",
            "Rosewood  \t ",
            "Veneer  \t "});
            this.MaterialCombo.Location = new System.Drawing.Point(175, 15);
            this.MaterialCombo.Name = "MaterialCombo";
            this.MaterialCombo.Size = new System.Drawing.Size(121, 21);
            this.MaterialCombo.TabIndex = 0;
            // 
            // WidthBox
            // 
            this.WidthBox.Location = new System.Drawing.Point(175, 50);
            this.WidthBox.Name = "WidthBox";
            this.WidthBox.Size = new System.Drawing.Size(121, 20);
            this.WidthBox.TabIndex = 1;
            // 
            // DepthBox
            // 
            this.DepthBox.Location = new System.Drawing.Point(175, 84);
            this.DepthBox.Name = "DepthBox";
            this.DepthBox.Size = new System.Drawing.Size(121, 20);
            this.DepthBox.TabIndex = 2;
            // 
            // drawerNumberBox
            // 
            this.drawerNumberBox.Location = new System.Drawing.Point(175, 122);
            this.drawerNumberBox.Name = "drawerNumberBox";
            this.drawerNumberBox.Size = new System.Drawing.Size(121, 20);
            this.drawerNumberBox.TabIndex = 3;
            // 
            // CreateQuote
            // 
            this.CreateQuote.Location = new System.Drawing.Point(459, 341);
            this.CreateQuote.Name = "CreateQuote";
            this.CreateQuote.Size = new System.Drawing.Size(88, 35);
            this.CreateQuote.TabIndex = 5;
            this.CreateQuote.Text = "Create ";
            this.CreateQuote.UseVisualStyleBackColor = true;
            this.CreateQuote.Click += new System.EventHandler(this.CreateQuote_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Surface Material";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Depth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "# of Drawers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Production Time";
            this.label5.Visible = false;
            // 
            // normalRadio
            // 
            this.normalRadio.AutoSize = true;
            this.normalRadio.Location = new System.Drawing.Point(175, 169);
            this.normalRadio.Name = "normalRadio";
            this.normalRadio.Size = new System.Drawing.Size(106, 17);
            this.normalRadio.TabIndex = 11;
            this.normalRadio.TabStop = true;
            this.normalRadio.Text = "Normal (14 Days)";
            this.normalRadio.UseVisualStyleBackColor = true;
            // 
            // threeDayRadio
            // 
            this.threeDayRadio.AutoSize = true;
            this.threeDayRadio.Location = new System.Drawing.Point(175, 192);
            this.threeDayRadio.Name = "threeDayRadio";
            this.threeDayRadio.Size = new System.Drawing.Size(58, 17);
            this.threeDayRadio.TabIndex = 12;
            this.threeDayRadio.TabStop = true;
            this.threeDayRadio.Text = "3 Days";
            this.threeDayRadio.UseVisualStyleBackColor = true;
            this.threeDayRadio.Visible = false;
            // 
            // fiveDayRadio
            // 
            this.fiveDayRadio.AutoSize = true;
            this.fiveDayRadio.Location = new System.Drawing.Point(175, 215);
            this.fiveDayRadio.Name = "fiveDayRadio";
            this.fiveDayRadio.Size = new System.Drawing.Size(58, 17);
            this.fiveDayRadio.TabIndex = 13;
            this.fiveDayRadio.TabStop = true;
            this.fiveDayRadio.Text = "5 Days";
            this.fiveDayRadio.UseVisualStyleBackColor = true;
            this.fiveDayRadio.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(347, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 34);
            this.button1.TabIndex = 15;
            this.button1.Text = "Show Rush Options";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sevenDayRadio
            // 
            this.sevenDayRadio.AutoSize = true;
            this.sevenDayRadio.Location = new System.Drawing.Point(175, 238);
            this.sevenDayRadio.Name = "sevenDayRadio";
            this.sevenDayRadio.Size = new System.Drawing.Size(58, 17);
            this.sevenDayRadio.TabIndex = 16;
            this.sevenDayRadio.TabStop = true;
            this.sevenDayRadio.Text = "7 Days";
            this.sevenDayRadio.UseVisualStyleBackColor = true;
            this.sevenDayRadio.Visible = false;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sevenDayRadio);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fiveDayRadio);
            this.Controls.Add(this.threeDayRadio);
            this.Controls.Add(this.normalRadio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateQuote);
            this.Controls.Add(this.drawerNumberBox);
            this.Controls.Add(this.DepthBox);
            this.Controls.Add(this.WidthBox);
            this.Controls.Add(this.MaterialCombo);
            this.Name = "AddQuote";
            this.Text = "Add Quote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox MaterialCombo;
        private System.Windows.Forms.TextBox WidthBox;
        private System.Windows.Forms.TextBox DepthBox;
        private System.Windows.Forms.TextBox drawerNumberBox;
        private System.Windows.Forms.Button CreateQuote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton normalRadio;
        private System.Windows.Forms.RadioButton threeDayRadio;
        private System.Windows.Forms.RadioButton fiveDayRadio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton sevenDayRadio;
    }
}