using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YKS
{
    public class Prefrences
    {
        private static List<Universities> UniversitiesList = HelperCreateData.CreateMockUniversitiesList();
        public static List<int> GetRandomChoosing()
        {
            Random rnd = new Random();
            
            List<int> possible = new List<int>(4);
            
            List<int> TemplateList = Enumerable.Range(0, HelperCreateData.CreateMockUniversitiesList().Count).ToList();
            
            TemplateList = TemplateList.OrderBy(x => rnd.Next()).ToList();            
            
            for (int i = 0; i < possible.Capacity; i++)
            {
                possible.Add(TemplateList[i]);                

            }
            
            return possible; // metodun çağırıldığında verdiği sonuç  possibledır.
        }
        
    }
    
}
