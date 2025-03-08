namespace Cookies_Click
{
    public partial class Form1 : Form
    { 
        private int _ticks;
        private int _clicks;
    
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Cookies
            timer1.Start();
            label2.Text = "Cliks: " + _clicks;
            _clicks++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Timer
            _ticks++;
            label1.Text = "Time: " + _ticks;
            if (_ticks == 11)
            {
                timer1.Stop();
                label1.Text = "Game Over!";
                label2.Text = "Your clicks: " + _clicks;
                _ticks = 0;
                _clicks = 0;
                MessageBox.Show("Time is up!");
            }

        }
    }
}
