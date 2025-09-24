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
        Placement.PlacementFonc(Unis);
        var students = HelperCreateData.CreateMockStudentList();
        for (int i = 0; i < Unis.Count; i++)
        {


            Console.WriteLine($"Okulun adı: {Unis[i].Name}");
            Console.WriteLine($"Bölümün Türü: {Unis[i].Type}");
            Console.Write($"Kontenjan sayısı:{Unis[i].Quota}");
            Console.WriteLine($"Yerleşenler: ");
            Console.WriteLine($"Yerleşenler: {string.Join(", ", Unis[i].CurrentQuota)}");
            
            Console.WriteLine("-------------------------------------");

        }
        Console.WriteLine("Yerleşemeyenler: " + string.Join(", ", Placement.NonPlaced.Select(s => s.Name)));

        
        


      
    }
}