using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nunittest.Controllers
{
 
        public class MyService : IMyService
        {
            public string GetData()
            {
                return "Hello, world!";
            }
        }
    }

