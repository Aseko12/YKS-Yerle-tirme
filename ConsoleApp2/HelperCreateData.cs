using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YKS
{
    public class HelperCreateData
    {
         public static int MaxPrefCount=4;
        public static List<Students> CreateMockStudentList()
        {
            List<Students> MyStudentsList = new List<Students> {
            new Students("Arda", 12, 5, 8),
            new Students("Berkay", 5, 12, 3),
            new Students("Can", 18, 3, 14),
            new Students("Deniz", 3, 18, 6),
            new Students("Ece", 20, 7, 12),
            new Students("Selin", 7, 14, 1),
            new Students("Cenk", 15, 1, 10),
            new Students("Derya", 2, 10, 16),
            new Students("Funda", 10, 20, 5),
            new Students("Gokce", 8, 2, 18),
            new Students("Hakan", 14, 15, 2),
            new Students("Irem", 19, 8, 20),
            new Students("Jale", 4, 16, 7),
            new Students("Kaan", 16, 11, 17),
            new Students("Leyla", 11, 4, 4),
            new Students("Mert", 9, 13, 13),
            new Students("Nisa", 6, 19, 9),
            new Students("Ozan", 1, 9, 19),
            new Students("Pinar", 13, 6, 11),
            new Students("Ruya", 17, 17, 15)
        };
            return MyStudentsList;
        }

        public static List<Universities> CreateMockUniversitiesList()
        {
            List<Universities> MyUniInfo = new List<Universities>(6)
            {
            new Universities("OdtuSayisal", 3,new List<int>() ,"Sayisal", 0),
            new Universities("OdtuSozel", 3,new List<int>() ,"Sozel", 1),
            new Universities("OdtuEsitAgirlik", 3, new List<int>(),"EA", 2),
            new Universities("BogaziciSayisal", 3,new List<int>() ,"Sayisal", 3),
            new Universities("BogaziciSozel", 3, new List<int>(),"Sozel", 4),
            new Universities("BogaziciEsitAgirlik", 3, new List<int>(),"EA", 5)
            };
            MyUniInfo.OrderBy(u=>u.Keycode);
            return MyUniInfo;
            
            
        }
            
    }
    
}
