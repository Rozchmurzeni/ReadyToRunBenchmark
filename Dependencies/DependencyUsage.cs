using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Dependencies.Database;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;

namespace Dependencies
{
    public class DependencyUsage
    {
        public async Task DoSomeWorkAsync()
        {
            await RunEntityFrameworkCodeAsync();
            RunEpplusCode();
            
            File.Delete(DatabaseConfig.DbFilePath);
        }

        private async Task RunEntityFrameworkCodeAsync()
        {
            var myContext = new MyContext();
            await myContext.Database.MigrateAsync();
            var items = await myContext.Items.Where(item => item.Id > 0).ToListAsync();
        }

        private void RunEpplusCode()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using var package = new ExcelPackage();
            var sheet = package.Workbook.Worksheets.Add("My Sheet");
            var excelBytes = package.GetAsByteArray();
        }
    }
}
