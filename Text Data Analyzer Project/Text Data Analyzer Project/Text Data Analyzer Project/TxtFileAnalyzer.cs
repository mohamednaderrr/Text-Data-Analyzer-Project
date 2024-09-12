using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Data_Analyzer_Project
{
    public class TxtFileAnalyzer : FileAnalyzer, IFileAnalysis 
    {
        public void AnalyzeFile(FileInfo fileInfo)
        {
           string fileString = File.ReadAllText(fileInfo.FullName);
       
            AnalyasisResults results = new AnalyasisResults();

            var words = fileString.Split(new char[] { ' ', '\n', '\r' }); //return array of string
            results.WordCount= words.Length; //عدد الكلمات ال في المصفوفه
            results.CharachterCount =  fileString.Length;
            var lines = fileString.Split(new char[] { '\n', });
            results.LineCount= lines.Length;

            SetResults(results);
        }
    }
}
