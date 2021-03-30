using System;
using System.Collections.Generic;
using System.Text;

namespace Delegatesdemo
{
    public class videoplayer
    {
        public int videostatus;
        public int playvideo(string type)
        {
            if (type != "mp4")
            {
                videostatus = -1;
            }
            else
            {
                videostatus = 0;
            }
            return videostatus;
        }
    }
}
