using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using Dapper;
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
                houseCriteria.HouseId = iTmp;
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
            rtbSplitOn.Text = res.SplitOn;
            rtbResult.Text = res.Sql;
            var parameters = GetKeyValues(ToDynamicParameters(res.Parameters));
            dgvParameters.Rows.Clear();

            //lbParameters.Items.Clear();
            foreach (var parameter in parameters)
            {
                dgvParameters.Rows.Add(new []{parameter.Key, parameter.Value.GetType(), parameter.Value});
            }
        }

        private static Dictionary<string, object> GetKeyValues(DynamicParameters dp)
        {
            var all = Enum.GetValues(typeof(BindingFlags))
                          .Cast<BindingFlags>()
                          .Aggregate((BindingFlags)0, (flags, bindingFlags) => flags | bindingFlags);
            var fieldInfo = dp.GetType().GetField("parameters", all);
            if (fieldInfo == null)
            {
                throw new InvalidOperationException();
            }
            var paramInfos = fieldInfo.GetValue(dp);
            var dictionary = new Dictionary<string, object>();
            foreach (var name in dp.ParameterNames)
            {
                var paramInfo = (paramInfos as IDictionary);
                if (paramInfo == null)
                {
                    throw new InvalidOperationException();
                }
                var value = paramInfo[name];
                dictionary.Add(name, value.GetType().GetProperty("Value").GetValue(value));
            }
            return dictionary;
        }

        private static DynamicParameters ToDynamicParameters(object o)
        {
            return o as DynamicParameters;
        }
    }
}