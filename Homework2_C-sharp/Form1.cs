namespace Homework2_C_sharp
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        System.Timers.Timer timer;
        int[] randoms = new int[10];
        List<int> randoms1 = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.timer = new System.Timers.Timer(2000);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.random.Next(45,90).ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                this.randoms[i] = random.Next(0, 70);
                this.richTextBox1.AppendText("Another one:" + this.randoms[i] + "\n");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float sum=0;
            for (int i = 0; i < randoms.Length; i++)
            {
                sum += randoms[i];
            }
            this.textBox5.Text = ((sum / (randoms.Length)).ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //this.button4.BackColor = Color.Red;

            this.randoms1.Add(this.random.Next(50));
            int current = this.randoms1.Last();
            int partialSum = this.randoms1.Sum();
            double average = this.randoms1.Average();
            this.richTextBox2.AppendText("Random: " + current + "--Partial Sum:" + partialSum + "--Average:" + String.Format("{0:0.00}", average) + "\n");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();
        }

    }
}