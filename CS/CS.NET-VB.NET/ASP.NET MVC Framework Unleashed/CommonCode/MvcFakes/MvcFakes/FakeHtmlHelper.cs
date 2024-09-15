﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace MvcFakes
{
    public class FakeHtmlHelper : HtmlHelper
    {
        public FakeHtmlHelper() 
            : base(new FakeViewContext(), new FakeViewDataContainer()) { }
    }
}
