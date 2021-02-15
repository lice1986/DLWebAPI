using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DLWebAPI.Models.API
{
    public class MdvShoesOrd
    {
        public string ORDER_NO { get; set; }
        public string ORDER_DATE { get; set; }
        public string ORDER_USER_ID { get; set; }
        public string ORDER_USER_NAME { get; set; }
        public string ORDER_USER_ADDRESS { get; set; }
        public string ORDER_USER_TEL { get; set; }
        public string MES_ORDER_NO { get; set; }
        public IList<MdvShoesOrdProd> products { get; set; }
    }
}
