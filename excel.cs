//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Windows.Forms;
//using ExcelDataReader;
//using Excel = Microsoft.Office.Interop.Excel;
//using System.Drawing;

//namespace vkr
//{
//    internal class excel
//    {
//        public void LoadData(ref List<List<int>> DataR, ref List<List<int>> DataS, ref List<int> LoadTime, ref TextBox textBoxR, ref TextBox textBoxS, ref TextBox textBoxN, ref TextBox textBoxD, ref TextBox textBoxV)
//        {
//            using (OpenFileDialog opfd = new OpenFileDialog()
//            { Filter = "Excel Workbook|*.xlsx", ValidateNames = true })
//            {
//                if (opfd.ShowDialog() == DialogResult.OK)
//                {
//                    FileStream fs = File.Open(opfd.FileName, FileMode.Open, FileAccess.Read);
//                    try
//                    {
//                        var reader = ExcelReaderFactory.CreateReader(fs);
//                        DataR.Clear();
//                        DataS.Clear();
//                        LoadTime.Clear();
//                        int count = 0, row = 0, error = 0;
//                        while (count != 4)
//                        {
//                            if (error > 4)
//                            {
//                                MessageBox.Show("Загруженный Excel файл содержит некорректные входные данные!");
//                                break;
//                            }
//                            if (reader.Name == "Грузовики разгрузки" && textBoxR.Text != "" && textBoxN.Text != "")
//                            {

//                                int n = 0;

//                                for (int i = 0; i < Convert.ToInt64(textBoxR.Text); i++)
//                                {
//                                    DataR.Add(new List<int>());
//                                }

//                                while (n < Convert.ToInt64(textBoxR.Text))
//                                {
//                                    reader.Read();
//                                    if (row == 0)
//                                    {
//                                        row++;
//                                        continue;
//                                    }
//                                    for (int i = 0; i < Convert.ToInt64(textBoxN.Text); i++)
//                                    {

//                                        if (reader.GetValue(i) != null) DataR[n].Add(Convert.ToInt32(reader.GetValue(i)));
//                                        else DataR[n].Add(0);
//                                    }
//                                    n++;
//                                }
//                                count++;
//                                row = 0;
//                                reader.NextResult();
//                            }
//                            if (reader.Name == "Грузовики погрузки" && textBoxS.Text != "" && textBoxN.Text != "")
//                            {
//                                int n = 0;

//                                for (int i = 0; i < Convert.ToInt64(textBoxS.Text); i++)
//                                {
//                                    DataS.Add(new List<int>());
//                                }

//                                while (n < Convert.ToInt64(textBoxS.Text))
//                                {
//                                    reader.Read();
//                                    if (row == 0)
//                                    {
//                                        row++;
//                                        continue;
//                                    }
//                                    for (int i = 0; i < Convert.ToInt64(textBoxN.Text); i++)
//                                    {
//                                        if (reader.GetValue(i) != null) DataS[n].Add(Convert.ToInt32(reader.GetValue(i)));
//                                        else DataS[n].Add(0);
//                                    }
//                                    n++;
//                                }
//                                count++;
//                                row = 0;
//                                reader.NextResult();
//                            }
//                            if (reader.Name == "Данные")
//                            {
//                                while (reader.Read())
//                                {
//                                    if (row == 0)
//                                    {
//                                        row++;
//                                        continue;
//                                    }
//                                    if (reader.GetValue(0) != null) textBoxR.Text = reader.GetValue(0).ToString();
//                                    if (reader.GetValue(1) != null) textBoxS.Text = reader.GetValue(1).ToString();
//                                    if (reader.GetValue(2) != null) textBoxN.Text = reader.GetValue(2).ToString();
//                                    if (reader.GetValue(3) != null) textBoxD.Text = reader.GetValue(3).ToString();
//                                    if (reader.GetValue(4) != null) textBoxV.Text = reader.GetValue(4).ToString();
//                                }
//                                count++;
//                                row = 0;
//                                reader.NextResult();
//                            }
//                            if (reader.Name == "t переноса отдельного товара")
//                            {
//                                while (reader.Read())
//                                {
//                                    if (row == 0)
//                                    {
//                                        row++;
//                                        continue;
//                                    }
//                                    if (reader.GetValue(1) != null) LoadTime.Add(Convert.ToInt32(reader.GetValue(1).ToString()));
//                                    else LoadTime.Add(0);

//                                }
//                                count++;
//                                row = 0;
//                                reader.NextResult();
//                            }
//                            error++;
//                        }
//                        fs.Close();
//                    }
//                    catch (Exception ex)
//                    {
//                        MessageBox.Show(ex.ToString());
//                        fs.Close();
//                    }
//                }

//            }
//        }
        
//        public void SaveData(Result res)
//        {
//            Excel.Application ex = new Microsoft.Office.Interop.Excel.Application();
//            ex.Workbooks.Open(@"C:\Users\Eversince001\Desktop\diplom\exemples\result.xlsx",
//              Type.Missing, Type.Missing, Type.Missing, Type.Missing,
//              Type.Missing, Type.Missing, Type.Missing, Type.Missing,
//              Type.Missing, Type.Missing, Type.Missing, Type.Missing,
//              Type.Missing, Type.Missing);
//            //Отобразить Excel
//            ex.Visible = true;
//            //Количество листов в рабочей книге
//            ex.SheetsInNewWorkbook = 2;
//            //Добавить рабочую книгу
//            Excel.Workbook workBook = ex.Workbooks.Add(Type.Missing);
//            //Отключить отображение окон с сообщениями
//            ex.DisplayAlerts = false;
//            //Получаем первый лист документа (счет начинается с 1)
//            Excel.Worksheet sheet = (Excel.Worksheet)ex.Worksheets.get_Item(1);
//            //Название листа (вкладки снизу)
//            sheet.Name = "Отчет за 13.12.2017";
//            //Пример заполнения ячеек
//            for (int i = 1; i <= 9; i++)
//            {
//                for (int j = 1; j < 9; j++)
//                    sheet.Cells[i, j] = String.Format("Boom {0} {1}", i, j);
//            }
//            //Захватываем диапазон ячеек
//            Excel.Range range1 = sheet.get_Range(sheet.Cells[1, 1], sheet.Cells[9, 9]);
//            //Шрифт для диапазона
//            range1.Cells.Font.Name = "Tahoma";
//            //Размер шрифта для диапазона
//            range1.Cells.Font.Size = 10;
//            //Захватываем другой диапазон ячеек
//            Excel.Range range2 = sheet.get_Range(sheet.Cells[1, 1], sheet.Cells[9, 2]);
//            range2.Cells.Font.Name = "Times New Roman";
//            //Задаем цвет этого диапазона. Необходимо подключить System.Drawing
//            range2.Cells.Font.Color = ColorTranslator.ToOle(Color.Green);
//            //Фоновый цвет
//            range2.Interior.Color = ColorTranslator.ToOle(Color.FromArgb(0xFF, 0xFF, 0xCC));
//        }
//    }
//}
