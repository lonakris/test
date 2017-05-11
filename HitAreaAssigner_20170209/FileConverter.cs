using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HitAreaAssigner_20170209
{
    class FileConverter
    {
        public void ConvertToCSV(string path, AreaManager[] arealist, bool isUseState, bool isUseTag)
        {
            StreamWriter sw = new StreamWriter(path, false);
            try
            {
                for (int i = 0; i < arealist.Length; i++)
                {
                    foreach (var item in arealist[i].getAreas)
                        sw.WriteLine(item.DataForCSVFile(isUseState, isUseTag));

                    if (i + 1 != arealist.Length)
                        sw.WriteLine();
                }
                sw.Close();
            }
            catch
            {

            }
            sw.Dispose();
        }
    }
}
