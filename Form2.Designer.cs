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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			label1 = new Label();
			LabelUsername = new Label();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.Location = new Point(12, 9);
			label1.Name = "label1";
			label1.Size = new Size(437, 44);
			label1.TabIndex = 0;
			label1.Text = "Selamat Datang Atmin";
			// 
			// LabelUsername
			// 
			LabelUsername.AutoSize = true;
			LabelUsername.Font = new Font("Showcard Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
			LabelUsername.Location = new Point(3, 86);
			LabelUsername.Name = "LabelUsername";
			LabelUsername.Size = new Size(131, 40);
			LabelUsername.TabIndex = 1;
			LabelUsername.Text = "kewer";
			// 
			// Form2
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(LabelUsername);
			Controls.Add(label1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "Form2";
			Text = "Dashboard";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label LabelUsername;
	}
}