using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Tabs
{
    public class TabView
    {
        public string PanelName { get; set; }
        public string IconPath { get; set; }
        public string CardTitle { get; set; }
        public string BadgeData { get; set; }
        public Color BadgeColor { get; set; }
        public Microsoft.AspNetCore.Components.RenderFragment CardContent { get; set; }
        public bool IsDynamic { get; set; } = false;
        public bool IsActive { get; set; } = true;
    }
}

