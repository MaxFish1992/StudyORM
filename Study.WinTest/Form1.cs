using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study.WinTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ILog m_log = LogManager.GetLogger("Form1");
            m_log.Debug("这是一个Debug日志" + 2);
            m_log.Info("这是一个Info日志");
            m_log.Warn("这是一个Warn日志");
            m_log.Error("这是一个Error日志");
            string temp1 = "helloworld";
            m_log.Fatal(temp1);
        }
    }
}
