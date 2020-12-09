namespace Спецодежда_СИЗ
{
    partial class Нормы_выдачи
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Нормы_выдачи));
            this.dataGridView9 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button46 = new System.Windows.Forms.Button();
            this.button48 = new System.Windows.Forms.Button();
            this.button49 = new System.Windows.Forms.Button();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.button50 = new System.Windows.Forms.Button();
            this.сИЗDataSet = new Спецодежда_СИЗ.СИЗDataSet();
            this.нормыВыдачиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.нормы_выдачиTableAdapter = new Спецодежда_СИЗ.СИЗDataSetTableAdapters.Нормы_выдачиTableAdapter();
            this.профессииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сИЗDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.нормыВыдачиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView9
            // 
            this.dataGridView9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView9.AutoGenerateColumns = false;
            this.dataGridView9.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView9.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView9.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.профессииDataGridViewTextBoxColumn});
            this.dataGridView9.DataSource = this.нормыВыдачиBindingSource;
            this.dataGridView9.Location = new System.Drawing.Point(7, 109);
            this.dataGridView9.Name = "dataGridView9";
            this.dataGridView9.RowTemplate.Height = 24;
            this.dataGridView9.Size = new System.Drawing.Size(1283, 588);
            this.dataGridView9.TabIndex = 73;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(236, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 30);
            this.button1.TabIndex = 72;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button46
            // 
            this.button46.Location = new System.Drawing.Point(344, 36);
            this.button46.Name = "button46";
            this.button46.Size = new System.Drawing.Size(107, 30);
            this.button46.TabIndex = 69;
            this.button46.Text = "Удалить";
            this.button46.UseVisualStyleBackColor = true;
            // 
            // button48
            // 
            this.button48.Location = new System.Drawing.Point(122, 36);
            this.button48.Name = "button48";
            this.button48.Size = new System.Drawing.Size(108, 30);
            this.button48.TabIndex = 70;
            this.button48.Text = "Изменить";
            this.button48.UseVisualStyleBackColor = true;
            // 
            // button49
            // 
            this.button49.Location = new System.Drawing.Point(7, 36);
            this.button49.Name = "button49";
            this.button49.Size = new System.Drawing.Size(109, 30);
            this.button49.TabIndex = 71;
            this.button49.Text = "Добавить";
            this.button49.UseVisualStyleBackColor = true;
            // 
            // textBox10
            // 
            this.textBox10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox10.Location = new System.Drawing.Point(73, 72);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(1222, 30);
            this.textBox10.TabIndex = 68;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label40.Location = new System.Drawing.Point(3, 73);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(64, 21);
            this.label40.TabIndex = 66;
            this.label40.Text = "Поиск";
            // 
            // label41
            // 
            this.label41.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label41.Location = new System.Drawing.Point(619, 9);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(143, 21);
            this.label41.TabIndex = 67;
            this.label41.Text = "Нормы выдачи";
            // 
            // button50
            // 
            this.button50.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button50.Location = new System.Drawing.Point(1429, 73);
            this.button50.Name = "button50";
            this.button50.Size = new System.Drawing.Size(32, 30);
            this.button50.TabIndex = 65;
            this.button50.UseVisualStyleBackColor = true;
            // 
            // сИЗDataSet
            // 
            this.сИЗDataSet.DataSetName = "СИЗDataSet";
            this.сИЗDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // нормыВыдачиBindingSource
            // 
            this.нормыВыдачиBindingSource.DataMember = "Нормы выдачи";
            this.нормыВыдачиBindingSource.DataSource = this.сИЗDataSet;
            // 
            // нормы_выдачиTableAdapter
            // 
            this.нормы_выдачиTableAdapter.ClearBeforeFill = true;
            // 
            // профессииDataGridViewTextBoxColumn
            // 
            this.профессииDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.профессииDataGridViewTextBoxColumn.DataPropertyName = "Профессии";
            this.профессииDataGridViewTextBoxColumn.HeaderText = "Профессии";
            this.профессииDataGridViewTextBoxColumn.Name = "профессииDataGridViewTextBoxColumn";
            this.профессииDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Нормы_выдачи
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 709);
            this.Controls.Add(this.dataGridView9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button46);
            this.Controls.Add(this.button48);
            this.Controls.Add(this.button49);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.button50);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Нормы_выдачи";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Нормы выдачи";
            this.Load += new System.EventHandler(this.Нормы_выдачи_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сИЗDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.нормыВыдачиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button46;
        private System.Windows.Forms.Button button48;
        private System.Windows.Forms.Button button49;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Button button50;
        private СИЗDataSet сИЗDataSet;
        private System.Windows.Forms.BindingSource нормыВыдачиBindingSource;
        private СИЗDataSetTableAdapters.Нормы_выдачиTableAdapter нормы_выдачиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn профессииDataGridViewTextBoxColumn;
    }
}