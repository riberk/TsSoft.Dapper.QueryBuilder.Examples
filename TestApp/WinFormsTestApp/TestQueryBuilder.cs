using System;
using System.Windows.Forms;
using TsSoft.Dapper.QueryBuilder;
using TsSoft.Dapper.QueryBuilder.Models.Enumerations;
using WinFormsTestApp.Criterias;
using System.Linq;

namespace WinFormsTestApp
{
    public partial class TestQueryBuilder : Form
    {
        public TestQueryBuilder()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            var values = Enum.GetValues(typeof (QueryType)).Cast<QueryType>();
            foreach (var queryType in values)
            {
                comboQueryType.Items.Add(queryType);
            }
            comboQueryType.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var houseCriteria = new HouseCriteria();
            int iTmp;
            long lTmp;
            if (int.TryParse(tbId.Text, out iTmp))
            {
                houseCriteria.Id = iTmp;
            }
            if (int.TryParse(tbOwnerId.Text, out iTmp))
            {
                houseCriteria.OwnerId = iTmp;
            }
            if (long.TryParse(tbPriceFrom.Text, out lTmp))
            {
                houseCriteria.PriceFrom = lTmp;
            }
            if (long.TryParse(tbPriceTo.Text, out lTmp))
            {
                houseCriteria.PriceTo = lTmp;
            }
            houseCriteria.PersonFullName = string.IsNullOrWhiteSpace(tbPersonFullName.Text) ? null : tbPersonFullName.Text;
            houseCriteria.WithPersons = chkWithPersons.Checked;
            houseCriteria.QueryType = (QueryType) comboQueryType.SelectedItem;
            houseCriteria.Skip = int.TryParse(tbSkip.Text, out iTmp) ? iTmp : 0;
            houseCriteria.Take = int.TryParse(tbTake.Text, out iTmp) ? iTmp : 0;
            var res = new QueryBuilder<HouseCriteria>(houseCriteria).Build();
            rtbResult.Text = res.Sql;
        }
    }
}