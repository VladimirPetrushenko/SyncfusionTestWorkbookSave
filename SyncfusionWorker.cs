using Microsoft.AspNetCore.Http.Internal;
using Newtonsoft.Json;
using Syncfusion.EJ2.Spreadsheet;
using Syncfusion.XlsIO;
using System.IO;
using System.Text;
using TestRoundedValues.Models;

namespace TestRoundedValues
{
    public static class SyncfusionWorker
    {
        private const string jsonFile = "test.json";
        private const string xlsxFile = "test.xlsx";
        public static void Open()
        {
            using (ExcelEngine excelEngine = new ExcelEngine())
            {
                var application = excelEngine.Excel;

                application.DefaultVersion = ExcelVersion.Xlsx;

                var workbook = application.Workbooks.Create(1);

                var workSheet = workbook.Worksheets[0];

                IRange cells = workSheet.Range;

                for(var i = 1; i < 25; i++)
                {
                    cells[1, i].NumberFormat = "@";
                    cells[1, i].ColumnWidth = 15;
                    cells[1, i].Value = new string('1', i);
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    stream.Position = 0;

                    var file = new FormFile(stream, 0, stream.Length, null, $"test.xlsx");
                    var request = new OpenRequest
                    {
                        File = file,
                    };

                    var settingsFile = Workbook.Open(request);
                    //need to get a similar json file as the one that comes with the interface (angular + Syncfusion.Spreadsheet)
                    var settings = JsonConvert.DeserializeObject<PreviewSettings>(settingsFile);
                    var result = JsonConvert.SerializeObject(settings.Workbook);

                    var content = Encoding.Default.GetBytes(result);
                    File.WriteAllBytes(jsonFile, content);
                }
            }
        }

        public static void Save()
        {
            var settings = File.ReadAllText(jsonFile);

            var saveSettings = new SaveSettings
            {
                FileContentType = ContentType.Xlsx,
                JSONData = settings,
                SaveType = SaveType.Xlsx,
                VersionType = VersionType.Xlsx,
                PdfLayoutSettings = "{\"fitSheetOnOnePage\":false}",
                FileName = "test.xlsx",
            };

            var file = Workbook.Save(saveSettings);

            using(var ms = new MemoryStream())
            {
                file.FileStream.CopyTo(ms);
                File.WriteAllBytes(xlsxFile, ms.ToArray());
            }

            file.FileStream.Dispose();
        }
    }
}
