namespace ContohWinform2
{
    partial class Form2
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
            LabelNama1 = new Label();
            LabelNama2 = new Label();
            SuspendLayout();
            // 
            // LabelNama1
            // 
            LabelNama1.AutoSize = true;
            LabelNama1.Location = new Point(19, 29);
            LabelNama1.Name = "LabelNama1";
            LabelNama1.Size = new Size(65, 25);
            LabelNama1.TabIndex = 0;
            LabelNama1.Text = "NAMA";
            // 
            // LabelNama2
            // 
            LabelNama2.AutoSize = true;
            LabelNama2.Location = new Point(19, 76);
            LabelNama2.Name = "LabelNama2";
            LabelNama2.Size = new Size(65, 25);
            LabelNama2.TabIndex = 1;
            LabelNama2.Text = "NAMA";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LabelNama2);
            Controls.Add(LabelNama1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelNama1;
        private Label LabelNama2;
    }
}