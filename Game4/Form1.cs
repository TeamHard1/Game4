using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game4
{
    public partial class Form1 : Form, IView
    {
        private IView view;
        private IController controller;
        public Form1()
        {
            InitializeComponent();


        }

        public void PaintShape(int i, int j)
        {
            throw new NotImplementedException();
        }

        public void SetInFild(int i, int j)
        {
            controller.UpdateModel( i, j);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            Button[,] button;
            button = new Button[7, 5]; 

            for (int i = 0; i < 7; i++)
                for (int j = 0; j < 5; j++)
                {
                    button[i, j] = new Button();
                    button[i, j].Parent = pole; 


                }
        }
    }
}
