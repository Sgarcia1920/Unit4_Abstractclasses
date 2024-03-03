namespace Unit4_Abstractclasses
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
			pictureBox1 = new PictureBox();
			label1 = new Label();
			label2 = new Label();
			txtBase = new TextBox();
			txtheight = new TextBox();
			label3 = new Label();
			btn_calculatearea = new Button();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(58, 40);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(142, 119);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Sitka Display", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.Maroon;
			label1.Location = new Point(206, 65);
			label1.Name = "label1";
			label1.Size = new Size(169, 70);
			label1.TabIndex = 1;
			label1.Text = "Parallelogram \r\nArea calculator";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.ForeColor = Color.DarkSlateGray;
			label2.Location = new Point(188, 177);
			label2.Name = "label2";
			label2.Size = new Size(66, 26);
			label2.TabIndex = 2;
			label2.Text = "Base: ";
			// 
			// txtBase
			// 
			txtBase.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtBase.Location = new Point(172, 206);
			txtBase.Name = "txtBase";
			txtBase.Size = new Size(110, 27);
			txtBase.TabIndex = 3;
			txtBase.TextChanged += txtBase_TextChanged;
			// 
			// txtheight
			// 
			txtheight.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtheight.Location = new Point(172, 268);
			txtheight.Name = "txtheight";
			txtheight.Size = new Size(110, 27);
			txtheight.TabIndex = 5;
			txtheight.TextChanged += txtheight_TextChanged;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.ForeColor = Color.DarkSlateGray;
			label3.Location = new Point(188, 239);
			label3.Name = "label3";
			label3.Size = new Size(79, 26);
			label3.TabIndex = 4;
			label3.Text = "Height:";
			// 
			// btn_calculatearea
			// 
			btn_calculatearea.BackColor = Color.DarkRed;
			btn_calculatearea.Font = new Font("Sitka Display", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btn_calculatearea.ForeColor = Color.White;
			btn_calculatearea.Location = new Point(161, 326);
			btn_calculatearea.Name = "btn_calculatearea";
			btn_calculatearea.Size = new Size(136, 39);
			btn_calculatearea.TabIndex = 6;
			btn_calculatearea.Text = "Calculate";
			btn_calculatearea.UseVisualStyleBackColor = false;
			btn_calculatearea.Click += btn_calculatearea_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(468, 398);
			Controls.Add(btn_calculatearea);
			Controls.Add(txtheight);
			Controls.Add(label3);
			Controls.Add(txtBase);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(pictureBox1);
			Name = "Form1";
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pictureBox1;
		private Label label1;
		private Label label2;
		private TextBox txtBase;
		private TextBox txtheight;
		private Label label3;
		private Button btn_calculatearea;
	}
}
