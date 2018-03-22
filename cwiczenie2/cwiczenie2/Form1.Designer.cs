namespace cwiczenie2
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
            this.miniTotalCommander1 = new cwiczenie2.miniTotalCommander();
            this.SuspendLayout();
            // 
            // miniTotalCommander1
            // 
            this.miniTotalCommander1.Location = new System.Drawing.Point(12, 12);
            this.miniTotalCommander1.Name = "miniTotalCommander1";
            this.miniTotalCommander1.Size = new System.Drawing.Size(223, 267);
            this.miniTotalCommander1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 287);
            this.Controls.Add(this.miniTotalCommander1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private miniTotalCommander miniTotalCommander1;
    }
}

