namespace NodeMCU_Studio
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textbox1 = new System.Windows.Forms.TextBox();
            this.downloadbut = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.端口cbox = new System.Windows.Forms.ComboBox();
            this.波特率cbox = new System.Windows.Forms.ComboBox();
            this.连接but = new System.Windows.Forms.Button();
            this.filelist = new System.Windows.Forms.ListBox();
            this.openfeil = new System.Windows.Forms.Button();
            this.savefile = new System.Windows.Forms.Button();
            this.ravetext = new System.Windows.Forms.TextBox();
            this.readlua = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.idname = new System.Windows.Forms.TextBox();
            this.SSIDtxtbox = new System.Windows.Forms.TextBox();
            this.Passwordtxtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.asdwqss = new System.Windows.Forms.Label();
            this.SaveSSID = new System.Windows.Forms.Button();
            this.cleartest = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.button12 = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textbox1
            // 
            this.textbox1.Location = new System.Drawing.Point(85, 6);
            this.textbox1.Multiline = true;
            this.textbox1.Name = "textbox1";
            this.textbox1.Size = new System.Drawing.Size(372, 421);
            this.textbox1.TabIndex = 0;
            // 
            // downloadbut
            // 
            this.downloadbut.Location = new System.Drawing.Point(475, 424);
            this.downloadbut.Name = "downloadbut";
            this.downloadbut.Size = new System.Drawing.Size(54, 23);
            this.downloadbut.TabIndex = 1;
            this.downloadbut.Text = "下载";
            this.downloadbut.UseVisualStyleBackColor = true;
            this.downloadbut.Click += new System.EventHandler(this.downloadbut_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(8, 433);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(450, 14);
            this.progressBar1.TabIndex = 2;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.端口cbox);
            this.groupBox3.Controls.Add(this.波特率cbox);
            this.groupBox3.Controls.Add(this.连接but);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(154, 117);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "串口设置";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "端口：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "波特率：";
            // 
            // 端口cbox
            // 
            this.端口cbox.FormattingEnabled = true;
            this.端口cbox.Location = new System.Drawing.Point(65, 18);
            this.端口cbox.Name = "端口cbox";
            this.端口cbox.Size = new System.Drawing.Size(60, 20);
            this.端口cbox.TabIndex = 4;
            this.端口cbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.端口cbox_MouseClick);
            // 
            // 波特率cbox
            // 
            this.波特率cbox.FormattingEnabled = true;
            this.波特率cbox.Location = new System.Drawing.Point(65, 52);
            this.波特率cbox.Name = "波特率cbox";
            this.波特率cbox.Size = new System.Drawing.Size(60, 20);
            this.波特率cbox.TabIndex = 5;
            this.波特率cbox.SelectedIndexChanged += new System.EventHandler(this.波特率cbox_SelectedIndexChanged);
            // 
            // 连接but
            // 
            this.连接but.Location = new System.Drawing.Point(6, 88);
            this.连接but.Name = "连接but";
            this.连接but.Size = new System.Drawing.Size(39, 23);
            this.连接but.TabIndex = 3;
            this.连接but.Text = "连接";
            this.连接but.UseVisualStyleBackColor = true;
            this.连接but.Click += new System.EventHandler(this.连接but_Click);
            // 
            // filelist
            // 
            this.filelist.FormattingEnabled = true;
            this.filelist.ItemHeight = 12;
            this.filelist.Location = new System.Drawing.Point(7, 6);
            this.filelist.Name = "filelist";
            this.filelist.Size = new System.Drawing.Size(72, 412);
            this.filelist.TabIndex = 13;
            this.filelist.MouseClick += new System.Windows.Forms.MouseEventHandler(this.filelist_MouseClick);
            this.filelist.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.filelist_MouseDoubleClick);
            this.filelist.MouseUp += new System.Windows.Forms.MouseEventHandler(this.filelist_MouseUp);
            // 
            // openfeil
            // 
            this.openfeil.Location = new System.Drawing.Point(463, 6);
            this.openfeil.Name = "openfeil";
            this.openfeil.Size = new System.Drawing.Size(65, 23);
            this.openfeil.TabIndex = 14;
            this.openfeil.Text = "打开文件";
            this.openfeil.UseVisualStyleBackColor = true;
            this.openfeil.Click += new System.EventHandler(this.openfeil_Click);
            // 
            // savefile
            // 
            this.savefile.Location = new System.Drawing.Point(464, 35);
            this.savefile.Name = "savefile";
            this.savefile.Size = new System.Drawing.Size(64, 23);
            this.savefile.TabIndex = 15;
            this.savefile.Text = "保存文件";
            this.savefile.UseVisualStyleBackColor = true;
            this.savefile.Click += new System.EventHandler(this.savefile_Click);
            // 
            // ravetext
            // 
            this.ravetext.Location = new System.Drawing.Point(6, 3);
            this.ravetext.Multiline = true;
            this.ravetext.Name = "ravetext";
            this.ravetext.Size = new System.Drawing.Size(522, 201);
            this.ravetext.TabIndex = 16;
            // 
            // readlua
            // 
            this.readlua.Location = new System.Drawing.Point(106, 170);
            this.readlua.Name = "readlua";
            this.readlua.Size = new System.Drawing.Size(54, 23);
            this.readlua.TabIndex = 17;
            this.readlua.Text = "读取";
            this.readlua.UseVisualStyleBackColor = true;
            this.readlua.Click += new System.EventHandler(this.readlua_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 20;
            this.label1.Text = "芯片ID：";
            // 
            // idname
            // 
            this.idname.Location = new System.Drawing.Point(66, 144);
            this.idname.Name = "idname";
            this.idname.Size = new System.Drawing.Size(100, 21);
            this.idname.TabIndex = 21;
            // 
            // SSIDtxtbox
            // 
            this.SSIDtxtbox.Location = new System.Drawing.Point(9, 217);
            this.SSIDtxtbox.Name = "SSIDtxtbox";
            this.SSIDtxtbox.Size = new System.Drawing.Size(157, 21);
            this.SSIDtxtbox.TabIndex = 22;
            // 
            // Passwordtxtbox
            // 
            this.Passwordtxtbox.Location = new System.Drawing.Point(9, 256);
            this.Passwordtxtbox.Name = "Passwordtxtbox";
            this.Passwordtxtbox.Size = new System.Drawing.Size(157, 21);
            this.Passwordtxtbox.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 24;
            this.label4.Text = "SSID:";
            // 
            // asdwqss
            // 
            this.asdwqss.AutoSize = true;
            this.asdwqss.Location = new System.Drawing.Point(7, 241);
            this.asdwqss.Name = "asdwqss";
            this.asdwqss.Size = new System.Drawing.Size(59, 12);
            this.asdwqss.TabIndex = 25;
            this.asdwqss.Text = "Password:";
            // 
            // SaveSSID
            // 
            this.SaveSSID.Location = new System.Drawing.Point(106, 283);
            this.SaveSSID.Name = "SaveSSID";
            this.SaveSSID.Size = new System.Drawing.Size(54, 23);
            this.SaveSSID.TabIndex = 26;
            this.SaveSSID.Text = "Save";
            this.SaveSSID.UseVisualStyleBackColor = true;
            this.SaveSSID.Click += new System.EventHandler(this.SaveSSID_Click);
            // 
            // cleartest
            // 
            this.cleartest.Location = new System.Drawing.Point(472, 207);
            this.cleartest.Name = "cleartest";
            this.cleartest.Size = new System.Drawing.Size(54, 23);
            this.cleartest.TabIndex = 27;
            this.cleartest.Text = "Clear";
            this.cleartest.UseVisualStyleBackColor = true;
            this.cleartest.Click += new System.EventHandler(this.cleartest_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(172, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(540, 479);
            this.tabControl1.TabIndex = 28;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textbox1);
            this.tabPage1.Controls.Add(this.downloadbut);
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Controls.Add(this.filelist);
            this.tabPage1.Controls.Add(this.openfeil);
            this.tabPage1.Controls.Add(this.savefile);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(532, 453);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "lua下载";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox13);
            this.tabPage2.Controls.Add(this.button12);
            this.tabPage2.Controls.Add(this.cleartest);
            this.tabPage2.Controls.Add(this.button9);
            this.tabPage2.Controls.Add(this.textBox10);
            this.tabPage2.Controls.Add(this.textBox11);
            this.tabPage2.Controls.Add(this.button10);
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.textBox8);
            this.tabPage2.Controls.Add(this.textBox9);
            this.tabPage2.Controls.Add(this.button8);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.ravetext);
            this.tabPage2.Controls.Add(this.textBox6);
            this.tabPage2.Controls.Add(this.textBox7);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.textBox5);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(532, 453);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "多项发送";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(505, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(270, 236);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(229, 21);
            this.textBox3.TabIndex = 18;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 234);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(229, 21);
            this.textBox2.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(505, 263);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(23, 23);
            this.button3.TabIndex = 23;
            this.button3.Text = "4";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(270, 263);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(229, 21);
            this.textBox4.TabIndex = 22;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(6, 261);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(229, 21);
            this.textBox5.TabIndex = 21;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(241, 261);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(23, 23);
            this.button4.TabIndex = 20;
            this.button4.Text = "3";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(505, 290);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(23, 23);
            this.button5.TabIndex = 27;
            this.button5.Text = "6";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(270, 290);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(229, 21);
            this.textBox6.TabIndex = 26;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(6, 288);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(229, 21);
            this.textBox7.TabIndex = 25;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(241, 288);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(23, 23);
            this.button6.TabIndex = 24;
            this.button6.Text = "5";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(505, 317);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(23, 23);
            this.button7.TabIndex = 31;
            this.button7.Text = "8";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(270, 317);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(229, 21);
            this.textBox8.TabIndex = 30;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(6, 315);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(229, 21);
            this.textBox9.TabIndex = 29;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(241, 315);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(23, 23);
            this.button8.TabIndex = 28;
            this.button8.Text = "7";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(501, 344);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(31, 23);
            this.button9.TabIndex = 35;
            this.button9.Text = "10";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(270, 344);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(229, 21);
            this.textBox10.TabIndex = 34;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(6, 342);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(229, 21);
            this.textBox11.TabIndex = 33;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(241, 342);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(23, 23);
            this.button10.TabIndex = 32;
            this.button10.Text = "9";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(6, 369);
            this.textBox13.Multiline = true;
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(493, 78);
            this.textBox13.TabIndex = 37;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(501, 373);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(31, 23);
            this.button12.TabIndex = 36;
            this.button12.Text = "11";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 494);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.SaveSSID);
            this.Controls.Add(this.asdwqss);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Passwordtxtbox);
            this.Controls.Add(this.SSIDtxtbox);
            this.Controls.Add(this.idname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.readlua);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox1;
        private System.Windows.Forms.Button downloadbut;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox 端口cbox;
        private System.Windows.Forms.ComboBox 波特率cbox;
        private System.Windows.Forms.Button 连接but;
        private System.Windows.Forms.ListBox filelist;
        private System.Windows.Forms.Button openfeil;
        private System.Windows.Forms.Button savefile;
        private System.Windows.Forms.TextBox ravetext;
        private System.Windows.Forms.Button readlua;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idname;
        private System.Windows.Forms.TextBox SSIDtxtbox;
        private System.Windows.Forms.TextBox Passwordtxtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label asdwqss;
        private System.Windows.Forms.Button SaveSSID;
        private System.Windows.Forms.Button cleartest;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button4;
    }
}

