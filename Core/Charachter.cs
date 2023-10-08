using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIOWCharGen.Core
{
    public class TIOWCharachter
    {

        //Base Info
        public string CharachterName { get; set; }
        public string PlayerName { get; set; }
        public string Regiment { get; set; }
        public string Speciality { get; set; }
        public string Demeanor { get; set; }
        public string Description { get; set; }
        public string CampaignName { get; set; }



        //Charachteristics
        public int WeaponSkill { get; set; }
        public int BallisticSkill { get; set; }
        public int Strength { get; set; }
        public int Tougness { get; set; }
        public int Agility { get; set; }
        public int Intellegence { get; set; }
        public int Perception { get; set; }
        public int Willpower { get; set; }
        public int Fellowship { get; set; }

        //Talents & Traits
        public string[] TalentsTraits { get; set; }

        //Skills
        public bool AcrobaticsTrained { get; set; }
        public bool Acrobatics10 { get; set; }
        public bool Acrobatics20 { get; set; }
        public bool Acrobatics30 { get; set; }
        public bool AthleticsTrained { get; set; }
        public bool Athletics10 { get; set; }
        public bool Athlectics20 { get; set; }
        public bool Athlectics30 { get; set; }
        public bool CharmTrained { get; set; }
        public bool Charm10 { get; set; }
        public bool Charm20 { get; set; }
        public bool Charm30 { get; set; }
        public bool CommandTrained { get; set; }
        public bool Command10 { get; set; }
        public bool Command20 { get; set; }
        public bool Command30 { get; set; }
        public bool CommerceTrained { get; set; }
        public bool Commerce10 { get; set; }
        public bool Commerce20 { get; set; }
        public bool Commerce30 { get; set; }
        public bool CommonLoreTrained { get; set; }
        public bool CommonLore10 { get; set; }
        public bool CommonLore20 { get; set; }
        public bool CommonLore30 { get; set; }
        public string CommonLore1 { get; set; }
        public bool CommonLore1Trained { get; set; }
        public bool CommonLore110 { get; set; }
        public bool CommonLore120 { get; set; }
        public bool CommonLore130 { get; set; }
        public string CommonLore2 { get; set; }
        public bool CommonLore2Trained { get; set; }
        public bool CommonLore210 { get; set; }
        public bool CommonLore220 { get; set; }
        public bool CommonLore230 { get; set; }
        public string CommonLore3 { get; set; }
        public bool CommonLore3Trained { get; set; }
        public bool CommonLore310 { get; set; }
        public bool CommonLore320 { get; set; }
        public bool CommonLore330 { get; set; }
        public bool DeceiveTrained { get; set; }
        public bool Deceive10 { get; set; }
        public bool Deceive20 { get; set; }
        public bool Deceive30 { get; set; }
        public bool DodgeTrained { get; set; }
        public bool Dodge10 { get; set; }
        public bool Dodge20 { get; set; }
        public bool Dodge30 { get; set; }
        public bool ForbiddenLoreTrained { get; set; }
        public bool ForbiddenLore10 { get; set; }
        public bool ForbiddenLore20 { get; set; }
        public bool ForbiddenLore30 { get; set; }
        public string ForbiddenLore1 { get; set; }
        public bool ForbiddenLore1Trained { get; set; }
        public bool ForbiddenLore110 { get; set; }
        public bool ForbiddenLore120 { get; set; }
        public bool ForbiddenLore130 { get; set; }
        public string ForbiddenLore2 { get; set; }
        public bool ForbiddenLore2Trained { get; set; }
        public bool ForbiddenLore210 { get; set; }
        public bool ForbiddenLore220 { get; set; }
        public bool ForbiddenLore230 { get; set; }
        public string ForbiddenLore3 { get; set; }
        public bool ForbiddenLore3Trained { get; set; }
        public bool ForbiddenLore310 { get; set; }
        public bool ForbiddenLore320 { get; set; }
        public bool ForbiddenLore330 { get; set; }
        public bool InquiryTrained { get; set; }
        public bool Inquiry10 { get; set; }
        public bool Inquiry20 { get; set; }
        public bool Inquiry30 { get; set; }
        public bool InterrogationTrained { get; set; }
        public bool Interrogation10 { get; set; }
        public bool Interrogation20 { get; set; }
        public bool Interrogation30 { get; set; }
        public bool IntimidateTrained { get; set; }
        public bool Intimidate10 { get; set; }
        public bool Intimidate20 { get; set; }
        public bool Intimidate30 { get; set; }
        public bool LinguisticsTrained { get; set; }
        public bool Linguistics10 { get; set; }
        public bool Linguistics20 { get; set; }
        public bool Linguistics30 { get; set; }
        public string Linguistics1 { get; set; }
        public bool Linguistics1Trained { get; set; }
        public bool Linguistics110 { get; set; }
        public bool Linguistics120 { get; set; }
        public bool Linguistics130 { get; set; }
        public string Linguistics2 { get; set; }
        public bool Linguistics2Trained { get; set; }
        public bool Linguistics210 { get; set; }
        public bool Linguistics220 { get; set; }
        public bool Linguistics230 { get; set; }
        public bool LogicTrained { get; set; }
        public bool Logic10 { get; set; }
        public bool Logic20 { get; set; }
        public bool Logic30 { get; set; }
        public bool MediceaTrained { get; set; }
        public bool Medicea10 { get; set; }
        public bool Medicea20 { get; set; }
        public bool Medicea30 { get; set; }
        public bool NavigateSurfaceTrained { get; set; }
        public bool NavigateSurface10 { get; set; }
        public bool NavigateSurface20 { get; set; }
        public bool NavigateSurface30 { get; set; }
        public bool NavigateStellarTrained { get; set; }
        public bool NavigateStellar10 { get; set; }
        public bool NavigateStellar20 { get; set; }
        public bool NavigateStellar30 { get; set; }
        public bool NavigateWarpTrained { get; set; }
        public bool NavigateWarp10 { get; set; }
        public bool NavigateWarp20 { get; set; }
        public bool NavigateWarp30 { get; set; }
        public bool OperateAeronauticaTrained { get; set; }
        public bool OperateAeronautica10 { get; set; }
        public bool OperateAeronautica20 { get; set; }
        public bool OperateAeronautica30 { get; set; }
        public bool OperateSurfaceTrained { get; set; }
        public bool OperateSurface10 { get; set; }
        public bool OperateSurface20 { get; set; }
        public bool OperateSurface30 { get; set; }
        public bool OperateVoidshipTrained { get; set; }
        public bool OperateVoidship10 { get; set; }
        public bool OperateVoidship20 { get; set; }
        public bool OperateVoidship30 { get; set; }
        public bool ParryTrained { get; set; }
        public bool Parry10 { get; set; }
        public bool Parry20 { get; set; }
        public bool Parry30 { get; set; }
        public bool PsyniscienceTrained { get; set; }
        public bool Psyniscience10 { get; set; }
        public bool Psyniscience20 { get; set; }
        public bool Psyniscience30 { get; set; }
        public bool ScholasticLoreTrained { get; set; }
        public bool ScholasticLore10 { get; set; }
        public bool ScholasticLore20 { get; set; }
        public bool ScholasticLore30 { get; set; }
        public string ScholasticLore1 { get; set; }
        public bool ScholasticLore1Trained { get; set; }
        public bool ScholasticLore110 { get; set; }
        public bool ScholasticLore120 { get; set; }
        public bool ScholasticLore130 { get; set; }
        public string ScholasticLore2 { get; set; }
        public bool ScholasticLore2Trained { get; set; }
        public bool ScholasticLore210 { get; set; }
        public bool ScholasticLore220 { get; set; }
        public bool ScholasticLore230 { get; set; }
        public string ScholasticLore3 { get; set; }
        public bool ScholasticLore3Trained { get; set; }
        public bool ScholasticLore310 { get; set; }
        public bool ScholasticLore320 { get; set; }
        public bool ScholasticLore330 { get; set; }
        public string ScholasticLore4 { get; set; }
        public bool ScholasticLore4Trained { get; set; }
        public bool ScholasticLore410 { get; set; }
        public bool ScholasticLore420 { get; set; }
        public bool ScholasticLore430 { get; set; }
        public string ScholasticLore5 { get; set; }
        public bool ScholasticLore5Trained { get; set; }
        public bool ScholasticLore510 { get; set; }
        public bool ScholasticLore520 { get; set; }
        public bool ScholasticLore530 { get; set; }
        public bool ScrutinyTrained { get; set; }
        public bool Scrutiny10 { get; set; }
        public bool Scrutiny20 { get; set; }
        public bool Scrutiny30 { get; set; }
        public bool SecurityTrained { get; set; }
        public bool Security10 { get; set; }
        public bool Security20 { get; set; }
        public bool Security30 { get; set; }
        public bool SleightofhandTrained { get; set; }
        public bool Sleightofhand10 { get; set; }
        public bool Sleightofhand20 { get; set; }
        public bool Sleightofhand30 { get; set; }
        public bool StealthTrained { get; set; }
        public bool Stealth10 { get; set; }
        public bool Stealth20 { get; set; }
        public bool Stealth30 { get; set; }
        public bool SurvivalTrained { get; set; }
        public bool Survival10 { get; set; }
        public bool Survival20 { get; set; }
        public bool Survival30 { get; set; }
        public bool TechuseTrained { get; set; }
        public bool Techuse10 { get; set; }
        public bool Techuse20 { get; set; }
        public bool Techuse30 { get; set; }
        public bool TradeTrained { get; set; }
        public bool Trade10 { get; set; }
        public bool Trade20 { get; set; }
        public bool Trade30 { get; set; }
        public string Trade1 { get; set; }
        public bool Trade1Trained { get; set; }
        public bool Trade110 { get; set; }
        public bool Trade120 { get; set; }
        public bool Trade130 { get; set; }
        public string Trade2 { get; set; }
        public bool Trade2Trained { get; set; }
        public bool Trade210 { get; set; }
        public bool Trade220 { get; set; }
        public bool Trade230 { get; set; }
        public string Trade3 { get; set; }
        public bool Trade3Trained { get; set; }
        public bool Trade310 { get; set; }
        public bool Trade320 { get; set; }
        public bool Trade330 { get; set; }

        //Wounds/Health
        public int WoundsTotal { get; set; }
        public int WoundsCurrent { get; set; }
        public int Fatigue { get; set; }
        public string CritDamage { get; set; }


        //Insanity
        public int Insanity { get; set; }
        public string[] MentalDisorders { get; set; }


        //Corruption
        public int Corruption { get; set; }
        public string[] Malignancies { get; set; }
        public string[] Mutations { get; set; }


        //Movement
        public int MovementFull { get; set; }
        public int MovementHalf { get; set; }
        public int MovementCharge { get; set; }
        public int MovementRun { get; set; }


        //FatePoint
        public int FatePointTotal { get; set; }
        public int FatePointCurrent { get; set; }


        //XP
        public int XPGained { get; set; }
        public int XPSpended { get; set; }


        //Pshychic Powers
        public int PsyRating { get; set; }
        public string[] PsychicPowers { get; set; }


        //Comrade
        public string ComradeName { get; set; }
        public string ComradeStatus { get; set; }
        public string[] ComradeAbillities { get; set; }


        //Aptitudes
        public string[] Aptitudes { get; set; }


        //Gear
        public string[] Gear { get; set; }


        //Armour
        public string ArmourHead { get; set;}
        public string ArmourHeadType { get; set; }
        public string ArmourRarm { get; set;}
        public string ArmourRarmType { get; set; }
        public string ArmourRleg { get; set;}
        public string ArmourRlegType { get; set; }
        public string ArmourLarm { get; set;}
        public string ArmourLarmType { get; set; }
        public string ArmourLleg { get; set;}
        public string ArmourLlegType { get; set; }
        public string ArmourBody { get; set;}
        public string ArmourBodyType { get; set; }


        //Weapon1
        public string WeaponName1 { get; set; }
        public string WeaponClass1 { get; set; }
        public string WeaponDamage1 { get; set;}
        public string WeaponType1 { get; set;}
        public string WeaponPen1 {  get; set; }
        public string WeaponRange1 { get; set; }
        public string WeaponROF1 { get; set; }
        public string WeaponClip1 { get; set; }
        public string WeaponRLD1 { get; set; }
        public string WeaponSL1 {  get; set; }


        //Weapon2
        public string WeaponName2 { get; set; }
        public string WeaponClass2 { get; set; }
        public string WeaponDamage2 { get; set; }
        public string WeaponType2 { get; set; }
        public string WeaponPen2 { get; set; }
        public string WeaponRange2 { get; set; }
        public string WeaponROF2 { get; set; }
        public string WeaponClip2 { get; set; }
        public string WeaponRLD2 { get; set; }
        public string WeaponSL2 { get; set; }


        //Weapon3
        public string WeaponName3 { get; set; }
        public string WeaponClass3 { get; set; }
        public string WeaponDamage3 { get; set; }
        public string WeaponType3 { get; set; }
        public string WeaponPen3 { get; set; }
        public string WeaponRange3 { get; set; }
        public string WeaponROF3 { get; set; }
        public string WeaponClip3 { get; set; }
        public string WeaponRLD3 { get; set; }
        public string WeaponSL3 { get; set; }


        //Weapon4
        public string WeaponName4 { get; set; }
        public string WeaponClass4 { get; set; }
        public string WeaponDamage4 { get; set; }
        public string WeaponType4 { get; set; }
        public string WeaponPen4 { get; set; }
        public string WeaponRange4 { get; set; }
        public string WeaponROF4 { get; set; }
        public string WeaponClip4 { get; set; }
        public string WeaponRLD4 { get; set; }
        public string WeaponSL4 { get; set; }


        public TIOWCharachter()
        {
            
        }

        public void Roll()
        {

        }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        public static TIOWCharachter FromJson(string json)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<TIOWCharachter>(json);
        }
    }
}
