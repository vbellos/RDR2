using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace RDR2
{
    public partial class area : UserControl
    {
        int cost;
        Point point;
        int vertex;
        
        
        public int Cost { get => cost; set { this.cost = value; colorize(); ; button.Text = cost.ToString(); } }


        public Point Point { get => point; set => point = value; }
        public int Vertex { get => vertex; set => this.vertex = value; }
        public void SetBTNColor(Color color)
        { button.BackColor = color; }

        public area(Point point)
        {
            this.point = point;
            cost = 1;
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Increase();
        }

        public void Increase()
        {
            if (cost < 4) { Cost = cost +1; }
            else { Cost = 1; }
        }
        
        public void colorize()
        {
            button.BackColor = ValColor();
        }

        public Color ValColor()
        {
            if(cost == 1) { return Color.White; }
            else if(cost == 2) { return Color.DarkGray; }
            else if (cost == 3) { return Color.Gray; }
            else { return Color.DimGray; }
        }

       
    }
}
