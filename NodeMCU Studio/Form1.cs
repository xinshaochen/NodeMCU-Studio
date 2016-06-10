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
        Timer t = new Timer();
        Timer ti = new Timer();
        public Form1()
        {
            InitializeComponent();
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            
            //端口cbox.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //filelist.ContextMenuStrip = contextMenuStrip1;
            this.Text = "NodeMCU Studio";

            波特率cbox.Items.Add("9600");
            波特率cbox.Items.Add("115200");
            波特率cbox.SelectedIndex = 0;
            //downloadbut.Enabled = false;
            textbox1.ScrollBars = ScrollBars.Both;
            testtext.ScrollBars = ScrollBars.Both;
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(portDataReceived);

            foreach (string s in SerialPort.GetPortNames())
            {
                端口cbox.Items.Add(s);
            }
            端口cbox.SelectedIndex = 0;
            连接but_Click(this,null);




            t.Interval = 200;
            t.Tick += new EventHandler((object s, EventArgs ex) =>
              {
                  
                      serialPort1.WriteLine(portbuf[i]);
                     // testtext.Text += (portbuf[i] + "\r\n");
                  i++;
                  //serialPort1.WriteLine("print(\"a\")");
                  //if (readbuf.IndexOf("a")!=-1)
                  //{
                  //    readok = 1;
                  //    t.Stop();
                  //}
                  progressBar1.Value = i;
                  if (i>=portbuf.Count)
                  {
                      t.Stop();
                      i = 0;
                      MessageBox.Show("下载完成","下载完成");
                  }
              });
            ti.Interval = 300;
            ti.Tick += new EventHandler((object s, EventArgs ex) =>
             {
                 switch(readmode)
                 {
                     case 0:
                         break;
                     case 1:
                         serialPort1.WriteLine("print(node.chipid())");
                         break;
                     case 2:
                         serialPort1.WriteLine(portbuf[portint]);
                         break;
                     case 3:
                         serialPort1.WriteLine(portbuf[portint]);
                         break;
                 }
             });
            ti.Start();

            
        }
        int portint=0;

        int i = 0;
        int readok = 0;

        string readbuf=null;
        private void portDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            
            byte[] buf = new byte[1024];
            int len = serialPort1.Read(buf, 0, 1024);
            readbuf = Encoding.Default.GetString(buf);
            testtext.Text += readbuf;
            switch (readmode)
            {
                case 1:
                    readbuf = readbuf.Replace("print(node.chipid())", "");
                    readbuf = readbuf.Replace("> ", "");
                    byte[] bytes = Encoding.ASCII.GetBytes(readbuf);
                    if (bytes.Length < 8) break;
                    uint s = 0;
                    int i;
                    for(i=0;i<8;i++)
                    {
                        if (bytes[i] < 0x30 || bytes[i] > 0x39)
                            break;
                    }
                    if(i>=8)
                    {
                        idname.Text = readbuf;
                        readmode = 0;
                    }
                    
                    break;
                case 2:
                    //readbuf = readbuf.Replace(portbuf[portint], "");
                    //readbuf = readbuf.Replace("> ", "");
                    //if (readbuf.IndexOf("\r\n")!=-1)
                        portint++;
                    if(portint>=1)
                    {
                        readmode = 3;
                    }
                    if (portint >= portbuf.Count)
                        readmode = 0;
                    break;
                case 3:
                    readbuf = readbuf.Replace(portbuf[portint], "");
                    readbuf = readbuf.Replace("> ", "");
                    if (readbuf.IndexOf("true")!=-1)
                        portint++;
                    if(portint>=(portbuf.Count-2))
                    {
                        readmode = 2;
                    }


                    break;
            }

            //if(readbuf.IndexOf("a")!=-1)
            //{
            //    t.Stop();
            //    readok = 1;
            //}
        }
            bool buts = false;
        private void 连接but_Click(object sender, EventArgs e)
        {

            buts = !buts;
            readmode = 0;
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
        List<string> portbuf = new List<string>();
        private void downloadbut_Click(object sender, EventArgs e)
        {
           
            serialPort1.BaudRate = Convert.ToInt32(波特率cbox.Text, 10);

            testtext.Clear();
            text[filelist.SelectedIndex] = textbox1.Text;
            string strtext=textbox1.Text;
            strtext = strtext.Replace("\"","\\\"");
            string[] ContenLines = strtext.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);//忽略空行
            
            portbuf.Clear();
            portbuf.Add("print(file.remove(\"" + filelist.SelectedItem + "\"))");
            portbuf.Add("print(file.open(\"" + filelist.SelectedItem + "\",\"w+\"))");



            //testtext.Text += "print(file.remove(\"" + filelist.SelectedItem + "\"))"+"\r\n";
            // testtext.Text += "print(file.open(\"" + filelist.SelectedItem + "\",\"w+\"))" + "\r\n";


            //serialPort1.WriteLine("print(file.remove(\"" + filelist.SelectedItem + "\"))");
                
            
            //serialPort1.WriteLine("print(file.open(\"" + filelist.SelectedItem + "\",\"w+\"))");


            foreach (string str in ContenLines)
            {
                //testtext.Text += "print(file.writeline(\"" + str + "\"))" + "\r\n";
                //serialPort1.WriteLine("print(file.writeline(\"" + str + "\"))");
                portbuf.Add("print(file.writeline(\"" + str + "\"))");
            }

            portbuf.Add("print(file.close())");

            portbuf.Add("node.restart()");

            //testtext.Text += "print(file.close())";

            //serialPort1.WriteLine("print(file.close())");
            progressBar1.Maximum = portbuf.Count;
            //readmode = 2;
           t.Start();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {

        }

        private void savefile_Click(object sender, EventArgs e)
        {
            int l = 0;
            if (filelist.Items.Count == 0) return;
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
            idname.Clear();
            if(serialPort1.IsOpen==true)
            readmode = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t.Start();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            text.RemoveAt(filelist.SelectedIndex);
            filestr.RemoveAt(filelist.SelectedIndex);
            filelist.Items.RemoveAt(filelist.SelectedIndex);
        }

        private void filelist_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Right)
            {
                int posindex = filelist.IndexFromPoint(new Point(e.X, e.Y));
                filelist.ContextMenuStrip = null;
                if (posindex >= 0&&posindex<filelist.Items.Count)
                {
                    filelist.SelectedIndex = posindex;
                    contextMenuStrip1.Show(filelist, new Point(e.X,e.Y));

                }
            }
            filelist.Refresh();//
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        bool initcbox = true;
        private void 波特率cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(initcbox == true)
            {
                initcbox = false;

            
            }
            else
            if(serialPort1.IsOpen==true)
            {
                readmode = 0;
                serialPort1.Close();

try
            {

                serialPort1.PortName = 端口cbox.Text;
                serialPort1.BaudRate = Convert.ToInt32(波特率cbox.Text, 10);
                serialPort1.Parity = Parity.None;
                serialPort1.DataBits = 8;
                serialPort1.StopBits = StopBits.One;
                serialPort1.Open();
                //    连接but.Text = "断开";
                //    downloadbut.Enabled = true;


                }
            catch
            {
                MessageBox.Show("端口错误", "错误");
            }


            }
            
            
        }
    }
}
