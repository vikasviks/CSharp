using System;
using System.Collections.Generic;
using System.Text;

namespace Delegatesdemo
{
    public class audioplayer
    {
        public int audiostatus;
        public int playaudio(string type)
        {
            if (type != "mp3")
            {
                audiostatus= - 1;
            }
            else
            {
                audiostatus= 0;
            }
            return audiostatus;
        }
    }
}
