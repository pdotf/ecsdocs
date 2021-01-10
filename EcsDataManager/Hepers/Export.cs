using CsvHelper;
using Syroot.Windows.IO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace EcsDataManager.Hepers
{
    public class Export : IExport
    {
        public async Task CsvExport<T>(List<T> records)
        {
            string submittedFilePath =
Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+"\\mycsv.csv";
            //new KnownFolder(KnownFolderType.PublicDownloads).Path
            using (var writer = new StreamWriter(submittedFilePath))
            using (var csv = new CsvWriter(writer, CultureInfo.DefaultThreadCurrentCulture))
            {
                csv.WriteRecords(records);
            }
        }
    }
}
