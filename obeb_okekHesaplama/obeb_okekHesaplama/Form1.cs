

namespace obeb_okekHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //obeb hesaplama
        private int obeb(int[] sayi)
        {
            int eleman, j, k, deger, i;
            int[] dizi;
            bool yon;
            eleman = sayi.Length; // eleman sayisiini bul
            dizi = new int[eleman];
            for (i = 0; i <= eleman - 1; i++)
            {
                dizi[i] = sayi[i];
            } 
            for (i = 0; i <= eleman - 1; i++) // diziyi büyükten küçüðe sýralama
            {
                for (j = 0; j <= eleman - 1; j++)
                {
                    if (dizi[i] > dizi[j])
                    {
                        deger = dizi[i];
                        dizi[i] = dizi[j];
                        dizi[j] = deger;
                    }
                }
            }
            for (i = dizi[eleman - 1]; i >= 2; i--) // obeb bulma mantýðý
            {
                yon = false;
                for (k = 0; k <= eleman - 1; k++)
                {
                    if (dizi[k] % i != 0)
                    {
                        yon = true;
                        break;//fordan cýk

                    }
                }
                if (yon == false)
                {
                    break;
                }



            }
            return i;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int adet, i;
            int[] dizi;
            adet = listBox1.Items.Count;
            dizi = new int[adet];
            for (i = 0; i < adet; i++)
            {
                dizi[i] = Convert.ToInt32(listBox1.Items[i]);
            }
            textBox2.Text = "sayilarin Obebi=" + obeb(dizi);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string girilenMetin = textBox1.Text;
            listBox1.Items.Add(girilenMetin);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Text = "Obeb HEsaplama";
            groupBox2.Text = "Okek Hesaplama";
            button1.Text="OK";      

        }//aa
        // okek hesaplama
        private int okek(int[] sayi1)
        {
            int deger, i, eleman, j, k, bul;
            int[] dizi1;
            bul = 1;
            bool yon;
            eleman = sayi1.Length;
            dizi1 = new int[eleman];
            for (i = 0; i <= eleman - 1; i++)
            {
                dizi1[i] = sayi1[i];
            }

            for (i = 0; i <= eleman - 1; i++)
            {
                for (j = 0; j <= eleman - 1; j++)
                {
                    if (dizi1[i] > dizi1[j])
                    {

                        deger = dizi1[i];
                        dizi1[i] = dizi1[j];
                        dizi1[j] = deger;
                    }
                }

            }
            deger = dizi1[0];
            for (k = 2; k <= deger; k++)
            {
                yon = false;
                for (i = 0; i <= eleman - 1; i++)
                {
                    if (dizi1[i] % k == 0)
                    {
                        yon = true;
                        dizi1[i] /= k;

                    }
                }
                if (yon == true)
                {
                    bul *= k;
                    k = 1;
                }
            }
            return bul;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int adet, i;
            int[] dizi1;
            adet = listBox2.Items.Count;
            dizi1 = new int[adet];
            for (i = 0; i < adet; i++)
            {
                dizi1[i] = Convert.ToInt32(listBox2.Items[i]);
            }
            textBox4.Text = "Sayýlarýn Okeki=" + okek(dizi1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string girilenSayi = textBox3.Text;
           listBox2.Items.Add(girilenSayi);
            
        }
    }
}
