namespace GeekSeatExam
{
    partial class FrmExamination
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
            this.LblYear = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmdCompare = new System.Windows.Forms.Button();
            this.txtCompPerson = new System.Windows.Forms.TextBox();
            this.BtnCheckKilled = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKilledByYear = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lblWKRC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWYC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblYear
            // 
            this.LblYear.AutoSize = true;
            this.LblYear.Location = new System.Drawing.Point(82, 53);
            this.LblYear.Name = "LblYear";
            this.LblYear.Size = new System.Drawing.Size(53, 25);
            this.LblYear.TabIndex = 21;
            this.LblYear.Text = "Year :";
            this.LblYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(387, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(317, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "How Many Person That to be compare";
            // 
            // cmdCompare
            // 
            this.cmdCompare.Location = new System.Drawing.Point(778, 19);
            this.cmdCompare.Name = "cmdCompare";
            this.cmdCompare.Size = new System.Drawing.Size(112, 34);
            this.cmdCompare.TabIndex = 19;
            this.cmdCompare.Text = "Compare";
            this.cmdCompare.UseVisualStyleBackColor = true;
            this.cmdCompare.Click += new System.EventHandler(this.cmdCompare_Click);
            // 
            // txtCompPerson
            // 
            this.txtCompPerson.Location = new System.Drawing.Point(710, 21);
            this.txtCompPerson.Name = "txtCompPerson";
            this.txtCompPerson.Size = new System.Drawing.Size(62, 31);
            this.txtCompPerson.TabIndex = 18;
            // 
            // BtnCheckKilled
            // 
            this.BtnCheckKilled.Location = new System.Drawing.Point(205, 49);
            this.BtnCheckKilled.Name = "BtnCheckKilled";
            this.BtnCheckKilled.Size = new System.Drawing.Size(112, 34);
            this.BtnCheckKilled.TabIndex = 17;
            this.BtnCheckKilled.Text = "Check";
            this.BtnCheckKilled.UseVisualStyleBackColor = true;
            this.BtnCheckKilled.Click += new System.EventHandler(this.BtnCheckKilled_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Citizen Dies :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtKilledByYear
            // 
            this.txtKilledByYear.Enabled = false;
            this.txtKilledByYear.Location = new System.Drawing.Point(141, 96);
            this.txtKilledByYear.Name = "txtKilledByYear";
            this.txtKilledByYear.Size = new System.Drawing.Size(57, 31);
            this.txtKilledByYear.TabIndex = 15;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(141, 50);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(57, 31);
            this.txtYear.TabIndex = 14;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(-4, 371);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(1225, 79);
            this.txtMessage.TabIndex = 22;
            // 
            // lblWKRC
            // 
            this.lblWKRC.AutoSize = true;
            this.lblWKRC.Location = new System.Drawing.Point(23, 9);
            this.lblWKRC.Name = "lblWKRC";
            this.lblWKRC.Size = new System.Drawing.Size(219, 25);
            this.lblWKRC.TabIndex = 23;
            this.lblWKRC.Text = "Wizard Killing Rule Check :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Wizard Year Control";
            // 
            // txtWYC
            // 
            this.txtWYC.Location = new System.Drawing.Point(197, 150);
            this.txtWYC.Name = "txtWYC";
            this.txtWYC.Size = new System.Drawing.Size(45, 31);
            this.txtWYC.TabIndex = 25;
            this.txtWYC.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-4, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Result:";
            // 
            // FrmExamination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtWYC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWKRC);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.LblYear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmdCompare);
            this.Controls.Add(this.txtCompPerson);
            this.Controls.Add(this.BtnCheckKilled);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKilledByYear);
            this.Controls.Add(this.txtYear);
            this.Name = "FrmExamination";
            this.Text = "FrmExamination";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblYear;
        private Label label6;
        private Button cmdCompare;
        private TextBox txtCompPerson;
        private Button BtnCheckKilled;
        private Label label3;
        private TextBox txtKilledByYear;
        private TextBox txtYear;
        private TextBox txtMessage;
        private Label lblWKRC;
        private Label label1;
        private TextBox txtWYC;
        private Label label2;
    }
}