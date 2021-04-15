using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;


namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        MySqlConnection conn;
        string connstr;
        string delete;
        string update;

        private void Form2_Load(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(1072, 450);
            create_panel.Visible = false;
            delete_panel.Visible = false;
            update_panel.Visible = false;
            try
            {
                connstr = Form1.connstr;
                conn = new MySqlConnection(connstr);
                conn.Open();
                //MessageBox.Show("서버 상태", "Information");
            }
            catch (Exception)
            {
                MessageBox.Show("서버 상태가 양호하지 않습니다", "Information");
                this.Close();
            }
            conn.Close();


        }
        private void Info_panel_Paint(object sender, PaintEventArgs e)
        {
            ShowStoremenu();
            
        }

        public string ShowStoremenu()
        {
            try
            {
                conn.Open();
                storemenu_View.View = View.Details;
                MySqlDataAdapter adapt = new MySqlDataAdapter("SELECT * FROM `storemenu`;", conn);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                storemenu_View.Items.Clear();                                // View가 중복조회 되는것을 방지한다.
                
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    ListViewItem listitem = new ListViewItem((i + 1).ToString());
                    //listitem.Text = null;  // 첫번째 열은 값을 넣지 않는다. checkbox 용도
                    listitem.SubItems.Add(dr["item"].ToString());
                    listitem.SubItems.Add(dr["product"].ToString());
                    listitem.SubItems.Add(dr["price"].ToString());
                    listitem.SubItems.Add(dr["manufacture"].ToString());
                    listitem.SubItems.Add(dr["Calorie"].ToString());
                    listitem.SubItems.Add(dr["stock"].ToString());
                    listitem.SubItems.Add(dr["picture"].ToString());
                    storemenu_View.Items.Add(listitem);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB에러");
            }
            conn.Close();
            return "";
        }

        /*public string ShowFileOpenDialog()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "file select";
            ofd.FileName = "file";
            ofd.Filter = "그림 파일 (*.jpg, *.gif, *.bmp, *.png) | *.jpg; *.gif; *.bmp; *.png;| 모든 파일 (*.*) | *.*";

            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                fileName = ofd.SafeFileName;
                fileFullName = ofd.FileName;

                //ftpimage();

                return fileFullName;
            }
            else if (dr == DialogResult.Cancel)
            {
                return "";
            }

            return "";
        }*/

        private void Button4_Click(object sender, EventArgs e)
        {
            string product_insert = product_textbox.Text;
            string price_insert = price_textBox.Text;
            string manufacture_insert = manufacture_textbox.Text;
            string calorie_insert = calorie_textbox.Text;
            string item_insert = item_listBox.Text;
            string stock_insert;
            string picture_insert = filename_textbox.Text;
            if ((product_insert.Length != 0) && (price_insert.Length != 0) && (manufacture_insert.Length != 0) && (calorie_insert.Length != 0) && (item_insert.Length != 0) && (picture_insert.Length != 0))
            {

                if (stock_checkBox.Checked == true)
                {
                    stock_insert = "1";
                }
                else
                {
                    stock_insert = "0";
                }

                string str = "INSERT INTO `hansei`.`storemenu` (`item`, `product`, `price`, `manufacture`, `Calorie`,`stock` ,`picture`) VALUES ('" + item_insert + "', '" + product_insert + "', '" + price_insert + "', '" + manufacture_insert + "', '" + calorie_insert + "', '" + stock_insert + "', '" + picture_insert + "');";
                //MessageBox.Show(str);
                try
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand(str, conn);

                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("입력 완료");
                    ShowStoremenu();
                    product_textbox.Text = "";
                    price_textBox.Text = "";
                    manufacture_textbox.Text = "";
                    calorie_textbox.Text = "";
                    stock_checkBox.Checked = true;
                    filename_textbox.Text = "";
                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show("입력 에러");
                }
            }
            else
            {
                MessageBox.Show("잘못 입력하셨습니다.");
            }
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
      
            delete = delete_number.Text;
            try
            {
                delete_view.Items.Clear();
                string de1 = storemenu_View.Items[Convert.ToInt32(delete) - 1].SubItems[1].Text;
                string de2 = storemenu_View.Items[Convert.ToInt32(delete) - 1].SubItems[2].Text;
                string de3 = storemenu_View.Items[Convert.ToInt32(delete) - 1].SubItems[3].Text;
                string de4 = storemenu_View.Items[Convert.ToInt32(delete) - 1].SubItems[4].Text;
                string de5 = storemenu_View.Items[Convert.ToInt32(delete) - 1].SubItems[5].Text;
                string de6 = storemenu_View.Items[Convert.ToInt32(delete) - 1].SubItems[6].Text;
                string de7 = storemenu_View.Items[Convert.ToInt32(delete) - 1].SubItems[7].Text;
                ListViewItem listitem = new ListViewItem(de1.ToString());
                listitem.SubItems.Add(de2.ToString());
                listitem.SubItems.Add(de3.ToString());
                listitem.SubItems.Add(de4.ToString());
                listitem.SubItems.Add(de5.ToString());
                listitem.SubItems.Add(de6.ToString());
                listitem.SubItems.Add(de7.ToString());
                delete_view.Items.Add(listitem);

            }
            catch (Exception ex)
            {
                MessageBox.Show("error");
            }
        }

        private void Db_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("정말 삭제하시겠습니까?", "경고", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    conn.Open();
                    string del = storemenu_View.Items[Convert.ToInt32(delete) - 1].SubItems[2].Text;
                    string str = "DELETE FROM `hansei`.`storemenu` WHERE  `product`= '" + del + "';";
                    //MessageBox.Show(str);
                    MySqlCommand cmd = new MySqlCommand(str, conn);
                    cmd.ExecuteNonQuery();
                    delete_view.Items.Clear();
                    MessageBox.Show("삭제완료");
                    delete_number.Text = "";
                    conn.Close();
                    ShowStoremenu();
                    delete = "";
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("삭제 실패");
            }
        }

        private void Update_seerch_Click(object sender, EventArgs e)
        {
            update = update_number.Text;
            try
            {
                delete_view.Items.Clear();
                string de1 = storemenu_View.Items[Convert.ToInt32(update) - 1].SubItems[1].Text;
                string de2 = storemenu_View.Items[Convert.ToInt32(update) - 1].SubItems[2].Text;
                string de3 = storemenu_View.Items[Convert.ToInt32(update) - 1].SubItems[3].Text;
                string de4 = storemenu_View.Items[Convert.ToInt32(update) - 1].SubItems[4].Text;
                string de5 = storemenu_View.Items[Convert.ToInt32(update) - 1].SubItems[5].Text;
                string de6 = storemenu_View.Items[Convert.ToInt32(update) - 1].SubItems[6].Text;
                string de7 = storemenu_View.Items[Convert.ToInt32(update) - 1].SubItems[7].Text;
                update_item.SelectedItem = de1.ToString();
                update_product.Text = de2.ToString();
                update_price.Text = de3.ToString();
                update_manufacture.Text = de4.ToString();
                update_Calorie.Text = de5.ToString();
                string tempstock = de6.ToString();
                if (tempstock.Equals("1"))
                {
                    update_stock.Checked = true;
                }
                else
                {
                    update_stock.Checked = false;
                }
                update_filename.Text = de7.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("검색실패");
            }


        }


        private void Db_update_Click(object sender, EventArgs e)
        {
            string product_insert = update_product.Text;
            string price_insert = update_price.Text;
            string manufacture_insert = update_manufacture.Text;
            string calorie_insert = update_Calorie.Text;
            string item_insert = update_item.Text;
            string stock_insert;
            string picture_insert = update_filename.Text;
            if ((product_insert.Length != 0) && (price_insert.Length != 0) && (manufacture_insert.Length != 0) && (calorie_insert.Length != 0) && (item_insert.Length != 0) && (picture_insert.Length != 0))
            {
                    if (update_stock.Checked == true)
                    {
                        stock_insert = "1";
                    }
                    else
                    {
                        stock_insert = "0";
                    }
                    try
                    {
                        string de2 = storemenu_View.Items[Convert.ToInt32(update) - 1].SubItems[2].Text;
                        conn.Open();
                        string str = "DELETE FROM `hansei`.`storemenu` WHERE  `product`= '" + de2 + "';";
                        //MessageBox.Show(str);
                        MySqlCommand cmd = new MySqlCommand(str, conn);
                        cmd.ExecuteNonQuery();


                        string str2 = "INSERT INTO `hansei`.`storemenu` (`item`, `product`, `price`, `manufacture`, `Calorie`, `stock`,`picture`) VALUES ('" + item_insert + "', '" + product_insert + "', '" + price_insert + "', '" + manufacture_insert + "', '" + calorie_insert + "', '" + stock_insert + "', '" + picture_insert + "');";
                        //MessageBox.Show(str);

                        MySqlCommand cmd2 = new MySqlCommand(str2, conn);
                        cmd2.ExecuteNonQuery();
                        MessageBox.Show("수정 완료");
                        conn.Close();
                        update_product.Text = "";
                        update_price.Text = "";
                        update_manufacture.Text = "";
                        update_Calorie.Text = "";
                        update_number.Text = "";
                        update_filename.Text = "";
                        update_stock.Checked = false;
                        update = "";
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        MessageBox.Show("수정 실패");
                    }
                    ShowStoremenu();
            }
            else
            {
                MessageBox.Show("입력 에러");
            }
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(1072, 610);
            create_panel.Visible = false;
            delete_panel.Visible = false;
            update_panel.Visible = true;
            update_panel.Location = new System.Drawing.Point(12, 422);

        }

        private void Create_button_Click(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(1072, 610);
            create_panel.Visible = true;
            delete_panel.Visible = false;
            update_panel.Visible = false;
            create_panel.Location = new System.Drawing.Point(12, 422);
        }

        private void DB_delete_Click(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(1072, 610);
            create_panel.Visible = false;
            delete_panel.Visible = true;
            update_panel.Visible = false;
            delete_panel.Location = new System.Drawing.Point(12, 422);
        }


    }
}
