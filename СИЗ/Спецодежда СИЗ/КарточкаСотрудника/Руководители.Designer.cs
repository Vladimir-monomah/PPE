namespace Спецодежда_СИЗ.КарточкаСотрудника
{
    partial class Руководители
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Руководители));
            this.headDataGridView = new System.Windows.Forms.DataGridView();
            this.headFilterTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.button38 = new System.Windows.Forms.Button();
            this.сИЗDataSet = new Спецодежда_СИЗ.СИЗDataSet();
            this.руководителиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.руководителиTableAdapter = new Спецодежда_СИЗ.СИЗDataSetTableAdapters.РуководителиTableAdapter();
            this.ФИО = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.headDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сИЗDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.руководителиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // headDataGridView
            // 
            this.headDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headDataGridView.AutoGenerateColumns = false;
            this.headDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.headDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.headDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ФИО});
            this.headDataGridView.DataSource = this.руководителиBindingSource;
            this.headDataGridView.Location = new System.Drawing.Point(12, 45);
            this.headDataGridView.Name = "headDataGridView";
            this.headDataGridView.RowTemplate.Height = 24;
            this.headDataGridView.Size = new System.Drawing.Size(865, 445);
            this.headDataGridView.TabIndex = 46;
            this.headDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.headDataGridView_CellDoubleClick);
            // 
            // headFilterTextBox
            // 
            this.headFilterTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headFilterTextBox.Location = new System.Drawing.Point(80, 9);
            this.headFilterTextBox.MaxLength = 30;
            this.headFilterTextBox.Multiline = true;
            this.headFilterTextBox.Name = "headFilterTextBox";
            this.headFilterTextBox.Size = new System.Drawing.Size(759, 30);
            this.headFilterTextBox.TabIndex = 45;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(10, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 21);
            this.label16.TabIndex = 44;
            this.label16.Text = "Поиск";
            // 
            // button38
            // 
            this.button38.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button38.Image = global::Спецодежда_СИЗ.Properties.Resources.кнопка_3;
            this.button38.Location = new System.Drawing.Point(845, 7);
            this.button38.Name = "button38";
            this.button38.Size = new System.Drawing.Size(32, 30);
            this.button38.TabIndex = 43;
            this.button38.UseVisualStyleBackColor = true;
            this.button38.Click += new System.EventHandler(this.button38_Click);
            // 
            // сИЗDataSet
            // 
            this.сИЗDataSet.DataSetName = "СИЗDataSet";
            this.сИЗDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // руководителиBindingSource
            // 
            this.руководителиBindingSource.DataMember = "Руководители";
            this.руководителиBindingSource.DataSource = this.сИЗDataSet;
            // 
            // руководителиTableAdapter
            // 
            this.руководителиTableAdapter.ClearBeforeFill = true;
            // 
            // ФИО
            // 
            this.ФИО.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ФИО.DataPropertyName = "ФИО";
            this.ФИО.HeaderText = "ФИО";
            this.ФИО.Name = "ФИО";
            this.ФИО.ReadOnly = true;
            // 
            // Руководители
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 502);
            this.Controls.Add(this.headDataGridView);
            this.Controls.Add(this.headFilterTextBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.button38);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Руководители";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Руководители";
            this.Load += new System.EventHandler(this.Руководители_Load);
            ((System.ComponentModel.ISupportInitialize)(this.headDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сИЗDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.руководителиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView headDataGridView;
        private System.Windows.Forms.TextBox headFilterTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button38;
        private СИЗDataSet сИЗDataSet;
        private System.Windows.Forms.BindingSource руководителиBindingSource;
        private СИЗDataSetTableAdapters.РуководителиTableAdapter руководителиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ФИО;
    }
}