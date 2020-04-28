using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson11.LinqEntityFramework
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DEVHRMEntities db = new DEVHRMEntities();
            var dmTinh = db.DM_TINH_THANH.ToList();

            dataGridView1.DataSource = dmTinh;
        }
    }
}
