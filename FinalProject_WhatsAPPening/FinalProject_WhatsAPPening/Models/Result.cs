﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FinalProject_WhatsAPPening.Models;
using Microsoft.Owin.Security;

namespace FinalProject_WhatsAPPening.Models
{
    public class Result
    {
        public Activity ActivityResult { get; set; }

        public Restaurant RestaurantResult { get; set; }
    }
}