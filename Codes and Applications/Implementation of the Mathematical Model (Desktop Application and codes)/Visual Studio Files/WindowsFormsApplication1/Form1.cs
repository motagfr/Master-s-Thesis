using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel; 

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int resultrows = 0;
        static float P(int n, int k, int h) //The recursion coded in it's recursive form which proved to be inefficient when it comes to large numbers of Nodes
        {
            if (k == 1 && h == 0)
            { return 1; }
            else if (k >= h + 1 || h <= 0 || k <= 0) { return 0; }
            else
            {
                return 2 * ((float)(k) / n) * (((float)(n - k)) / (n - 1)) * P(n, k - 1, h - 1) + (1 - 2 * ((float)(k) / n) * (((float)(n - k)) / (n - 1))) * P(n, k, h - 1);
            }
        }

         private float PNR(int n, int k, int h) //The Non-recursive code of the recursion which calculate the values of the recursion in an step-by-step or non-recursive manner
        {
            int  cl=1;
            List<float> prevlist = new List<float>();
            List<int>  zerolist = new List<int>();
            List<float> templist =new List<float>();
            for (int i = 0; i <= (h/n)+1; i++) { prevlist.Add(0); pointsgrid.Rows[0].Cells[i].Value = i; }
             for (int i = 1; i <= k; i++) { pointsgrid.Rows[i].Cells[0].Value = i; if (i == 1) zerolist.Add(1); else zerolist.Add(0); }
            pointsgrid.Rows[0].Cells[0].Value = "K / H";
             
            float prevVal = 1;    // P(n,1,0)
            for (int i=1; i<=k;i++)
            {   
                prevVal = zerolist[i-1];
                templist.Add(prevVal);
                for (int j=1; j<=h;j++)
                {
                    if (i == 1 ) { prevVal = 0; }else
                    if (i == 2 && j == 1) { prevVal = 1; }
                    else
                    {
                        prevVal = 2 * ((float)(i - 1) / n) * ((float)(n - i + 1) / (n - 1)) * prevlist[j - 1] + (1 - 2 * ((float)(i) / n) * (((float)(n - i)) / (n - 1))) * prevVal;
                    }
                templist.Add(prevVal);

                if (j % n == 0)  //shows only columns which are a product of n
                {
                    cl = (j / n);
                    pointsgrid.Rows[i].Cells[cl].Value = prevVal.ToString();
                }
                
                }
            prevlist.Clear();
            prevlist.AddRange(templist);
            templist.Clear();
            }
            return prevVal;
        }
         private float PNR2(int n, int k, int h)
         {
            
             n = int.Parse(textBox1.Text);
             k = int.Parse(l7.Text);
             h = int.Parse(textBox3.Text)*n;
             float a = 0;
             for (int i = 0; i <= h/n; i++) { if (i == 0) pointsgrid2.Rows[0].Cells[i].Value = "K / H"; else pointsgrid2.Rows[0].Cells[i].Value = i; }
             for (int j = 1; j <= h/n; j++)
             {
                 for (int i = 1; i <= k; i++)   // k=n  k should be equal to n to calculate E(k)
                 {
                     a = a + (i * float.Parse(pointsgrid.Rows[i].Cells[j].Value.ToString())); // P(n, i, j));
                 }
                pointsgrid2.Rows[1].Cells[j].Value = a.ToString();
                a = 0;
            }
             return 1;
         }
        private void button1_Click(object sender, EventArgs e)
        {
            int n = 1, k = 1, h = 0;
            n= int.Parse(textBox1.Text);
            k = int.Parse(l7.Text);
            h = int.Parse(textBox3.Text)*n;
            pointsgrid.AutoGenerateColumns = false;
            pointsgrid.RowCount = int.Parse(l7.Text)+1;
            DataGridViewCell cell = new DataGridViewTextBoxCell(); //Specify which type of cell in this column
            for (int i = 0; i < (h/n) + 1; i++)
            {
                DataGridViewColumn  newCol = new DataGridViewColumn(); // add a column to the grid
                newCol.CellTemplate = cell;
                newCol.Visible = true;
                newCol.FillWeight = 1;
                pointsgrid.Columns.Add(newCol);

            }
            PNR(n, k, h);
            button2.Enabled = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int n = 1, k = 1, h = 0;
            n = int.Parse(textBox1.Text);
            k = int.Parse(l7.Text);
            h = int.Parse(textBox3.Text)*n;
            pointsgrid2.RowCount = 2;
            DataGridViewCell cell = new DataGridViewTextBoxCell(); //Specify which type of cell in this column
            for (int i = 0; i < (h/n)+1; i++)
            {
                DataGridViewColumn newCol = new DataGridViewColumn(); // add a column to the grid
                newCol.CellTemplate = cell;
                newCol.Visible = true;
                newCol.FillWeight = 1;
                pointsgrid2.Columns.Add(newCol);
            }
            PNR2(n, k, h);
            button4.Enabled = true;
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (int.Parse(textBox1.Text)<int.Parse(textBox2.Text)) {
                textBox2.Text = textBox1.Text;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            Excel.Worksheet xlWorkSheet2;
            Excel.Worksheet xlWorkSheet3;
            object misValue = System.Reflection.Missing.Value;
            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            int i = 0, j= 0;

            for (i = 0; i <= pointsgrid.RowCount - 1; i++)
            {
                for (j = 0; j <= pointsgrid.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = pointsgrid[j, i];
                    xlWorkSheet.Cells[i + 1, j + 1] = cell.Value;
                }
            }
///////////////////////////////////////////////////////////////////////////////////////////////////////
            xlWorkSheet2 = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(2);
             i = 0;
             j = 0;
            for (i = 0; i <= pointsgrid2.RowCount - 1; i++)
            {
                for (j = 0; j <= pointsgrid2.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = pointsgrid2[j, i];
                    xlWorkSheet2.Cells[i + 1, j + 1] = cell.Value;
                }
            }
///////////////////////////////////////////////////////////////////////////////////////////////////////
            xlWorkSheet3 = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(3);
            i = 0;
            j = 0;

            xlWorkSheet3.Cells[1, 1] = "index";
            xlWorkSheet3.Cells[1, 2] = "Number of Nodes";
            xlWorkSheet3.Cells[1, 3] = "Expected H";
            xlWorkSheet3.Cells[1, 4] = "Total time in Second";
            for (i = 0; i <= ResultGrid3.RowCount - 1; i++)
            {
                for (j = 0; j <= ResultGrid3.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = ResultGrid3[j, i];
                    xlWorkSheet3.Cells[i + 2, j + 1] = cell.Value;
                }
            }
//////////////////////////////
            xlWorkBook.SaveAs("c:\\resultsinfo.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();
            releaseObject(xlWorkSheet);
            releaseObject(xlWorkSheet2);
            releaseObject(xlWorkSheet3);

            releaseObject(xlWorkBook);
            releaseObject(xlApp);
            MessageBox.Show("Excel file created , you can find the file c:\\resultsinfo.xls");
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

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            int k = int.Parse(textBox1.Text);
            int h = int.Parse(textBox3.Text)*n;
            int counter = 0;
            double[,] sim = new double[n+1, (h/n)+1];
////////////////////////////////////////////////////////////////////////////////////////
            int x = 0, cl = 1;
            List<float> prevlist = new List<float>();
            List<int> zerolist = new List<int>();
            List<float> templist = new List<float>();
            for (int i = 0; i <= (h / n) + 1; i++) { prevlist.Add(0); pointsgrid.Rows[0].Cells[i].Value = i; }
            for (int i = 1; i <= k; i++) { sim [i,0] = i; if (i == 1) zerolist.Add(1); else zerolist.Add(0); }
            float prevVal = 1;    // P(n,1,0)
            for (int i = 1; i <= k; i++)
            {
                prevVal = zerolist[i - 1];
                templist.Add(prevVal);
                for (int j = 1; j <= h; j++)
                {
                    if (i == 1) { prevVal = 0; }
                    else
                        if (i == 2 && j == 1) { prevVal = 1; }
                        else
                        {
                            prevVal = 2 * ((float)(i - 1) / n) * ((float)(n - i + 1) / (n - 1)) * prevlist[j - 1] + (1 - 2 * ((float)(i) / n) * (((float)(n - i)) / (n - 1))) * prevVal;
                        }
                    templist.Add(prevVal);

                    if (j % n == 0)
                    {
                        cl = (j / n);
                        sim[i, cl] = prevVal;
                    }
                    x++;
                }
                prevlist.Clear();
                prevlist.AddRange(templist);
                templist.Clear();
            }
/////////////////////////////////////////////////////////////////////////////////////////            
            double a = 0;
            double[,] pg2 = new double[2,(h / n) + 1];
            for (int i = 0; i <= (h / n); i++) { pg2[0,i]= i; }
            for (int j = 1; j <= (h / n); j++)
            {
                for (int i = 1; i <= k; i++)   // k=n  k should be equal to n to calculate E(k)
                {
                    a = a + (i * sim[i,j]); // P(n, i, j));
                }
                pg2[1, j] = a;
                a = 0;
            }
            double z = pg2[1, counter];
           // while (z <= n - 0.5)
            while(z<=n-1)
                { counter++; z = pg2[1, counter]; }
            ResultGrid3.Rows.Add(1);
            ResultGrid3.Rows[resultrows].Cells[0].Value = resultrows + 1;
            ResultGrid3.Rows[resultrows].Cells[1].Value = n;
            ResultGrid3.Rows[resultrows].Cells[2].Value = pg2[0,counter];
            ResultGrid3.Rows[resultrows].Cells[3].Value = pg2[0, counter] * (float.Parse(textBox4.Text) / 1000);
            resultrows++;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            l7.Text = textBox1.Text;
        }

    }
}
