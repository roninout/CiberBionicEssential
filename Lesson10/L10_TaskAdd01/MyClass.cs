using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10_TaskAdd01
{
    // Долго искал про это ограничение new()
    // https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/new-constraint
    class MyClass<T> where T : new()
    {
        // обобщенный фабричный метод
        public static T FacrotyMethod()
        {
            return new T();
        }
    }
}
