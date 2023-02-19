namespace FinanceAssistent
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Тип дохода");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Доход", new System.Windows.Forms.TreeNode[] {
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Тип расхода");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Расход", new System.Windows.Forms.TreeNode[] {
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Семья");
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.действияСТаблицейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.графикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.построитьГрафикДоходовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.построитьГрафикРасходовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сформироватьОтчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиТоварToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeView1.Location = new System.Drawing.Point(12, 27);
            this.treeView1.Name = "treeView1";
            treeNode6.Name = "Узел1";
            treeNode6.Text = "Тип дохода";
            treeNode7.Name = "Узел0";
            treeNode7.Text = "Доход";
            treeNode8.Name = "Узел3";
            treeNode8.Text = "Тип расхода";
            treeNode9.Name = "Узел2";
            treeNode9.Text = "Расход";
            treeNode10.Name = "Узел0";
            treeNode10.Text = "Семья";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode9,
            treeNode10});
            this.treeView1.ShowLines = false;
            this.treeView1.Size = new System.Drawing.Size(359, 167);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Location = new System.Drawing.Point(377, 27);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Size = new System.Drawing.Size(395, 422);
            this.dataGridView1.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.действияСТаблицейToolStripMenuItem,
            this.графикToolStripMenuItem,
            this.отчетToolStripMenuItem,
            this.найтиТоварToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 25);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // действияСТаблицейToolStripMenuItem
            // 
            this.действияСТаблицейToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.удалитьДанныеToolStripMenuItem,
            this.изменитьДанныеToolStripMenuItem});
            this.действияСТаблицейToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.действияСТаблицейToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("действияСТаблицейToolStripMenuItem.Image")));
            this.действияСТаблицейToolStripMenuItem.Name = "действияСТаблицейToolStripMenuItem";
            this.действияСТаблицейToolStripMenuItem.Size = new System.Drawing.Size(165, 21);
            this.действияСТаблицейToolStripMenuItem.Text = "Действия с таблицей";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("добавитьToolStripMenuItem.Image")));
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить данные";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // удалитьДанныеToolStripMenuItem
            // 
            this.удалитьДанныеToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("удалитьДанныеToolStripMenuItem.Image")));
            this.удалитьДанныеToolStripMenuItem.Name = "удалитьДанныеToolStripMenuItem";
            this.удалитьДанныеToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.удалитьДанныеToolStripMenuItem.Text = "Удалить данные";
            // 
            // изменитьДанныеToolStripMenuItem
            // 
            this.изменитьДанныеToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("изменитьДанныеToolStripMenuItem.Image")));
            this.изменитьДанныеToolStripMenuItem.Name = "изменитьДанныеToolStripMenuItem";
            this.изменитьДанныеToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.изменитьДанныеToolStripMenuItem.Text = "Изменить данные";
            this.изменитьДанныеToolStripMenuItem.Click += new System.EventHandler(this.изменитьДанныеToolStripMenuItem_Click);
            // 
            // графикToolStripMenuItem
            // 
            this.графикToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.построитьГрафикДоходовToolStripMenuItem,
            this.построитьГрафикРасходовToolStripMenuItem});
            this.графикToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.графикToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("графикToolStripMenuItem.Image")));
            this.графикToolStripMenuItem.Name = "графикToolStripMenuItem";
            this.графикToolStripMenuItem.Size = new System.Drawing.Size(81, 21);
            this.графикToolStripMenuItem.Text = "График";
            // 
            // построитьГрафикДоходовToolStripMenuItem
            // 
            this.построитьГрафикДоходовToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("построитьГрафикДоходовToolStripMenuItem.Image")));
            this.построитьГрафикДоходовToolStripMenuItem.Name = "построитьГрафикДоходовToolStripMenuItem";
            this.построитьГрафикДоходовToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.построитьГрафикДоходовToolStripMenuItem.Text = "Построить график доходов";
            this.построитьГрафикДоходовToolStripMenuItem.Click += new System.EventHandler(this.построитьГрафикДоходовToolStripMenuItem_Click);
            // 
            // построитьГрафикРасходовToolStripMenuItem
            // 
            this.построитьГрафикРасходовToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("построитьГрафикРасходовToolStripMenuItem.Image")));
            this.построитьГрафикРасходовToolStripMenuItem.Name = "построитьГрафикРасходовToolStripMenuItem";
            this.построитьГрафикРасходовToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.построитьГрафикРасходовToolStripMenuItem.Text = "Построить график расходов";
            // 
            // отчетToolStripMenuItem
            // 
            this.отчетToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сформироватьОтчетToolStripMenuItem});
            this.отчетToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.отчетToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("отчетToolStripMenuItem.Image")));
            this.отчетToolStripMenuItem.Name = "отчетToolStripMenuItem";
            this.отчетToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.отчетToolStripMenuItem.Text = "Данные";
            // 
            // сформироватьОтчетToolStripMenuItem
            // 
            this.сформироватьОтчетToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("сформироватьОтчетToolStripMenuItem.Image")));
            this.сформироватьОтчетToolStripMenuItem.Name = "сформироватьОтчетToolStripMenuItem";
            this.сформироватьОтчетToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.сформироватьОтчетToolStripMenuItem.Text = "Выгрузить данные";
            this.сформироватьОтчетToolStripMenuItem.Click += new System.EventHandler(this.сформироватьОтчетToolStripMenuItem_Click);
            // 
            // найтиТоварToolStripMenuItem
            // 
            this.найтиТоварToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("найтиТоварToolStripMenuItem.Image")));
            this.найтиТоварToolStripMenuItem.Name = "найтиТоварToolStripMenuItem";
            this.найтиТоварToolStripMenuItem.Size = new System.Drawing.Size(103, 21);
            this.найтиТоварToolStripMenuItem.Text = "Найти товар";
            this.найтиТоварToolStripMenuItem.Click += new System.EventHandler(this.найтиТоварToolStripMenuItem_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Location = new System.Drawing.Point(-1, -1);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(363, 249);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Location = new System.Drawing.Point(12, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 249);
            this.panel1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Финансовый помошник";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem действияСТаблицейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьДанныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem графикToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem построитьГрафикДоходовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem построитьГрафикРасходовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сформироватьОтчетToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem изменитьДанныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найтиТоварToolStripMenuItem;
    }
}

