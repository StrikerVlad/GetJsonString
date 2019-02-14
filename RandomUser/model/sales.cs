using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomUser.model
{
    public class sales
    {
        public int Burks { get; set; }
        public int WERKS { get; set; }
        public int LGORT { get; set; }

        public int SALES_CHANEL { get; set; }
        public int SALES_CHANEL_TXT { get; set; }

        public int KUNNR { get; set; }

        public string KUNNR_TXT { get; set; }

        public int KUNNR_BIN { get; set; }

        public string KUNNR_ADR_UR { get; set; }

        public string KUNNR_ADR_DOST { get; set; }
        public int ID_OUT_DELIVERY { get; set; }

        public string ID_OUT_DELIVERY_DATA {
            get
            {
                return ID_OUT_DELIVERY_DATA;
            }
            set
            {
                DateTime tmp;
                if (DateTime.TryParse(value, out tmp))
                {
                    ID_OUT_DELIVERY_DATA = string.Format("{0;dd-mm-yy}", tmp);
                }

                else
                    ID_OUT_DELIVERY_DATA = "";

            }
        }
    }
}
