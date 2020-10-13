using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehicle
{
    public partial class Vehicle : Form

    {
        Random rand = new Random();
        CarRace Class = new CarRace();
        CarRace Bmw = new CarRace();
        public Vehicle()
        {
            InitializeComponent();
        }

        private void StartBt_Click(object sender, EventArgs e)
        {
            Move();
        }
        
          public new async void Move()

        {
            
            {
                Bmw.Location = new Point(Bmw.Location.X + 10, Bmw.Location.Y);
                await Task.Delay(10);
                Toyata.Location = new Point(Toyata.Location.X + 25, Toyata.Location.Y);
                await Task.Delay(25);
                Plane.Location = new Point(Plane.Location.X + 30, Plane.Location.Y);
                await Task.Delay(30);
                Bicycle.Location = new Point(Bicycle.Location.X + 15, Bicycle.Location.Y);
                await Task.Delay(15);

            }
            while (Bmw.Location.X < 500)
            {
                int speed1 = rand.Next(0, 20);
                Bmw.Location = new Point(Bmw.Location.X + speed1, Bmw.Location.Y);
                await Task.Delay(25);
                int speed2 = rand.Next(0, 20);
                Toyata.Location = new Point(Toyata.Location.X + speed2, Toyata.Location.Y);
                await Task.Delay(25);
                int speed3 = rand.Next(0, 20);
                Plane.Location = new Point(Plane.Location.X + speed3, Plane.Location.Y);
                await Task.Delay(30);
                int speed4 = rand.Next(0, 20);
                Bicycle.Location = new Point(Bicycle.Location.X + speed4, Bicycle.Location.Y);
                await Task.Delay(15);
            }

        }
    

        private void Bmw_Click(object sender, EventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bt_Click(object sender, EventArgs e)
        {

            TextBox.Text = Convert.ToString(Bmw.IncreaseDoors());
        }
    }
    }



    

