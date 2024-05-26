using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using HilbertCurveConstructor.Logic;
using ScottPlot.WinForms;
using SkiaSharp.Views.Desktop;

namespace HilbertCurveConstructor.Forms
{
    public partial class MainForm : Form
    {
        private AboutForm aboutForm;
        private FormsPlot plot;
        private Hilbert2d.Class1 hilb2d;
        private Hilbert3d.Class1 hilb3d;
        private ElementHost host;
        private static bool isSaved;
        public static bool isLoaded;
        
        INIManager manager = new INIManager("data.ini");
        private CurveConstructor2D constructor2D;
        private CurveConstructor3D constructor3D;
        public MainForm()
        {
            InitializeComponent();
            restore(); // Восстановление из INI-файла

            try // Проверка корректной инициализации классов Matlab
            {
                hilb2d = new Hilbert2d.Class1();
                hilb3d = new Hilbert3d.Class1();
                isLoaded = true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка: " + e.Message);
            }

            constructor2D = new CurveConstructor2D();
            constructor3D = new CurveConstructor3D();

            saveFileDialog1.Filter = "Excel Files|*.xlsx";
            saveFileDialog2.Filter = "PNG Files|*.png";
            
            plot = new FormsPlot(); // Инициализация и настройка поля 2D графика
            plot.Height = 378;
            plot.Width = 512;
            plot.Menu.Add("Экспорт в Excel", (plot) =>
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) return;
                string filename = saveFileDialog1.FileName;
                constructor2D.ExcelExport(filename);
            });
            tabControl.TabPages[0].Controls.Add(plot);
            
            aboutForm = new AboutForm();
            
            host = new ElementHost(); // Инициализация и настройка поля 3D графика
            host.Dock = DockStyle.Fill;
            tabControl.TabPages[1].Controls.Add(host);
            
        }
        
        private void colorButton_Click(object sender, EventArgs e) // Обработчик нажатия на кнопку выбора цвета
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel) return;
            panel1.BackColor = colorDialog1.Color;
        }

        private void buildButton_Click(object sender, EventArgs e) // Обработчик нажатия на кнопку построения
        {
            constructor2D.SetCurveParams(hilb2d, plot , (int)curveGradeUpDown.Value, panel1.BackColor.ToSKColor());
            constructor3D.SetCurveParams(hilb3d, host, (int)curveGradeUpDown.Value,(int)thicnessNumericUpDown.Value,panel1);
            constructor2D.BuildCurve();
            constructor3D.BuildCurve();
            
        }

        private void closeButton_Click(object sender, EventArgs e) // Обработчик нажатия на кнопку выхода
        {
            if (!isSaved)
            {
                manager.Write("main", null, null);
            }
            Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e) // Обработчик меню "О программе"
        {
            aboutForm.Show();
        }

        private void saveMenuItem_Click(object sender, EventArgs e) // Обработчик меню "Сохранить изображение"
        {
            if (saveFileDialog2.ShowDialog() == DialogResult.Cancel) return;
            string filename = saveFileDialog2.FileName;
            plot.Plot.SavePng(filename, 500, 500);
            
        }

        private void clearButton_Click(object sender, EventArgs e) // Обработчик нажатия на кнопку очистки
        {
            constructor2D.Clear();
            constructor3D.Clear();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e) // Обработчик меню "Сохранить"
        {
            isSaved = true;
            manager.Write("main", "grade", curveGradeUpDown.Value.ToString());
            manager.Write("main", "thickness", thicnessNumericUpDown.Value.ToString());
            manager.Write("color", "a", panel1.BackColor.A.ToString());
            manager.Write("color", "r", panel1.BackColor.R.ToString());
            manager.Write("color", "g", panel1.BackColor.G.ToString());
            manager.Write("color", "b", panel1.BackColor.B.ToString());
        }

        private void restore() // Функция восстановления из INI-файла
        {
            try
            {
                curveGradeUpDown.Value = Int32.Parse(manager.ReadINI("main", "grade"));
                thicnessNumericUpDown.Value = Int32.Parse(manager.ReadINI("main", "thickness"));
                var A = Int32.Parse(manager.ReadINI("color", "a"));
                var R = Int32.Parse(manager.ReadINI("color", "r"));
                var G = Int32.Parse(manager.ReadINI("color", "g"));
                var B = Int32.Parse(manager.ReadINI("color", "b"));
                panel1.BackColor = Color.FromArgb(A, R, G, B);
            }
            catch{}
        }
        
        private void dТочкиСГрафикомToolStripMenuItem_Click(object sender, EventArgs e) // Обработчик меню 2D экспорта
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            string filename = saveFileDialog1.FileName;
            constructor2D.ExcelExport(filename);
            
        }

        private void dТочкиToolStripMenuItem_Click(object sender, EventArgs e) // Обработчик меню 3D экспорта
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            string filename = saveFileDialog1.FileName;
            constructor3D.ExcelExport(filename);
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e) // Обработчик меню "Помощь"
        {
            try
            {
                string chmFilePath = @"D:/HilbertCurveConstructor/HilbertCurveConstructor/resources/HilbertHelp.chm";

                Process.Start(chmFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
    }
}