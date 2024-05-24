using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oborudovanie
{
    public partial class SotrudnikForm : Form
    {
        public SotrudnikForm()
        {
            InitializeComponent();
        }

        private void SotrudnikForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "oborudovanieDataSet2.Polzovateli". При необходимости она может быть перемещена или удалена.
            this.polzovateliTableAdapter1.Fill(this.oborudovanieDataSet2.Polzovateli);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "oborudovanieDataSet1.Polzovateli". При необходимости она может быть перемещена или удалена.
            this.polzovateliTableAdapter.Fill(this.oborudovanieDataSet1.Polzovateli);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "oborudovanieDataSet.Oborudovanie". При необходимости она может быть перемещена или удалена.
            this.oborudovanieTableAdapter.Fill(this.oborudovanieDataSet.Oborudovanie);

        }
    }
}
