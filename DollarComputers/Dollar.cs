using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DollarComputers
{
    enum DollarField{
        ID,COST,MFG,MODEL,MEMORY,LCDSIZE,CPUBRAND,CPUTYPE,
        CPUNUMBER,CPUSPEED,CONDITION,PLATFORM,OS,HDD,
        GPUTYPE,WEBCAM
        
    }
    public class Dollar
    {
        public int ID { get; set; }
     
        public string Cost { get; set; }

        public string MFG { get; set; }

        public string Model { get; set; }

        public string Memory { get; set; }

        public string LCDSize { get; set; }

        public string CPUBrand { get; set; }

        public string CPUType { get; set; }

      
        public string CPUNumber { get; set; }

  
        public string CPUSpeed { get; set; }

        
        public string Condition { get; set; }

      
        public string Platform { get; set; }

     
        public string OS { get; set; }

        
        public string HDD { get; set; }

        
        public string GPUType { get; set; }

    
        public string WebCam { get; set; }
    }
}
