using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NodeMCU_Studio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            foreach (string s in SerialPort.GetPortNames())
            {
                端口cbox.Items.Add(s);
            }
            //端口cbox.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "NodeMCU Studio";
            this.Text = "超声波";

            波特率cbox.Items.Add("9600");
            波特率cbox.Items.Add("115200");
            波特率cbox.SelectedIndex = 0;
            //downloadbut.Enabled = false;
            textbox1.ScrollBars = ScrollBars.Both;
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(portDataReceived);
            
        }

        string readbuf;
        private void portDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] buf = new byte[1024];
            int len = serialPort1.Read(buf, 0, 1024);
            readbuf += Encoding.Default.GetString(buf);
            readlua.Text = readbuf;

        }
            bool buts = false;
        private void 连接but_Click(object sender, EventArgs e)
        {

            buts = !buts;
            if (buts == true)
            {

                try
                {
                    
                    serialPort1.PortName = 端口cbox.Text;
                    serialPort1.BaudRate = Convert.ToInt32(波特率cbox.Text, 10);
                    serialPort1.Parity = Parity.None;
                    serialPort1.DataBits = 8;
                    serialPort1.StopBits = StopBits.One;
                    serialPort1.Open();
                    连接but.Text = "断开";
                   downloadbut.Enabled = true;


                }
                catch
                {
                    MessageBox.Show("端口错误", "错误");
                }



            }
            else
            {
                try
                {
                    serialPort1.Close();
                    连接but.Text = "连接";
                }
                catch
                {

                    throw;
                }

            }
        }
        private void 端口cbox_MouseClick(object sender, MouseEventArgs e)
        {
            端口cbox.Items.Clear();
            foreach (string s in SerialPort.GetPortNames())
            {
                端口cbox.Items.Add(s);
            }
            //端口cbox.SelectedIndex = 0;
        }

        uint l = 0;
        List<string> filestr = new List<string>();
        List<string> text = new List<string>(); 
        private void openfeil_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Lua files (*.lua)|*.lua|All files (*.*)|*.*"; //过滤文件类型
            fd.Multiselect = true;//多选文件
            fd.InitialDirectory = Application.StartupPath+"lua";//设定初始目录
            //fd.ShowReadOnly = true; //设定文件是否只读
            DialogResult r = fd.ShowDialog();
            if(r==DialogResult.OK)
            {
                
                foreach (string filename in fd.FileNames)
                {
                    FileStream fs = new FileStream(filename,FileMode.Open);
                    StreamReader Reader = new StreamReader(fs);
                    //while (!Reader.EndOfStream)
                    //{
                        text.Add(Reader.ReadToEnd());
                   // }
                   
                    Reader.Close();
                }
                foreach (string str in fd.SafeFileNames)
                {
                    filelist.Items.Add(str);
                    
                }
                foreach(string str in fd.FileNames)
                {
                    filestr.Add(str);
                }

                //string[] strs = fd.SafeFileNames;
                //filestr = fd.FileNames;
                //foreach (string str in strs)
                //{
                //    filelist.Items.Add(str);
                //}
                filelist.SelectedIndex = 0;
                lastSelectedIndex = 0;
                textbox1.Text = text[0];

            }
        }
        int lastSelectedIndex;
        private void filelist_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (filelist.SelectedItem != null &&  filelist.Items.Count> 0 && lastSelectedIndex!=filelist.SelectedIndex)
            {
                text[lastSelectedIndex] = textbox1.Text;
                lastSelectedIndex = filelist.SelectedIndex;
                textbox1.Text = text[filelist.SelectedIndex];
               // FileStream fs = new FileStream(filestr[filelist.SelectedIndex],FileMode.Open);
               // StreamReader Reader = new StreamReader(fs);
               // textbox1.Clear();
               //while(!Reader.EndOfStream)
               // {
               //     textbox1.Text += Reader.ReadToEnd(); 
               // }
               // Reader.Close();

            }
        }

        uint readmode = 0;
        private void downloadbut_Click(object sender, EventArgs e)
        {
            text[filelist.SelectedIndex] = textbox1.Text;
            string strtext=textbox1.Text;
            strtext = strtext.Replace("\"","\\\"");
            string[] ContenLines = strtext.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);//忽略空行

            
           testtext.Text += "file.remove(\"" + filelist.SelectedItem + "\")"+"\r\n";
            testtext.Text += "file.open(\"" + filelist.SelectedItem + "\",\"w+\")" + "\r\n";

           // serialPort1.WriteLine("file.remove(\"" + filelist.SelectedItem+"\")");
           // serialPort1.WriteLine("file.open(\"" + filelist.SelectedItem + "\",\"w+\")");


            foreach (string str in ContenLines)
            {
                testtext.Text += "file.writeline(\"" + str + "\")" + "\r\n";
                //serialPort1.WriteLine("file.writeline(\"" + str + "\")" + "\r\n");
            }

            testtext.Text += "file.close()";
            
           // serialPort1.WriteLine("file.close()");

        }

        private void Form1_Resize(object sender, EventArgs e)
        {

        }

        private void savefile_Click(object sender, EventArgs e)
        {
            int l = 0;
            text[filelist.SelectedIndex] = textbox1.Text;
            foreach(string str in filestr)
            {
                File.WriteAllText(str,text[l]);
                l++;
            }
        }

        private void filelist_MouseClick(object sender, MouseEventArgs e)
        {
            if (filelist.SelectedItem != null && filelist.Items.Count > 0 && lastSelectedIndex != filelist.SelectedIndex)
            {
                text[lastSelectedIndex] = textbox1.Text;
                lastSelectedIndex = filelist.SelectedIndex;
                textbox1.Text = text[filelist.SelectedIndex];
                // FileStream fs = new FileStream(filestr[filelist.SelectedIndex],FileMode.Open);
                // StreamReader Reader = new StreamReader(fs);
                // textbox1.Clear();
                //while(!Reader.EndOfStream)
                // {
                //     textbox1.Text += Reader.ReadToEnd(); 
                // }
                // Reader.Close();

            }
        }

        private void readlua_Click(object sender, EventArgs e)
        {

        }
    }
}
