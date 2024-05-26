using System;
using System.Collections.Generic;
using System.Windows;
using Spire.Xls;

namespace HilbertCurveConstructor.Logic
{
    public static class ExcelManager
    {
        public static void ExcelExport(List<double> listX, List<double> listY, string path)
        {
            try
            {
                Workbook workbook = new Workbook(); // Создание новой книги
                workbook.Worksheets.Clear();
                workbook.Worksheets.Add("hilbert");
                Worksheet worksheet = workbook.Worksheets[0]; // Выбор первого листа для работы

                //Запись данных в определенные ячейки
                worksheet.Range[1, 1].Value = "X";
                worksheet.Range[2, 1].Value = "Y";
                worksheet.InsertArray(listX.ToArray(), 1, 2, false);
                worksheet.InsertArray(listY.ToArray(), 2, 2, false);
                int index = worksheet.LastColumn;
                //Автоматическая подгонка ширины столбцов
                worksheet.AllocatedRange.AutoFitColumns();

                //Применение стиля к первой строке
                CellStyle style = workbook.Styles.Add("newStyle");
                style.Font.IsBold = true;
                worksheet.Range[1, 1, 1, 4].Style = style;
            
                // Начало создания графика
                Chart chart = worksheet.Charts.Add();
                chart.ChartType = ExcelChartType.ScatterLineMarkers; // Выбор типа графика
            
                // Заполнение графика даннными
                chart.Series.Add();
                chart.Series[0].CategoryLabels = worksheet.Range[1, 2, 1, index];
                chart.Series[0].Values = worksheet.Range[2, 2, 2, index];
            
                // Настройка графика и его положения
                chart.ChartTitle = "Кривая Гильберта";
                chart.LeftColumn = 1;
                chart.TopRow = 6;
                chart.RightColumn = 10;
                chart.BottomRow = 20;
                //Сохранение в файл Excel
                workbook.SaveToFile(path, ExcelVersion.Version2016);
            }
            catch (Exception e)
            {
                MessageBox.Show("Excel уже открыт", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        
        public static void ExcelExport3D(List<double> listX, List<double> listY, List<double> listZ, string path)
        {
            Workbook workbook = new Workbook();
            workbook.Worksheets.Clear();
            workbook.Worksheets.Add("hilbert");
            Worksheet worksheet = workbook.Worksheets[0];
            
            worksheet.Range[1, 1].Value = "X";
            worksheet.Range[2, 1].Value = "Y";
            worksheet.Range[3, 1].Value = "Z";
            worksheet.InsertArray(listX.ToArray(), 1, 2, false);
            worksheet.InsertArray(listY.ToArray(), 2, 2, false);
            worksheet.InsertArray(listZ.ToArray(), 3, 2, false);
            
            worksheet.AllocatedRange.AutoFitColumns();
            
            CellStyle style = workbook.Styles.Add("newStyle");
            style.Font.IsBold = true;
            worksheet.Range[1, 1, 1, 4].Style = style;
            
            workbook.SaveToFile(path, ExcelVersion.Version2016);
        }
        }
    }