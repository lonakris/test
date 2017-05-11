using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HitAreaAssigner_20170209
{
    class BufferedListView : ListView
    {
        protected override bool DoubleBuffered
        {
            get
            {
                return true;
            }
            set
            {

            }
        }
    }
}
