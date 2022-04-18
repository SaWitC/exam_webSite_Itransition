﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExampleWebSite.Models;

namespace ExampleWebSite.Data
{
    public class SampleDate
    {
        public static void InitialiseThemes(ExamWebSiteDBContext _context)
        {
            if (!_context.Themes.Any())
            {
                _context.Themes.AddRange(
                new ThemaModel { Title = "Books", Description = "coloctions of books" },
                new ThemaModel  {Title = "Minerals", Description = "coloctions of Minerals" },
                new ThemaModel {Title = "alcohol", Description = "coloctions of alcohol" }
                );
                _context.SaveChanges();
            }
        }
    }
}
