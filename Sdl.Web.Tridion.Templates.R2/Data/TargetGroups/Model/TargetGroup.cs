﻿using System.Collections.Generic;

namespace Sdl.Web.Tridion.Templates.R2.Data.TargetGroups.Model
{
    public class TargetGroup
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
        
        public IList<Condition> Conditions { get; set; }
    }
}
