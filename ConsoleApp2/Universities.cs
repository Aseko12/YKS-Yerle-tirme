using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YKS
{
    public class Universities
    {
        public string Name { get; set; }
        public List<string> CurrentQuota { get; set; }
        public int Quota { get; set; }
        public string Type { get; set; }
        public int Keycode { get; set; }

        public Universities(string name, int quota, List<string> currentQuota,string type, int keycode)
        {
            Name = name;
            Quota = quota;
            CurrentQuota = currentQuota ;
            Type = type;
            Keycode = keycode;


        } //universite (isim, kontenjan) kuralı

        //public override string ToString()
        //{
       //     return "Universite : " + Name + "/n" + "Kontenjan :" + Quota.ToString() + "/n" + "Unv. Türü:" + Type.ToString() + "/n" + "Unv.Kod:" + Keycode.ToString();
        //}
    }
}
