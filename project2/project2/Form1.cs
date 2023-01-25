using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project2
{
    
    public partial class Form1 : Form
    {
        Graphics g;
        int x = -1;
        int y = -1;
        Boolean moving = false;
        Pen pen;


        Boolean finished = false;
        public Form1()
        {
            InitializeComponent();
            g =panel2.CreateGraphics();
            pen =  new Pen(Color.Black, 5);
           
            
        }

        private void openvidbut_Click(object sender, EventArgs e)
        {
            play myform = new play();
            Thread newform = new Thread(new ThreadStart(() =>
            {
                new play().ShowDialog();
            }));
            newform.SetApartmentState(ApartmentState.STA);
            newform.Start();


        }
        //[SecurityPermissionAttribute(SecurityAction.Demand, ControlThread = true)]
        private void button1_Click(object sender, EventArgs e)
        {
            
            Thread backgroundThread2 = new Thread(
            new ThreadStart(() =>
            {
                try
                {
                    for (int n = 0; n < 100; n++)
                    {
                     
                        Action safeWrite = delegate { progressBar1.Value = n; };
                        progressBar1.Invoke(safeWrite);
                        if (n == 50) { this.finished = true; break; }

                    }
                }
                finally {
                  //  stopthread();
                    
                }
            
            }
            
            ));

            backgroundThread2.Start();
            backgroundThread2.Join(500);

            //this doesnt work as the main thread must be finished to join this that wont happen here
            //backgroundThread2.Join();
                if (finished)
                {

                    MessageBox.Show("bebbin");
                    backgroundThread2.Abort();

                }
            


            

            
        }

        
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            x = e.X;
            y = e.Y;    
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving && x != -1 && y != -1)
            {
                g.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y=e.Y;
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            moving =false;  
            x = -1;
            y = -1;

        }
    }

}

