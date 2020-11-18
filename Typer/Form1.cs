using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Typer
{
    public partial class Form1 : Form
    {
        int cur_pos_user = -1, cur_pos_word = -1, word_index;
        string cur_text = "", old_text = "";
        string[] word_list;
        Stopwatch t1 = new Stopwatch();

        int timer_cnt = 60;
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        void timerTick(object sender, EventArgs e)
        {
            --timer_cnt;
            if (timer_cnt == 0)
            {
                timer.Stop();
                if (test_done == false)
                    lblWpm.Text = "Failed";
            }
            lblTimer.Text = timer_cnt.ToString();
        }

        
       

        bool test_done;

        string generateText()
        {
            t1.Start();
            var currentDirectory = Directory.GetCurrentDirectory();
            var textFile = Path.Combine(currentDirectory, "text.txt");
           // string textFile = @"D:\VS Project\TyperNew\text.txt";
            List<string> textList = File.ReadAllLines(textFile).ToList();
            Random rand = new Random();
            string newText = textList[rand.Next(0, textList.Count)];
            word_list = newText.Split(' ');
            word_index = 0;

            cur_pos_user = -1; //Reset posistions
            cur_pos_word = -1;
            txtUser.Text = "";
            cur_text = "";
            return newText;
        }

        public Form1()
        {
            InitializeComponent();
            timer.Tick += new EventHandler(timerTick);
            txtText.Text = generateText();
        }

        void removeText()
        {
            if (txtUser.Text == "Type text here...")
            {
                txtUser.Text = "";
                cur_text = "";
            }
        }

        private void txtUser_Enter_1(object sender, EventArgs e)
        {
            removeText();
        }

        int calculateTime()
        {
            // int words = txtText.Text.Length / 5;
            //Console.WriteLine(words);
            return (txtText.Text.Length / 40) * 15;
        }

        void setTimer()
        {
            txtUser.Focus();
            txtText.Text = generateText();

            test_done = false;
            timer_cnt = calculateTime();
            //Console.WriteLine(timer_cnt);

            timer.Interval = 1000; // 1 second
            timer.Start();

            lblTimer.Text = timer_cnt.ToString();
        }
        private void rbtnTest_Click(object sender, EventArgs e)
        {
            // cur_pos_user = -1;
            // cur_pos_word = -1;
            // word_index = 0;

            setTimer();

            
        }

        private void rbtnPractice_Click(object sender, EventArgs e)
        {
            //cur_pos_user = -1, cur_pos_word = -1, word_index = 0;
           
            lblTimer.Text = "0";
            timer.Stop();
        }

        void addText()
        {
            if (string.IsNullOrWhiteSpace(txtUser.Text))
            {
                txtUser.Text = "Type text here...";
                old_text = "";
                cur_text = "";
            }

        }
        private void txtUser_Leave_1(object sender, EventArgs e)
        {
        //    addText();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            old_text = cur_text;
            cur_text = txtUser.Text;

            if (old_text.Length > txtText.Text.Length || cur_text.Length > txtText.Text.Length)
                return;

            if (cur_text.Length > old_text.Length) //Check if current user-char == text-char
            {
                ++cur_pos_user;
                if (word_list[word_index].Length + 1 < cur_text.Length)
                    return;
                ++cur_pos_word;
                txtText.SelectionStart = cur_pos_word;
                txtText.SelectionLength = 1;

                if (cur_text[cur_pos_user] == txtText.Text[cur_pos_word]) //True -> Green
                {
                    if (txtUser.Text[cur_pos_user] == ' ')
                    {
                        if (txtUser.Text == word_list[word_index] + ' ')
                        {
                            cur_text = "";
                            cur_pos_user = -1;
                            txtUser.Text = "";
                            ++word_index;
                        }
                    }
                    txtText.SelectionColor = Color.Green;
                }
                else //False -> Red
                {
                    if (txtText.Text[cur_pos_word] == ' ')
                        txtText.SelectionBackColor = Color.Red;
                    else txtText.SelectionColor = Color.Red;
                }
            }
            else //Remove colored-character
            {
                if (word_list[word_index].Length >= cur_text.Length)
                {
                    txtText.SelectionStart = cur_pos_word;
                    txtText.SelectionLength = 1;
                    if (txtText.Text[cur_pos_word] == ' ')
                        txtText.SelectionBackColor = Color.White;
                    else txtText.SelectionColor = Color.Black;
                    --cur_pos_word;
                }
                --cur_pos_user;
            }

            if (cur_pos_word == txtText.Text.Length - 1) //Text finished
            {
               
                t1.Stop(); //Get WPM
                if (lblWpm.Text != "Failed")
                {
                    float words = txtText.Text.Length / 5;
                    lblWpm.Text = ((int)((words / (float)t1.Elapsed.TotalSeconds) * 60)).ToString() + " WPM";
                }
                t1.Reset();
                test_done = true;
                if (timer_cnt != 0) test_done = true;
                timer.Stop();

                //    cur_pos_user = -1; //Generate new text
                //    cur_pos_word = -1;

                if (rbtnTest.Checked)
                    setTimer();
                else txtText.Text = generateText();
            //    txtUser.Text = "";
            //    cur_text = "";

            }
        }
    }
}
