using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObserverPatternYMOdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            // Yatırımcıları oluşturur
            Yatirimci s = new Yatirimci("George Soros");
            Yatirimci b = new Yatirimci("Berkshire Hathaway");

            // IBM hisse senedini oluşturur ve yatırımcıları ekler
            IBM ibm = new IBM("IBM", 120.00);
            ibm.Attach(s);
            ibm.Attach(b);

            // Yatırımcılara bildirilen değişen değerler
            ibm.Deger = 120.10;
            ibm.Deger = 121.00;
            ibm.Deger = 120.50;
            ibm.Deger = 120.75;
            ibm.Deger = 122.05;

        }
    }
}
