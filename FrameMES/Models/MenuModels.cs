using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameMES.Models
{
  public  class MenuItemModel
    {
        public string Icon { get; set; }
        public string Header { get; set; }
        public List<SubItemModel> Children { get; set; } =
            new List<SubItemModel>();
    }
     
  public  class SubItemModel
    {
        public string Header { get; set; }
        public string TargetView { get; set; }
     
    }
}
