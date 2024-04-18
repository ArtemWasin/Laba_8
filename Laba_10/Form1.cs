using System.Runtime.CompilerServices;

namespace Laba_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double volume, height, radius, area;
                areaErorLable.Visible = false;
                valumeErorLable.Visible = false;

                if (!double.TryParse(volumeTextBox.Text, out volume) | !(volume > 0))
                {
                    valumeErorLable.Visible = true;
                    valumeErorLable.Text = "����������, ������� �������� �������� ������ '0' ��� ������.";
                    heightLabel.Text = "������ ����� ������!!!";
                    MessageBox.Show("����������, ������� �������� �������� ������ '0' ��� ������.", "������");
                    return;
                }

                if (!double.TryParse(areaTextBox.Text, out area) | !(area > 0))
                {
                    areaErorLable.Visible = true;
                    areaErorLable.Text = "����������, ������� �������� �������� ������ '0' ��� �������.";
                    heightLabel.Text = "������ ����� ������!!!";
                    MessageBox.Show("����������, ������� �������� �������� ������ '0' ��� ������� ���������.", "������");
                    return;
                }

                radius = Math.Sqrt(area / Math.PI);
                height = volume / (Math.PI * Math.Pow(radius, 2));

                heightLabel.Text = "������ ��������: " + height.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("��������� ������: " + ex.Message, "������");
            }
        }
    }
}
