using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backup
{
    class Program
    {
        static void Main()
        {
            HostFactory.Run(x =>                                 //1
            {
                x.Service<TownCrier>(s =>                        //2
                {
                    s.ConstructUsing(name => new TownCrier());     //3
                    s.WhenStarted(tc => tc.Start());              //4
                    s.WhenStopped(tc => tc.Stop());               //5
                });
                x.RunAsLocalSystem();                            //6

                x.SetDescription("Blazing Lite Simple Backup for nightly storage");        //7
                x.SetDisplayName("BlazingLiteBackup");                       //8
                x.SetServiceName("BlazingLiteBackup");                       //9
            });   
        }
    }
}
