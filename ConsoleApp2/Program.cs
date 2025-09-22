// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;
using YKS;


internal class Program
{
    private static void Main(string[] args)
    {

        List<Students> StudentsList = HelperCreateData.CreateMockStudentList();
        TakePrefrence.CreatePreference(StudentsList);

        var Unis = HelperCreateData.CreateMockUniversitiesList();
        var students = HelperCreateData.CreateMockStudentList();
        Placement.PlacementFonc();
        for (int i = 0; i < Unis.Count; i++)
        {
                
                
                Console.WriteLine($"University: {Unis[i].Name}");
                Console.WriteLine($"Kontenjan : {Unis[i].Quota}");
                Console.WriteLine($"Eğitim Alanı : {Unis[i].Type}");
                
                
                for (int h = 0; h < Unis[i].Quota; h++)
                {
                    
                    

                        if (Unis[i].Type == "Sozel")
                        {
                            int checkher = Unis[i].CurrentQuota[h];
                            var ogr = students.FirstOrDefault(s => s.Sozelorder == checkher);

                            if (ogr != null)
                            {
                                Console.WriteLine($"Yerleşenler : {ogr.Name}");
                            }
                        }
                        
                        
                        
                        
                        else if(Unis[i].Type == "EA")
                        {
                            int checkher = Unis[i].CurrentQuota[h];
                            var ogr = students.FirstOrDefault(s => s.EAorder == checkher);

                            if (ogr != null)
                            {
                                Console.WriteLine($"Yerleşenler : {ogr.Name}");
                            }
                        }
                        
                        
                        
                        
                        else if (Unis[i].Type == "Sayisal")
                        {
                            int checkher = Unis[i].CurrentQuota[h];
                            var ogr = students.FirstOrDefault(s => s.Sayisalorder == checkher);

                            if (ogr != null)
                            {
                                Console.WriteLine($"Yerleşenler : {ogr.Name}, ");
                            }
                        }

                    

                } // For Döngüsü

                
                
             
        }

    }
}