using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    class CheckNetwork
    {
        public string Check(string adress)
        {
            Ping ping = new Ping();
            try
            {
                PingReply pingreplay = ping.Send(adress);
                return String.Format("Адресс {0}: IP {1} Time {2} ms Status {3}", adress, pingreplay.Address, pingreplay.RoundtripTime, pingreplay.Status);
            }
            catch
            {
                return String.Format("Узел {0} не отвечает!", adress);
            }
        }
        public List<string> CheckGroup(string filename)
        {
            Ping ping = new Ping();
            List<string> pingresult = new List<string>();
            List<string> siteList = new List<string>();
            try
            {
                siteList = File.ReadAllLines(filename).ToList();
            }
            catch
            {
                MessageBox.Show("Ошибка чтения файла");
                return pingresult;
            }
            foreach (string s in siteList)
            {
                try
                {
                    PingReply pingreplay = ping.Send(s);
                    pingresult.Add(String.Format("Адресс {0}: IP {1} Time {2} ms Status {3} \r\n", s, pingreplay.Address, pingreplay.RoundtripTime, pingreplay.Status));
                }
                catch
                {
                    pingresult.Add(String.Format("Узел {0} не отвечает! \r\n", s));
                }
            }
            return pingresult;
        }
        public void Delete(string FileName, string text)
        {
            List<string> lines = File.ReadAllLines(FileName).ToList();
            List<string> linesremove = lines.Where(l => l.Contains(text)).ToList();
            foreach(string l in linesremove)
            {
                lines.Remove(l);
            }
            File.WriteAllLines(FileName, lines.ToArray());
        }
    }
}
