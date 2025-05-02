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
			button1 = new Button();
			checkBox1 = new CheckBox();
			SuspendLayout();
			// 
			// textBox1
			// 
			textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
			textBox1.Location = new Point(236, 179);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(305, 55);
			textBox1.TabIndex = 0;
			textBox1.TextChanged += textBox1_TextChanged;
			// 
			// LabelAtas
			// 
			LabelAtas.AutoSize = true;
			LabelAtas.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
			LabelAtas.Location = new Point(336, 112);
			LabelAtas.Name = "LabelAtas";
			LabelAtas.Size = new Size(103, 44);
			LabelAtas.TabIndex = 2;
			LabelAtas.Text = "Nama";
			// 
			// button1
			// 
			button1.Location = new Point(327, 282);
			button1.Name = "button1";
			button1.Size = new Size(112, 34);
			button1.TabIndex = 3;
			button1.Text = "Login";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// checkBox1
			// 
			checkBox1.AutoSize = true;
			checkBox1.Location = new Point(547, 191);
			checkBox1.Name = "checkBox1";
			checkBox1.Size = new Size(131, 29);
			checkBox1.TabIndex = 5;
			checkBox1.Text = "Nak Tengok";
			checkBox1.UseVisualStyleBackColor = true;
			checkBox1.CheckedChanged += checkBox1_CheckedChanged;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(checkBox1);
			Controls.Add(button1);
			Controls.Add(LabelAtas);
			Controls.Add(textBox1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "Form1";
			Text = "Login";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox1;
		private Label InputUsername;
		private Button button1;
		public Label LabelAtas;
		private CheckBox checkBox1;
	}
}
