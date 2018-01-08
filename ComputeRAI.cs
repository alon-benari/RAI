using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class ComputeRAI
    {
        
        public Hashtable ht = new System.Collections.Hashtable(); //Hashtable table to hold data.

        private Hashtable adl = new System.Collections.Hashtable();
       

        public  ComputeRAI() //Constructor
        {
            adl.Add("Independent", 0);
            adl.Add("Supervised", 1);
            adl.Add("LimitedAssistance", 2);
            adl.Add("ExtensiveAssistance", 3);
            adl.Add("TotalDependence", 4);
        }

        public int GetFraily()
        {
            int frailty = 0;
            frailty = frailty +(int) ht["ageCategory"];
            ht.Remove("cancer");
            ht.Remove("age");
            ht.Remove("ageCategory");
            foreach(string k in ht.Keys)
            {
                frailty = frailty + (int)ht[k];
            }
            return frailty;

        }

        // Overloading when a hashatable needs be passed
        public int GetFraily(Hashtable ht)
        {
            int frailty = 0;
            frailty = frailty + (int)ht["ageCategory"];
            ht.Remove("cancer");
            ht.Remove("age");
            ht.Remove("ageCategory");
            foreach (string k in ht.Keys)
            {
                frailty = frailty + (int)ht[k];
            }
            return frailty;

        }

        //
        public void setAge(int ageInYears)
        /*
        *A method to set age and get age category
        */
        {
            ht.Add("age", ageInYears);
        }

        public void setAgeCAtegory()
        {
            
           
            
            //bool can = false;
            //bool can = (bool)ht["cancer"];
            if ((int)ht["age"]<= 69)
            {
                int[] cancerAgeScore = { 2, 20 };
                if ((bool)ht["cancer"])
                {
                    ht.Add("ageCategory", cancerAgeScore[1]);
                }
                else
                {
                    ht.Add("ageCategory", cancerAgeScore[0]);

                }
                

            }
            if ((int)ht["age"] >=70 && (int)ht["age"]<= 74)
            {
                int[] cancerAgeScore = { 3,19};
                if ((bool)ht["cancer"])
                {
                    ht.Add("ageCategory", cancerAgeScore[1]);
                }
                else
                {
                    ht.Add("ageCategory", cancerAgeScore[0]);

                }
                
                
            }
            if ((int)ht["age"]>=75 && (int)ht["age"] <= 79)
            {
                int[] cancerAgeScore = { 4, 18 };
                if ((bool)ht["cancer"])
                {
                    ht.Add("ageCategory", cancerAgeScore[1]);
                }
                else
                {
                    ht.Add("ageCategory", cancerAgeScore[0]);

                }
               

            }
            if ((int)ht["age"] >=80 && (int)ht["age"] <= 84)
            {
                int[] cancerAgeScore = { 5, 17 };
                if ((bool)ht["cancer"])
                {
                    ht.Add("ageCategory", cancerAgeScore[1]);
                }
                else
                {
                    ht.Add("ageCategory", cancerAgeScore[0]);

                }
               

            }
            if ((int)ht["age"] >=85 && (int)ht["age"] <= 89)
            {
                int[] cancerAgeScore = { 6, 15 };
                if ((bool)ht["cancer"])
                {
                    ht.Add("ageCategory", cancerAgeScore[1]);
                }
                else
                {
                    ht.Add("ageCategory", cancerAgeScore[0]);

                }
                
            }
            if ((int)ht["age"]>=90 && (int)ht["age"] <= 94)
            {
                int[] cancerAgeScore = { 7,14 };
                if ((bool)ht["cancer"])
                {
                    ht.Add("ageCategory", cancerAgeScore[1]);
                }
                else
                {
                    ht.Add("ageCategory", cancerAgeScore[0]);

                }
                
            }
            if ((int)ht["age"] >=95 && (int)ht["age"] <=99)
            {
                int[] cancerAgeScore = {8,14 };
                if ((bool)ht["cancer"])
                {
                    ht.Add("ageCategory", cancerAgeScore[1]);
                }
                else
                {
                    ht.Add("ageCategory", cancerAgeScore[0]);

                }
                
            }
            if ((int)ht["age"] >= 100)
            {
                int[] cancerAgeScore = { 9, 13 };
                if ((bool)ht["cancer"])
                {
                    ht.Add("ageCategory", cancerAgeScore[1]);
                }
                else
                {
                    ht.Add("ageCategory", cancerAgeScore[0]);

                }
                
            }

        }

        public void setCancer(bool cancer)
           /*
            * A method to set cancer status
            * 
           */
        {
            ht.Add("cancer", cancer);
        }

        public void setWeightLoss(bool weightLoss) { 
            /*
             * Determine if patient had a weight loss and assign score accordingly
             * 
             */
        
            if (weightLoss)
            {
                ht.Add("WeightLoss", 5);
            }
            else
            {
                ht.Add("WeightLoss", 0);
            }
            
        }

        public void setRenalFailure(bool kidney, bool stones)
            /*
             * Determine scoring for kideny failure
             */
        {
            if (kidney && stones)
            {
                ht.Add("kidney", 6);
            }
            else
            {
                ht.Add("kidney", 0);
            }
        }

        public void setCongestiveHeartFailure(bool chf)
        /*
         * Determine scoring for heart failure
         */
        {
            if (chf)
            {
                ht.Add("chf", 4);
            }
            else
            {
                ht.Add("chf", 0);
            }
        }

        public void setPoorAppetite(bool appetite)
        /*
         * Determine scoring for poor appetite
         */
        {
            if (appetite)
            {
                ht.Add("appetite", 4);
            }
            else
            {
                ht.Add("chf", 0);
            }
        }

        public void setSOB(bool sob)
        /*
         * Determine scoring for shortness of breath
         */
        {
            if (sob)
            {
                ht.Add("sob", 4);
            }
            else
            {
                ht.Add("chf", 0);
            }
        }

        public void setAssistedLiving(bool snf)
        /*
         * Determine scoring living a non independent living setting.
         */
        {
            if (snf)
            {
                ht.Add("snf", 8);
            }
            else
            {
                ht.Add("snf", 0);
            }
        }

        public void adlCog(string category,string level)
            /*
             * A method to score the ADL in the RAI
             * factor - Mobility, eating,Toilet Use etc.
             */
        {
         
            ht.Add(category,adl[level]);

        }

       
    }
}
