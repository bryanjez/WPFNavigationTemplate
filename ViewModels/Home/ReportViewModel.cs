namespace WPFNavigationTemplate.ViewModels.Home
{
    public partial class ReportViewModel : BaseViewModel
    {
        public ReportViewModel()
        {
            
        }

        [ObservableProperty]
        int max = 100;

        [ObservableProperty]
        int val = 0;

        [ObservableProperty]
        string pdfSource;

        [RelayCommand]
        async Task UploadAsync()
        {
            string url = "ftp://codeecraft.com/progress.pdf";
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(url);
            request.Credentials = new NetworkCredential("codeecraft", "c0d33cr*ft");
            request.Method = WebRequestMethods.Ftp.UploadFile;

            using (Stream fileStream = File.OpenRead(@"C:\Users\Bryan\Desktop\pd907_af_revsept2013-1.pdf"))
            using (Stream ftpStream = await request.GetRequestStreamAsync())
            {
                Max = (int)fileStream.Length;

                byte[] buffer = new byte[10240];
                int read;
                while ((read = await fileStream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                {
                    await ftpStream.WriteAsync(buffer, 0, read);
                    Val = (int)fileStream.Position;
                }
            }
        }

        [RelayCommand]
        void View()
        {
            PdfSource = @"C:\Users\Bryan\Desktop\pd907_af_revsept2013-1.pdf";
        }


    }
}
