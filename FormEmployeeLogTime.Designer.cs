
namespace ProjectBD
{
    partial class FormEmployeeLogTime
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
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.buttonLogAndTime = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(370, 24);
            this.textBoxLog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.Size = new System.Drawing.Size(509, 327);
            this.textBoxLog.TabIndex = 0;
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(370, 375);
            this.textBoxTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(76, 20);
            this.textBoxTime.TabIndex = 1;
            // 
            // buttonLogAndTime
            // 
            this.buttonLogAndTime.Location = new System.Drawing.Point(464, 366);
            this.buttonLogAndTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLogAndTime.Name = "buttonLogAndTime";
            this.buttonLogAndTime.Size = new System.Drawing.Size(76, 37);
            this.buttonLogAndTime.TabIndex = 2;
            this.buttonLogAndTime.Text = "Log";
            this.buttonLogAndTime.UseVisualStyleBackColor = true;
            this.buttonLogAndTime.Click += new System.EventHandler(this.buttonLogAndTime_Click);
            // 
            // FormEmployeeLogTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 449);
            this.Controls.Add(this.buttonLogAndTime);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.textBoxLog);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormEmployeeLogTime";
            this.Text = "LogTime";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Button buttonLogAndTime;
    }
}