using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YKS
{

    public class TakePrefrence
    {
        public static List<Students> StudenListWithPrefs { get; private set; }
        public static void CreatePreference(List<Students> studentlist)
        {
            List<Universities> UniInfo = HelperCreateData.CreateMockUniversitiesList();
            for (int studentque = 0; studentque < studentlist.Count; studentque++)
            {
                List<int> prefChoosing = Prefrences.GetRandomChoosing(); //possible döndüğü için possibledaki değer prefChoosing e aktarılmış oluyor.
                //prefChoosing listesi = possible listesi
                for (int i = 0; i < prefChoosing.Count; i++)
                {
                    studentlist[studentque].Prefrences.Add(UniInfo[prefChoosing[i]]);  //öğrenci listesindeki [i] indexine.||||| UniInfodaki okullar. prefChoosingdeki tercih sırasına göre ekleniyor. 
                }
                
                //studentlist[studentque].ToString();
                
            }
            
            StudenListWithPrefs = studentlist;
        }
        
    }

}
