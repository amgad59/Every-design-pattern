using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.S_In_SOLID
{
    public class Persistence
    {
        public void SaveToFile(Journal j,string filename,bool overwrite = false) {
            if (!File.Exists(filename) || overwrite) {
                File.WriteAllText(filename,j.ToString());
            }
        }
    }
}
