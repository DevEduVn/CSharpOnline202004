using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson11.WForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DEVHRMEntities db = new DEVHRMEntities();
            var dmTinh = db.DM_TINH_THANH.ToList();

            dataGridView1.DataSource = dmTinh;
        }
    }
}
