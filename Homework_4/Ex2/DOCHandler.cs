using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class DOCHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Открыт документ формата .TXT");
        }

        public override void Create()
        {
            Console.WriteLine("Создан документ формата .TXT");
        }


        public override void Change()
        {
            Console.WriteLine("Изменен документ формата .TXT");
        }

        public override void Save()
        {
            Console.WriteLine("Документ сохранен в формате .TXT");
        }
    }
}
