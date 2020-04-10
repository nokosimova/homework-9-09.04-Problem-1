using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        class DocumentWorker
        {
            public virtual void OpenDocument()
            {
                Console.WriteLine("Документ открыт");
            }
             public virtual void EditDocument()
            {
                Console.WriteLine("Редактирование докуемнта доступно в версии Про");
            }
             public virtual void SaveDocument()
            {
                Console.WriteLine("Сохранение документа доступно в версии Про");
            }
        }


    }
}
