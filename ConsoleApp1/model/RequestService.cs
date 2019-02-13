using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.model
{
    public class RequestService
    {
        public void CreateRequest()
        {
            Request r = new Request();
            Console.Write("Заполните Kunnr: ");
            r.KUNNR = Int32.Parse(Console.ReadLine());
            Console.Write("Заполните Burks: ");
            r.Burks = Int32.Parse(Console.ReadLine());
            Console.Write("Заполните Werks: ");
            r.Werks = Int32.Parse(Console.ReadLine());
            Console.Write("Заполните Data1: ");
            r.Data1 = DateTime.Parse(Console.ReadLine());
            Console.Write("Заполните Data2: ");
            r.Data2 = DateTime.Parse(Console.ReadLine());
        }

        public void GenerateReport(Request request)
        {
            switch (request.RequestType)
            {
                case RequestType.SALES:
                    break;
                case RequestType.SALESIMS:
                    break;
                case RequestType.STORED:
                    break;
                case RequestType.MOVING:
                    break;
                case RequestType.GOODS_RECEIPT:
                    break;
                default:
                    break;
            }
        }
    }
}
