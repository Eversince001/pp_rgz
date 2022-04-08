using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vkr
{
    public partial class Time : Form
    {

        private DataTable dataTableT;
        private int N;
        private List<int> LoadTime;
        public Time(int N, ref List<int>LoadTime)
        {
            InitializeComponent();
            dataTableT = new DataTable();
            dataGridViewT.Width = N * 148;
            dataGridViewT.Height = 70;

            this.Width = dataGridViewT.Width + 35;
            this.Height = dataGridViewT.Height + 85;

            this.N = N;
            this.LoadTime = LoadTime;

            for (int i = 0; i < N; i++)
            {
                dataTableT.Columns.Add(i.ToString(), typeof(int)); // укажите нужный тип данных матрицы
                dataTableT.Columns[i].ColumnName = "Время разгрузки для товара " + (i + 1);
            }

            dataTableT.Rows.Add(dataTableT.NewRow());


            if (LoadTime.Count == 0)
            {
                for (int i = 0; i < N; i++)
                    dataTableT.Rows[0][i] = 0;
            }
            else
            {
                for (int i = 0; i < N; i++)
                    dataTableT.Rows[0][i] = LoadTime[i];
            }

            dataGridViewT.DataSource = dataTableT;

            dataGridViewT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewT.AllowUserToAddRows = false;
        }

        private void Time_Load(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < N; i++)
            {
                if (dataTableT.Rows[0][i].ToString() == "")
                    dataTableT.Rows[0][i] = 0;

                LoadTime[i] = Convert.ToInt32(dataTableT.Rows[0][i].ToString());
            }
            this.Close();
        }
    }
}
