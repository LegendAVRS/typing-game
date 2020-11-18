namespace Typer
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
            this.txtUser = new System.Windows.Forms.RichTextBox();
            this.txtText = new System.Windows.Forms.RichTextBox();
            this.lblWpm = new System.Windows.Forms.Label();
            this.grpMode = new System.Windows.Forms.GroupBox();
            this.rbtnPractice = new System.Windows.Forms.RadioButton();
            this.rbtnTest = new System.Windows.Forms.RadioButton();
            this.grpResults = new System.Windows.Forms.GroupBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.grpMode.SuspendLayout();
            this.grpResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(12, 250);
            this.txtUser.Name = "txtUser";
            this.txtUser.ShortcutsEnabled = false;
            this.txtUser.Size = new System.Drawing.Size(574, 44);
            this.txtUser.TabIndex = 1;
            this.txtUser.Text = "";
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            this.txtUser.Enter += new System.EventHandler(this.txtUser_Enter_1);
            this.txtUser.Leave += new System.EventHandler(this.txtUser_Leave_1);
            // 
            // txtText
            // 
            this.txtText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtText.Location = new System.Drawing.Point(12, 12);
            this.txtText.Name = "txtText";
            this.txtText.ShortcutsEnabled = false;
            this.txtText.Size = new System.Drawing.Size(574, 195);
            this.txtText.TabIndex = 2;
            this.txtText.Text = "";
            // 
            // lblWpm
            // 
            this.lblWpm.AutoSize = true;
            this.lblWpm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWpm.Location = new System.Drawing.Point(30, 31);
            this.lblWpm.Name = "lblWpm";
            this.lblWpm.Size = new System.Drawing.Size(27, 25);
            this.lblWpm.TabIndex = 3;
            this.lblWpm.Text = "...";
            this.lblWpm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpMode
            // 
            this.grpMode.Controls.Add(this.rbtnTest);
            this.grpMode.Controls.Add(this.rbtnPractice);
            this.grpMode.Location = new System.Drawing.Point(592, 12);
            this.grpMode.Name = "grpMode";
            this.grpMode.Size = new System.Drawing.Size(151, 100);
            this.grpMode.TabIndex = 4;
            this.grpMode.TabStop = false;
            this.grpMode.Text = "Mode";
            // 
            // rbtnPractice
            // 
            this.rbtnPractice.AutoSize = true;
            this.rbtnPractice.Checked = true;
            this.rbtnPractice.Location = new System.Drawing.Point(7, 22);
            this.rbtnPractice.Name = "rbtnPractice";
            this.rbtnPractice.Size = new System.Drawing.Size(80, 21);
            this.rbtnPractice.TabIndex = 0;
            this.rbtnPractice.TabStop = true;
            this.rbtnPractice.Text = "Practice";
            this.rbtnPractice.UseVisualStyleBackColor = true;
            this.rbtnPractice.Click += new System.EventHandler(this.rbtnPractice_Click);
            // 
            // rbtnTest
            // 
            this.rbtnTest.AutoSize = true;
            this.rbtnTest.Location = new System.Drawing.Point(7, 50);
            this.rbtnTest.Name = "rbtnTest";
            this.rbtnTest.Size = new System.Drawing.Size(57, 21);
            this.rbtnTest.TabIndex = 1;
            this.rbtnTest.TabStop = true;
            this.rbtnTest.Text = "Test";
            this.rbtnTest.UseVisualStyleBackColor = true;
            this.rbtnTest.Click += new System.EventHandler(this.rbtnTest_Click);
            // 
            // grpResults
            // 
            this.grpResults.Controls.Add(this.lblWpm);
            this.grpResults.Location = new System.Drawing.Point(599, 130);
            this.grpResults.Name = "grpResults";
            this.grpResults.Size = new System.Drawing.Size(144, 77);
            this.grpResults.TabIndex = 5;
            this.grpResults.TabStop = false;
            this.grpResults.Text = "Results";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(645, 259);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(16, 17);
            this.lblTimer.TabIndex = 6;
            this.lblTimer.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 356);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.grpResults);
            this.Controls.Add(this.grpMode);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.txtUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpMode.ResumeLayout(false);
            this.grpMode.PerformLayout();
            this.grpResults.ResumeLayout(false);
            this.grpResults.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox txtUser;
        private System.Windows.Forms.RichTextBox txtText;
        private System.Windows.Forms.Label lblWpm;
        private System.Windows.Forms.GroupBox grpMode;
        private System.Windows.Forms.RadioButton rbtnTest;
        private System.Windows.Forms.RadioButton rbtnPractice;
        private System.Windows.Forms.GroupBox grpResults;
        private System.Windows.Forms.Label lblTimer;
    }
}

