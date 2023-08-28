namespace kalkulator_matriksMATH
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

        private void button2_Click(object sender, EventArgs e)
        {
            matriksA1.Text = "";
            matriksA2.Text = "";
            matriksA3.Text = "";
            matriksA4.Text = "";
            matriksA5.Text = "";
            matriksA6.Text = "";
            matriksA7.Text = "";
            matriksA8.Text = "";
            matriksA9.Text = "";

            matriksB1.Text = "";
            matriksB2.Text = "";
            matriksB3.Text = "";
            matriksB4.Text = "";
            matriksB5.Text = "";
            matriksB6.Text = "";
            matriksB7.Text = "";
            matriksB8.Text = "";
            matriksB9.Text = "";

            res1.Text = "";
            res2.Text = "";
            res3.Text = "";
            res4.Text = "";
            res5.Text = "";
            res6.Text = "";
            res7.Text = "";
            res8.Text = "";
            res9.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            int a, j;
            a = int.Parse(matriksA1.Text);
            j = int.Parse(matriksB1.Text);
            int result1 = a + j;
            res1.Text = result1.ToString();

            int b, k;
            b = int.Parse(matriksA2.Text);
            k = int.Parse(matriksB2.Text);
            int result2 = b + k;
            res2.Text = result2.ToString();

            int c, l;
            c = int.Parse(matriksA3.Text);
            l = int.Parse(matriksB3.Text);
            int result3 = c + l;
            res3.Text = result3.ToString();

            int d, m;
            d = int.Parse(matriksA4.Text);
            m = int.Parse(matriksB4.Text);
            int result4 = d + m;
            res4.Text = result4.ToString();

            int E, n;
            E = int.Parse(matriksA5.Text);
            n = int.Parse(matriksB5.Text);
            int result5 = E + n;
            res5.Text = result5.ToString();

            int f, o;
            f = int.Parse(matriksA6.Text);
            o = int.Parse(matriksB6.Text);
            int result6 = f + o;
            res6.Text = result6.ToString();

            int g, p;
            g = int.Parse(matriksA7.Text);
            p = int.Parse(matriksB7.Text);
            int result7 = g + p;
            res7.Text = result7.ToString();

            int h, q;
            h = int.Parse(matriksA8.Text);
            q = int.Parse(matriksB8.Text);
            int result8 = h + q;
            res8.Text = result8.ToString();

            int i, r;
            i = int.Parse(matriksA9.Text);
            r = int.Parse(matriksB9.Text);
            int result9 = i + r;
            res9.Text = result9.ToString();

        }

        private void matriksA1_TextChanged(object sender, EventArgs e)
        {

        }

        private void matriksA1_TextChanged_1(object sender, EventArgs e)
        {

            // Hanya izinkan karakter angka (0-9), tombol backspace, dan tombol delete
            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = true; // Mencegah karakter tidak valid dimasukkan
            //}
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {

        }

        private void btnMinus_Click_1(object sender, EventArgs e)
        {

            int a, j;
            a = int.Parse(matriksA1.Text);
            j = int.Parse(matriksB1.Text);
            int resultM1 = a - j;
            res1.Text += resultM1.ToString();

            int b, k;
            b = int.Parse(matriksA2.Text);
            k = int.Parse(matriksB2.Text);
            int resultM2 = b - k;
            res2.Text += resultM2.ToString();

            int c, l;
            c = int.Parse(matriksA3.Text);
            l = int.Parse(matriksB3.Text);
            int resultM3 = c - l;
            res3.Text += resultM3.ToString();

            int d, m;
            d = int.Parse(matriksA4.Text);
            m = int.Parse(matriksB4.Text);
            int resultM4 = d - m;
            res4.Text += resultM4.ToString();

            int E, n;
            E = int.Parse(matriksA5.Text);
            n = int.Parse(matriksB5.Text);
            int resultM5 = E - n;
            res5.Text += resultM5.ToString();

            int f, o;
            f = int.Parse(matriksA6.Text);
            o = int.Parse(matriksB6.Text);
            int resultM6 = f - o;
            res6.Text += resultM6.ToString();

            int g, p;
            g = int.Parse(matriksA7.Text);
            p = int.Parse(matriksB7.Text);
            int resultM7 = g - p;
            res7.Text += resultM7.ToString();

            int h, q;
            h = int.Parse(matriksA8.Text);
            q = int.Parse(matriksB8.Text);
            int resultM8 = h - q;
            res8.Text += resultM8.ToString();

            int i, r;
            i = int.Parse(matriksA9.Text);
            r = int.Parse(matriksB9.Text);
            int resultM9 = i - r;
            res9.Text += resultM9.ToString();

        }

        private void times_Click(object sender, EventArgs e)
        {
            int a, j;
            a = int.Parse(matriksA1.Text);
            j = int.Parse(matriksB1.Text);
            int resultT1 = a * j;
            res1.Text += resultT1.ToString();

            int b, k;
            b = int.Parse(matriksA2.Text);
            k = int.Parse(matriksB2.Text);
            int resultT2 = b * k;
            res2.Text += resultT2.ToString();

            int c, l;
            c = int.Parse(matriksA3.Text);
            l = int.Parse(matriksB3.Text);
            int resultT3 = c * l;
            res3.Text += resultT3.ToString();

            int d, m;
            d = int.Parse(matriksA4.Text);
            m = int.Parse(matriksB4.Text);
            int resultT4 = d * m;
            res4.Text += resultT4.ToString();

            int E, n;
            E = int.Parse(matriksA5.Text);
            n = int.Parse(matriksB5.Text);
            int resultT5 = E * n;
            res5.Text += resultT5.ToString();

            int f, o;
            f = int.Parse(matriksA6.Text);
            o = int.Parse(matriksB6.Text);
            int resultT6 = f * o;
            res6.Text += resultT6.ToString();

            int g, p;
            g = int.Parse(matriksA7.Text);
            p = int.Parse(matriksB7.Text);
            int resultT7 = g * p;
            res7.Text += resultT7.ToString();

            int h, q;
            h = int.Parse(matriksA8.Text);
            q = int.Parse(matriksB8.Text);
            int resultT8 = h * q;
            res8.Text += resultT8.ToString();

            int i, r;
            i = int.Parse(matriksA9.Text);
            r = int.Parse(matriksB9.Text);
            int resultT9 = i * r;
            res9.Text += resultT9.ToString();

        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            int a, j;
            a = int.Parse(matriksA1.Text);
            j = int.Parse(matriksB1.Text);
            int resultD1 = a / j;
            res1.Text += resultD1.ToString();

            int b, k;
            b = int.Parse(matriksA2.Text);
            k = int.Parse(matriksB2.Text);
            int resultD2 = b / k;
            res2.Text += resultD2.ToString();

            int c, l;
            c = int.Parse(matriksA3.Text);
            l = int.Parse(matriksB3.Text);
            int resultD3 = c / l;
            res3.Text += resultD3.ToString();

            int d, m;
            d = int.Parse(matriksA4.Text);
            m = int.Parse(matriksB4.Text);
            int resultD4 = d / m;
            res4.Text += resultD4.ToString();

            int E, n;
            E = int.Parse(matriksA5.Text);
            n = int.Parse(matriksB5.Text);
            int resultD5 = E / n;
            res5.Text += resultD5.ToString();

            int f, o;
            f = int.Parse(matriksA6.Text);
            o = int.Parse(matriksB6.Text);
            int resultD6 = f / o;
            res6.Text += resultD6.ToString();

            int g, p;
            g = int.Parse(matriksA7.Text);
            p = int.Parse(matriksB7.Text);
            int resultD7 = g / p;
            res7.Text += resultD7.ToString();

            int h, q;
            h = int.Parse(matriksA8.Text);
            q = int.Parse(matriksB8.Text);
            int resultD8 = h / q;
            res8.Text += resultD8.ToString();

            int i, r;
            i = int.Parse(matriksA9.Text);
            r = int.Parse(matriksB9.Text);
            int resultD9 = i / r;
            res9.Text += resultD9.ToString();
        }
    }
}