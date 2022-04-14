using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTables.Models
{
    public class ProjectData
    {
        public int Id { get; set; }
        public string ProjectFolder { get; set; }
        public string ProjectName { get; set; }
        public string ProjectContent { get; set; }
    }
}