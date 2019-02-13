using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.model
{
    public enum RequestType
    {
        SALES,
        SALESIMS,
        STORED,
        MOVING,
        GOODS_RECEIPT
    }
    public class Request
    {
        public Request()
        {

        }

        public Request(DateTime Data1, DateTime Data2)
        {
            this.Data1 = Data1;
            this.Data2 = Data2;
        }
        public RequestType RequestType { get; set; }
        /// <summary>
        /// Код поставщика из системы SAP ERP (или BIN).
        /// </summary>
        public int KUNNR { get; set; }
        /// <summary>
        /// Код БЕ в SAP ERP. Код БЕ может быть заполнен, а может и не заполнен. 
        /// </summary>
        public int Burks { get; set; }
        /// <summary>
        /// Завод, в рамках которого необходимо передать данные по продажам из системы SAP ERP. 
        /// </summary>
        public int Werks { get; set; }
        /// <summary>
        /// Дата с начало периода
        /// </summary>
        public DateTime Data1 { get; set; }
        /// <summary>
        /// Дата с начало периода
        /// </summary>
        public DateTime Data2 { get; set; }
        

    }
}
