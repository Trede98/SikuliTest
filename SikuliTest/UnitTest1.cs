using System;
using System.Collections;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sikuli4Net.sikuli_REST;
using TestStack.White;

namespace SikuliTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            Pattern file = new Pattern(@"C:\Users\Fabio\Desktop\jdownloaderImages\file.png");
            Pattern max = new Pattern(@"C:\Users\Fabio\Desktop\jdownloaderImages\maximize.png");
            Pattern aggiungi = new Pattern(@"C:\Users\Fabio\Desktop\jdownloaderImages\aggiungi.png");
            Pattern testoAggiungi = new Pattern(@"C:\Users\Fabio\Desktop\jdownloaderImages\testoAggiungi.png");
            Pattern continua = new Pattern(@"C:\Users\Fabio\Desktop\jdownloaderImages\continua.png");
            

            TestStack.White.Application application = TestStack.White.Application.Launch(@"C:\Users\Fabio\AppData\Local\JDownloader v2.0\JDownloader2.exe");
            
            Thread.Sleep(5000);

            Sikuli4Net.sikuli_REST.Screen scr = new Sikuli4Net.sikuli_REST.Screen();
            scr.Click(max);
            scr.Click(file);
            scr.Click(aggiungi);

            scr.Click(testoAggiungi);
            SendKeys.SendWait("http://releases.ubuntu.com/19.04/ubuntu-19.04-desktop-amd64.iso");
            Thread.Sleep(1000);
            scr.Click(continua);


            Thread.Sleep(4000);
            application.Close();

        }
    }
}
