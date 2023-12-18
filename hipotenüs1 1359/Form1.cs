using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hipotenüs1_1359
{
    public partial class lblHipotenus : Form
    {
        public lblHipotenus()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double kenar1 = Convert.ToDouble(txtKenar1.Text);
            double kenar2 = Convert.ToDouble(txtKenar2.Text);

            double kenarHipotenus = Math.Sqrt ( Math.Pow(kenar1,2) + Math.Pow(kenar2, 2) );

            lblHipoten.Text = $"1.kenarı{kenar1} \n2.kenar{kenar1}\n2hipotenus{kenarHipotenus}";
        }
    }
}
