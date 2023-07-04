using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Task3
{
    public class ProDocumentWorker : DocumentWorker
    {
      
        public override void EditDocument()
        {
            Console.WriteLine("Документ отредактирован");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных\r\n//форматах доступно в версии Эксперт");
        }
    }
}
