﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MardisGeo.Views.modelWeb
{
    public class ListModel
    {
        public ListModel()
        {
            ActionsList = new List<SelectListItem>();
        }
        public IEnumerable<SelectListItem> ActionsList { get; set; }
        public string Text { get; set; }
        public string Id { get; set; }

    }
}