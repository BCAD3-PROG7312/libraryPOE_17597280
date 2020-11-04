using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libraryPOE_17597280
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnOrderCallNum_Click(object sender, EventArgs e)
        {
            ReplaceBooks rb = new ReplaceBooks();
            rb.Show();
            this.Hide();
        }

        private void btnIA_Click(object sender, EventArgs e)
        {
            IdentifyAreas rb = new IdentifyAreas();
            rb.Show();
             this.Hide();
        }

        private void btnTree_Click(object sender, EventArgs e)
        {
            Form1 rb = new Form1();
            rb.Show();
           this.Hide();
        }
    }
}
