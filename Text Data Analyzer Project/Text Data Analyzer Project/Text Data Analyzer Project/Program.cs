namespace Text_Data_Analyzer_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To File Analyzer");
            Console.WriteLine("Please Enter Folder Path To Analyzer");


            string inputFolder=Console.ReadLine();

            DirectoryInfo directoryInfo = new DirectoryInfo(inputFolder);

            if (directoryInfo.Exists == false) 
            {
                Console.WriteLine("Folder Don't Exist");
                return;
            }
            var filenames= directoryInfo.GetFiles();

            IFileAnalysis fileAnalysis = null;

            foreach (var file in filenames)
            {
                if (file.IsTextFile()) //extentions
                {
                    fileAnalysis = new TxtFileAnalyzer();
                    fileAnalysis.AnalyzeFile(file); //AnalyzeFile is InterFace

                    var results = ((FileAnalyzer)fileAnalysis).GetResults();//casting
                    Console.WriteLine($"File Name : {file.Name}");
                    Console.WriteLine($"Word Count : {results.WordCount}");
                    Console.WriteLine($"Charachter Count : {results.CharachterCount}");
                    Console.WriteLine($"Line Count : {results.LineCount}");
                }
                else if (file.IsCsvFile()) 
                {
                    fileAnalysis = new CSVFileAnalyzer();

                    fileAnalysis.AnalyzeFile(file); //AnalyzeFile is InterFace

                    var results = ((FileAnalyzer)fileAnalysis).GetResults();//casting

                    Console.WriteLine($"File Name : {file.Name}");
                    Console.WriteLine($"Field Count : {results.FieldCount}");
                    
                }
                


            }
        }
    }
}
