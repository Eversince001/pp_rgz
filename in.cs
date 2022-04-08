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
    public partial class @in : Form
    {
        private DataTable dataTableR;
        private List<List<int>> DataR;
        private int R, N;
        public @in(ref List<List<int>> DataR, int R, int N)
        {
            InitializeComponent();
            dataTableR = new DataTable();



            dataGridViewR.Width = N * 78;
            dataGridViewR.Height = R * 23 + 19;

            this.Width = dataGridViewR.Width + 18;
            this.Height = dataGridViewR.Height + 85;

            this.R = R;
            this.N = N;
            this.DataR = DataR;

            for (int i = 0; i < N; i++)
            {
                dataTableR.Columns.Add(i.ToString(), typeof(int)); 
                dataTableR.Columns[i].ColumnName = "Товар " + (i + 1);
            }

            // Количество строк
            for (int i = 0; i < R; i++)
            {
                //dataGridView1.Rows[0].HeaderCell.Value = "Машина " + (i + 1);
                dataTableR.Rows.Add(dataTableR.NewRow());

            }

     
            if (DataR.Count == 0)
            {
                for (int i = 0; i < N; i++)
                    for (int j = 0; j < R; j++)
                        dataTableR.Rows[i][j] = 0;
            }
            else
            {
                for (int i = 0; i < N; i++)
                    for (int j = 0; j < R; j++)
                        dataTableR.Rows[j][i] = DataR[j][i];
            }


            dataGridViewR.DataSource = dataTableR;
            // Опции по желанию
            dataGridViewR.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewR.AllowUserToAddRows = false;
        }

        private void ButtonSaveR_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < R; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (dataTableR.Rows[i][j].ToString() == "")
                        dataTableR.Rows[i][j] = 0;
                    DataR[i][j] = Convert.ToInt32(dataTableR.Rows[i][j].ToString());
                }

            }
            this.Close();
        }
    }
}
