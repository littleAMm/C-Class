using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace 第十一次课堂作业
{
   
    public partial class Form1 : Form
    {
        static String DP_PATH = "Data Source=" + @".\Data\SQLite.db";
        SQLiteConnection con;
        static int number = 1;
        String Chinese = "";
        String SqlEngllish = @"SELECT*  FROM English  WHERE" + " id=" ;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (EnglishText.Text == Chinese)
            {
                label1.ForeColor = Color.Green;
                label1.Text = "√";
                label2.Text = "";
            }
            else 
            {
                label1.ForeColor=Color.Red;
                label1.Text = "X";
            }
        }

        private void getEnglish() 
        {   
            SQLiteCommand command = new SQLiteCommand(SqlEngllish + number.ToString(), con);
            SQLiteDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                ChineseText.Text = (string)reader["Chinese"];
                Chinese = (string)reader["English"];
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (number < 6)
            {
                if (label1.Text == "√")
                {
                    number++;
                    EnglishText.Text = "";
                    label1.Text = "";
                    label2.Text = "";
                    getEnglish();
                }
                else { label2.Text = "请完成当前单词背诵"; }
            }
            else 
            {
                label2.Text = "恭喜你已完成所有单词背诵";
            }
            
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SQLiteConnection(DP_PATH);
            con.Open();
            getEnglish();
        }
    }
}
