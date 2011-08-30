using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using DataAccess.Implement.Memory;

namespace DataAccess.Access
{
    public class DataAccessFactory:IDataAccessFactory
    {
        #region IDataAccessFactory Members

        public IBaiDA GetBaiDA()
        {
            return new BaiDA();
        }
        public IKyThiDA GetKyThiDA()
        {
            return new KyThiDA();
        }
        #endregion
    }
}
