namespace Programming
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxCars = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вывестиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonModify = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRemove = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLoad = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonProceed = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripModelName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripManufacturerName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripFuelConsumption = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripWeight = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonProceed = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.mostEfficientCarTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxCars
            // 
            this.listBoxCars.FormattingEnabled = true;
            this.listBoxCars.ItemHeight = 15;
            this.listBoxCars.Location = new System.Drawing.Point(12, 67);
            this.listBoxCars.Name = "listBoxCars";
            this.listBoxCars.Size = new System.Drawing.Size(256, 259);
            this.listBoxCars.TabIndex = 1;
            this.listBoxCars.SelectedIndexChanged += new System.EventHandler(this.listBoxCars_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Список &автомобилей";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(274, 67);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(95, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "&Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Enabled = false;
            this.buttonRemove.Location = new System.Drawing.Point(274, 125);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(95, 23);
            this.buttonRemove.TabIndex = 3;
            this.buttonRemove.Text = "&Удалить";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonModify
            // 
            this.buttonModify.Enabled = false;
            this.buttonModify.Location = new System.Drawing.Point(274, 96);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(95, 23);
            this.buttonModify.TabIndex = 4;
            this.buttonModify.Text = "&Изменить";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.действияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(667, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // действияToolStripMenuItem
            // 
            this.действияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.вывестиToolStripMenuItem});
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.действияToolStripMenuItem.Text = "Действия...";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить...";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Enabled = false;
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.изменитьToolStripMenuItem.Text = "Изменить...";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Enabled = false;
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить...";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить...";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Enabled = false;
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить...";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // вывестиToolStripMenuItem
            // 
            this.вывестиToolStripMenuItem.Enabled = false;
            this.вывестиToolStripMenuItem.Name = "вывестиToolStripMenuItem";
            this.вывестиToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.вывестиToolStripMenuItem.Text = "Вывести...";
            this.вывестиToolStripMenuItem.Click += new System.EventHandler(this.вывестиToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAdd,
            this.toolStripButtonModify,
            this.toolStripButtonRemove,
            this.toolStripButtonLoad,
            this.toolStripButtonSave,
            this.toolStripButtonProceed});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(667, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonAdd
            // 
            this.toolStripButtonAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAdd.Image = global::Programming.Properties.Resources.more;
            this.toolStripButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdd.Name = "toolStripButtonAdd";
            this.toolStripButtonAdd.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAdd.Text = "toolStripButton1";
            this.toolStripButtonAdd.Click += new System.EventHandler(this.toolStripButtonAdd_Click);
            // 
            // toolStripButtonModify
            // 
            this.toolStripButtonModify.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonModify.Enabled = false;
            this.toolStripButtonModify.Image = global::Programming.Properties.Resources.pencil;
            this.toolStripButtonModify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonModify.Name = "toolStripButtonModify";
            this.toolStripButtonModify.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonModify.Text = "toolStripButton2";
            this.toolStripButtonModify.Click += new System.EventHandler(this.toolStripButtonModify_Click);
            // 
            // toolStripButtonRemove
            // 
            this.toolStripButtonRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRemove.Enabled = false;
            this.toolStripButtonRemove.Image = global::Programming.Properties.Resources.close;
            this.toolStripButtonRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRemove.Name = "toolStripButtonRemove";
            this.toolStripButtonRemove.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRemove.Text = "toolStripButton3";
            this.toolStripButtonRemove.Click += new System.EventHandler(this.toolStripButtonRemove_Click);
            // 
            // toolStripButtonLoad
            // 
            this.toolStripButtonLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonLoad.Image = global::Programming.Properties.Resources.up_arrow;
            this.toolStripButtonLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLoad.Name = "toolStripButtonLoad";
            this.toolStripButtonLoad.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonLoad.Text = "toolStripButton4";
            this.toolStripButtonLoad.Click += new System.EventHandler(this.toolStripButtonLoad_Click);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSave.Enabled = false;
            this.toolStripButtonSave.Image = global::Programming.Properties.Resources.down;
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSave.Text = "toolStripButton5";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // toolStripButtonProceed
            // 
            this.toolStripButtonProceed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonProceed.Enabled = false;
            this.toolStripButtonProceed.Image = global::Programming.Properties.Resources.list;
            this.toolStripButtonProceed.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonProceed.Name = "toolStripButtonProceed";
            this.toolStripButtonProceed.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonProceed.Text = "toolStripButton6";
            this.toolStripButtonProceed.Click += new System.EventHandler(this.toolStripButtonProceed_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripModelName,
            this.toolStripManufacturerName,
            this.toolStripFuelConsumption,
            this.toolStripWeight});
            this.statusStrip1.Location = new System.Drawing.Point(0, 338);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(667, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripFactoryName
            // 
            this.toolStripModelName.Name = "toolStripFactoryName";
            this.toolStripModelName.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripChefSurname
            // 
            this.toolStripManufacturerName.Name = "toolStripChefSurname";
            this.toolStripManufacturerName.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripItemsType
            // 
            this.toolStripFuelConsumption.Name = "toolStripItemsType";
            this.toolStripFuelConsumption.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripIncome
            // 
            this.toolStripWeight.Name = "toolStripIncome";
            this.toolStripWeight.Size = new System.Drawing.Size(0, 17);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(274, 245);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(95, 23);
            this.buttonLoad.TabIndex = 8;
            this.buttonLoad.Text = "Загрузить";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(274, 274);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(95, 23);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonProceed
            // 
            this.buttonProceed.Enabled = false;
            this.buttonProceed.Location = new System.Drawing.Point(274, 303);
            this.buttonProceed.Name = "buttonProceed";
            this.buttonProceed.Size = new System.Drawing.Size(95, 23);
            this.buttonProceed.TabIndex = 8;
            this.buttonProceed.Text = "Вывести";
            this.buttonProceed.UseVisualStyleBackColor = true;
            this.buttonProceed.Click += new System.EventHandler(this.buttonProceed_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Самый экономичный автомобиль";
            // 
            // mostEfficientCarTextBox
            // 
            this.mostEfficientCarTextBox.Location = new System.Drawing.Point(375, 68);
            this.mostEfficientCarTextBox.Name = "mostEfficientCarTextBox";
            this.mostEfficientCarTextBox.ReadOnly = true;
            this.mostEfficientCarTextBox.Size = new System.Drawing.Size(280, 23);
            this.mostEfficientCarTextBox.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 360);
            this.Controls.Add(this.mostEfficientCarTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonProceed);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxCars);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Куницин Д.С. - задание 4 - вариант 22";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBoxCars;
        private Label label1;
        private Button buttonAdd;
        private Button buttonRemove;
        private Button buttonModify;
        private MenuStrip menuStrip1;
        private ToolStrip toolStrip1;
        private StatusStrip statusStrip1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Button buttonLoad;
        private Button buttonSave;
        private Button buttonProceed;
        private ToolStripButton toolStripButtonAdd;
        private ToolStripButton toolStripButtonModify;
        private ToolStripButton toolStripButtonRemove;
        private ToolStripButton toolStripButtonLoad;
        private ToolStripButton toolStripButtonSave;
        private ToolStripButton toolStripButtonProceed;
        private ToolStripMenuItem действияToolStripMenuItem;
        private ToolStripMenuItem добавитьToolStripMenuItem;
        private ToolStripMenuItem изменитьToolStripMenuItem;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private ToolStripMenuItem загрузитьToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem вывестиToolStripMenuItem;
        private Label label2;
        private ToolStripStatusLabel toolStripModelName;
        private ToolStripStatusLabel toolStripManufacturerName;
        private ToolStripStatusLabel toolStripFuelConsumption;
        private ToolStripStatusLabel toolStripWeight;
        private TextBox mostEfficientCarTextBox;
    }
}