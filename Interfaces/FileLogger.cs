using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class FileLogger :ILogger
    {
        public void writeLog()
        {
            Console.WriteLine("Dosyaya log yazar.");
        }
    }
}
