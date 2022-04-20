namespace SeedOldDataInDB

{
    using Newtonsoft.Json.Linq;
    using ExcelApp = Microsoft.Office.Interop.Excel;
    using System.Linq;
    using System.Xml.Linq;

    public class Program
    {
        private const string Path = @"C:\Users\georg\OneDrive\Desktop\ShiftReport\NewShiftReport\ShiftReport.v2.0\SeedOldDataInDB\data.json";
        private const string Path1 = @"C:\Users\georg\OneDrive\Desktop\ShiftReport\NewShiftReport\ShiftReport.v2.0\SeedOldDataInDB\Shift.xml";
        static void Main(string[] args)
        {
            JObject obj = JObject.Parse(File.ReadAllText(Path));

            XDocument document = XDocument.Load(Path1);

            var names = new HashSet<string>();

            var records = document.Root.Elements();
            foreach (var record in records)
            {
                if (record==null)
                {

                }
                string engineerName = record.Element("NODE3").Value;
               // names.Add(engineerName);
            }
        }
    }
}