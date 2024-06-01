namespace Calculator
{
    partial class HistoryForm
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
            this.historyBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // historyBox
            // 
            this.historyBox.BackColor = System.Drawing.Color.Black;
            this.historyBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.historyBox.ForeColor = System.Drawing.Color.White;
            this.historyBox.Location = new System.Drawing.Point(0, 0);
            this.historyBox.Multiline = true;
            this.historyBox.Name = "historyBox";
            this.historyBox.ReadOnly = true;
            this.historyBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.historyBox.Size = new System.Drawing.Size(493, 520);
            this.historyBox.TabIndex = 0;
            this.historyBox.TabStop = false;
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 520);
            this.Controls.Add(this.historyBox);
            this.Name = "HistoryForm";
            this.Text = "HistoryForm";
            this.Load += new System.EventHandler(this.HistoryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox historyBox;
    }
}