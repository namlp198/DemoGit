using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoGit
{
    class ClassTest02
    {
        enum eCar
        {
            suv,euv
        }
        Task<string> task;
        Thread thread;
        //Them 1 cai list nhe
        List<float> lst;
        //Tao cung them nhe test02
        Dictionary<string, string> dict;
        //admin them 1 cai hash
        HashSet<int> hs;

        //Tao la test01 day. gio tao moi dc them cai gi do
        List<string> lstTest01;
        
        public int id;
        public string name;
    }
}
