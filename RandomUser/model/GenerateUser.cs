using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomUser.model
{
    public class GenerateUser
    {
        public static results GetUser()
        {
            ServiceUser serviceUser = new ServiceUser("https://randomuser.me/api?results=1");
            /* Console.WriteLine(serviceUser.GetJsonString())*/
            ;
            string json = serviceUser.GetJsonString();
            var users = JsonConvert.DeserializeObject<Users>(json);
            return users.results[0];
        }
    }
}
