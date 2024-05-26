using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using HelixToolkit.Wpf;
using Hilbert3d;
using MathWorks.MATLAB.NET.Arrays;

namespace HilbertCurveConstructor.Logic
{
    public class CurveConstructor3D: ICurveConstructor
    {
        private List<double> listX, listY, listZ; // Списки для координат осей XYZ
        
        private HelixViewport3D helix = new HelixViewport3D(); //Экземпляр класса библиотеки для 3D графики

        private Class1 hilb;
        private ElementHost host;
        private int grade, thickness;
        private Panel panel;

        public void SetCurveParams(Class1 hilb, ElementHost host, int grade, int thickness,Panel panel) //Задача параметров 
        {                                                                                               //кривой
            this.hilb = hilb;
            this.host = host;
            this.grade = grade;
            this.thickness = thickness;
            this.panel = panel;
        }
        public void BuildCurve()
        {
            
            MWArray[] array = hilb.Hilbert(3,grade); // Использование функции из импортируемой dll
            MWNumericArray numericArrayX = (MWNumericArray)array[0];
            MWNumericArray numericArrayY = (MWNumericArray)array[1];
            MWNumericArray numericArrayZ = (MWNumericArray)array[2];
            double[,] arrayX = (double[,])numericArrayX.ToArray(MWArrayComponent.Real); //Преобразование результатов
            double[,] arrayY = (double[,])numericArrayY.ToArray(MWArrayComponent.Real); //вычисления координат
            double[,] arrayZ = (double[,])numericArrayZ.ToArray(MWArrayComponent.Real);
            
            Point3D point = new Point3D();
            LinesVisual3D line = new LinesVisual3D();
            
            listX = new List<double>();
            listY = new List<double>();
            listZ = new List<double>();
            
            for (int i = 0; i < arrayX.Length; i++) // Заполнение списков полученными координатами
            {
                listX.Add(arrayX[0, i]);
                listY.Add(arrayY[0, i]);
                listZ.Add(arrayZ[0, i]);
            }
            
            int counter = 0;
            for (int i = 0; i < arrayX.Length; i++) // Построение кривой в 3D поточечно и визуальная настройка
            {
                counter++;
                point.X = arrayX[0, i];
                point.Y = arrayY[0, i];
                point.Z = arrayZ[0, i];
                if (counter == 2)
                {
                    i--;
                    counter = 0;
                }
                line.Points.Add(point);
            }
            line.Color = Color.FromArgb(panel.BackColor.A, panel.BackColor.R, panel.BackColor.G, panel.BackColor.B);
            line.Thickness = thickness;
            helix.Children.Add(line);
            host.Child = helix;
        }

        public void Clear() // Очистка кривой
        {
            helix.Children.Clear();
        }
        
        public void ExcelExport(string path) // Экспорт в Excel-таблицу
        {
            ExcelManager.ExcelExport3D(listX, listY, listZ, path);
        }
    }
}