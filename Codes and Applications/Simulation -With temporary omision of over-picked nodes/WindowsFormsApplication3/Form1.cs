using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel; 

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int resultrows=0;
        private void button1_Click(object sender, EventArgs e)
        {
            ////////////////////////////--- initial objects---/////////////////////////////
            label2.Text = "Number of Steps:";
            for (int i = 0; i < ResultGrid.ColumnCount; i++)
                for (int j = 0; j < ResultGrid.RowCount; j++ )
                    ResultGrid.Rows[j].Cells[i].Value = "";
            ////////////////////////////----------------------/////////////////////////////
            int x = 0, counter=0, rval=0;
            int Number_of_Nodes= int.Parse(NodesCount.Text);
            Boolean all1=false;
            Random randomval = new Random();
            List<int> randomList = new List<int>();
            int[,] PreRandom = new int[Number_of_Nodes, 2];
            int[,] sim = new int[Number_of_Nodes, 3];
            ResultGrid.RowCount = Number_of_Nodes+2;
            ResultGrid.ColumnCount = 3;
            ResultGrid2.RowCount = 50;
            ResultGrid2.ColumnCount = 3;
            ResultGrid3.ColumnCount = Number_of_Nodes + 1;
            ResultGrid3.RowCount = 50;
            ResultGrid.Rows[0].Cells[0].Value = "Step 0";
            for (int i = 0; i < Number_of_Nodes+1; i++)
                for (int j = 0; j < ResultGrid3.RowCount; j++)
                    ResultGrid3.Rows[j].Cells[i].Value = "";
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < ResultGrid2.RowCount; j++)
                    ResultGrid2.Rows[j].Cells[i].Value = "";
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < Number_of_Nodes; j++)
                    PreRandom[j, i] = 0;
            //-------------------Initial part---------------------------//
            for (int i = 0; i < Number_of_Nodes; i++)
            {
                sim[i, 0] = i + 1;
                rval = sim[i, 0];
                while (rval == sim[i, 0]) { sim[i, 1] = randomval.Next(1, Number_of_Nodes); rval = sim[i, 1]; }
                PreRandom[i, 0] = rval; 
                if (i == 0) sim[i, 2] = 1; else sim[i, 2] = 0;
            }
            x++;
            for (int k = 0; k < Number_of_Nodes; k++)
            { if (sim[k, 1] == 1) sim[k, 2] = 2; } 
            sim[sim[0, 1] - 1, 2] = 2;
            for (int k = 0; k < Number_of_Nodes; k++)
            { if (sim[k, 2] == 2) sim[k, 2] = 1;
            if (sim[k, 2] == 1) { counter++; 
                                  ResultGrid3.Rows[0].Cells[k + 1].Value = "X"; 
                                }
              ResultGrid.Rows[k + 1].Cells[0].Value = sim[k, 0];
              ResultGrid.Rows[k + 1].Cells[1].Value = sim[k, 1];
              ResultGrid.Rows[k + 1].Cells[2].Value = sim[k, 2];
            }
            ResultGrid.Rows[ (Number_of_Nodes + 1)].Cells[0].Value = "Step 0";
            ResultGrid.Rows[ (Number_of_Nodes + 1) ].Cells[1].Value = "Nodes Count:";
            ResultGrid.Rows[ (Number_of_Nodes + 1) ].Cells[2].Value = counter;
            
            ResultGrid2.Rows[0].Cells[0].Value = "Step 0";
            ResultGrid2.Rows[0].Cells[1].Value = "Nodes Count:";
            ResultGrid2.Rows[0].Cells[2].Value = counter;

            ResultGrid3.Rows[0].Cells[0].Value = "Step 0";
            
            for (int ind = 1; ind < Number_of_Nodes+1; ind++)
            {
                ResultGrid3.Columns[ind].HeaderText = "N" + ind;
                
            }
            if (counter == Number_of_Nodes) { all1 = true; }
            counter = 0;
