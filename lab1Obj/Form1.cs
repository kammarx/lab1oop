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
using System.Drawing.Drawing2D;

namespace lab1Obj
{
    
    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer timer=new Timer();
        TimeSpan countdownClock = TimeSpan.FromSeconds(30);
        public Button btnFormSize = new Button();
        public Form1()
        {
            
            InitializeComponent();
            btnFormSize.Text = "Make Form bigger";
            btnFormSize.Size = new Size(100,40);
            btnFormSize.Location = new Point(500,530);
            this.Controls.Add(btnFormSize);
            btnFormSize.Click += new System.EventHandler(this.btnFormSize_Click);
            trackBar1.Minimum = 0;
            trackBar1.Maximum = picBoxSoup.Size.Width;
       
        }

        bool[] arr = new bool[5];
        int progBVal = 0;
        int timeleft = 90;
        int pboxcl = 0;
        ListBox mylist = new ListBox();


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] picList = Directory.GetFiles(@"E:\Рабочий стол\Soups\", "*.jpg");
            int q;
            bool alltr=false;
            textBox1.Text = soupBox.SelectedItem.ToString();
            int selectedSoup = soupBox.SelectedIndex;
            picBoxSoup.Image = Image.FromFile(picList[selectedSoup]);
            if (!arr[selectedSoup])
            {
                arr[selectedSoup] = true;
                progBVal+=20;
                progBar.Value +=20;
                labelProgBar.Text = "You're " + progBVal + "% soup";
            }
          
            q=0;
            for(int i = 0; i < 5; i++)
            {
                if (!arr[i]) break;
                q++;
            }
            if (q == 5)
            {
                radioButton3.Checked = true;
                groupBox1.Enabled = false;
            }
          
           
            

        }
        
        private void CommonBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string name = btn.Name;
            if (name == "btnColor1") this.BackColor = Color.Pink;
            if (name == "btnColor2") this.BackColor = Color.Yellow;
            if (name == "btnColor3") this.BackColor = Color.Gray;
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;

            timer = new System.Windows.Forms.Timer();
            timer.Interval = (int)TimeSpan.FromSeconds(1).TotalMilliseconds;
            timer.Tick += OnTimeEvent;
            DisplayTime();
            timer.Start();

            foreach (var item in this.Controls)
            {
                if(item is Button)
                {
                    ((Button)item).Click += CommonBtn_Click;
                }
            }
        }

        private void OnTimeEvent(object sender, EventArgs e)
        {
            countdownClock = countdownClock.Subtract(TimeSpan.FromMilliseconds(timer.Interval));

            if (countdownClock.TotalMilliseconds <= 0)
            {
                countdownClock = TimeSpan.Zero;
                timer.Stop();
                //Application.Restart();
            }

            DisplayTime();
        }
        private void DisplayTime()
        {
            labelTimer.Text = countdownClock.ToString();
        }

        private void AddTimeToClock(TimeSpan timeToAdd)
        {
            countdownClock += timeToAdd;
            DisplayTime();
            if (!timer.Enabled) timer.Start();
        }

        private void btnNumeric_Click(object sender, EventArgs e)
        {
            double t = decimal.ToDouble(numUpDown.Value);
            AddTimeToClock(TimeSpan.FromSeconds(t));
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int x = rnd.Next(650, 850);
            int y = rnd.Next(50, 200);
            Button genbtn = new Button();
            genbtn.Location = new Point(x, y);
            genbtn.BackColor = Color.GreenYellow;
            genbtn.Size = new Size(80, 25);
            genbtn.Text = "Click me!";
            genbtn.Click +=genbtnRemove_Click;
            this.Controls.Add(genbtn);
        }

        private void genbtnRemove_Click(object sender, EventArgs e)
        {
            Controls.Remove((Button)sender);
        }

        private void btnFormSize_Click(object sender,EventArgs e)
        {
            int inc = 10;
            this.Height += inc;

        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
           CheckBox chk = sender as CheckBox;
            if (chk.Checked)
            {
                textBoxServe.Text += (chk.Text+Environment.NewLine);
                chk.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxServe.Clear();
            CheckBox[] chkarr=new CheckBox[3] {checkBox1,checkBox2,checkBox3 };
           for(int i = 0; i < 3; i++)
            {
                chkarr[i].Checked = false;
                chkarr[i].Enabled = true;
            }

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            Pen myPen = new Pen(Color.Blue, 10);
            myPen.StartCap = LineCap.ArrowAnchor;
            myPen.EndCap = LineCap.Flat;
            Point myPoint1 = new Point(570, 350);
            Point myPoint2 = new Point(650, 400);
            e.Graphics.DrawLine(myPen, myPoint1, myPoint2);
            string text = "Soup bowl wisdom";
            gr.DrawString(text, new Font("Helvetica", 15), Brushes.Black, 400, 300);
            gr.DrawEllipse(myPen, 385, 270, 200, 100);
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            coordX.Text = "X : " + e.X.ToString();
            coordY.Text = "Y : " + e.Y.ToString();
            
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.P)
            {
                MessageBox.Show("P key was pressed!");
            }
            if(e.KeyCode == Keys.Enter)
            {
                textBox1.Text = richTextBox1.Text;
            }

        }

        private void deleteAPictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picBoxSoup.Visible = false;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed by Kamil Mardanov PRO-227");
        }

        private void myTree_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Level == 1 || e.Node.Level == 0)
            {
                return;
            }

            if (listBox1.Items.Count == 6)
            {
                myTree.Enabled = false;
            }

            
            TreeNode node = e.Node;
            if (e.Node.Level == 2)
            {
                if (!listBox1.Items.Contains(node)  ){
                        listBox1.Items.Add(node);
                    }
                return;
            }
        

           

        }
        private void btnSayHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello!");
            
        }

        private void btnTriggerHello_Click(object sender, EventArgs e)
        {
            btnSayHello_Click(null,null);
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            picBoxSoup.Width = trackBar1.Value;
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabPage1) label1.BackColor = Color.Red;
            else if (tabControl.SelectedTab == tabPage2) label2.BackColor = Color.Green;
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                btnCreate.PerformClick();
            }
            tabControl.TabPages.Remove(tabPage2);
        }

        private void btnListClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        
    }
}
