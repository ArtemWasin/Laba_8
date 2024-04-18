namespace Laba_10._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sr_aref_button_Click(object sender, EventArgs e)
        {
            try
            {
                double value1, value2;

                if (!double.TryParse(value1_textBox.Text, out value1))
                {
                    value1ErorLable.Visible = true;
                    value1ErorLable.Text = "Пожалуйста, введите число.";
                    sr_aref_label.Text = "Ошибка ввода данных!!!";
                    MessageBox.Show("Пожалуйста, введите число.", "Ошибка");
                    return;
                }

                if (!double.TryParse(value2_textBox.Text, out value2))
                {
                    value2ErorLable.Visible = true;
                    value2ErorLable.Text = "Пожалуйста, введите число.";
                    sr_aref_label.Text = "Ошибка ввода данных!!!";
                    MessageBox.Show("Пожалуйста, введите число.", "Ошибка");
                    return;
                }

                sr_aref_label.Text = "Среднее арифметическое всех чисел: " + ((value1 + value2) / 2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message, "Ошибка");
            }
        }

        private void sr_geom_button_Click(object sender, EventArgs e)
        {
            try
            {
                double value1, value2;

                if (!double.TryParse(value1_textBox.Text, out value1))
                {
                    value1ErorLable.Visible = true;
                    value1ErorLable.Text = "Пожалуйста, введите число.";
                    sr_geom_label.Text = "Ошибка ввода данных!!!";
                    MessageBox.Show("Пожалуйста, введите число.", "Ошибка");
                    return;
                }

                if (!double.TryParse(value2_textBox.Text, out value2))
                {
                    value2ErorLable.Visible = true;
                    value2ErorLable.Text = "Пожалуйста, введите число.";
                    sr_geom_label.Text = "Ошибка ввода данных!!!";
                    MessageBox.Show("Пожалуйста, введите число.", "Ошибка");
                    return;
                }

                sr_geom_label.Text = "Среднее арифметическое всех чисел: " + (Math.Sqrt(value1 * value2));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message, "Ошибка");
            }
        }
    }
}
