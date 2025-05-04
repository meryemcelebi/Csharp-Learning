namespace siralamaAlgoritmalari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Bubble sort
        private void button1_Click(object sender, EventArgs e)
        {
            int[] dizi;
            int i, j, adet, deger;
            adet = listBox1.Items.Count;
            dizi = new int[adet]; // bellekte yer ayrýldý
            for (i = 0; i <= adet - 1; i++)
            {
                dizi[i] = Convert.ToInt32(listBox1.Items[i]);

            }
            for (i = 1; i <= adet - 1; i++)
            {
                for (j = adet - 1; j >= i; j--)
                {
                    if (dizi[j - 1] < dizi[j])
                    {
                        deger = dizi[j];
                        dizi[j] = dizi[j - 1];
                        dizi[j - 1] = deger;
                    }
                }
            }
            foreach (int eleman in dizi)
            {
                listBox2.Items.Add(eleman.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string girilenSayi = textBox1.Text;
            listBox1.Items.Add(girilenSayi);
        }
        // Bubble Sort 2 
        private void button3_Click(object sender, EventArgs e)
        {
            int[] dizi;
            int i, j, adet, yer, deger, k = 0;
            bool yon;
            adet = listBox1.Items.Count;
            dizi = new int[adet];
            foreach (object satir in listBox1.Items)
            {
                dizi[k] = Convert.ToInt32(satir);
                k++;

            }
            do
            {
                yon = true;
                for (i = 0; i <= adet - 2; i++)
                {
                    if (dizi[i] > dizi[i + 1])
                    {
                        deger = dizi[i];
                        dizi[i] = dizi[i + 1];
                        dizi[i + 1] = deger;
                    }
                }
            } while (yon == false);
            foreach (int eleman1 in dizi)
            {
                listBox2.Items.Add(eleman1.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "YAZ";
            button2.Text = "Büyükten Küçüðe Sýrala";
            button3.Text = "Küçükten Büyüðe Sýrala";
        }
    }
}