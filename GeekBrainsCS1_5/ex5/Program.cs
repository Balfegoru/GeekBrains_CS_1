using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    class Program
    {
        /* 5) Список задач(ToDo-list) :
        написать приложение для ввода списка задач;
        задачу описать классом ToDo с полями Title и IsDone;
        на старте, если есть файл tasks.json/xml/bin(выбрать формат), загрузить из него массив имеющихся задач и вывести их на экран;
        если задача выполнена, вывести перед её названием строку «[x]»;
        вывести порядковый номер для каждой задачи;
        при вводе пользователем порядкового номера задачи отметить задачу с этим порядковым номером как выполненную;
        записать актуальный массив задач в файл tasks.json/xml/bin.*/


        
        static void Main(string[] args)
        {
            ToDo myJornal = new ToDo();
            myJornal.Title[0] = "asd";
           
            Console.WriteLine(myJornal.Title[0]);

        }
    }
}
