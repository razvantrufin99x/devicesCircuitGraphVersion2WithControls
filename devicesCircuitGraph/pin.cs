using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace devicesCircuitGraph
{
    public partial class pin : UserControl
    {
        public pin()
        {
            InitializeComponent();
        }
        public int value = 0;
        public bool changeColor()
        {
            if (value == 1) { this.BackColor = Color.Green; return true; }
            else { this.BackColor = Color.Red; return false; }
        }
        public bool changeValue()
        {
            if (value == 0) { value = 1; return true; }
            else { value = 0; return false; }
        }
        public void setValue(int x)
        {
            value = x;
        }
        public int getValue()
        {
            return value;
        }
        public Color getColor()
        {
            return this.BackColor;
        }
        public void setColor(Color c)
        {
            BackColor = c;
        }
        public bool setColor(int v)
        {
            if (v == 1) { this.BackColor = Color.Green; return true; }
            else { this.BackColor = Color.Red; return false; }
        }
        private void pin_Click(object sender, EventArgs e)
        {
            changeValue();
            changeColor();
           
        }



        public int codpin;
      
       
      


        private void pin_Load(object sender, EventArgs e)
        {

        }
    }
}
