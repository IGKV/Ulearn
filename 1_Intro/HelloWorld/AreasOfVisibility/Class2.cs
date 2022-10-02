using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasOfVisibility
{
    class Sample4
    {
        void M1()
        {
            int i = 0;
            {
                int i = 1;
            }
        }
        void M2(int i)
        {
            int i = 0;
        }
        void M3()
        {
            // Фигурными скобками можно группировать операторы (правда почти никогда этого делать не стоит)
            // и каждая пара фигурных скобок создает свою область видимости.
            {
                int i = 0;
            }
            {
                int i = 1;
            }
        }
    }
}
