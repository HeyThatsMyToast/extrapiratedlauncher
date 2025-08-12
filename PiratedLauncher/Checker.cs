using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace PiratedLauncher
{
    internal class Checker
    {
        private static Query query = new Query();

        public static async Task<bool> CheckKey(string key)
        {
            return true;
        }
    }
}
