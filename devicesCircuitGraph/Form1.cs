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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        circuit c = new circuit();

        private void Form1_Load(object sender, EventArgs e)
        {
            //d1
            device1.setValuePin1(1);
            device1.setColorPin1(1);

            device1.setValuePin2(1);
            device1.setColorPin2(1);

            device1.setValuePin3(c.c.add(device1.getValuePin1(),device1.getValuePin2()));
            device1.setColorPin3(device1.getValuePin3());

            //d2
            device2.setValuePin1(device1.getValuePin3());
            device2.setColorPin1(device1.getValuePin1());

            device2.setValuePin2(1);
            device2.setColorPin2(1);

            device2.setValuePin3(c.c.add(device2.getValuePin1(), device2.getValuePin2()));
            device2.setColorPin3(device2.getValuePin3());

            //d3
            device3.setValuePin1(device2.getValuePin3());
            device3.setColorPin1(device2.getValuePin1());

            device3.setValuePin2(1);
            device3.setColorPin2(1);

            device3.setValuePin3(c.c.add(device3.getValuePin1(), device3.getValuePin2()));
            device3.setColorPin3(device3.getValuePin3());

        }
    }
}
