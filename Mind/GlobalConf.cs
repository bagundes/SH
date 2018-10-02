using System;
using System.Collections.Generic;
using System.Text;

namespace Mind
{
    public class GlobalConf
    {
#if DEBUG
        public const string UserTest_UNIQUE = "DEVELOP";
#else
        public const string UserTest_UNIQUE = null;
#endif
    }
}
