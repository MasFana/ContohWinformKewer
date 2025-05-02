namespace ContohWinform2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            LabelAtas = new Label();
            Submit = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(230, 190);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(291, 31);
            textBox1.TabIndex = 0;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // LabelAtas
            // 
            LabelAtas.AutoSize = true;
            LabelAtas.Font = new Font("Stencil", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelAtas.Location = new Point(329, 129);
            LabelAtas.Name = "LabelAtas";
            LabelAtas.Size = new Size(103, 38);
            LabelAtas.TabIndex = 2;
            LabelAtas.Text = "NAMA";
            LabelAtas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Submit
            // 
            Submit.Location = new Point(323, 246);
            Submit.Name = "Submit";
            Submit.Size = new Size(112, 34);
            Submit.TabIndex = 3;
            Submit.TabStop = false;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            Submit.Click += Submit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Submit);
            Controls.Add(LabelAtas);
            Controls.Add(textBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label LabelAtas;
        private Button Submit;
    }
}
