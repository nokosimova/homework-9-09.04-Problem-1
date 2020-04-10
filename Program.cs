using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            string pro_key = "profi";
            string exp_key = "expert";
            string pro, exp;
            Console.WriteLine("Введите ключ для версии Про:");
            pro = Console.ReadLine();
            if (pro != pro_key)
            {
                DocumentWorker user1 = new DocumentWorker();
                Console.WriteLine("document status:");
                user1.OpenDocument();
                user1.EditDocument();
                user1.SaveDocument(); 
            } else {
                Console.WriteLine("Введите ключ для версии Эксперт:");
                exp = Console.ReadLine();
                if (exp != exp_key)
                {
                    ExpertDocumentWorker user1 = new ExpertDocumentWorker();
                    Console.WriteLine("document status:");
                    user1.OpenDocument();
                    user1.EditDocument();
                    user1.SaveDocument(); 
                } else {
                    ProDocumentWorker user1 = new ProDocumentWorker();
                    Console.WriteLine("document status:");
                    user1.OpenDocument();
                    user1.EditDocument();
                    user1.SaveDocument();                

                }
            }
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
        class ProDocumentWorker : DocumentWorker
        {
            public override void EditDocument()
            {
                Console.WriteLine("Документ отредактирован");
            }
            public override void SaveDocument()
            {
                Console.WriteLine("Документ сохранен в старом формате, сохранение в осталных форматах доступно в версии Эксперт");
            }
        }
        class ExpertDocumentWorker : ProDocumentWorker
        {
            public override void SaveDocument()
            {
                Console.WriteLine("Документ сохранен в новом формате");
            }
        }



    }
}
