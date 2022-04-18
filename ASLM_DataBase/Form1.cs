using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASLM_DataBase
{
    public partial class Form1 : Form
    {
        string conn_param = "Server=192.168.0.151;Port=5432;User Id=postgres;Password=sql;Database=aslm;";
        public Form1()
        {
            InitializeComponent();
            DataFromBaseGridView.AllowUserToResizeRows = false;
        }


        //Обработчик запроса sql
        public void DoSqlQuery(string sqlQuery)
        {
            NpgsqlConnection conn = new NpgsqlConnection(conn_param);
            OpenConnection(conn);

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sqlQuery, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            var finalTable = ds.Tables[0];

            conn.Close(); //Закрываем соединение.

            DataFromBaseGridView.DataSource = finalTable;
            DataFromBaseGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataFromBaseGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataFromBaseGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        //обработчик запроса по деталям
        private void GetDataButton_Click(object sender, EventArgs e)
        {
            var reader = new StreamReader("GetDetailsSql.txt");
            string sql = reader.ReadToEnd();
            DoSqlQuery(sql);
            DataFromBaseGridView.Columns[0].Width = 40;
            DataFromBaseGridView.Columns[1].Width = 95;
            DataFromBaseGridView.Columns[2].Width = 85;
            DataFromBaseGridView.Columns[3].Width = 85;
            DataFromBaseGridView.Columns[4].Width = 120;
            DataFromBaseGridView.Columns[5].Width = 120;
            DataFromBaseGridView.Columns[5].Width = 120;
            DataFromBaseGridView.Columns[6].Width = 250;
            DataFromBaseGridView.Update();
        }

        //обработчик запроса по ячейкам
        private void GetCellInfoButton_Click(object sender, EventArgs e)
        {
            var reader = new StreamReader("GetCellInfoSql.txt");
            string sql = reader.ReadToEnd();
            DoSqlQuery(sql);

            if (DataFromBaseGridView.Rows.Count != 0)
            {
                DataFromBaseGridView.Columns[1].DefaultCellStyle.Format = "F1";
            }

            DataFromBaseGridView.Update();
        }

        //открыть соединение и проверить его на наличие ошибок
        private void OpenConnection(NpgsqlConnection conn)
        {
            try
            {
                conn.Open(); //Открываем соединение.
            }
            catch (NpgsqlException)
            {
                MessageBox.Show("Отсутствует подключение");
                return;
            }
            catch (TimeoutException)
            {
                MessageBox.Show("Истекло время ожидания сервера");
                return;
            }
        }
    }
}
