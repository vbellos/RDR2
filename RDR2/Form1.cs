using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RDR2
{
    public partial class Form1 : Form
    {
        List<area> field;
        List<int> weights;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitField();
        }

        public void setField()
        {
            field = new List<area>();
            weights = new List<int>();
            foreach(area a in tableLayoutPanel.Controls)
            {
                a.colorize();
                field.Add(a);
                weights.Add(a.Cost);
            }
        }

        private void InitField()
        {
            field = new List<area>();
            weights = new List<int>();
            int w = tableLayoutPanel.Width / 5;
            int h = tableLayoutPanel.Height / 5;
            int v = 0;
            for (int y = 0; y<5; y++)
            {
                for (int x = 0; x < 5; x++)
                {
                    area area = new area(new Point(x, y));
                    area.Vertex = v;
                    area.Width = w;
                    area.Height = h;
                    field.Add(area);
                    weights.Add(area.Cost);
                    v++;
                }
            }

            tableLayoutPanel.RowCount = 5;
            tableLayoutPanel.ColumnCount = 5;

            tableLayoutPanel.RowStyles.Clear();
            tableLayoutPanel.ColumnStyles.Clear();
            v = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, w));
                    tableLayoutPanel.Controls.Add(field[v],field[v].Point.X, field[v].Point.Y);
                    v++;
                }
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, h));
            }
        }

        private void bfsbtn_Click(object sender, EventArgs e)
        {
            setField();
            int source = (int)(sourceYnumericUpDown.Value * 5 + sourceXnumericUpDown.Value);
            int dest = (int)(destYnumericUpDown.Value * 5 + destXnumericUpDown.Value);
            BFS bFS = new BFS(source, dest);
            List<int> path = bFS.GetShortestPath();

            foreach (area c in tableLayoutPanel.Controls)
            {
                if (path.Contains(c.Vertex)) { c.SetBTNColor(Color.Green); }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setField();
            int source = (int)(sourceYnumericUpDown.Value * 5 + sourceXnumericUpDown.Value);
            int dest = (int)(destYnumericUpDown.Value * 5 + destXnumericUpDown.Value);
            BFSWeight bFS = new BFSWeight(source, dest, weights);
            List<int> path = bFS.GetShortestPath();

            foreach (area c in tableLayoutPanel.Controls)
            {
                if (path.Contains(c.Vertex)) { c.SetBTNColor(Color.Green); }
            }
        }
    }

       
    
}
