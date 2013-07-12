using System;
using System.Net;
class DownloadFile
{
    static void Main()
    {
        using (WebClient download = new WebClient())
        {
            try
            {
                download.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", @"..\..\..\logo.jpg");
                Console.WriteLine("The file has been downloaded.");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Enter a file to download");
            }
            catch (WebException)
            {
                Console.WriteLine("Filename is null; File does not exist or an error occurred while downloading data.");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("The method has been called simultaneously on multiple threads.");
            }
        }
    }
}

