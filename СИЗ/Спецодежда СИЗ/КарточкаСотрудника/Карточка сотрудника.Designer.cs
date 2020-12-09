namespace Спецодежда_СИЗ.КарточкаСотрудника
{
    partial class Карточка_сотрудника
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Карточка_сотрудника));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.номерКарточкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.табельныйномерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.полDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.должностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.руководительDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ростDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.размерОдеждыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.размерОбувиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.размерЗимнейОбувиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.размерГоловногоУбораDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.размерПерчатокDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаПоступленияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаИзмененияДолжностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сИЗDataSet = new Спецодежда_СИЗ.СИЗDataSet();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.сотрудникиTableAdapter = new Спецодежда_СИЗ.СИЗDataSetTableAdapters.СотрудникиTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сИЗDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерКарточкиDataGridViewTextBoxColumn,
            this.табельныйномерDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn,
            this.полDataGridViewTextBoxColumn,
            this.должностьDataGridViewTextBoxColumn,
            this.руководительDataGridViewTextBoxColumn,
            this.ростDataGridViewTextBoxColumn,
            this.размерОдеждыDataGridViewTextBoxColumn,
            this.размерОбувиDataGridViewTextBoxColumn,
            this.размерЗимнейОбувиDataGridViewTextBoxColumn,
            this.размерГоловногоУбораDataGridViewTextBoxColumn,
            this.размерПерчатокDataGridViewTextBoxColumn,
            this.датаПоступленияDataGridViewTextBoxColumn,
            this.датаИзмененияДолжностиDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.сотрудникиBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 56);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1458, 652);
            this.dataGridView.TabIndex = 16;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // номерКарточкиDataGridViewTextBoxColumn
            // 
            this.номерКарточкиDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.номерКарточкиDataGridViewTextBoxColumn.DataPropertyName = "Номер карточки";
            this.номерКарточкиDataGridViewTextBoxColumn.HeaderText = "Номер карточки";
            this.номерКарточкиDataGridViewTextBoxColumn.Name = "номерКарточкиDataGridViewTextBoxColumn";
            this.номерКарточкиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // табельныйномерDataGridViewTextBoxColumn
            // 
            this.табельныйномерDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.табельныйномерDataGridViewTextBoxColumn.DataPropertyName = "Табельный_номер";
            this.табельныйномерDataGridViewTextBoxColumn.HeaderText = "Табельный номер";
            this.табельныйномерDataGridViewTextBoxColumn.Name = "табельныйномерDataGridViewTextBoxColumn";
            this.табельныйномерDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            this.фИОDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // полDataGridViewTextBoxColumn
            // 
            this.полDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.полDataGridViewTextBoxColumn.DataPropertyName = "Пол";
            this.полDataGridViewTextBoxColumn.HeaderText = "Пол";
            this.полDataGridViewTextBoxColumn.Name = "полDataGridViewTextBoxColumn";
            this.полDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // должностьDataGridViewTextBoxColumn
            // 
            this.должностьDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.должностьDataGridViewTextBoxColumn.DataPropertyName = "Должность";
            this.должностьDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.должностьDataGridViewTextBoxColumn.Name = "должностьDataGridViewTextBoxColumn";
            this.должностьDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // руководительDataGridViewTextBoxColumn
            // 
            this.руководительDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.руководительDataGridViewTextBoxColumn.DataPropertyName = "Руководитель";
            this.руководительDataGridViewTextBoxColumn.HeaderText = "Руководитель";
            this.руководительDataGridViewTextBoxColumn.Name = "руководительDataGridViewTextBoxColumn";
            this.руководительDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ростDataGridViewTextBoxColumn
            // 
            this.ростDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ростDataGridViewTextBoxColumn.DataPropertyName = "Рост";
            this.ростDataGridViewTextBoxColumn.HeaderText = "Рост";
            this.ростDataGridViewTextBoxColumn.Name = "ростDataGridViewTextBoxColumn";
            this.ростDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // размерОдеждыDataGridViewTextBoxColumn
            // 
            this.размерОдеждыDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.размерОдеждыDataGridViewTextBoxColumn.DataPropertyName = "Размер одежды";
            this.размерОдеждыDataGridViewTextBoxColumn.HeaderText = "Размер одежды";
            this.размерОдеждыDataGridViewTextBoxColumn.Name = "размерОдеждыDataGridViewTextBoxColumn";
            this.размерОдеждыDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // размерОбувиDataGridViewTextBoxColumn
            // 
            this.размерОбувиDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.размерОбувиDataGridViewTextBoxColumn.DataPropertyName = "Размер обуви";
            this.размерОбувиDataGridViewTextBoxColumn.HeaderText = "Размер обуви";
            this.размерОбувиDataGridViewTextBoxColumn.Name = "размерОбувиDataGridViewTextBoxColumn";
            this.размерОбувиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // размерЗимнейОбувиDataGridViewTextBoxColumn
            // 
            this.размерЗимнейОбувиDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.размерЗимнейОбувиDataGridViewTextBoxColumn.DataPropertyName = "Размер зимней обуви";
            this.размерЗимнейОбувиDataGridViewTextBoxColumn.HeaderText = "Размер зимней обуви";
            this.размерЗимнейОбувиDataGridViewTextBoxColumn.Name = "размерЗимнейОбувиDataGridViewTextBoxColumn";
            this.размерЗимнейОбувиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // размерГоловногоУбораDataGridViewTextBoxColumn
            // 
            this.размерГоловногоУбораDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.размерГоловногоУбораDataGridViewTextBoxColumn.DataPropertyName = "Размер головного убора";
            this.размерГоловногоУбораDataGridViewTextBoxColumn.HeaderText = "Размер головного убора";
            this.размерГоловногоУбораDataGridViewTextBoxColumn.Name = "размерГоловногоУбораDataGridViewTextBoxColumn";
            this.размерГоловногоУбораDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // размерПерчатокDataGridViewTextBoxColumn
            // 
            this.размерПерчатокDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.размерПерчатокDataGridViewTextBoxColumn.DataPropertyName = "Размер перчаток";
            this.размерПерчатокDataGridViewTextBoxColumn.HeaderText = "Размер перчаток";
            this.размерПерчатокDataGridViewTextBoxColumn.Name = "размерПерчатокDataGridViewTextBoxColumn";
            this.размерПерчатокDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаПоступленияDataGridViewTextBoxColumn
            // 
            this.датаПоступленияDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.датаПоступленияDataGridViewTextBoxColumn.DataPropertyName = "Дата поступления";
            this.датаПоступленияDataGridViewTextBoxColumn.HeaderText = "Дата поступления";
            this.датаПоступленияDataGridViewTextBoxColumn.Name = "датаПоступленияDataGridViewTextBoxColumn";
            this.датаПоступленияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаИзмененияДолжностиDataGridViewTextBoxColumn
            // 
            this.датаИзмененияДолжностиDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.датаИзмененияДолжностиDataGridViewTextBoxColumn.DataPropertyName = "Дата изменения должности";
            this.датаИзмененияДолжностиDataGridViewTextBoxColumn.HeaderText = "Дата изменения должности";
            this.датаИзмененияДолжностиDataGridViewTextBoxColumn.Name = "датаИзмененияДолжностиDataGridViewTextBoxColumn";
            this.датаИзмененияДолжностиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this.сИЗDataSet;
            // 
            // сИЗDataSet
            // 
            this.сИЗDataSet.DataSetName = "СИЗDataSet";
            this.сИЗDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(80, 20);
            this.textBox3.MaxLength = 30;
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(1352, 30);
            this.textBox3.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(10, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Поиск";
            // 
            // button11
            // 
            this.button11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button11.Image = global::Спецодежда_СИЗ.Properties.Resources.кнопка_3;
            this.button11.Location = new System.Drawing.Point(1438, 21);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(32, 30);
            this.button11.TabIndex = 17;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // Карточка_сотрудника
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 720);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Карточка_сотрудника";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Карточка сотрудника";
            this.Load += new System.EventHandler(this.Карточка_сотрудника_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сИЗDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button11;
        private СИЗDataSet сИЗDataSet;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private СИЗDataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерКарточкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn табельныйномерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn полDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn должностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn руководительDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ростDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn размерОдеждыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn размерОбувиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn размерЗимнейОбувиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn размерГоловногоУбораDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn размерПерчатокDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаПоступленияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаИзмененияДолжностиDataGridViewTextBoxColumn;
    }
}