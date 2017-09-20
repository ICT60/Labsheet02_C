namespace Labsheet02_C
{
    partial class frmMain
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
            this.btnShowResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowResult
            // 
            this.btnShowResult.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShowResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowResult.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnShowResult.Location = new System.Drawing.Point(12, 12);
            this.btnShowResult.Name = "btnShowResult";
            this.btnShowResult.Size = new System.Drawing.Size(274, 84);
            this.btnShowResult.TabIndex = 0;
            this.btnShowResult.Text = "Result";
            this.btnShowResult.UseVisualStyleBackColor = false;
            this.btnShowResult.Click += new System.EventHandler(this.btnShowResult_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 108);
            this.Controls.Add(this.btnShowResult);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Labsheet02_C : 6002526";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowResult;
    }
}

