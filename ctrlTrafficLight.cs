using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrafficLight.Classes;
using TrafficLight.Properties;

namespace TrafficLight
{
    public partial class ctrlTrafficLight : UserControl
    {
        private readonly LightColor Red = new(LightColorEnum.Red, Resources.Red);
        private readonly LightColor Green = new(LightColorEnum.Green, Resources.Green);
        private readonly LightColor Yellow = new(LightColorEnum.Yellow, Resources.Orange);

        private LightColor? _CurrentColor;
        private int _TimerCountDown;

        public ctrlTrafficLight()
        {
            InitializeComponent();

            Red.Next = Green;
            Green.Next = Yellow;
            Yellow.Next = Red;

            SetColor(LightColorEnum.Red);
            lblTimerDisplay.Text = _TimerCountDown.ToString();
        }


        public LightColorEnum StartColor
        {
            get
            {
                return _CurrentColor!.Color;
            }
            set
            {
                SetColor(value);
            }
        }

        public int RedTime
        {
            get
            {
                return Red.DisplayTime;
            }
            set
            {
                Red.DisplayTime = value;
            }
        }

        public int GreenTime
        {
            get
            {
                return Green.DisplayTime;
            }

            set
            {
                Green.DisplayTime = value;
            }
        }

        public int YellowTime
        {
            get
            {
                return Yellow.DisplayTime;
            }

            set
            {
                Yellow.DisplayTime = value;
            }
        }

        private void SetColor(LightColorEnum selectedColor)
        {
            switch (selectedColor)
            {
                case LightColorEnum.Red:
                    pbTrafficLightDisplay.Image = Resources.Red;
                    _CurrentColor = Red;
                    break;
                case LightColorEnum.Green:
                    pbTrafficLightDisplay.Image = Resources.Green;
                    _CurrentColor = Green;
                    break;
                case LightColorEnum.Yellow:
                    pbTrafficLightDisplay.Image = Resources.Orange;
                    _CurrentColor = Yellow;
                    break;
            }

            _TimerCountDown = _CurrentColor!.DisplayTime;
        }

        public void Start()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }

        private void timer_Tick_1(object sender, EventArgs e)
        {
            lblTimerDisplay.Text = _TimerCountDown.ToString();


            _TimerCountDown--;

            if (_TimerCountDown <= 0)
            {
                timer.Stop();
                SetColor(_CurrentColor!.Next.Color);
                timer.Start();
            }
        }
    }
}
