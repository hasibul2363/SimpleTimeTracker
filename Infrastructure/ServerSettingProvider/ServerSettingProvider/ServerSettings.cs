using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerSettingProvider
{
    public class ServerSettings
    {
        public static Guid GetSystemUserId()
        {
            return Guid.Parse("081b8162-8a2a-4a34-8c28-1c081b6768ee");
        }
    }
}
