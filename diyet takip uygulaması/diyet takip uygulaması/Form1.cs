namespace diyet_takip_uygulaması
{
    public partial class Form1 : Form
    {
        int _cal = 0;
        int _sum = 0;
        yemek tavuk = new yemek();
        yemek pirinç = new yemek();
        yemek ekmek = new yemek();
        yemek et = new yemek();
        class yemek
        {
            public string ad = "";
            public int kalori = 0;
            public int gram;
        }
        string _hedefkalori;
        public Form1()
        {
            InitializeComponent();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            hedefkalori.Text = textBox1.Text;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            int hedef = Convert.ToInt32(hedefkalori.Text);
            _cal = Convert.ToInt32(textBox3.Text);
            _sum += _cal;
            _hedefkalori = Convert.ToString(_sum);
            string sum = Convert.ToString(_sum);
            alinankalori.Text = _hedefkalori;

            textBox3.Clear();

            if (_sum > hedef)
            {
                MessageBox.Show($"Günlük kalori ihtiyacınızı aştınız hedefiniz {hedef} idi sizin aldığınız kalori miktarı ise {sum} dır", "Uyarı");
                label8.Visible = true;
            }
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string selected = comboBox.SelectedItem.ToString();
            if (selected == "Pirinç 1g 1cal")
            {
                int grm = Convert.ToInt32(gram.Text);

                _sum += grm * 1;
                string sum = Convert.ToString(_sum);
                alinankalori.Text = sum;
                int hedef = Convert.ToInt32(hedefkalori.Text);

                pirinç.ad = "Pirinç";
                pirinç.kalori += grm * 2;
                pirinç.gram += grm;

                string result = ($"{pirinç.ad} {pirinç.kalori}kalori {pirinç.gram}gram");
                listBox1.Items[2] = result;



                if (_sum > hedef)
                {
                    MessageBox.Show($"Günlük kalori ihtiyacınızı aştınız hedefiniz {hedef} idi sizin aldığınız kalori miktarı ise {sum} dır", "Uyarı");
                    label8.Visible = true;
                }
            }

            if (selected == "Et 1g 2cal")
            {
                int grm = Convert.ToInt32(gram.Text);

                _sum += grm * 2;
                string sum = Convert.ToString(_sum);
                alinankalori.Text = sum;

                et.ad = "Et";
                et.kalori += grm * 2;
                et.gram += grm;

                string result = ($"{et.ad} {et.kalori}kalori {et.gram}gram");

                listBox1.Items[1] = result;


                int hedef = Convert.ToInt32(hedefkalori.Text);
                if (_sum > hedef)
                {
                    MessageBox.Show($"Günlük kalori ihtiyacınızı aştınız hedefiniz {hedef} idi sizin aldığınız kalori miktarı ise {sum} dır", "Uyarı");
                    label8.Visible = true;
                }
            }

            if (selected == "Ekmek 1g 3cal")
            {
                int grm = Convert.ToInt32(gram.Text);

                _sum += grm * 3;
                string sum = Convert.ToString(_sum);
                alinankalori.Text = sum;

                ekmek.ad = "Ekmek";
                ekmek.kalori += grm * 2;
                ekmek.gram += grm;

                string result = ($"{ekmek.ad} {ekmek.kalori}kalori {ekmek.gram}gram");
                listBox1.Items[3] = result;





                int hedef = Convert.ToInt32(hedefkalori.Text);
                if (_sum > hedef)
                {
                    MessageBox.Show($"Günlük kalori ihtiyacınızı aştınız hedefiniz {hedef} idi sizin aldığınız kalori miktarı ise {sum} dır", "Uyarı");
                    label8.Visible = true;
                }
            }

            if (selected == "Tavuk 1g 2cal")
            {
                int grm = Convert.ToInt32(gram.Text);

                _sum += grm * 2;
                string sum = Convert.ToString(_sum);
                alinankalori.Text = sum;

                

                tavuk.ad = "Tavuk";
                tavuk.kalori += grm * 2;
                tavuk.gram += grm;

                string result = ($"{tavuk.ad} {tavuk.kalori}kalori {tavuk.gram}gram");

                listBox1.Items[0] = result;
                int hedef = Convert.ToInt32(hedefkalori.Text);
                if (_sum > hedef)
                {
                    MessageBox.Show($"Günlük kalori ihtiyacınızı aştınız hedefiniz {hedef} idi sizin aldığınız kalori miktarı ise {sum} dır", "Uyarı");
                    label8.Visible = true;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           

            int kal = Convert.ToInt16(alinankalori.Text);

            if (listBox1.SelectedIndex==0)
            {

                _sum -= tavuk.kalori;
                int kal1 = _sum;
                string son = Convert.ToString(kal1);
                alinankalori.Text = son;

                

            }

            if (listBox1.SelectedIndex==1&&et.kalori>0)
            {
                _sum -= et.kalori;
                listBox1.Items[1] = "et";

                kal = _sum;

                string kal1 = Convert.ToString(kal);

                alinankalori.Text = kal1;
            }

            if (listBox1.SelectedIndex==2&&pirinç.kalori>0)
            {
                _sum -= pirinç.kalori;
                listBox1.Items[2] = "pirinç";

                kal = _sum;

                string kal1 = Convert.ToString(kal);

                alinankalori.Text = kal1;
            }

            if (listBox1.SelectedIndex==3&&ekmek.kalori>0)
            {
                _sum -= ekmek.kalori;
                listBox1.Items[3] = "ekmek";
               


            }

        }
    }
}
