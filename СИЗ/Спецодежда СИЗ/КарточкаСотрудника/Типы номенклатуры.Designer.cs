namespace Спецодежда_СИЗ.КарточкаСотрудника
{
    partial class Типы_номенклатуры
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Типы_номенклатуры));
            this.label19 = new System.Windows.Forms.Label();
            this.dataGridView8 = new System.Windows.Forms.DataGridView();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.срокПолезногоИспользованияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типыНоменклатурыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сИЗDataSet = new Спецодежда_СИЗ.СИЗDataSet();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.button43 = new System.Windows.Forms.Button();
            this.типы_номенклатурыTableAdapter = new Спецодежда_СИЗ.СИЗDataSetTableAdapters.Типы_номенклатурыTableAdapter();
            this.addNomenclButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.типыНоменклатурыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сИЗDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(600, 9);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(192, 21);
            this.label19.TabIndex = 50;
            this.label19.Text = "Типы номенклатуры";
            // 
            // dataGridView8
            // 
            this.dataGridView8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView8.AutoGenerateColumns = false;
            this.dataGridView8.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView8.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView8.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.наименованиеDataGridViewTextBoxColumn,
            this.срокПолезногоИспользованияDataGridViewTextBoxColumn});
            this.dataGridView8.DataSource = this.типыНоменклатурыBindingSource;
            this.dataGridView8.Location = new System.Drawing.Point(13, 69);
            this.dataGridView8.Name = "dataGridView8";
            this.dataGridView8.RowTemplate.Height = 24;
            this.dataGridView8.Size = new System.Drawing.Size(1368, 561);
            this.dataGridView8.TabIndex = 55;
            this.dataGridView8.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView8_CellDoubleClick);
            // 
            // наименованиеDataGridViewTextBoxColumn
            // 
            this.наименованиеDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.Name = "наименованиеDataGridViewTextBoxColumn";
            this.наименованиеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // срокПолезногоИспользованияDataGridViewTextBoxColumn
            // 
            this.срокПолезногоИспользованияDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.срокПолезногоИспользованияDataGridViewTextBoxColumn.DataPropertyName = "Срок полезного использования";
            this.срокПолезногоИспользованияDataGridViewTextBoxColumn.HeaderText = "Срок полезного использования";
            this.срокПолезногоИспользованияDataGridViewTextBoxColumn.Name = "срокПолезногоИспользованияDataGridViewTextBoxColumn";
            this.срокПолезногоИспользованияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // типыНоменклатурыBindingSource
            // 
            this.типыНоменклатурыBindingSource.DataMember = "Типы номенклатуры";
            this.типыНоменклатурыBindingSource.DataSource = this.сИЗDataSet;
            // 
            // сИЗDataSet
            // 
            this.сИЗDataSet.DataSetName = "СИЗDataSet";
            this.сИЗDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox8
            // 
            this.textBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox8.Location = new System.Drawing.Point(81, 33);
            this.textBox8.MaxLength = 30;
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(1263, 30);
            this.textBox8.TabIndex = 54;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(11, 34);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 21);
            this.label18.TabIndex = 53;
            this.label18.Text = "Поиск";
            // 
            // button43
            // 
            this.button43.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button43.Image = global::Спецодежда_СИЗ.Properties.Resources.кнопка_3;
            this.button43.Location = new System.Drawing.Point(1350, 31);
            this.button43.Name = "button43";
            this.button43.Size = new System.Drawing.Size(31, 30);
            this.button43.TabIndex = 52;
            this.button43.UseVisualStyleBackColor = true;
            // 
            // типы_номенклатурыTableAdapter
            // 
            this.типы_номенклатурыTableAdapter.ClearBeforeFill = true;
            // 
            // addNomenclButton
            // 
            this.addNomenclButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addNomenclButton.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNomenclButton.Location = new System.Drawing.Point(1121, 636);
            this.addNomenclButton.Name = "addNomenclButton";
            this.addNomenclButton.Size = new System.Drawing.Size(127, 48);
            this.addNomenclButton.TabIndex = 56;
            this.addNomenclButton.Text = "Добавить";
            this.addNomenclButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(1254, 636);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(127, 48);
            this.cancelButton.TabIndex = 57;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // Типы_номенклатуры
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 696);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addNomenclButton);
            this.Controls.Add(this.dataGridView8);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.button43);
            this.Controls.Add(this.label19);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Типы_номенклатуры";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Типы номенклатуры";
            this.Load += new System.EventHandler(this.Типы_номенклатуры_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.типыНоменклатурыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сИЗDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridView dataGridView8;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button43;
        private СИЗDataSet сИЗDataSet;
        private System.Windows.Forms.BindingSource типыНоменклатурыBindingSource;
        private СИЗDataSetTableAdapters.Типы_номенклатурыTableAdapter типы_номенклатурыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn срокПолезногоИспользованияDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button addNomenclButton;
        private System.Windows.Forms.Button cancelButton;
    }
}