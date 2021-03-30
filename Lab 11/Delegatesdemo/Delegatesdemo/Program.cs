using System;

namespace Delegatesdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            mediastorage m = new mediastorage();
            audioplayer ap = new audioplayer();
            videoplayer vp = new videoplayer();
            mediastorage.playermedia playerdelegate = ap.playaudio;


            m.Reportresult(playerdelegate, "mp3");
            playerdelegate = vp.playvideo;
        }
    }
    
}
