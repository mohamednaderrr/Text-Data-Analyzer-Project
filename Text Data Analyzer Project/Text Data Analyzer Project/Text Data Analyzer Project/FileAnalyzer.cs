using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Data_Analyzer_Project
{
    //Base Class
    public class FileAnalyzer
    {
        //data hiding ->Encapsolation
        private AnalyasisResults _results;

        public AnalyasisResults GetResults()
        { 
            return _results;
        }

        public void SetResults(AnalyasisResults results)
        {
            //Cheecking OR Validation ->ميزه من مميزات ال Encapsolation
            _results = results;
        }
           
    }
}
