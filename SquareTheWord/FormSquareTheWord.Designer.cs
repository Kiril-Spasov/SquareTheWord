namespace SquareTheWord
{
    partial class FormSquareTheWord
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
            this.BtnSquareTheWord = new System.Windows.Forms.Button();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnSquareTheWord
            // 
            this.BtnSquareTheWord.Location = new System.Drawing.Point(55, 70);
            this.BtnSquareTheWord.Name = "BtnSquareTheWord";
            this.BtnSquareTheWord.Size = new System.Drawing.Size(208, 65);
            this.BtnSquareTheWord.TabIndex = 0;
            this.BtnSquareTheWord.Text = "Square The Word";
            this.BtnSquareTheWord.UseVisualStyleBackColor = true;
            this.BtnSquareTheWord.Click += new System.EventHandler(this.BtnSquareTheWord_Click);
            // 
            // TxtResult
            // 
            this.TxtResult.Location = new System.Drawing.Point(325, 70);
            this.TxtResult.Multiline = true;
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.Size = new System.Drawing.Size(397, 320);
            this.TxtResult.TabIndex = 1;
            // 
            // FormSquareTheWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtResult);
            this.Controls.Add(this.BtnSquareTheWord);
            this.Name = "FormSquareTheWord";
            this.Text = "Square The Word";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSquareTheWord;
        private System.Windows.Forms.TextBox TxtResult;
    }
}

