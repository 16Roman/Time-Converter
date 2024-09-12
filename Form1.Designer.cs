namespace Roman_s_Time_Converter
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MilitaryButton = new System.Windows.Forms.RadioButton();
            this.RegularButton = new System.Windows.Forms.RadioButton();
            this.MilitaryEntry = new System.Windows.Forms.TextBox();
            this.RegularEntry = new System.Windows.Forms.TextBox();
            this.AMcheck = new System.Windows.Forms.CheckBox();
            this.PMcheck = new System.Windows.Forms.CheckBox();
            this.Convert = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.FinalTime = new System.Windows.Forms.Label();
            this.Box1 = new System.Windows.Forms.Label();
            this.Box2 = new System.Windows.Forms.Label();
            this.MilitaryEntry2 = new System.Windows.Forms.TextBox();
            this.RegularEntry2 = new System.Windows.Forms.TextBox();
            this.AmPmLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(836, 79);
            this.label1.TabIndex = 0;
            this.label1.Text = "Roman\'s Time Converter!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(728, 51);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Time that you want converted ";
            // 
            // MilitaryButton
            // 
            this.MilitaryButton.AutoSize = true;
            this.MilitaryButton.Location = new System.Drawing.Point(81, 267);
            this.MilitaryButton.Name = "MilitaryButton";
            this.MilitaryButton.Size = new System.Drawing.Size(234, 29);
            this.MilitaryButton.TabIndex = 2;
            this.MilitaryButton.Text = "Military Time (24 hr)";
            this.MilitaryButton.UseVisualStyleBackColor = true;
            this.MilitaryButton.CheckedChanged += new System.EventHandler(this.MilitaryButton_CheckedChanged);
            // 
            // RegularButton
            // 
            this.RegularButton.AutoSize = true;
            this.RegularButton.Location = new System.Drawing.Point(81, 366);
            this.RegularButton.Name = "RegularButton";
            this.RegularButton.Size = new System.Drawing.Size(240, 29);
            this.RegularButton.TabIndex = 3;
            this.RegularButton.Text = "Regular Time (12 hr)";
            this.RegularButton.UseVisualStyleBackColor = true;
            this.RegularButton.CheckedChanged += new System.EventHandler(this.RegularButton_CheckedChanged);
            // 
            // MilitaryEntry
            // 
            this.MilitaryEntry.Location = new System.Drawing.Point(417, 267);
            this.MilitaryEntry.Name = "MilitaryEntry";
            this.MilitaryEntry.Size = new System.Drawing.Size(30, 31);
            this.MilitaryEntry.TabIndex = 4;
            this.MilitaryEntry.Visible = false;
            // 
            // RegularEntry
            // 
            this.RegularEntry.Location = new System.Drawing.Point(417, 375);
            this.RegularEntry.Name = "RegularEntry";
            this.RegularEntry.Size = new System.Drawing.Size(30, 31);
            this.RegularEntry.TabIndex = 5;
            this.RegularEntry.Visible = false;
            // 
            // AMcheck
            // 
            this.AMcheck.AutoSize = true;
            this.AMcheck.Location = new System.Drawing.Point(569, 377);
            this.AMcheck.Name = "AMcheck";
            this.AMcheck.Size = new System.Drawing.Size(76, 29);
            this.AMcheck.TabIndex = 6;
            this.AMcheck.Text = "AM";
            this.AMcheck.UseVisualStyleBackColor = true;
            this.AMcheck.Visible = false;
            // 
            // PMcheck
            // 
            this.PMcheck.AutoSize = true;
            this.PMcheck.Location = new System.Drawing.Point(569, 429);
            this.PMcheck.Name = "PMcheck";
            this.PMcheck.Size = new System.Drawing.Size(76, 29);
            this.PMcheck.TabIndex = 7;
            this.PMcheck.Text = "PM";
            this.PMcheck.UseVisualStyleBackColor = true;
            this.PMcheck.Visible = false;
            // 
            // Convert
            // 
            this.Convert.Location = new System.Drawing.Point(779, 297);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(314, 58);
            this.Convert.TabIndex = 8;
            this.Convert.Text = "Convert";
            this.Convert.UseVisualStyleBackColor = true;
            this.Convert.Click += new System.EventHandler(this.Convert_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(522, 821);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(314, 54);
            this.Clear.TabIndex = 9;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 674);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(328, 51);
            this.label3.TabIndex = 10;
            this.label3.Text = "Converted Time";
            // 
            // FinalTime
            // 
            this.FinalTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FinalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalTime.Location = new System.Drawing.Point(446, 665);
            this.FinalTime.Name = "FinalTime";
            this.FinalTime.Size = new System.Drawing.Size(459, 69);
            this.FinalTime.TabIndex = 11;
            this.FinalTime.Text = "label4";
            this.FinalTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Box1
            // 
            this.Box1.AutoSize = true;
            this.Box1.Location = new System.Drawing.Point(453, 270);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(18, 25);
            this.Box1.TabIndex = 12;
            this.Box1.Text = ":";
            this.Box1.Visible = false;
            // 
            // Box2
            // 
            this.Box2.AutoSize = true;
            this.Box2.Location = new System.Drawing.Point(453, 377);
            this.Box2.Name = "Box2";
            this.Box2.Size = new System.Drawing.Size(18, 25);
            this.Box2.TabIndex = 13;
            this.Box2.Text = ":";
            this.Box2.Visible = false;
            // 
            // MilitaryEntry2
            // 
            this.MilitaryEntry2.Location = new System.Drawing.Point(478, 267);
            this.MilitaryEntry2.Name = "MilitaryEntry2";
            this.MilitaryEntry2.Size = new System.Drawing.Size(55, 31);
            this.MilitaryEntry2.TabIndex = 14;
            this.MilitaryEntry2.Visible = false;
            // 
            // RegularEntry2
            // 
            this.RegularEntry2.Location = new System.Drawing.Point(478, 375);
            this.RegularEntry2.Name = "RegularEntry2";
            this.RegularEntry2.Size = new System.Drawing.Size(55, 31);
            this.RegularEntry2.TabIndex = 15;
            this.RegularEntry2.Visible = false;
            // 
            // AmPmLabel
            // 
            this.AmPmLabel.Enabled = false;
            this.AmPmLabel.Location = new System.Drawing.Point(955, 665);
            this.AmPmLabel.Name = "AmPmLabel";
            this.AmPmLabel.Size = new System.Drawing.Size(147, 69);
            this.AmPmLabel.TabIndex = 16;
            this.AmPmLabel.Text = "label4";
            this.AmPmLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1544, 996);
            this.Controls.Add(this.AmPmLabel);
            this.Controls.Add(this.RegularEntry2);
            this.Controls.Add(this.MilitaryEntry2);
            this.Controls.Add(this.Box2);
            this.Controls.Add(this.Box1);
            this.Controls.Add(this.FinalTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Convert);
            this.Controls.Add(this.PMcheck);
            this.Controls.Add(this.AMcheck);
            this.Controls.Add(this.RegularEntry);
            this.Controls.Add(this.MilitaryEntry);
            this.Controls.Add(this.RegularButton);
            this.Controls.Add(this.MilitaryButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton MilitaryButton;
        private System.Windows.Forms.RadioButton RegularButton;
        private System.Windows.Forms.TextBox MilitaryEntry;
        private System.Windows.Forms.TextBox RegularEntry;
        private System.Windows.Forms.CheckBox AMcheck;
        private System.Windows.Forms.CheckBox PMcheck;
        private System.Windows.Forms.Button Convert;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label FinalTime;
        private System.Windows.Forms.Label Box1;
        private System.Windows.Forms.Label Box2;
        private System.Windows.Forms.TextBox MilitaryEntry2;
        private System.Windows.Forms.TextBox RegularEntry2;
        private System.Windows.Forms.Label AmPmLabel;
    }
}

