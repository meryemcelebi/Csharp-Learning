using System.Windows.Forms;

namespace okekHesaplama_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int okek(int[] sayi1)
        {
            int bul = 1;
            int eleman = sayi1.Length;
            int[] dizi1 = new int[eleman];
            Array.Copy(sayi1, dizi1, eleman);

            while (true)
            {
                int maxSayi = dizi1.Max(); // En b�y�k say�y� bul
                if (maxSayi == 1) break;   // T�m say�lar 1 oldu�unda dur

                int k;
                for (k = 2; k <= maxSayi; k++)
                {
                    bool yon = false;
                    for (int i = 0; i < eleman; i++)
                    {
                        if (dizi1[i] % k == 0)
                        {
                            yon = true;
                            dizi1[i] /= k;
                        }
                    }
                    if (yon)
                    {
                        bul *= k;
                        break; // k'y� bulduk, yeniden 2'den ba�la
                    }
                }

                if (k > maxSayi) break; // B�len yok, ��k
            }
            return bul;
        }
        private void button2_Click(object sender, EventArgs e)
        {

            int adet, i;
            int[] dizi1;
            adet = listBox1.Items.Count;
            dizi1 = new int[adet];
            for (i = 0; i < adet; i++)
            {
                dizi1[i] = Convert.ToInt32(listBox1.Items[i]);
            }
            textBox2.Text = "Say�lar�n Okeki=" + okek(dizi1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string girilenSayi = textBox1.Text;
            listBox1.Items.Add(girilenSayi);
        }
    }
}
