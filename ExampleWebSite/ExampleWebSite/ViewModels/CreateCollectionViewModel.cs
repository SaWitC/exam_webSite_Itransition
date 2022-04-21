﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using ExampleWebSite.Models;
using Microsoft.AspNetCore.Http;

namespace ExampleWebSite.ViewModels
{
    public class CreateCollectionViewModel
    {
        public CollectionModel collection { get; set; }
        public string ThemaTitle { get; set; }

       // public int PropertiesNum { get; set; }
        public IEnumerable<string> PropertiesNumTitles { get; set; }
        public IEnumerable<string> PropertiesStrTitles { get; set; }
        public IEnumerable<string> PropertiesDateTitles { get; set; }

        public IFormFile ImageFile { get; set; }



        // public int PropertiesStr { get; set; }
        // public int PropertiesDate { get; set; }

    }
}
