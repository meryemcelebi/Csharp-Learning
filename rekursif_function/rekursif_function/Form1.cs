namespace rekursif_function
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static float faktor(int sayi)//rekursif fonksiyon tanýmlanýyor
        {
            float sonuc = 1;
            if (sayi > 1)
            {
                sonuc = sayi * faktor(sayi - 1); // kendi kendisini cagiriyor
            }
            return sonuc;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double deger;
            int x;
            x = Convert.ToInt32(textBox1.Text);//sayiya cevir
            deger = faktor(x); //fonksiyon isletiliyor
            this.Text = x.ToString() + "sayýsýnýn faktoriyeli=" + deger.ToString();
        }
    /* 
* rekursif ozelligi sadece fonksiyonlara has degildir prosedur olarak tanimlanabilir
* sonsuz dongu icerisine kolayca sokulabilir
*/
  /*  private void mesaj()//rekursif proccedure tanimlaniyor
        {
            MessageBox.Show(this, "Prestige");
            mesaj();//tekrar cagir
        }*/
        private void button2_Click(object sender, EventArgs e)
        {
           // mesaj(); //procedure islet
        }
    
    }
}
