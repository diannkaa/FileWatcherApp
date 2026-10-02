using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileWatcherApp
{
    public class LogDataManager
    {
        public void AppendLog(string path, LogEntry entry)
        {
            StreamWriter writer = null;

            try
            {
                writer = new StreamWriter(path, true);
                writer.WriteLine(entry.ToString());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }
    }
}