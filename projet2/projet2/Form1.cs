using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularArea_Click(object sender, EventArgs e)
        {

            Aresta objeAresta = new Aresta();
            objeAresta.setAresta(int.Parse(txtAresta.Text));
            objeAresta.Arestaarea();
            lblArea.Text = objeAresta.getArea().ToString();
            
        }
    }
}
