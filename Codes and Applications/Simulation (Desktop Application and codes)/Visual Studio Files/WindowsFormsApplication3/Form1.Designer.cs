namespace WindowsFormsApplication3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NodesCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ResultGrid = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.ResultGrid2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.ResultGrid3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResultGridH = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfNodes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MeanValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Totaltime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StandardDeviation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ResultGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultGrid3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultGridH)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(236, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Simulate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of Nodes:";
            // 
            // NodesCount
            // 
            this.NodesCount.Location = new System.Drawing.Point(127, 15);
            this.NodesCount.Name = "NodesCount";
            this.NodesCount.Size = new System.Drawing.Size(100, 20);
            this.NodesCount.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(372, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number of steps: ";
            // 
            // ResultGrid
            // 
            this.ResultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.Rand,
            this.X});
            this.ResultGrid.Location = new System.Drawing.Point(38, 91);
            this.ResultGrid.Name = "ResultGrid";
            this.ResultGrid.Size = new System.Drawing.Size(284, 286);
            this.ResultGrid.TabIndex = 6;
            // 
            // Index
            // 
            this.Index.HeaderText = "Index";
            this.Index.Name = "Index";
            // 
            // Rand
            // 
            this.Rand.HeaderText = "Rand";
            this.Rand.Name = "Rand";
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Simulation Steps:";
            // 
            // ResultGrid2
            // 
            this.ResultGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultGrid2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.ResultGrid2.Location = new System.Drawing.Point(349, 91);
            this.ResultGrid2.Name = "ResultGrid2";
            this.ResultGrid2.Size = new System.Drawing.Size(284, 286);
            this.ResultGrid2.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Index";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Rand";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "X";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1077, 32);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "Export to Excel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ResultGrid3
            // 
            this.ResultGrid3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultGrid3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4});
            this.ResultGrid3.Location = new System.Drawing.Point(38, 396);
            this.ResultGrid3.Name = "ResultGrid3";
            this.ResultGrid3.Size = new System.Drawing.Size(594, 286);
            this.ResultGrid3.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Index";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // ResultGridH
            // 
            this.ResultGridH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultGridH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.NumberOfNodes,
            this.MeanValue,
            this.Totaltime,
            this.StandardDeviation});
            this.ResultGridH.Location = new System.Drawing.Point(689, 91);
            this.ResultGridH.Name = "ResultGridH";
            this.ResultGridH.Size = new System.Drawing.Size(599, 286);
            this.ResultGridH.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(689, 32);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 34);
            this.button3.TabIndex = 4;
            this.button3.Text = "Simulate 100 Times";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Time Scale:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(373, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Total Time in miliseconds:";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Index";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // NumberOfNodes
            // 
            this.NumberOfNodes.HeaderText = "Number Of Nodes";
            this.NumberOfNodes.Name = "NumberOfNodes";
            this.NumberOfNodes.Width = 120;
            // 
            // MeanValue
            // 
            this.MeanValue.HeaderText = "Mean Number of Steps";
            this.MeanValue.Name = "MeanValue";
            // 
            // Totaltime
            // 
            this.Totaltime.HeaderText = "Total time in Second";
            this.Totaltime.Name = "Totaltime";
            this.Totaltime.Width = 80;
            // 
            // StandardDeviation
            // 
            this.StandardDeviation.HeaderText = "Standard Deviation";
            this.StandardDeviation.Name = "StandardDeviation";
            this.StandardDeviation.Width = 130;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 853);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ResultGridH);
            this.Controls.Add(this.ResultGrid3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ResultGrid2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ResultGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NodesCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ResultGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultGrid3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultGridH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NodesCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView ResultGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rand;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView ResultGrid2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView ResultGrid3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView ResultGridH;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfNodes;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeanValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Totaltime;
        private System.Windows.Forms.DataGridViewTextBoxColumn StandardDeviation;
    }
}

