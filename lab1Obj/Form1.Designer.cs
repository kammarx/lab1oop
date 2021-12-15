
namespace lab1Obj
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Potato");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Tomato");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Carrot");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Vegetables", new System.Windows.Forms.TreeNode[] {
            treeNode28,
            treeNode29,
            treeNode30});
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Beef");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Chicken");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Fish");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Meat", new System.Windows.Forms.TreeNode[] {
            treeNode32,
            treeNode33,
            treeNode34});
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Food products", new System.Windows.Forms.TreeNode[] {
            treeNode31,
            treeNode35});
            this.soupBox = new System.Windows.Forms.ComboBox();
            this.picBoxSoup = new System.Windows.Forms.PictureBox();
            this.progBar = new System.Windows.Forms.ProgressBar();
            this.labelProgBar = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnColor1 = new System.Windows.Forms.Button();
            this.btnColor2 = new System.Windows.Forms.Button();
            this.btnColor3 = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.myTree = new System.Windows.Forms.TreeView();
            this.textBoxServe = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.coordX = new System.Windows.Forms.TextBox();
            this.coordY = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAPictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelTimer = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.btnListClear = new System.Windows.Forms.Button();
            this.numUpDown = new System.Windows.Forms.NumericUpDown();
            this.btnNumeric = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSoup)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // soupBox
            // 
            this.soupBox.FormattingEnabled = true;
            this.soupBox.Items.AddRange(new object[] {
            "Solyanka",
            "Borscht",
            "Tokmach",
            "Okroshka",
            "Ukha"});
            this.soupBox.Location = new System.Drawing.Point(380, 71);
            this.soupBox.Name = "soupBox";
            this.soupBox.Size = new System.Drawing.Size(183, 21);
            this.soupBox.TabIndex = 0;
            this.soupBox.Text = "What soup are you today?";
            this.soupBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // picBoxSoup
            // 
            this.picBoxSoup.Location = new System.Drawing.Point(380, 111);
            this.picBoxSoup.Name = "picBoxSoup";
            this.picBoxSoup.Size = new System.Drawing.Size(183, 145);
            this.picBoxSoup.TabIndex = 1;
            this.picBoxSoup.TabStop = false;
            // 
            // progBar
            // 
            this.progBar.Location = new System.Drawing.Point(802, 589);
            this.progBar.Name = "progBar";
            this.progBar.Size = new System.Drawing.Size(142, 23);
            this.progBar.Step = 20;
            this.progBar.TabIndex = 2;
            // 
            // labelProgBar
            // 
            this.labelProgBar.AutoSize = true;
            this.labelProgBar.Location = new System.Drawing.Point(834, 573);
            this.labelProgBar.Name = "labelProgBar";
            this.labelProgBar.Size = new System.Drawing.Size(80, 13);
            this.labelProgBar.TabIndex = 3;
            this.labelProgBar.Text = "You\'re 0% soup";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(0, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(962, 29);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "\"I live on good soup, not on fine words\"";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 148);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "How much do you like soup?";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(20, 102);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(113, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Can\'t live without it";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(20, 66);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(102, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Well, it\'s eatable";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(20, 30);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(60, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "I hate it";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // btnColor1
            // 
            this.btnColor1.Location = new System.Drawing.Point(11, 531);
            this.btnColor1.Name = "btnColor1";
            this.btnColor1.Size = new System.Drawing.Size(76, 23);
            this.btnColor1.TabIndex = 6;
            this.btnColor1.Text = "Pink ";
            this.btnColor1.UseVisualStyleBackColor = true;
            // 
            // btnColor2
            // 
            this.btnColor2.Location = new System.Drawing.Point(12, 560);
            this.btnColor2.Name = "btnColor2";
            this.btnColor2.Size = new System.Drawing.Size(75, 23);
            this.btnColor2.TabIndex = 7;
            this.btnColor2.Text = "Yellow";
            this.btnColor2.UseVisualStyleBackColor = true;
            // 
            // btnColor3
            // 
            this.btnColor3.Location = new System.Drawing.Point(12, 589);
            this.btnColor3.Name = "btnColor3";
            this.btnColor3.Size = new System.Drawing.Size(75, 23);
            this.btnColor3.TabIndex = 8;
            this.btnColor3.Text = "Gray";
            this.btnColor3.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(790, 255);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(105, 23);
            this.btnCreate.TabIndex = 9;
            this.btnCreate.Text = "Create a button";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(186, 100);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "What should it be served with?";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(20, 66);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(75, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Side salad";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(20, 43);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Sour cream";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(20, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(54, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Bread";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(837, 410);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(107, 134);
            this.listBox1.TabIndex = 11;
            // 
            // myTree
            // 
            this.myTree.CheckBoxes = true;
            this.myTree.Location = new System.Drawing.Point(0, 410);
            this.myTree.Name = "myTree";
            treeNode28.Name = "Node11";
            treeNode28.Text = "Potato";
            treeNode29.Name = "Node12";
            treeNode29.Text = "Tomato";
            treeNode30.Name = "Node13";
            treeNode30.Text = "Carrot";
            treeNode31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            treeNode31.Name = "Node1";
            treeNode31.Text = "Vegetables";
            treeNode31.ToolTipText = "Main ingredients";
            treeNode32.Name = "Node21";
            treeNode32.Text = "Beef";
            treeNode33.Name = "Node22";
            treeNode33.Text = "Chicken";
            treeNode34.Name = "Node23";
            treeNode34.Text = "Fish";
            treeNode35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            treeNode35.Name = "Node2";
            treeNode35.Text = "Meat";
            treeNode36.Name = "Node0";
            treeNode36.Text = "Food products";
            this.myTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode36});
            this.myTree.Size = new System.Drawing.Size(187, 115);
            this.myTree.TabIndex = 12;
            this.myTree.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.myTree_AfterCheck);
            // 
            // textBoxServe
            // 
            this.textBoxServe.Location = new System.Drawing.Point(11, 324);
            this.textBoxServe.Multiline = true;
            this.textBoxServe.Name = "textBoxServe";
            this.textBoxServe.ReadOnly = true;
            this.textBoxServe.Size = new System.Drawing.Size(134, 80);
            this.textBoxServe.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 80);
            this.button1.TabIndex = 15;
            this.button1.Text = "Clear and reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // coordX
            // 
            this.coordX.Location = new System.Drawing.Point(110, 592);
            this.coordX.Name = "coordX";
            this.coordX.Size = new System.Drawing.Size(66, 20);
            this.coordX.TabIndex = 16;
            // 
            // coordY
            // 
            this.coordY.Location = new System.Drawing.Point(200, 592);
            this.coordY.Name = "coordY";
            this.coordY.Size = new System.Drawing.Size(64, 20);
            this.coordY.TabIndex = 17;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(659, 576);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(122, 36);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = "";
            this.richTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBox1_KeyDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(962, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteAPictureToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // deleteAPictureToolStripMenuItem
            // 
            this.deleteAPictureToolStripMenuItem.Name = "deleteAPictureToolStripMenuItem";
            this.deleteAPictureToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.deleteAPictureToolStripMenuItem.Text = "Delete the picture";
            this.deleteAPictureToolStripMenuItem.Click += new System.EventHandler(this.deleteAPictureToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // labelTimer
            // 
            this.labelTimer.BackColor = System.Drawing.Color.LightSlateGray;
            this.labelTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimer.Location = new System.Drawing.Point(439, 591);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(97, 39);
            this.labelTimer.TabIndex = 20;
            this.labelTimer.Text = "Timer";
            this.labelTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(674, 525);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(143, 45);
            this.trackBar1.TabIndex = 21;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(581, 410);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(200, 100);
            this.tabControl.TabIndex = 22;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 74);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tab1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(50, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "First tab";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tab2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(50, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Second tab";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnListClear
            // 
            this.btnListClear.Location = new System.Drawing.Point(868, 380);
            this.btnListClear.Name = "btnListClear";
            this.btnListClear.Size = new System.Drawing.Size(75, 23);
            this.btnListClear.TabIndex = 24;
            this.btnListClear.Text = "Clear";
            this.btnListClear.UseVisualStyleBackColor = true;
            this.btnListClear.Click += new System.EventHandler(this.btnListClear_Click);
            // 
            // numUpDown
            // 
            this.numUpDown.Location = new System.Drawing.Point(295, 531);
            this.numUpDown.Name = "numUpDown";
            this.numUpDown.Size = new System.Drawing.Size(120, 20);
            this.numUpDown.TabIndex = 25;
            // 
            // btnNumeric
            // 
            this.btnNumeric.Location = new System.Drawing.Point(313, 557);
            this.btnNumeric.Name = "btnNumeric";
            this.btnNumeric.Size = new System.Drawing.Size(75, 23);
            this.btnNumeric.TabIndex = 26;
            this.btnNumeric.Text = "Click";
            this.btnNumeric.UseVisualStyleBackColor = true;
            this.btnNumeric.Click += new System.EventHandler(this.btnNumeric_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(258, 432);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "Hello";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnSayHello_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(258, 458);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 28;
            this.button3.Text = "Trigger Hello";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnTriggerHello_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 633);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnNumeric);
            this.Controls.Add(this.numUpDown);
            this.Controls.Add(this.btnListClear);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.coordY);
            this.Controls.Add(this.coordX);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxServe);
            this.Controls.Add(this.myTree);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnColor3);
            this.Controls.Add(this.btnColor2);
            this.Controls.Add(this.btnColor1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelProgBar);
            this.Controls.Add(this.progBar);
            this.Controls.Add(this.picBoxSoup);
            this.Controls.Add(this.soupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSoup)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox soupBox;
        private System.Windows.Forms.PictureBox picBoxSoup;
        private System.Windows.Forms.ProgressBar progBar;
        private System.Windows.Forms.Label labelProgBar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnColor1;
        private System.Windows.Forms.Button btnColor2;
        private System.Windows.Forms.Button btnColor3;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TreeView myTree;
        private System.Windows.Forms.TextBox textBoxServe;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox coordX;
        private System.Windows.Forms.TextBox coordY;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAPictureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnListClear;
        private System.Windows.Forms.NumericUpDown numUpDown;
        private System.Windows.Forms.Button btnNumeric;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

