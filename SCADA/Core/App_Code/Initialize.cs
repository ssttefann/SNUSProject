using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Core.App_Code
{
    public class Initialize
    {
        public static void AppInitialize()
        {
            XMLConfig.ReadData();
        }
    }
}