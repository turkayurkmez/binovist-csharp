namespace Constructors
{
    /// <summary>
    /// Excel'den gelen verileri rapora dönüştürecek nesne:
    /// </summary>
    public class Report
    {
        public ReportFormats ReportFormat { get; set; }
        public string ExcelFilePath { get; set; }
        //public Report()
        //{
        //    ReportFormat = ReportFormats.HTML;
        //    //assignForConfiguariton();
        //}

        public Report(string path) : this(path, ReportFormats.HTML)
        {
        }

        public Report(string path, ReportFormats reportFormat)
        {
            isValidFilePath(path);
            ReportFormat = reportFormat;


        }

        private void isValidFilePath(string path)
        {
            ArgumentException.ThrowIfNullOrEmpty(nameof(path));
            isFileExists(path);
            ExcelFilePath = path;
        }

        private void isFileExists(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"{path} adresine gittim. Dosya mosya yok");
            }
        }





        //private void assignForConfiguariton()
        //{
        //    throw new NotImplementedException();
        //}
    }

    public enum ReportFormats
    {
        PDF,
        HTML
    }
}
