using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DLWebAPI.Models.API
{
    public class MdvShoesOrdProd
    {
        public string ORDER_NO { get; set; }
        public string PRODUCT_CODE { get; set; }
        public string USER_PRODUCT_CODE { get; set; }
        public string SIZE { get; set; }
        public string GENDER { get; set; }
        public string FOOT_TYPE { get; set; }
        public string SIGNATURE { get; set; }
        public IList<MdvShoesOrdProdPart> detail { get; set; }
    }
}
