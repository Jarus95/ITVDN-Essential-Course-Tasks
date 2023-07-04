using System;

namespace _3_Task3
{
    public class DocumentWorker
    {
        private readonly string proKey = "123";
        private readonly string expertKey = "1234";
        public virtual void OpenDocument()
        {
            Console.WriteLine("Документ открыт");
        }

        public virtual void EditDocument() 
        {
            Console.WriteLine("Редактирование документа доступно в версии Про");
        }
        public virtual void SaveDocument() 
        {
            Console.WriteLine("Сохранение документа доступно в\r\n//версии Про");
        }

        public DocumentWorker AcivateProduct(string key)
        {
            if (key == proKey)
            {
                Console.WriteLine("Pro версия Активирована");
                return new ProDocumentWorker();
            }

            else if (key == expertKey)
            {
                Console.WriteLine("Expert версия Активирована");
                return new ExpertDocumentWorker();
            }

            else
            {
                Console.WriteLine("неправилный ключ");
                return new DocumentWorker();
            }
             
        }

        public DocumentWorker()
        {
            
        }
    }
}
