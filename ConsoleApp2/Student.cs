using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace YKS
{
    public class Students
    {
        public string Name { get; set; }
        public int Sayisalorder { get; set; }
        public int Sozelorder { get; set; }
        public int EAorder { get; set; }
        public bool PlacementStatus { get; set; } = false;
        public List<Universities> Prefrences { get; set; }


        public Students(string name, int sayisaloder, int sozelorder, int eaorder, bool placementstatus = false)
        {
            Name = name;
            Sayisalorder = sayisaloder;
            Sozelorder = sozelorder;
            EAorder = eaorder;
            PlacementStatus = placementstatus;
            Prefrences = new List<Universities>();
        }

        public override string ToString()
        {
            string str = "Adı : " + Name + "\n" + "Sayisalorder :" + Sayisalorder.ToString() + "\n" + "Sozelorder:" + Sozelorder.ToString() + "\n" 
                + "EsitAgirlikorder:" + EAorder.ToString() + "\n" + "PlacementStatus: " + PlacementStatus.ToString()+ "\nTercihler :";
            foreach (var item in Prefrences)
            {
                str = str + "\n\t\t" + item.ToString();
            }

            Console.WriteLine(str);
            Console.WriteLine("===========================================================================================");
            return str.ToString();

        }

    }
}
