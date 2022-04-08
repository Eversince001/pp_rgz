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
    public partial class @out : Form
    {
        private DataTable dataTableS;
        private List<List<int>> DataS;
        private int S, N;
        public @out(ref List<List<int>> DataS, int S, int N)
        {
            InitializeComponent();
            dataTableS = new DataTable();

            dataGridViewS.Width = N * 87;
            dataGridViewS.Height = S * 23 + 19;

            this.Width = dataGridViewS.Width + 18;
            this.Height = dataGridViewS.Height + 85;


            this.S = S;
            this.N = N;
            this.DataS = DataS;

            for (int i = 0; i < N; i++)
            {
                dataTableS.Columns.Add(i.ToString(), typeof(int)); // укажите нужный тип данных матрицы
                dataTableS.Columns[i].ColumnName = "Товар " + (i + 1);
            }

            // Количество строк
            for (int i = 0; i < S; i++)
            {
                //dataGridView1.Rows[0].HeaderCell.Value = "Машина " + (i + 1);
                dataTableS.Rows.Add(dataTableS.NewRow());

            }

            if (DataS.Count == 0)
            {
                for (int i = 0; i < N; i++)
                    for (int j = 0; j < S; j++)
                        dataTableS.Rows[i][j] = 0;
            }
            else
            {
                for (int i = 0; i < N; i++)
                    for (int j = 0; j < S; j++)
                        dataTableS.Rows[j][i] = DataS[j][i];
            }

            dataGridViewS.DataSource = dataTableS;

            dataGridViewS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewS.AllowUserToAddRows = false;
        }

        private void ButtonSaveS_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < S; i++)
            {

                for (int j = 0; j < N; j++)
                {
                    if (dataTableS.Rows[i][j].ToString() == "")
                        dataTableS.Rows[i][j] = 0;

                    DataS[i][j] = Convert.ToInt32(dataTableS.Rows[i][j].ToString());
                }

            }
            this.Close();
        }
    }
}
