using System.Collections.Generic;
using Hilbert2d;
using MathWorks.MATLAB.NET.Arrays;
using ScottPlot;
using ScottPlot.WinForms;
using SkiaSharp;

namespace HilbertCurveConstructor.Logic
{
    public class CurveConstructor2D : ICurveConstructor
    {
        private List<double> listX = new List<double>(); // Список координат для оси X
        private List<double> listY = new List<double>(); // Список координат для оси Y
        
        private Class1 hilb;
        private FormsPlot plot;
        private int grade;
        private SKColor color;

        public void SetCurveParams(Class1 hilb, FormsPlot plot, int grade,SKColor color) // Задача параметров кривой
        {
            this.hilb = hilb;
            this.plot = plot;
            this.grade = grade;
            this.color = color;
        }
        
        public void BuildCurve() // Функция построения кривой
        {
            MWArray[] array = hilb.Hilbert2d(2,grade); // Использование функции из импортируемой dll
            MWNumericArray numericArrayX = (MWNumericArray)array[0];
            MWNumericArray numericArrayY = (MWNumericArray)array[1];                   //Преобразование результатов
            double[,] arrayX = (double[,])numericArrayX.ToArray(MWArrayComponent.Real);//вычисления координат
            double[,] arrayY = (double[,])numericArrayY.ToArray(MWArrayComponent.Real);

            listX = new List<double>();
            listY = new List<double>();
            
            for (int i = 0; i < arrayX.Length; i++) // Заполнение списков полученными координатами
            {
                listX.Add(arrayX[0, i]);
                listY.Add(arrayY[0, i]);
            }
            
            plot.Plot.Add.Scatter(listX, listY, Color.FromSKColor(color)); // Построение графика
            plot.Plot.Axes.AutoScale();
            plot.Refresh();
        }

        public void Clear() // Функция очистки графика
        {
            plot.Plot.Clear();
            plot.Refresh();
        }

        public void ExcelExport(string path) // Функция экспорта результатов в Excel-таблицу
        {
            ExcelManager.ExcelExport(listX,listY, path);
        }
    }
}