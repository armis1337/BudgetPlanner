using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BudgetPlanner2Web.Models;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;

namespace BudgetPlanner2Web.Services
{
    public class GoogleDriveService
    {
        private IConfiguration Configuration;
        private IWebHostEnvironment _env;
        private UserManager<ApplicationUser> _userManager;
        private HttpContext _context;
        // ============!!!=============
        // not finished & not working
        // ============!!!=============
        public GoogleDriveService(IConfiguration config, IWebHostEnvironment env, UserManager<ApplicationUser> usrmgr, IHttpContextAccessor http)
        {
            Configuration = config;
            _env = env;
            _userManager = usrmgr;
            _context = http.HttpContext;
        }

        public static string[] Scopes = { DriveService.Scope.Drive };

        //create Drive API service.
        public DriveService GetService()
        {
            UserCredential credential;

            credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                new ClientSecrets { 
                    ClientId = Configuration["Authentication:Google:ClientId"], 
                    ClientSecret = Configuration["Authentication:Google:ClientSecret"],
                },
                Scopes,
                //_userManager.GetUserAsync(_context.User).Result.UserName,
                "user",
                CancellationToken.None).Result;

            //create Drive API service.
            DriveService service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "test",
            });
            return service;
        }

        //file Upload to the Google Drive root folder.
        public void UploadFileOnDrive()
        {
            // create file
            var path = Path.Combine(_env.ContentRootPath, @"tmp\" + "report.txt");

            using (FileStream fs = System.IO.File.Create(path))
            {
                byte[] content = new UTF8Encoding(true).GetBytes("Hello World");

                fs.Write(content, 0, content.Length);
            }
            // upload
            DriveService service = GetService();
            //string path = @"C:\Users\Armis\source\repos\BudgetPlanner2\BudgetPlanner2Web\Startup.cs";

            FilesResource.CreateMediaUpload request;

            //service.Files.List();
            using (var stream = new System.IO.FileStream(path, FileMode.Open))
            {
                var FileMetaData = new Google.Apis.Drive.v3.Data.File();
                FileMetaData.Name = Path.GetFileName(path);
                request = service.Files.Create(FileMetaData, stream, FileMetaData.MimeType);
                //request.Fields = "id";
                request.Upload();
                
                // pirma kart prisijungus, visada ikelia faila i mano (arminas.glusinskas@gmail.com)
                // google drive, net jeigu esu atsijunges is google ar prisijunges prie programos su kita paskyra
            }
        }
    }
}