//--------------------------------------------------------------------
            while (!all1)
            {
                ResultGrid.RowCount = (x+1)*(Number_of_Nodes + 1)+3;
                ResultGrid.Rows[ResultGrid.RowCount - Number_of_Nodes - 1].Cells[2].Value = "Step " + x;
                for (int i = 0; i < Number_of_Nodes; i++)
                {
                    rval = sim[i, 0];
                    while (rval == sim[i, 0] && rval != PreRandom[i, 0] && rval != PreRandom[i, 1]) { sim[i, 1] = randomval.Next(1, Number_of_Nodes); rval = sim[i, 1];  }
                    if (x % 2 == 0) PreRandom[i, 0] = rval; else PreRandom[i, 1] = rval;
                }
                for (int k = 0; k < Number_of_Nodes; k++)
                { if (sim[k, 0] == 1 && sim[sim[k, 1]-1, 2] != 1) sim[sim[k, 1]-1, 2] = 2; else if (sim[sim[k, 1]-1, 2] == 1 && sim[k, 2] != 1) sim[k, 2] = 2; }
                for (int k = 0; k < Number_of_Nodes; k++)
                { if (sim[k, 2] == 2) sim[k, 2] = 1;
                if (sim[k, 2] == 1)
                {
                    counter++;
                    ResultGrid3.Rows[x].Cells[k + 1].Value = "X";
                }
                    ResultGrid.Rows[x * (Number_of_Nodes + 1) + k + 2].Cells[0].Value = sim[k, 0];
                    ResultGrid.Rows[x * (Number_of_Nodes + 1) + k + 2].Cells[1].Value = sim[k, 1];
                    ResultGrid.Rows[x * (Number_of_Nodes + 1) + k + 2].Cells[2].Value = sim[k, 2];  

                }
                ResultGrid.Rows[ResultGrid.RowCount - 2].Cells[0].Value = "Step " + x;
                ResultGrid.Rows[ResultGrid.RowCount - 2].Cells[1].Value = "Nodes Count:";
                ResultGrid.Rows[ResultGrid.RowCount - 2].Cells[2].Value = counter;

                ResultGrid2.Rows[x].Cells[0].Value = "Step "+x;
                ResultGrid2.Rows[x].Cells[1].Value = "Nodes Count:";
                ResultGrid2.Rows[x].Cells[2].Value = counter;

                ResultGrid3.Rows[x].Cells[0].Value = "Step " + x;

                if (counter == Number_of_Nodes) { all1 = true; }
                counter = 0;
                x++;
            }
            label2.Text = "Number of Steps:" + x.ToString();
            label5.Text = "Total Time in miliseconds:" + (int.Parse(textBox1.Text) * x).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            Excel.Worksheet xlWorkSheet2;
            object misValue = System.Reflection.Missing.Value;
            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            int i = 0;
            int j = 0;
            for (i = 0; i <= ResultGrid2.RowCount - 1; i++)
            {
                for (j = 0; j <= ResultGrid2.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = ResultGrid2[j, i];
                    xlWorkSheet.Cells[i + 1, j + 1] = cell.Value;
                }
            }
            /////////////////////////////0
            xlWorkSheet2 = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(2);
            i = 0;
            j = 0;
            xlWorkSheet2.Cells[1, 1] = "index";
            xlWorkSheet2.Cells[1, 2] = "Number of Nodes";
            xlWorkSheet2.Cells[1, 3] = "Mean Number of Steps";
            xlWorkSheet2.Cells[1, 4] = "Total time in Second";
            xlWorkSheet2.Cells[1, 5] = "Standard Deviation";

            for (i = 0; i <= ResultGridH.RowCount - 1; i++)
            {
                for (j = 0; j <= ResultGridH.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = ResultGridH[j, i];
                    xlWorkSheet2.Cells[i + 2, j + 1] = cell.Value;
                }
            }
            //////////////////////////////
            xlWorkBook.SaveAs("c:\\SimulationResult.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();
            releaseObject(xlWorkSheet);
            releaseObject(xlWorkSheet2);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);
            MessageBox.Show("Excel file created , you can find the file c:\\SimulationResult.xls");
        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
           
            float Mean_Value=0,  Standard_deviation=0;
            int x = 0, counter = 0, rval = 0;
            int Number_of_Nodes = int.Parse(NodesCount.Text);
            int[,] PreRandom = new int[Number_of_Nodes, 2];
            int[,] vars = new int[15, 2];
            int rowindex = 0;
            Boolean addvar = true;
