using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    class State
    {
        private int index;
        public int Index
        {
            get { return index; }
            set
            {
                int maxVal = Folder.GetDirectories().Length;
                if (value >= 0 && value < maxVal)
                {
                    index = value;
                }
            }
        }
        public DirectoryInfo Folder { get; set; }
    }
}
