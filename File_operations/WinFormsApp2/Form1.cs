namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Text = "Dosya iþlemleri";
            label1.Text = "";
            button1.Text = "OKU";
            button2.Text = "YAZ";
            button3.Text = "GÜNCELLE";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "AÇ";
            openFileDialog1.InitialDirectory = "C:\\Users\\Meryem\\Desktop";
            openFileDialog1.Filter = "Metin Dosyalarý (*.txt)|*.txt|Tüm Dosyalar (*.*)|*.*";
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            label1.Text = openFileDialog1.FileName;
            StreamReader dosya_oku = new StreamReader(openFileDialog1.FileName);
            richTextBox1.Text = dosya_oku.ReadToEnd();
            dosya_oku.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Kaydet";
            saveFileDialog1.InitialDirectory = "C:\\Users\\Meryem\\Desktop";
            saveFileDialog1.Filter = "Metin Dosyalarý (*.txt)|*.txt|Tüm Dosyalar (*.*)|*.*";
            saveFileDialog1.FileName = "";
            saveFileDialog1.ShowDialog();
            StreamWriter dosya_yaz = new StreamWriter(saveFileDialog1.FileName);
            dosya_yaz.Write(richTextBox1.Text);
            dosya_yaz.Close();
            MessageBox.Show("Ýçerik kaydedildi");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamWriter dosya_yaz = new StreamWriter(label1.Text);
            dosya_yaz .Write(richTextBox1.Text);
            dosya_yaz .Close();
        }
    }
}
