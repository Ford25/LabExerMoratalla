using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MoratallaLabMidterm
{
    public partial class FrmBasicThread : Form
    {
        


        public FrmBasicThread()
        {
            InitializeComponent();

            //Thread basicThread1 = Thread.CurrentThread;

            //basicThread1.Name = "Thread A";


           
           


        }



        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

            ThreadStart th = new ThreadStart(MyThreadClass.Thread1);
            Thread threadA = new Thread(th);
            threadA.Name = "Thread A";

            Thread threadB = new Thread(th);
            threadB.Name = "Thread B";


            threadA.Start();
            threadB.Start();
            threadA.Join();
            threadB.Join();

           
            label1.Text = "-End Of Thread-";

            
        }

        private void FrmBasicThread_Load(object sender, EventArgs e)
        {


            



        }
    }
}
