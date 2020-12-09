namespace Спецодежда_СИЗ
{
    partial class Работа_внутри_БД
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Работа_внутри_БД));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.панельИнструментовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.восстановитьБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.карточкиСотрудниковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.типыНоменклатурыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.должностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.руководителиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отделыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ведомостиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ведомостьНаВыдачуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.документацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.видToolStripMenuItem,
            this.справочникиToolStripMenuItem,
            this.ведомостиToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.панельИнструментовToolStripMenuItem,
            this.восстановитьБДToolStripMenuItem});
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.видToolStripMenuItem.Text = "Настройка";
            // 
            // панельИнструментовToolStripMenuItem
            // 
            this.панельИнструментовToolStripMenuItem.Name = "панельИнструментовToolStripMenuItem";
            this.панельИнструментовToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.панельИнструментовToolStripMenuItem.Text = "Сохранить БД";
            this.панельИнструментовToolStripMenuItem.Click += new System.EventHandler(this.панельИнструментовToolStripMenuItem_Click);
            // 
            // восстановитьБДToolStripMenuItem
            // 
            this.восстановитьБДToolStripMenuItem.Name = "восстановитьБДToolStripMenuItem";
            this.восстановитьБДToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.восстановитьБДToolStripMenuItem.Text = "Восстановить БД";
            this.восстановитьБДToolStripMenuItem.Click += new System.EventHandler(this.восстановитьБДToolStripMenuItem_Click);
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.карточкиСотрудниковToolStripMenuItem,
            this.toolStripMenuItem4,
            this.типыНоменклатурыToolStripMenuItem,
            this.toolStripMenuItem5,
            this.должностиToolStripMenuItem,
            this.руководителиToolStripMenuItem,
            this.отделыToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // карточкиСотрудниковToolStripMenuItem
            // 
            this.карточкиСотрудниковToolStripMenuItem.Image = global::Спецодежда_СИЗ.Properties.Resources.unnamed;
            this.карточкиСотрудниковToolStripMenuItem.Name = "карточкиСотрудниковToolStripMenuItem";
            this.карточкиСотрудниковToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.карточкиСотрудниковToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.карточкиСотрудниковToolStripMenuItem.Text = "Карточки сотрудников";
            this.карточкиСотрудниковToolStripMenuItem.Click += new System.EventHandler(this.AddTabControl);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(288, 6);
            // 
            // типыНоменклатурыToolStripMenuItem
            // 
            this.типыНоменклатурыToolStripMenuItem.Image = global::Спецодежда_СИЗ.Properties.Resources._1200x630bb;
            this.типыНоменклатурыToolStripMenuItem.Name = "типыНоменклатурыToolStripMenuItem";
            this.типыНоменклатурыToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.типыНоменклатурыToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.типыНоменклатурыToolStripMenuItem.Text = "Типы номенклатуры";
            this.типыНоменклатурыToolStripMenuItem.Click += new System.EventHandler(this.AddTabControl);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(288, 6);
            // 
            // должностиToolStripMenuItem
            // 
            this.должностиToolStripMenuItem.Image = global::Спецодежда_СИЗ.Properties.Resources.Notary_icon;
            this.должностиToolStripMenuItem.Name = "должностиToolStripMenuItem";
            this.должностиToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.должностиToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.должностиToolStripMenuItem.Text = "Должности";
            this.должностиToolStripMenuItem.Click += new System.EventHandler(this.AddTabControl);
            // 
            // руководителиToolStripMenuItem
            // 
            this.руководителиToolStripMenuItem.Image = global::Спецодежда_СИЗ.Properties.Resources._1_1;
            this.руководителиToolStripMenuItem.Name = "руководителиToolStripMenuItem";
            this.руководителиToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4)));
            this.руководителиToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.руководителиToolStripMenuItem.Text = "Руководители";
            this.руководителиToolStripMenuItem.Click += new System.EventHandler(this.AddTabControl);
            // 
            // отделыToolStripMenuItem
            // 
            this.отделыToolStripMenuItem.Image = global::Спецодежда_СИЗ.Properties.Resources.kissclipart_cl_be34af16619f6e29;
            this.отделыToolStripMenuItem.Name = "отделыToolStripMenuItem";
            this.отделыToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D5)));
            this.отделыToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.отделыToolStripMenuItem.Text = "Отделы";
            this.отделыToolStripMenuItem.Click += new System.EventHandler(this.AddTabControl);
            // 
            // ведомостиToolStripMenuItem
            // 
            this.ведомостиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ведомостьНаВыдачуToolStripMenuItem});
            this.ведомостиToolStripMenuItem.Name = "ведомостиToolStripMenuItem";
            this.ведомостиToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.ведомостиToolStripMenuItem.Text = "Ведомости";
            // 
            // ведомостьНаВыдачуToolStripMenuItem
            // 
            this.ведомостьНаВыдачуToolStripMenuItem.Image = global::Спецодежда_СИЗ.Properties.Resources.ведомость_на_выдачу;
            this.ведомостьНаВыдачуToolStripMenuItem.Name = "ведомостьНаВыдачуToolStripMenuItem";
            this.ведомостьНаВыдачуToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.ведомостьНаВыдачуToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.ведомостьНаВыдачуToolStripMenuItem.Text = "Ведомость на выдачу";
            this.ведомостьНаВыдачуToolStripMenuItem.Click += new System.EventHandler(this.AddTabControl);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.документацияToolStripMenuItem,
            this.toolStripMenuItem9,
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // документацияToolStripMenuItem
            // 
            this.документацияToolStripMenuItem.Image = global::Спецодежда_СИЗ.Properties.Resources._285_2852814_swim_ring_clipart_swim_ring_clipart_png;
            this.документацияToolStripMenuItem.Name = "документацияToolStripMenuItem";
            this.документацияToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.документацияToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.документацияToolStripMenuItem.Text = "Помощь";
            this.документацияToolStripMenuItem.Click += new System.EventHandler(this.документацияToolStripMenuItem_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(233, 6);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Image = global::Спецодежда_СИЗ.Properties.Resources.christmas_star;
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Controls.Add(this.pictureBox2);
            this.panel.Location = new System.Drawing.Point(0, 31);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(800, 53);
            this.panel.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = global::Спецодежда_СИЗ.Properties.Resources.customer_vector_3;
            this.pictureBox2.Location = new System.Drawing.Point(12, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.AddTabControl);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl.Location = new System.Drawing.Point(0, 90);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(788, 348);
            this.tabControl.TabIndex = 2;
            this.tabControl.Visible = false;
            this.tabControl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl_MouseClick);
            // 
            // Работа_внутри_БД
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Работа_внутри_БД";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спецодежда СИЗ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Работа_внутри_БД_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem панельИнструментовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ведомостиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem карточкиСотрудниковToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem должностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem руководителиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ведомостьНаВыдачуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem документацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.ToolStripMenuItem типыНоменклатурыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem восстановитьБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отделыToolStripMenuItem;
    }
}