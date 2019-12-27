namespace atm
{
    partial class banking
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
            this.saving = new System.Windows.Forms.Button();
            this.current = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "type of account";
            // 
            // saving
            // 
            this.saving.Location = new System.Drawing.Point(42, 113);
            this.saving.Name = "saving";
            this.saving.Size = new System.Drawing.Size(75, 23);
            this.saving.TabIndex = 1;
            this.saving.Text = "saving";
            this.saving.UseVisualStyleBackColor = true;
            // 
            // current
            // 
            this.current.Location = new System.Drawing.Point(399, 113);
            this.current.Name = "current";
            this.current.Size = new System.Drawing.Size(75, 23);
            this.current.TabIndex = 2;
            this.current.Text = "current";
            this.current.UseVisualStyleBackColor = true;
            this.current.Click += new System.EventHandler(this.button1_Click);
            // 
            // banking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 306);
            this.Controls.Add(this.current);
            this.Controls.Add(this.saving);
            this.Controls.Add(this.label1);
            this.Name = "banking";
            this.Text = "banking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saving;
        private System.Windows.Forms.Button current;
    }
}