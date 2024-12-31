using TrafficLight.Classes;
using TrafficLight.Properties;

namespace TrafficLight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ctrlTrafficLight1.Start();
            ctrlTrafficLight2.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ctrlTrafficLight1.Stop();
            ctrlTrafficLight2.Stop();

        }
    }
}
