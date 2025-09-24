namespace YKS;

public class Placement
{
        public static List<Students> NonPlaced { get; private set; }
        public static void PlacementFonc(List<Universities> UniInfo)
    {
        List<Students> SayısalPlacement = new List<Students>();
        List<Students> EAPlacement = new List<Students>();
        List<Students> SozelPlacement = new List<Students>();
        List<Students> studentsWithPrefs = TakePrefrence.StudenListWithPrefs;

        for (int f = 0; f < studentsWithPrefs.Count; f++)
        {
            for (int i = 0; i < HelperCreateData.MaxPrefCount; i++)
            {
                if (studentsWithPrefs[f].PlacementStatus == true)
                {
                    continue;
                }

                Universities prefs = studentsWithPrefs[f].Prefrences[i];

                if (prefs.Type == "Sayisal")
                    SayısalPlacement.Add(studentsWithPrefs[f]);
                else if (prefs.Type == "EA")
                    EAPlacement.Add(studentsWithPrefs[f]);
                else if (prefs.Type == "Sozel")
                    SozelPlacement.Add(studentsWithPrefs[f]);
            }
        }

        SayısalPlacement = SayısalPlacement.OrderBy(s => s.Sayisalorder).ToList();
        SozelPlacement   = SozelPlacement.OrderBy(s => s.Sozelorder).ToList();
        EAPlacement      = EAPlacement.OrderBy(s => s.EAorder).ToList();

        for (int i = 0; i < HelperCreateData.MaxPrefCount; i++)
        {
            for (int j = 0; j < SayısalPlacement.Count; j++)
            {
                var Saystudent = SayısalPlacement[j];
                var Sayuniversity = UniInfo[Saystudent.Prefrences[i].Keycode];
                if (Sayuniversity.CurrentQuota.Count < Sayuniversity.Quota && Saystudent.PlacementStatus == false)
                {
                    Sayuniversity.CurrentQuota.Add(Saystudent.Name);
                    Saystudent.PlacementStatus = true;
                }
            }

            for (int h = 0; h < SozelPlacement.Count; h++)
            {
                var Sozstudent = SozelPlacement[h];
                var Sozuniversity = UniInfo[Sozstudent.Prefrences[i].Keycode];
                if (Sozuniversity.CurrentQuota.Count < Sozuniversity.Quota && Sozstudent.PlacementStatus == false)
                {
                    Sozuniversity.CurrentQuota.Add(Sozstudent.Name);
                    Sozstudent.PlacementStatus = true;
                }
            }

            for (int k = 0; k < EAPlacement.Count; k++)
            {
                var EAstudent = EAPlacement[k];
                var EAuniversity = UniInfo[EAstudent.Prefrences[i].Keycode];
                if (EAuniversity.CurrentQuota.Count < EAuniversity.Quota && EAstudent.PlacementStatus == false)
                {
                    EAuniversity.CurrentQuota.Add(EAstudent.Name);
                    EAstudent.PlacementStatus = true;
                }
            }
        }
        NonPlaced = studentsWithPrefs.Where(s => s.PlacementStatus == false).ToList();

    }

}
        
    
    //Pllacement Fonc
    
