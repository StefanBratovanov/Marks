using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Iskra_Marks_App.Data;

namespace Iskra_Marks_App.Web.Controllers
{
    public abstract class BaseController : Controller
    {
        protected BaseController(IMarksData data)
        {
            this.Data = data;
        }

        public IMarksData Data { get; private set; }
    }
}

