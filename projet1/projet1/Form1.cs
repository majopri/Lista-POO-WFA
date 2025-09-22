using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularArea_Click(object sender, EventArgs e)
        {
            Area objArea = new Area();
            objArea.setaltura(int.Parse(txtAltura.Text));
            objArea.setBase(int.Parse(txtBase.Text));
            objArea.calcularArea();
            lblArea.Text=objArea.getArea().ToString();
        }
    }
}
