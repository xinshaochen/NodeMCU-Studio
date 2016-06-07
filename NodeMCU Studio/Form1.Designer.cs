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
            this.testtext = new System.Windows.Forms.TextBox();
            this.readlua = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textbox1
            // 
            this.textbox1.Location = new System.Drawing.Point(250, 14);
            this.textbox1.Multiline = true;
            this.textbox1.Name = "textbox1";
            this.textbox1.Size = new System.Drawing.Size(372, 282);
            this.textbox1.TabIndex = 0;
            // 
            // downloadbut
            // 
            this.downloadbut.Location = new System.Drawing.Point(639, 293);
            this.downloadbut.Name = "downloadbut";
            this.downloadbut.Size = new System.Drawing.Size(54, 23);
            this.downloadbut.TabIndex = 1;
            this.downloadbut.Text = "下载";
            this.downloadbut.UseVisualStyleBackColor = true;
            this.downloadbut.Click += new System.EventHandler(this.downloadbut_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(250, 302);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(372, 14);
            this.progressBar1.TabIndex = 2;
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
            this.filelist.Location = new System.Drawing.Point(172, 14);
            this.filelist.Name = "filelist";
            this.filelist.Size = new System.Drawing.Size(72, 280);
            this.filelist.TabIndex = 13;
            this.filelist.MouseClick += new System.Windows.Forms.MouseEventHandler(this.filelist_MouseClick);
            this.filelist.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.filelist_MouseDoubleClick);
            // 
            // openfeil
            // 
            this.openfeil.Location = new System.Drawing.Point(628, 14);
            this.openfeil.Name = "openfeil";
            this.openfeil.Size = new System.Drawing.Size(65, 23);
            this.openfeil.TabIndex = 14;
            this.openfeil.Text = "打开文件";
            this.openfeil.UseVisualStyleBackColor = true;
            this.openfeil.Click += new System.EventHandler(this.openfeil_Click);
            // 
            // savefile
            // 
            this.savefile.Location = new System.Drawing.Point(629, 43);
            this.savefile.Name = "savefile";
            this.savefile.Size = new System.Drawing.Size(64, 23);
            this.savefile.TabIndex = 15;
            this.savefile.Text = "保存文件";
            this.savefile.UseVisualStyleBackColor = true;
            this.savefile.Click += new System.EventHandler(this.savefile_Click);
            // 
            // testtext
            // 
            this.testtext.Location = new System.Drawing.Point(699, 16);
            this.testtext.Multiline = true;
            this.testtext.Name = "testtext";
            this.testtext.Size = new System.Drawing.Size(372, 282);
            this.testtext.TabIndex = 16;
            // 
            // readlua
            // 
            this.readlua.Location = new System.Drawing.Point(639, 264);
            this.readlua.Name = "readlua";
            this.readlua.Size = new System.Drawing.Size(54, 23);
            this.readlua.TabIndex = 17;
            this.readlua.Text = "读取";
            this.readlua.UseVisualStyleBackColor = true;
            this.readlua.Click += new System.EventHandler(this.readlua_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 320);
            this.Controls.Add(this.readlua);
            this.Controls.Add(this.testtext);
            this.Controls.Add(this.savefile);
            this.Controls.Add(this.openfeil);
            this.Controls.Add(this.filelist);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.downloadbut);
            this.Controls.Add(this.textbox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.TextBox testtext;
        private System.Windows.Forms.Button readlua;
    }
}

