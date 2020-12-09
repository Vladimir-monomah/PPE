namespace Спецодежда_СИЗ.КарточкаСотрудника
{
    partial class Должности
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Должности));
            this.positionDataGridView = new System.Windows.Forms.DataGridView();
            this.positionFilterTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.сИЗDataSet = new Спецодежда_СИЗ.СИЗDataSet();
            this.должностиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.должностиTableAdapter = new Спецодежда_СИЗ.СИЗDataSetTableAdapters.ДолжностиTableAdapter();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button12 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.positionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сИЗDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // positionDataGridView
            // 
            this.positionDataGridView.AllowUserToAddRows = false;
            this.positionDataGridView.AllowUserToDeleteRows = false;
            this.positionDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.positionDataGridView.AutoGenerateColumns = false;
            this.positionDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.positionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.positionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.названиеDataGridViewTextBoxColumn});
            this.positionDataGridView.DataSource = this.должностиBindingSource;
            this.positionDataGridView.Location = new System.Drawing.Point(12, 42);
            this.positionDataGridView.Name = "positionDataGridView";
            this.positionDataGridView.ReadOnly = true;
            this.positionDataGridView.RowTemplate.Height = 24;
            this.positionDataGridView.Size = new System.Drawing.Size(855, 506);
            this.positionDataGridView.TabIndex = 16;
            this.positionDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.positionDataGridView_CellDoubleClick);
            // 
            // positionFilterTextBox
            // 
            this.positionFilterTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.positionFilterTextBox.Location = new System.Drawing.Point(80, 6);
            this.positionFilterTextBox.MaxLength = 30;
            this.positionFilterTextBox.Multiline = true;
            this.positionFilterTextBox.Name = "positionFilterTextBox";
            this.positionFilterTextBox.Size = new System.Drawing.Size(749, 30);
            this.positionFilterTextBox.TabIndex = 15;
            this.positionFilterTextBox.TextChanged += new System.EventHandler(this.positionFilterTextBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(10, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 21);
            this.label9.TabIndex = 14;
            this.label9.Text = "Поиск";
            // 
            // сИЗDataSet
            // 
            this.сИЗDataSet.DataSetName = "СИЗDataSet";
            this.сИЗDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // должностиBindingSource
            // 
            this.должностиBindingSource.DataMember = "Должности";
            this.должностиBindingSource.DataSource = this.сИЗDataSet;
            // 
            // должностиTableAdapter
            // 
            this.должностиTableAdapter.ClearBeforeFill = true;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            this.названиеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // button12
            // 
            this.button12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button12.Image = global::Спецодежда_СИЗ.Properties.Resources.кнопка_3;
            this.button12.Location = new System.Drawing.Point(835, 2);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(32, 30);
            this.button12.TabIndex = 13;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // Должности
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 560);
            this.Controls.Add(this.positionDataGridView);
            this.Controls.Add(this.positionFilterTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button12);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Должности";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Должности";
            this.Load += new System.EventHandler(this.Должности_Load);
            ((System.ComponentModel.ISupportInitialize)(this.positionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сИЗDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView positionDataGridView;
        private System.Windows.Forms.TextBox positionFilterTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button12;
        private СИЗDataSet сИЗDataSet;
        private System.Windows.Forms.BindingSource должностиBindingSource;
        private СИЗDataSetTableAdapters.ДолжностиTableAdapter должностиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
    }
}