//==================================================================================================
    for (int sss=0; sss<100; sss++)
    {
            x = 0; counter = 0; rval = 0;
            Boolean all1 = false;
            Random randomval = new Random();
            List<int> randomList = new List<int>();
            int[,] sim = new int[Number_of_Nodes, 3];
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < Number_of_Nodes; j++)
                    PreRandom[j, i] = 0;
            //-------------------Initial part---------------------------//
            for (int i = 0; i < Number_of_Nodes; i++)
            {
                sim[i, 0] = i + 1;
                rval = sim[i, 0];
                while (rval == sim[i, 0]) { sim[i, 1] = randomval.Next(1, Number_of_Nodes); rval = sim[i, 1]; }
                PreRandom[i, 0] = rval; 
                if (i == 0) sim[i, 2] = 1; else sim[i, 2] = 0;
            }
            x++;
            for (int k = 0; k < Number_of_Nodes; k++)
            { if (sim[k, 1] == 1) sim[k, 2] = 2; } 
            sim[sim[0, 1] - 1, 2] = 2;
            for (int k = 0; k < Number_of_Nodes; k++)
            {
                if (sim[k, 2] == 2) sim[k, 2] = 1;
                if (sim[k, 2] == 1)
                {
                    counter++;
                }

            }
            if (counter == Number_of_Nodes) { all1 = true; }
            counter = 0;
    //--------------------------------------------------------------------
            while (!all1)
            {
                for (int i = 0; i < Number_of_Nodes; i++)
                {
                    rval = sim[i, 0];
                    while (rval == sim[i, 0]) { sim[i, 1] = randomval.Next(1, Number_of_Nodes); rval = sim[i, 1]; }
                    if (x % 2 == 0) PreRandom[i, 0] = rval; else PreRandom[i, 1] = rval;
                }

                for (int k = 0; k < Number_of_Nodes; k++)
                { if (sim[k, 0] == 1 && sim[sim[k, 1] - 1, 2] != 1) sim[sim[k, 1] - 1, 2] = 2; else if (sim[sim[k, 1] - 1, 2] == 1 && sim[k, 2] != 1) sim[k, 2] = 2; }
                for (int k = 0; k < Number_of_Nodes; k++)
                {
                    if (sim[k, 2] == 2) sim[k, 2] = 1;
                    if (sim[k, 2] == 1)
                    {
                        counter++;
                    }
                }
                if (counter == Number_of_Nodes) { all1 = true; }
                counter = 0;
                x++;
            }
            int sss2 = 0;
            if (sss == 0) { vars[0, 0] = x; vars[0, 1] = 1; rowindex=1; }
            else
            {
                addvar = true;
                while (addvar && sss2<rowindex)
                { if (vars[sss2, 0] == x) { vars[sss2, 1]++; addvar = false; } sss2++; }
                if (addvar) {  vars[rowindex, 0] = x; vars[rowindex, 1] = 1; rowindex++; addvar = false; }
            }
            System.Threading.Thread.Sleep(100); 
    }
 //===============================================================================================
    ResultGridH.ColumnCount = 5;
    for (int i = 0; i <rowindex; i++)
    {
        Mean_Value = Mean_Value + (vars[i, 0] * vars[i, 1]);
    }
    Mean_Value = Mean_Value / 100;
    for (int i = 0; i < rowindex; i++)
    {
        Standard_deviation = Standard_deviation + (float)Math.Pow((vars[i, 0] - Mean_Value), 2);
    }
    Standard_deviation = (float)Math.Sqrt((Standard_deviation / 100));

    ResultGridH.Rows.Add(1);
    ResultGridH.Rows[resultrows].Cells[0].Value = resultrows+1;
    ResultGridH.Rows[resultrows].Cells[1].Value = Number_of_Nodes;
    ResultGridH.Rows[resultrows].Cells[2].Value = Mean_Value;
    ResultGridH.Rows[resultrows].Cells[3].Value = Mean_Value*(float.Parse(textBox1.Text)/1000);
    ResultGridH.Rows[resultrows].Cells[4].Value = Standard_deviation;
    resultrows++;
        }
    }
}
