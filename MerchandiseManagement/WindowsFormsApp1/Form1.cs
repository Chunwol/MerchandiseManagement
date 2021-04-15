using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection conn;
        MySqlConnection conn2;
        MySqlCommand cmd;
        public static string connstr;
        public string selectedlist;                     // listview에서 선택된 list를 알게해주는 변수
        private BackgroundWorker worker;



        public void DB_connect(object sender, EventArgs e)
        {
            string loginName = admin_id.Text;
            string password = admin_pw.Text;

            if (loginName == "" && password == "")
            {
                MessageBox.Show("아이디와 비밀번호를 확인하십시오");
            }
            else
            {
                try
                {
                    connstr = "Server=13.209.69.190;Port=3306;Database=hansei;Uid=" + loginName + ";Pwd=" + password;
                    conn = new MySqlConnection(connstr);
                    conn2 = new MySqlConnection(connstr);
                    conn2.Open();
                    MessageBox.Show("로그인에 성공하였습니다.", "Information");
                    panel1.Visible = false;
                    this.ClientSize = new System.Drawing.Size(1082, 398);
                    panel2.Location = new Point(1, 1);
                    panel2.Visible = true;
                    //작업쓰레드 시작
                    CheckForIllegalCrossThreadCalls = false;
                    Thread T = new Thread(new ThreadStart(ThreadProc));
                    T.Start();
                }
                catch (Exception)
                {
                    MessageBox.Show("  아이디 비밀번호가 다르거나\n 서버 상태가 양호하지 않습니다", "Information");
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(407, 216);
        }

        private void insert_Click(object sender, EventArgs e)
        {

            Form2 newForm = new Form2();
            newForm.Show();
        }


        private void ThreadProc() {
            while (true)
            {
                try
                {
                    order_view.View = View.Details;
                    MySqlDataAdapter adapt = new MySqlDataAdapter("SELECT * FROM `order`;", conn);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    order_view.Items.Clear();                                // View가 중복조회 되는것을 방지한다.

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow dr = dt.Rows[i];
                        ListViewItem listitem = new ListViewItem((i+1).ToString());
                        listitem.SubItems.Add(dr["name"].ToString());
                        listitem.SubItems.Add(dr["phone"].ToString());
                        listitem.SubItems.Add(dr["order_info"].ToString());
                        listitem.SubItems.Add(dr["Additions"].ToString());
                        listitem.SubItems.Add(dr["total_amount"].ToString());
                        listitem.SubItems.Add(dr["visit_time"].ToString());
                        order_view.Items.Add(listitem);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thread 에러");
                }
                conn.Close();
                Thread.Sleep(3000);
                conn.Open();
            }
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {



            if (MessageBox.Show("정말 삭제하시겠습니까?", "경고", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                string delete = delete_number.Text;
                try
                {
                    string DBdelete1 = order_view.Items[Convert.ToInt32(delete) - 1].SubItems[1].Text;
                    string DBdelete2 = order_view.Items[Convert.ToInt32(delete) - 1].SubItems[2].Text;
                    string DBdelete3 = order_view.Items[Convert.ToInt32(delete) - 1].SubItems[3].Text;
                    string DBdelete4 = order_view.Items[Convert.ToInt32(delete) - 1].SubItems[4].Text;
                    string DBdelete5 = order_view.Items[Convert.ToInt32(delete) - 1].SubItems[5].Text;
                    string DBdelete6 = order_view.Items[Convert.ToInt32(delete) - 1].SubItems[6].Text;

                    conn2.Open();
                    string str = "DELETE FROM `hansei`.`order` WHERE  `name`= '" + DBdelete1 + "' AND `phone`= '" + DBdelete2 + "' AND `order_info`= '" + DBdelete3 + "' AND `Additions`= '" + DBdelete4 + "' AND `total_amount`= '" + DBdelete5 + "' AND `visit_time`= '" + DBdelete6 + "';";
                    MySqlCommand cmd = new MySqlCommand(str, conn2);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("삭제완료");
                    delete_number.Text = "";
                    conn2.Close();
                }
                catch
                {
                    MessageBox.Show("error");
                }
                /*
                String str = "DELETE FROM `hansei`.`storemenu` WHERE  `product`= '" + delete + "';";
                MessageBox.Show(str);
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("삭제완료");
                delete_number.Text = "";
                conn.Close();
                */
            }
        }
    }
}
