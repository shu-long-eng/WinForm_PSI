using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormPSI.Model;

namespace WinFormPSI
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            using (var context = new PSIsystemModel())
            {   //取出資料
                var query = context.Purchases.Where(item => item.Isdelete != true)
                    .GroupBy(item => new { item.ID, item.Date, item.Creator })
                    .Select(item => new
                    {
                        ID = item.Key.ID,
                        CountID = item.Count(),
                        Count = (int)item.Sum(x => x.Count),
                        Date = (DateTime)item.Key.Date,
                        Total = (decimal)item.Sum(x => x.Total),
                        Creator = item.Key.Creator

                    }).ToList();
                //匯入水晶報表資料
                
                CrystalReport1 crp = new CrystalReport1();
                this.CrystalReport11.SetDataSource(query);
                
            }
        }
    }
}
