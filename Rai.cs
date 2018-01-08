using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Rai
    {


        public static string[] levelList = new string[] { "Independent", "Supervised", "LimitedAssistance", "ExtensiveAssistance", "TotalDependence" };
        public static string[] adlCategory = new string[] { "Mobility", "Eating", "ToiletUse", "Hygiene" };

       
      
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int frlty;    // frailty score
            
            ComputeRAI rai = new ComputeRAI(); // build the table.
            
            // build the vector of features.
            rai.setAge(76);
            rai.setCancer(false);
            rai.setWeightLoss(true);
            rai.setRenalFailure(true,true);
            rai.setCongestiveHeartFailure(true);
            rai.setPoorAppetite(true);
            rai.setSOB(true);
            rai.setAssistedLiving(true);
            //Fill the ADL score randomly
            
            foreach (String cat in adlCategory)
                
            {
                int i = rnd.Next(0, 4);
               
                rai.adlCog(cat, levelList[i]);
              
                //Console.WriteLine(cat+":"+rai.ht[cat]);
            }
            
           
            rai.setAgeCAtegory();
           
            frlty = rai.GetFraily();
            Console.WriteLine("fraily score is {0}",frlty);
            
            Console.WriteLine("*************"); // and we are done.
        }
    }
}
