using System;
using System.Collections.Generic;
using System.Text;

namespace Delegatesdemo
{
    public class mediastorage
    {
        public delegate int playermedia(string a);
        public void Reportresult(playermedia p,string type)
        {
            var status = p(type);
            if (status == 0)
            {
                Console.WriteLine("media played successfully");

            }
            else
            {
                Console.WriteLine("media played successfully");

            }
         
        } 


    }
}
