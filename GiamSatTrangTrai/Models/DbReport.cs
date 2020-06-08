using Models.Framework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class DbReport
    {
        public List<DataModel> SelectAllList()
        {
            List<DataModel> result = new List<DataModel>();

            var data = DataProvider.Instance.ExecuteQuery("select * from datachuongid1");

            if (data!=null && data.Rows.Count>0)
            {
                DataModel _add;
                foreach (DataRow item in data.Rows)
                {
                    _add = new DataModel(item);
                    result.Add(_add);
                }
            }

            return result;
        }

        public DataTable SelectAllTable(String query)
        {
            DataTable result = new DataTable();

            var data = DataProvider.Instance.ExecuteQuery(query);}

            return result;
        }
    }
}
