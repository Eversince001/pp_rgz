using System;
using System.Collections.Generic;
using System.Windows.Forms;



namespace vkr
{
    public partial class solution : Form
    {
        private Result Result;

        private GetTargetFunction GetTargetFunction;
        private List<List<int>> DataR;
        private List<List<int>> DataS;
        private List<int> LoadTime;
        private excel exc;

        public solution()
        {
            InitializeComponent();
            DataR = new List<List<int>>(); //товары в грузовиках разгрузки
            DataS = new List<List<int>>(); //товары в грузовиках погрузки
            LoadTime = new List<int>(); //t переноса отдельного товара на складе
            exc = new excel();
        }


        private bool isEmpty(List<List<int>> Data)
        {
            if (Data.Count == 0)
                return false;

            for (int i = 0; i < Data.Count; i++)
            {
                for (int j = 0; j < Data[i].Count; j++)
                {
                    if (Data[i][j] != 0)
                        return true;
                }

            }
            return false;
        }

        private bool isEqual(List<List<int>> DataSS, List<List<int>> DataRR, int N)
        {
            int sumR = 0, sumS = 0;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < DataRR.Count; j++)
                {
                    sumR += DataRR[j][i];
                }

                for (int j = 0; j < DataSS.Count; j++)
                {
                    sumS += DataSS[j][i];
                }
                if (sumR != sumS)
                {
                    MessageBox.Show("Количество товара " + (i+1) + " не совпадает в таблицах поставок");
                    return false;
                }

                sumR = 0;
                sumS = 0;

            }

            return true;
        }


        private void buttonSolution_Click_1(object sender, EventArgs e)
        {

            if (textBoxN.Text == "" || textBoxR.Text == "" || textBoxS.Text == "" || textBoxD.Text == "" || textBoxV.Text == "")
            {
                MessageBox.Show("Заполните пустые поля");
                return;
            }
            if (isEmpty(DataR) && isEmpty(DataS) && LoadTime.Count != 0)
            {
                if (isEqual(DataS, DataR, Convert.ToInt32(textBoxN.Text)))
                {
                    System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();
                    timer.Start();
                    GetTargetFunction = new GetTargetFunction(Convert.ToInt32(textBoxR.Text), Convert.ToInt32(textBoxS.Text), Convert.ToInt32(textBoxN.Text), Convert.ToInt32(textBoxD.Text), Convert.ToInt32(textBoxV.Text));
                    Result = GetTargetFunction.GetResult(DataR, DataS, LoadTime);
                    string PR = "", PS = "";
                    for (int i = 0; i < Result.PR.Count; i++)
                        PR += (Result.PR[i] + 1).ToString() + " ";
                    for (int i = 0; i < Result.PS.Count; i++)
                        PS += (Result.PS[i] + 1).ToString() + " ";

                    //exc.SaveData(Result);
                    timer.Stop();
                    MessageBox.Show("Время: " + Result.M.ToString() + "\n" + "Порядок машин разгрузки:" + PR + "\n" + "Порядок машин погрузки: " + PS + "\n" + "Подробная информация в файле result.xlsx\n" + Convert.ToString(timer.Elapsed));
                }
            }
            else
                MessageBox.Show("Заполните таблицы поставок");

        }

        private void ButtonR_Click(object sender, EventArgs e)
        {
         

            if (textBoxN.Text == "" || textBoxR.Text == "")
            {
                MessageBox.Show("Заполните поля <<Количесво машин разгрузки>> и <<Количество типов товара>> ");
                return;
            }

              if (DataR.Count == 0)
                for (int i = 0; i < Convert.ToInt32(textBoxR.Text); i++)
                {
                    DataR.Add(new List<int>());
                    for (int j = 0; j < Convert.ToInt32(textBoxN.Text); j++)
                    {
                        DataR[i].Add(0);
                    }

                }

            Form In = new @in(ref DataR, Convert.ToInt32(textBoxR.Text), Convert.ToInt32(textBoxN.Text));

            In.ShowDialog();

        }

        private void ButtonS_Click(object sender, EventArgs e)
        {

  

            if (textBoxN.Text == "" || textBoxS.Text == "")
            {
                MessageBox.Show("Заполните поля <<Количесво машин погрузки>> и <<Количество типов товара>> ");
                return;
            }

            if (DataS.Count == 0)
                for (int i = 0; i < Convert.ToInt32(textBoxS.Text); i++)
                {
                    DataS.Add(new List<int>());
                    for (int j = 0; j < Convert.ToInt32(textBoxN.Text); j++)
                    {
                        DataS[i].Add(0);
                    }

                }

            Form Out = new @out(ref DataS, Convert.ToInt32(textBoxS.Text), Convert.ToInt32(textBoxN.Text));

            Out.ShowDialog();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exc.LoadData(ref DataR, ref DataS, ref LoadTime, ref textBoxR, ref textBoxS, ref textBoxN, ref textBoxD, ref textBoxV);
        }

        private void ButtonTime_Click(object sender, EventArgs e)
        {
            if (textBoxN.Text == "")
            {
                MessageBox.Show("Заполните поле <<Количество типов товара>> ");
                return;
            }
            if (LoadTime.Count == 0)
            {
                for (int j = 0; j < Convert.ToInt32(textBoxN.Text); j++)
                {
                    LoadTime.Add(0);
                }
            }
            Form Time = new @Time(Convert.ToInt32(textBoxN.Text), ref LoadTime);
            Time.Show();
        }
    }
}
