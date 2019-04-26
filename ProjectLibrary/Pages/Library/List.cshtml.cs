using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectLibrary.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace ProjectLibrary.Pages.Library
{
    public class ListModel : PageModel
    {
        
        public IConfiguration Configuration { get; }
        public ILibraryData libraryData;


        public string Message { get; set; }
        public IEnumerable<Core.Library> Libraries { get; set; }


        public ListModel(IConfiguration configuration, ILibraryData libraryData)
        {
            Configuration = configuration;
            this.libraryData = libraryData;
        }
        public void OnGet()
        {
            Libraries = libraryData.GetAlLibraries();
            Message = Configuration["Message"];
        }
    }
}