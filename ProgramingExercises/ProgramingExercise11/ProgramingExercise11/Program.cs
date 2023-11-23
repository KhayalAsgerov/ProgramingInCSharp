using static System.Net.Mime.MediaTypeNames;
using System.Net.NetworkInformation;

namespace ProgramingExercise11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Organize contents of any directory and it's files in the following style 

            //All image files and videos should be in Images folder(png, jpg, mp4,mp3 and etc.)
           // All txt files should be in Videos folder(txt,doc,pdf and etc.)

            OrganazingDocumentFilesOnDesktop test = new OrganazingDocumentFilesOnDesktop();
            test.TxtOrganizer();
            OrganazingMultimediaOnDesktop test1=new OrganazingMultimediaOnDesktop();
            test1.OrganizingMultimedia();
            Console.ReadKey();
        }
        public class OrganazingDocumentFilesOnDesktop
        {
            public void TxtOrganizer()
            {
                string MyDesktopPath = @"C:\Users\User\Desktop";
                string DocumentsPath = Path.Combine(MyDesktopPath,"Documents");

                string[] TxtFilesOnDesktop = Directory.GetFiles(MyDesktopPath,"*.txt");
                string[] PdfFilesOnDesktop = Directory.GetFiles(MyDesktopPath, "*.pdf");
                string[] DocxFilesOnDesktop = Directory.GetFiles(MyDesktopPath, "*.docx");
                string[] DocFilesOnDesktop = Directory.GetFiles(MyDesktopPath, "*.doc");

                try
                {
                    if (!Directory.Exists(DocumentsPath))
                    {
                        Directory.CreateDirectory(DocumentsPath);
                        Console.WriteLine("txtAndPdfFiles created");
                    }
                    else
                    { Console.WriteLine("txtAndPdfFiles is already exsists"); }

                }
                catch (Exception ex)
                {

                    Console.WriteLine("Error: " + ex.Message);
                }

                foreach (string file in TxtFilesOnDesktop)
                {
                    string fileName= Path.GetFileName(file);
                    string destFile=Path.Combine(DocumentsPath,fileName);
                    File.Move(file,destFile);
                }
                Console.WriteLine("All .txt files moved succesfully");

                foreach (string file in PdfFilesOnDesktop)
                {
                    string fileName = Path.GetFullPath(file);
                    string destFile=Path.Combine (DocumentsPath,fileName);
                    File.Move(file,destFile);
                }
                Console.WriteLine("All .pdf files moved succesfully");
                foreach (string file in DocxFilesOnDesktop)
                {
                    string fileName = Path.GetFileName(file);
                    string destFile = Path.Combine(DocumentsPath, fileName);
                    File.Move(file, destFile);
                }
                Console.WriteLine("All .docx files moved succesfully");
                foreach (string file in DocFilesOnDesktop)
                {
                    string fileName = Path.GetFileName(file);
                    string destFile = Path.Combine(DocumentsPath, fileName);
                    File.Move(file, destFile);
                }
                Console.WriteLine("All .doc files moved succesfully");
            }
             }
        public class OrganazingMultimediaOnDesktop
        {
            string MyDesktopPath = @"C:\Users\User\Desktop";
            string MultimediaPath = Path.Combine(@"C:\Users\User\Desktop","Multimedia");
            public void OrganizingMultimedia()
            {
                try
                {
                    if (!Directory.Exists(MultimediaPath))
                    {
                        Directory.CreateDirectory(MultimediaPath);
                        Console.WriteLine("Multimedia directory is created");
                    }
                    else
                    {
                        Console.WriteLine("This Directory is already exists");
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine("Error:"+ex);
                }
                string[] Mp3FilesOnDesktop = Directory.GetFiles(MyDesktopPath,"*.mp3");
                string[] JpgFilesOnDesktop = Directory.GetFiles(MyDesktopPath,"*.jpg");
                string[] ImgFilesOnDesktop = Directory.GetFiles(MyDesktopPath,"*.img");
                string[] PngFilesOnDesktop = Directory.GetFiles(MyDesktopPath,"*.png");
                foreach (var file in Mp3FilesOnDesktop)
                {
                    string fileName = Path.GetFileName(file);
                    string destFile = Path.Combine(MultimediaPath, fileName);
                    File.Move(file, destFile);
                    
                }
                Console.WriteLine("mp3 files sucsessfully moved");
                foreach (var file in JpgFilesOnDesktop)
                { 
                string fileName=Path.GetFileName(file);
                    string destFile=Path.Combine(MultimediaPath, fileName);
                    File.Move(file, destFile);
                   
                }
                Console.WriteLine("jpeg files sucsessfully moved");
                foreach (var file in ImgFilesOnDesktop)
                {
                    string fileName = Path.GetFileName(file);
                    string destFile = Path.Combine(MultimediaPath, fileName);
                    File.Move(file, destFile);
                   
                }
                Console.WriteLine("img files sucsessfully moved");
                foreach (var file in PngFilesOnDesktop)
                {
                    string fileName = Path.GetFileName(file);
                    string destFile = Path.Combine(MultimediaPath, fileName);
                    File.Move(file, destFile);
                    
                }
                Console.WriteLine("png files sucsessfully moved");

            }
        }
    }
    }

