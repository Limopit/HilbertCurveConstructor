using System.ComponentModel;

namespace HilbertCurveConstructor.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экспортВExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dТочкиСГрафикомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dТочкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage2D = new System.Windows.Forms.TabPage();
            this.tabPage3D = new System.Windows.Forms.TabPage();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.thicnessLabel = new System.Windows.Forms.Label();
            this.thicnessNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.curveLabel = new System.Windows.Forms.Label();
            this.curveGradeUpDown = new System.Windows.Forms.NumericUpDown();
            this.buildButton = new System.Windows.Forms.Button();
            this.colorButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thicnessNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curveGradeUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(32, 19);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.fileMenuItem, this.infoMenuItem, this.toolStripMenuItem3 });
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "Меню";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.saveMenuItem, this.сохранитьToolStripMenuItem, this.экспортВExcelToolStripMenuItem });
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileMenuItem.Text = "Файл";
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.Name = "saveMenuItem";
            this.saveMenuItem.ShortcutKeyDisplayString = "Crtl+S";
            this.saveMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveMenuItem.Size = new System.Drawing.Size(250, 22);
            this.saveMenuItem.Text = "Сохранить изображение";
            this.saveMenuItem.Click += new System.EventHandler(this.saveMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // экспортВExcelToolStripMenuItem
            // 
            this.экспортВExcelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.dТочкиСГрафикомToolStripMenuItem, this.dТочкиToolStripMenuItem });
            this.экспортВExcelToolStripMenuItem.Name = "экспортВExcelToolStripMenuItem";
            this.экспортВExcelToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.экспортВExcelToolStripMenuItem.Text = "Экспорт в Excel";
            // 
            // dТочкиСГрафикомToolStripMenuItem
            // 
            this.dТочкиСГрафикомToolStripMenuItem.Name = "dТочкиСГрафикомToolStripMenuItem";
            this.dТочкиСГрафикомToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.dТочкиСГрафикомToolStripMenuItem.Text = "2D точки с графиком";
            this.dТочкиСГрафикомToolStripMenuItem.Click += new System.EventHandler(this.dТочкиСГрафикомToolStripMenuItem_Click);
            // 
            // dТочкиToolStripMenuItem
            // 
            this.dТочкиToolStripMenuItem.Name = "dТочкиToolStripMenuItem";
            this.dТочкиToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.dТочкиToolStripMenuItem.Text = "3D точки";
            this.dТочкиToolStripMenuItem.Click += new System.EventHandler(this.dТочкиToolStripMenuItem_Click);
            // 
            // infoMenuItem
            // 
            this.infoMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.оПрограммеToolStripMenuItem, this.помощьToolStripMenuItem });
            this.infoMenuItem.Name = "infoMenuItem";
            this.infoMenuItem.Size = new System.Drawing.Size(93, 20);
            this.infoMenuItem.Text = "Информация";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.помощьToolStripMenuItem.Text = "Помощь";
            this.помощьToolStripMenuItem.Click += new System.EventHandler(this.помощьToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(12, 20);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage2D);
            this.tabControl.Controls.Add(this.tabPage3D);
            this.tabControl.Location = new System.Drawing.Point(12, 27);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(520, 404);
            this.tabControl.TabIndex = 1;
            // 
            // tabPage2D
            // 
            this.tabPage2D.Location = new System.Drawing.Point(4, 22);
            this.tabPage2D.Name = "tabPage2D";
            this.tabPage2D.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2D.Size = new System.Drawing.Size(512, 378);
            this.tabPage2D.TabIndex = 0;
            this.tabPage2D.Text = "2D";
            this.tabPage2D.UseVisualStyleBackColor = true;
            // 
            // tabPage3D
            // 
            this.tabPage3D.Location = new System.Drawing.Point(4, 22);
            this.tabPage3D.Name = "tabPage3D";
            this.tabPage3D.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3D.Size = new System.Drawing.Size(512, 378);
            this.tabPage3D.TabIndex = 1;
            this.tabPage3D.Text = "3D";
            this.tabPage3D.UseVisualStyleBackColor = true;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.thicnessLabel);
            this.groupBox.Controls.Add(this.thicnessNumericUpDown);
            this.groupBox.Controls.Add(this.panel1);
            this.groupBox.Controls.Add(this.curveLabel);
            this.groupBox.Controls.Add(this.curveGradeUpDown);
            this.groupBox.Controls.Add(this.buildButton);
            this.groupBox.Controls.Add(this.colorButton);
            this.groupBox.Location = new System.Drawing.Point(538, 43);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(250, 355);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Настроить кривую";
            // 
            // thicnessLabel
            // 
            this.thicnessLabel.Location = new System.Drawing.Point(6, 109);
            this.thicnessLabel.Name = "thicnessLabel";
            this.thicnessLabel.Size = new System.Drawing.Size(120, 17);
            this.thicnessLabel.TabIndex = 8;
            this.thicnessLabel.Text = "Толщина линии(3D):";
            // 
            // thicnessNumericUpDown
            // 
            this.thicnessNumericUpDown.Location = new System.Drawing.Point(6, 129);
            this.thicnessNumericUpDown.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            this.thicnessNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.thicnessNumericUpDown.Name = "thicnessNumericUpDown";
            this.thicnessNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.thicnessNumericUpDown.TabIndex = 7;
            this.thicnessNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(164, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(44, 41);
            this.panel1.TabIndex = 6;
            // 
            // curveLabel
            // 
            this.curveLabel.Location = new System.Drawing.Point(6, 26);
            this.curveLabel.Name = "curveLabel";
            this.curveLabel.Size = new System.Drawing.Size(100, 17);
            this.curveLabel.TabIndex = 4;
            this.curveLabel.Text = "Порядок кривой:";
            // 
            // curveGradeUpDown
            // 
            this.curveGradeUpDown.Location = new System.Drawing.Point(6, 46);
            this.curveGradeUpDown.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            this.curveGradeUpDown.Name = "curveGradeUpDown";
            this.curveGradeUpDown.Size = new System.Drawing.Size(120, 20);
            this.curveGradeUpDown.TabIndex = 3;
            // 
            // buildButton
            // 
            this.buildButton.Location = new System.Drawing.Point(6, 167);
            this.buildButton.Name = "buildButton";
            this.buildButton.Size = new System.Drawing.Size(75, 23);
            this.buildButton.TabIndex = 1;
            this.buildButton.Text = "Построить";
            this.buildButton.UseVisualStyleBackColor = true;
            this.buildButton.Click += new System.EventHandler(this.buildButton_Click);
            // 
            // colorButton
            // 
            this.colorButton.Location = new System.Drawing.Point(6, 72);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(140, 23);
            this.colorButton.TabIndex = 0;
            this.colorButton.Text = "Выбрать цвет кривой";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(538, 404);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(713, 404);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Выйти";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(0, 0);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 443);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
            this.Location = new System.Drawing.Point(15, 15);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Кривые Гильберта";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.thicnessNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.curveGradeUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.SaveFileDialog saveFileDialog2;

        private System.Windows.Forms.ToolStripMenuItem dТочкиСГрафикомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dТочкиToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem экспортВExcelToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;

        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;

        private System.Windows.Forms.Button clearButton;

        private System.Windows.Forms.NumericUpDown thicnessNumericUpDown;
        private System.Windows.Forms.Label thicnessLabel;

        private System.Windows.Forms.Integration.ElementHost elementHost1;

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;

        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;

        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.NumericUpDown curveGradeUpDown;
        private System.Windows.Forms.Label curveLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ColorDialog colorDialog1;

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage2D;
        private System.Windows.Forms.TabPage tabPage3D;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.Button buildButton;

        private System.Windows.Forms.ToolStripMenuItem infoMenuItem;

        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;

        private System.Windows.Forms.MenuStrip menuStrip;

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;

        #endregion
    }
}