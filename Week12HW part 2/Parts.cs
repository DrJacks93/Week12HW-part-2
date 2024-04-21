using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week12HW_part_2
{
    public class Parts
    {
        int partNumber;
        string pName, pDescription;
        double cost;


        public Parts(int pNumb, string pn, string pd, double c) 
        { 
            
            partNumber = pNumb;
            pName = pn;
            pDescription = pd;
            Cost = c;
                 
        }
                  
        public int PartNumber 
        { 
         get { return partNumber; }
            set { partNumber = value; }
        
        
        }
        public string PName 
        { 
         get { return pName; }
            set { pName = value; }
        
        
        }

        public string PDescription
        { 
            
            get { return pDescription; }         
             set { pDescription = value; }
        }

        public double Cost 
        {
            get { return cost;}
            set { cost = value; }
        
        
        }
    }

    
}
