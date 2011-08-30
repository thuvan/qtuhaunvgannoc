using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccess;

namespace SPKOnlineOLPContest
{
    public partial class DanhSachKyThi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ListItem item;
            foreach(KyThi kt in DataAccess.InMemory.InMemoryDatabase.KyThiTable.Values)
            {
                item = new ListItem(kt.TenKyThi, kt.ID.ToString());
                drID.Items.Add(item);
            }
            IKyThiDA ktDA = Setting.DaFactory.GetKyThiDA();
            List<KyThi> dsKt = ktDA.LayTatCa();
            grvKyThi.DataSource = dsKt;
            DataBind();
        }

        protected void btnLayTheoMa_Click(object sender, EventArgs e)
        {
        }

        public IEnumerable<int> MemoryDatabase { get; set; }
    }
}