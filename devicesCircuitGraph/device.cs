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
    public partial class device : UserControl
    {
        public device()
        {
            InitializeComponent();
        }
        public void setLabel(string s)
        { 
            this.label1.Text = s;
        }

        public int coddevice;

        public void setValuePin1(int px)
        { 
            this.pin1.setValue(px);
        }
        public void setValuePin2(int px)
        {
            this.pin2.setValue(px);
        }
        public void setValuePin3(int px)
        {
            this.pin3.setValue(px);
        }

        public void setColorPin1(int px)
        {
            this.pin1.setColor(px);
        }
        public void setColorPin2(int px)
        {
            this.pin2.setColor(px);
        }
        public void setColorPin3(int px)
        {
            this.pin3.setColor(px);
        }
        public int getValuePin1()
        { 
            return this.pin1.getValue();
        }
        public Color getColorPin1()
        {
            return this.pin1.getColor();
        }
        public int getValuePin2()
        {
            return this.pin2.getValue();
        }
        public Color getColorPin2()
        {
            return this.pin2.getColor();
        }
        public int getValuePin3()
        {
            return this.pin3.getValue();
        }
        public Color getColorPin3()
        {
            return this.pin3.getColor();
        }

        private void device_Load(object sender, EventArgs e)
        {

        }
    }
}
