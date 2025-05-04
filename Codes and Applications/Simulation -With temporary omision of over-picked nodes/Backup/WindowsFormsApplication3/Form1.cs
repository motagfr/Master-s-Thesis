using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            int x = 0, counter=0, rval=0;
            int Number_of_Nodes= int.Parse(NodesCount.Text);
            Boolean all1=false;
            Random randomval = new Random();
            List<int> randomList = new List<int>();
            int[,] sim = new int[Number_of_Nodes, 3];
     //-------------------Initial part---------------------------//
            for (int i = 0; i < Number_of_Nodes; i++)
            {
                sim[i, 0] = i + 1;
                rval = sim[i, 0];
                while (rval == sim[i, 0]) { sim[i, 1] = randomval.Next(1, Number_of_Nodes); rval = sim[i, 1]; }
                
                if (i == 0) sim[i, 2] = 1; else sim[i, 2] = 0;
            }
            x++;
            for (int k = 0; k < Number_of_Nodes; k++)
            { if (sim[k, 1] == 1) sim[k, 2] = 2; }
            for (int k = 0; k < Number_of_Nodes; k++)
            { if (sim[k, 2] == 2) sim[k, 2] = 1; if (sim[k, 2] == 1) counter++; }
            if (counter == Number_of_Nodes) { all1 = true; }
            counter = 0;
//--------------------------------------------------------------------
            
            while (!all1)
            {
                for (int i = 0; i < Number_of_Nodes; i++)
                {
                    rval = sim[i, 0];
                    while (rval == sim[i, 0]) { sim[i, 1] = randomval.Next(1, Number_of_Nodes); rval = sim[i, 1]; }
                    //if (i == 0) sim[i, 2] = 1; else sim[i, 2] = 0;
                }
                x++;
                for (int k = 0; k < Number_of_Nodes; k++)
                { if (sim[k, 0] == 1 && sim[sim[k, 1]-1, 2] != 1) sim[sim[k, 1]-1, 2] = 2; else if (sim[sim[k, 1]-1, 2] == 1 & sim[k, 2] != 1) sim[k, 2] = 2; }
                for (int k = 0; k < Number_of_Nodes; k++)
                { if (sim[k, 2] == 2) sim[k, 2] = 1; if (sim[k, 2] == 1) counter++; }
                if (counter == Number_of_Nodes) { all1 = true; }
                counter = 0;
            }
            label2.Text = "Number of iteraions:" + x.ToString();

        }

        private void ResultGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
