using FrameMES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameMES.ViewModels
{
  public class MainViewModel
    {
        public List<MenuItemModel> MenuList { get; set; }
        = new List<MenuItemModel>();

        public MainViewModel() 
        {
            MenuItemModel mm = new MenuItemModel();
            mm.Header = "工艺";
            mm.Icon = "\ue610";
            MenuList.Add(mm);
            mm.Children.Add(new SubItemModel
            {
                Header = "EBOM",
                TargetView = "BlankPage"
            });
            mm.Children.Add(new SubItemModel
            {
                Header = "PBOM",
                TargetView = "PBOMView"
            });
            mm.Children.Add(new SubItemModel
            {
                Header = "加工工艺",
                TargetView = "BlankPage",
            });

            mm = new MenuItemModel();
            mm.Header = "排程";
            mm.Icon = "\ue655";
            MenuList.Add(mm);
            mm.Children.Add(new SubItemModel
            {
                Header = "手动排程",
                TargetView = "SchedulView"
            });
            mm.Children.Add(new SubItemModel
            {
                Header = "自动排程",
                TargetView = "BlankPage"
            });
            mm.Children.Add(new SubItemModel
            {
                Header = "加工程序管理",
                TargetView = "ProcessPage"
            });

            mm = new MenuItemModel();
            mm.Header = "设备";
            mm.Icon = "\ue661";
            MenuList.Add(mm);
            mm.Children.Add(new SubItemModel
            {
                Header = "料仓管理",
                TargetView = "BlankPage"
            });
            mm.Children.Add(new SubItemModel
            {
                Header = "设备看板",
                TargetView = "DeviceDashboardView"
            });

            mm = new MenuItemModel();
            mm.Header = "测量";
            mm.Icon = "\ue643";
            MenuList.Add(mm);
            mm.Children.Add(new SubItemModel
            {
                Header = "刀具信息采集",
                TargetView = "BlankPage"
            });
            mm.Children.Add(new SubItemModel
            {
                Header = "测量数据采集",
                TargetView = "BlankPage"
            });
            mm.Children.Add(new SubItemModel
            {
                Header = "刀补返修",
                TargetView = "BlankPage"
            });
            mm.Children.Add(new SubItemModel
            {
                Header = "质量跟踪",
                TargetView = "BlankPage"
            });

            mm = new MenuItemModel();
            mm.Header = "生产";
            mm.Icon = "\ue7b9";
            MenuList.Add(mm);
            mm.Children.Add(new SubItemModel
            {
                Header = "生产数据统计",
                TargetView = "ProduceReportPage"
            });
            mm.Children.Add(new SubItemModel
            {
                Header = "刀具看板",
                TargetView = "BlankPage"
            });
            mm.Children.Add(new SubItemModel
            {
                Header = "料仓看板",
                TargetView = "BlankPage"
            });

            mm = new MenuItemModel();
            mm.Header = "系统";
            mm.Icon = "\ue626";
            MenuList.Add(mm);
            mm.Children.Add(new SubItemModel
            {
                Header = "网络拓扑图",
                TargetView = "BlankPage"
            });
            mm.Children.Add(new SubItemModel
            {
                Header = "机床通信测试",
                TargetView = "BlankPage"
            });
            mm.Children.Add(new SubItemModel
            {
                Header = "机器人通信测试",
                TargetView = "BlankPage"
            });
            mm.Children.Add(new SubItemModel
            {
                Header = "料仓通信测试",
                TargetView = "BlankPage"
            });
            mm.Children.Add(new SubItemModel
            {
                Header = "产品测量",
                TargetView = "BlankPage"
            });
            mm.Children.Add(new SubItemModel
            {
                Header = "系统菜单管理",
                TargetView = "MenuManagementView"
            });
            mm.Children.Add(new SubItemModel
            {
                Header = "用户权限管理",
                TargetView = "RoleManagementView"
            });

            mm = new MenuItemModel();
            mm.Header = "任务";
            mm.Icon = "\ue626";
            MenuList.Add(mm);
            mm.Children.Add(new SubItemModel
            {
                Header = "日志",
                TargetView = "BlankPage"
            });
        }
    }
}
