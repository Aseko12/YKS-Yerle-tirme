namespace YKS;

public class Placement
{

    public static void PlacementFonc()
    {
        List<Universities> UniInfo = HelperCreateData.CreateMockUniversitiesList();
        List<Students> SayısalPlacement = new List<Students>();
        List<Students> EAPlacement = new List<Students>();
        List<Students> SozelPlacement = new List<Students>();
        List<Students> studentsWithPrefs = TakePrefrence.StudenListWithPrefs;

        for (int i = 0; i < HelperCreateData.MaxPrefCount; i++)
        {
            for (int j = 0; j < studentsWithPrefs.Count; j++)
            {
                if (studentsWithPrefs[j].PlacementStatus == true)
                {
                    continue;
                }
                else
                {

                    Universities prefs = studentsWithPrefs[j].Prefrences[i];


                    if (prefs.Type == "Sayisal")
                    {
                        SayısalPlacement.Add(studentsWithPrefs[j]);
                    }


                    else if (prefs.Type == "EA")
                    {
                        EAPlacement.Add(studentsWithPrefs[j]);
                    }



                    else if (prefs.Type == "Sozel")
                    {
                        SozelPlacement.Add(studentsWithPrefs[j]);
                    }
                }
            } //öğrenci

            SayısalPlacement.OrderBy(s => s.Sayisalorder).ToList();
            SozelPlacement.OrderBy(s => s.Sozelorder).ToList();
            EAPlacement.OrderBy(s => s.Sozelorder).ToList();
            

            for (int j = 0; j < SayısalPlacement.Count; j++) // Sayısal Yerleştirme Döngüsü
            {
                var Saystudent = SayısalPlacement[j];
                var Sayuniversity = HelperCreateData.CreateMockUniversitiesList()[Saystudent.Prefrences[i].Keycode];
                
                if ((Sayuniversity.CurrentQuota.Count < Sayuniversity.Quota && Saystudent.PlacementStatus == false))
                {
                    Sayuniversity.CurrentQuota.Add(Saystudent.Sayisalorder);
                    Saystudent.PlacementStatus = true;
                }
            }

            for (int h = 0; h < SozelPlacement.Count; h++) // Sözel Yerleştirme Döngüsü
            {
                var Sozstudent = SozelPlacement[h];
                var Sozuniversity = HelperCreateData.CreateMockUniversitiesList()[Sozstudent.Prefrences[i].Keycode];
                
                if (Sozuniversity.CurrentQuota.Count < Sozuniversity.Quota && Sozstudent.PlacementStatus == false) // Eşit Ağırlık Yerleştirme
                {
                    Sozuniversity.CurrentQuota.Add(Sozstudent.EAorder);
                    Sozstudent.PlacementStatus = true;
                }
            }
            
            
            for(int k = 0; k < EAPlacement.Count; k++)
            {
                var EAstudent = EAPlacement[k];
                var EAuniversity = HelperCreateData.CreateMockUniversitiesList()[EAstudent.Prefrences[i].Keycode];
                
                if (EAuniversity.CurrentQuota.Count < EAuniversity.Quota && EAstudent.PlacementStatus == false) // Eşit Ağırlık Yerleştirme
                {
                    EAuniversity.CurrentQuota.Add(EAstudent.EAorder);
                    EAstudent.PlacementStatus = true;
                }
            }
        }
        
    }
    //Pllacement Fonc
    
}