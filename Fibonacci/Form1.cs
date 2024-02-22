namespace Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<Elem> elemek = new List<Elem> ();


            for (int i = 0; i < 10; i++)
            {
                Button b = new Button();
                b.Top = i * 30;
                b.Text = Fibonacci(i).ToString();
                Controls.Add(b);

                Elem újElem = new Elem();
                újElem.sorszam = i;
                újElem.ertek = Fibonacci(i);

                elemek.Add(újElem);
            }

            dataGridView1.DataSource = elemek;
        }

        private int Fibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        class Elem
        {
            public int sorszam { get; set; }
            public long ertek { get; set; }
        }

        
    }
}