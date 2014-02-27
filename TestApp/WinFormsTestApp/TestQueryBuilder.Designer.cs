namespace WinFormsTestApp
{
    partial class TestQueryBuilder
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
            this.tbId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbOwnerId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkWithPersons = new System.Windows.Forms.CheckBox();
            this.tbPriceFrom = new System.Windows.Forms.TextBox();
            this.tbPriceTo = new System.Windows.Forms.TextBox();
            this.tbPersonFullName = new System.Windows.Forms.TextBox();
            this.comboQueryType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSkip = new System.Windows.Forms.TextBox();
            this.tbTake = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rtbResult = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(104, 12);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(134, 20);
            this.tbId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "OwnerId";
            // 
            // tbOwnerId
            // 
            this.tbOwnerId.Location = new System.Drawing.Point(104, 38);
            this.tbOwnerId.Name = "tbOwnerId";
            this.tbOwnerId.Size = new System.Drawing.Size(134, 20);
            this.tbOwnerId.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "PriceFrom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "PriceTo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "PersonFullName";
            // 
            // chkWithPersons
            // 
            this.chkWithPersons.AutoSize = true;
            this.chkWithPersons.Location = new System.Drawing.Point(104, 142);
            this.chkWithPersons.Name = "chkWithPersons";
            this.chkWithPersons.Size = new System.Drawing.Size(86, 17);
            this.chkWithPersons.TabIndex = 7;
            this.chkWithPersons.Text = "WithPersons";
            this.chkWithPersons.UseVisualStyleBackColor = true;
            // 
            // tbPriceFrom
            // 
            this.tbPriceFrom.Location = new System.Drawing.Point(104, 64);
            this.tbPriceFrom.Name = "tbPriceFrom";
            this.tbPriceFrom.Size = new System.Drawing.Size(134, 20);
            this.tbPriceFrom.TabIndex = 8;
            // 
            // tbPriceTo
            // 
            this.tbPriceTo.Location = new System.Drawing.Point(104, 90);
            this.tbPriceTo.Name = "tbPriceTo";
            this.tbPriceTo.Size = new System.Drawing.Size(134, 20);
            this.tbPriceTo.TabIndex = 9;
            // 
            // tbPersonFullName
            // 
            this.tbPersonFullName.Location = new System.Drawing.Point(104, 116);
            this.tbPersonFullName.Name = "tbPersonFullName";
            this.tbPersonFullName.Size = new System.Drawing.Size(134, 20);
            this.tbPersonFullName.TabIndex = 10;
            // 
            // comboQueryType
            // 
            this.comboQueryType.FormattingEnabled = true;
            this.comboQueryType.Location = new System.Drawing.Point(321, 11);
            this.comboQueryType.Name = "comboQueryType";
            this.comboQueryType.Size = new System.Drawing.Size(134, 21);
            this.comboQueryType.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(287, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Skip";
            // 
            // tbSkip
            // 
            this.tbSkip.Location = new System.Drawing.Point(321, 38);
            this.tbSkip.Name = "tbSkip";
            this.tbSkip.Size = new System.Drawing.Size(134, 20);
            this.tbSkip.TabIndex = 13;
            // 
            // tbTake
            // 
            this.tbTake.Location = new System.Drawing.Point(321, 64);
            this.tbTake.Name = "tbTake";
            this.tbTake.Size = new System.Drawing.Size(134, 20);
            this.tbTake.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(283, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Take";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(256, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "QueryType";
            // 
            // rtbResult
            // 
            this.rtbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbResult.Location = new System.Drawing.Point(17, 165);
            this.rtbResult.Name = "rtbResult";
            this.rtbResult.Size = new System.Drawing.Size(445, 96);
            this.rtbResult.TabIndex = 17;
            this.rtbResult.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(321, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "BuildQuery";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TestQueryBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 278);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtbResult);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbTake);
            this.Controls.Add(this.tbSkip);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboQueryType);
            this.Controls.Add(this.tbPersonFullName);
            this.Controls.Add(this.tbPriceTo);
            this.Controls.Add(this.tbPriceFrom);
            this.Controls.Add(this.chkWithPersons);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbOwnerId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label1);
            this.Name = "TestQueryBuilder";
            this.Text = "TestQueryBuilder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbOwnerId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkWithPersons;
        private System.Windows.Forms.TextBox tbPriceFrom;
        private System.Windows.Forms.TextBox tbPriceTo;
        private System.Windows.Forms.TextBox tbPersonFullName;
        private System.Windows.Forms.ComboBox comboQueryType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSkip;
        private System.Windows.Forms.TextBox tbTake;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rtbResult;
        private System.Windows.Forms.Button button1;

    }
}

