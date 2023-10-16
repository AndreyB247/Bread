using static System.Windows.Forms.LinkLabel;

namespace Lab_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            double a; double b; double c; double d = 0;
            // X1
            a = Convert.ToDouble(numericUpDown1.Text);
            // X2
            b = Convert.ToDouble(numericUpDown2.Text);
            // Шаг
            c = Convert.ToDouble(comboBox1.Text);
            richTextBox1.AppendText("X       F(x)\r\n----------" + "\n");
            for (double i = a; i <= b; i += c)
            {
                if (listBox1.Text == "Cos")
                {
                    d = Math.Cos(i);
                    // Toчность вычислений
                    if (radioButton1.Checked == true) d = Math.Round(d, 2);
                    if (radioButton2.Checked == true) d = Math.Round(d, 3);
                    if (radioButton3.Checked == true) d = Math.Round(d, 4);
                }
                if (listBox1.Text == "Log10")
                {
                    d = Math.Log10(i);
                    if (radioButton1.Checked == true) d = Math.Round(d, 2);
                    if (radioButton2.Checked == true) d = Math.Round(d, 3);
                    if (radioButton3.Checked == true) d = Math.Round(d, 4);
                }
                if (listBox1.Text == "Tan")
                {
                    d = Math.Tan(i);
                    if (radioButton1.Checked == true) d = Math.Round(d, 2);
                    if (radioButton2.Checked == true) d = Math.Round(d, 3);
                    if (radioButton3.Checked == true) d = Math.Round(d, 4);
                }
                //else if (radioButton1.Checked == false || listBox1.Text == "   ") MessageBox.Show("Введите значения");
                richTextBox1.AppendText(Convert.ToString(i) + "       " + Convert.ToString(d) + "\n");

            }
            if (listBox1.Text == "Tan")
            {

                double X1; double X2;
                X1 = Convert.ToDouble(numericUpDown1.Text);
                X2 = Convert.ToDouble(numericUpDown2.Text);
                double shag = 0.02;
                int h = 0;
                Graphics g = pictureBox1.CreateGraphics();
                PointF[] ptf = new PointF[(int)(Math.Abs(X2 - X1) / shag)];
                g.TranslateTransform(pictureBox1.ClientRectangle.Width / 2, pictureBox1.ClientRectangle.Height / 2);
                g.ScaleTransform(-1, 1);
                g.Clear(Color.White);
                for (double i = X1; i <= X2; i += shag)
                {
                    if (h < ptf.Length)
                    {
                        double at = (Math.Tan(i));
                        ptf[h].X = (float)(i) * 100;
                        ptf[h].Y = (float)(at) * 100;
                        h += 1;
                    }
                }
                g.DrawLine(Pens.Blue, -pictureBox1.ClientRectangle.Width / 2, 0, pictureBox1.ClientRectangle.Width / 2, 0);
                g.DrawLine(Pens.Blue, 0, -pictureBox1.ClientRectangle.Height / 2, 0, pictureBox1.ClientRectangle.Height / 2);
                g.DrawLines(Pens.Red, ptf);
                //g.Dispose();

            }
            else if (listBox1.Text == "Cos")
            {
                Graphics g = pictureBox1.CreateGraphics();
                int cx = pictureBox1.Width;
                int cy = pictureBox1.Height / 2;
                PointF[] ptf = new PointF[cx];
                double cw = 0;
                try
                {
                    cw = (b - a);
                }
                catch
                {

                }
                // Очистим PictureBox
                if (cw > 0)
                {
                    g.Clear(pictureBox1.BackColor);
                    for (int i = 0; i < cx; i++)
                    {
                        ptf[i].X = i;
                        ptf[i].Y = (float)((cy / 2) * (1 - Math.Cos(i * cw * Math.PI / (cx - 1))));
                    }
                    g.DrawLines(Pens.Red, ptf);
                    g.Dispose();
                }
            }
            else if (listBox1.Text == "Log10")
            {
                Graphics g = pictureBox1.CreateGraphics();
                g.TranslateTransform(pictureBox1.ClientRectangle.Width / 2, pictureBox1.ClientRectangle.Height / 2);
                g.Clear(Color.White);
                double cw = 0;
                try
                {
                    cw = 1000;
                }
                catch
                {

                }
                PointF[] ptf = new PointF[(int)(Math.Abs(100)) + 1];
                int h = 0;

                for (double i = 1; i <= 100; i += 1)
                {

                    d = Math.Log10(i);
                    ptf[h] = new PointF((float)(i), -(float)(d));
                    h++;
                }

                g.DrawLines(Pens.Red, ptf);
                g.Dispose();
            }
            else MessageBox.Show("Неверное значение!");
        }

    }
}