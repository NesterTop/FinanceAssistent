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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Категории дохода");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Доходы", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Категории расхода");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Расходы", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Семья");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.действияСТаблицейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.графикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.построитьГрафикДоходовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьГрафикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(12, 27);
            this.treeView1.Name = "treeView1";
            treeNode1.ImageIndex = 1;
            treeNode1.Name = "Узел1";
            treeNode1.SelectedImageKey = "category_icon_242508.ico";
            treeNode1.Text = "Категории дохода";
            treeNode2.ImageIndex = 0;
            treeNode2.Name = "Узел0";
            treeNode2.SelectedImageKey = "3668841-earnings-income-salary-wallet_108032.ico";
            treeNode2.Text = "Доходы";
            treeNode3.ImageIndex = 1;
            treeNode3.Name = "Узел3";
            treeNode3.SelectedImageKey = "category_icon_242508.ico";
            treeNode3.Text = "Категории расхода";
            treeNode4.ImageIndex = 2;
            treeNode4.Name = "Узел2";
            treeNode4.SelectedImageKey = "bill_invoice_receipt_expenses_internet_icon_142257.ico";
            treeNode4.Text = "Расходы";
            treeNode5.ImageIndex = 3;
            treeNode5.Name = "Узел0";
            treeNode5.SelectedImageKey = "Family_icon-icons.com_54182.ico";
            treeNode5.Text = "Семья";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode4,
            treeNode5});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.ShowLines = false;
            this.treeView1.Size = new System.Drawing.Size(359, 167);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "3668841-earnings-income-salary-wallet_108032.ico");
            this.imageList1.Images.SetKeyName(1, "category_icon_242508.ico");
            this.imageList1.Images.SetKeyName(2, "bill_invoice_receipt_expenses_internet_icon_142257.ico");
            this.imageList1.Images.SetKeyName(3, "Family_icon-icons.com_54182.ico");
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(377, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(395, 422);
            this.dataGridView1.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.удалитьДанныеToolStripMenuItem.Click += new System.EventHandler(this.удалитьДанныеToolStripMenuItem_Click);
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
            this.очиститьГрафикToolStripMenuItem});
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
            this.построитьГрафикДоходовToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.построитьГрафикДоходовToolStripMenuItem.Text = "Построить график";
            this.построитьГрафикДоходовToolStripMenuItem.Click += new System.EventHandler(this.построитьГрафикToolStripMenuItem_Click);
            // 
            // очиститьГрафикToolStripMenuItem
            // 
            this.очиститьГрафикToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("очиститьГрафикToolStripMenuItem.Image")));
            this.очиститьГрафикToolStripMenuItem.Name = "очиститьГрафикToolStripMenuItem";
            this.очиститьГрафикToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.очиститьГрафикToolStripMenuItem.Text = "Очистить график";
            this.очиститьГрафикToolStripMenuItem.Click += new System.EventHandler(this.очиститьГрафикToolStripMenuItem_Click);
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
            this.найтиТоварToolStripMenuItem.Size = new System.Drawing.Size(112, 21);
            this.найтиТоварToolStripMenuItem.Text = "Найти товар";
            this.найтиТоварToolStripMenuItem.Click += new System.EventHandler(this.найтиТоварToolStripMenuItem_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(-1, -1);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
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
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem действияСТаблицейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьДанныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem графикToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem построитьГрафикДоходовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сформироватьОтчетToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem изменитьДанныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найтиТоварToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьГрафикToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
    }
}

