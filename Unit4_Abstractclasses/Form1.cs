namespace Unit4_Abstractclasses
{
	public partial class Form1 : Form
	{
		Parallelogram parallelogram_1 = new Parallelogram();
		public Form1()
		{
			InitializeComponent();
		}

		private void txtBase_TextChanged(object sender, EventArgs e)
		{

			if (double.TryParse(txtBase.Text, out double baseValue))
			{
				parallelogram_1.Base = baseValue;
			}
		}

		private void txtheight_TextChanged(object sender, EventArgs e)
		{
			if (double.TryParse(txtheight.Text, out double heightvalue))
			{
				parallelogram_1.Height = heightvalue;
			}
		}

		private void btn_calculatearea_Click(object sender, EventArgs e)
		{
			parallelogram_1.CalculateArea();
			MessageBox.Show(parallelogram_1.ToString());
		}
	}
}
