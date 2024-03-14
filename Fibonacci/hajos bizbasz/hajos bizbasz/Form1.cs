using System.Security.Cryptography;

namespace hajos_bizbasz
{
    public partial class Form1 : Form
    {
        List<Kerdes> OsszesKerdesek;
        List<Kerdes> AktivKerdesek;

        int AktivKerdes = 5;
        public Form1()
        {
            InitializeComponent();

        }

        private List<Kerdes> KerdesBeolvasas()
        {
            List<Kerdes> kerdesek = new List<Kerdes>();
            StreamReader sr = new StreamReader("text.txt");

            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine() ?? string.Empty;

                string[] tomb = sor.Split("\t");

                if (tomb.Length != 7) continue;

                Kerdes k = new Kerdes()
                {
                    KerdesSzoveg = tomb[1],
                    Valasz1 = tomb[2],
                    Valasz2 = tomb[3],
                    Valasz3 = tomb[4],
                    URL = tomb[5],
                };

                int.TryParse(tomb[6], out int jovalasz);

                k.HelyesValasz = jovalasz;

                kerdesek.Add(k);
            }

            sr.Close();


            return kerdesek;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AktivKerdesek = new List<Kerdes>();
            OsszesKerdesek = KerdesBeolvasas();

            for (int i = 0; i < 7; i++)
            {
                AktivKerdesek.Add(OsszesKerdesek[i]);
                OsszesKerdesek.RemoveAt(0);
            }

            dataGridView1.DataSource = AktivKerdesek;

            KerdesMegjelenites(AktivKerdesek[3]);
        }


        void KerdesMegjelenites(Kerdes kerdes)
        {
            label1.Text = kerdes.KerdesSzoveg;
            valaszGomb1.Text = kerdes.Valasz1;
            valaszGomb2.Text = kerdes.Valasz2;
            valaszGomb3.Text = kerdes.Valasz3;

            if (!string.IsNullOrEmpty(kerdes.URL))
            {
                pictureBox1.Load("https://storage.altinum.hu/hajo/" + kerdes.URL);
                pictureBox1.Visible = true;
            }
            else
            {
                pictureBox1.Visible = false;
            }





        }

        private void button1_Click(object sender, EventArgs e)
        {
            KerdesMegjelenites(AktivKerdesek[])
        }



    } 
}
