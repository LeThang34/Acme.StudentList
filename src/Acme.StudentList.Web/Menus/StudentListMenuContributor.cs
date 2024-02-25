using System.Threading.Tasks;
using Acme.StudentList.Localization;
using Acme.StudentList.MultiTenancy;
using Acme.StudentList.Permissions;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Identity.Web.Navigation;
using Volo.Abp.SettingManagement.Web.Navigation;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace Acme.StudentList.Web.Menus;

public class StudentListMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        var administration = context.Menu.GetAdministration();
        var l = context.GetLocalizer<StudentListResource>();

        context.Menu.Items.Insert(
            0,
            new ApplicationMenuItem(
                StudentListMenus.Home,
                l["Menu:Home"],
                "~/",
                icon: "fas fa-home",
                order: 0
            )
        );

        context.Menu.AddItem(
        new ApplicationMenuItem(
            "StudentList",
            l["Menu:StudentList"],
            icon: "fa fa-solid fa-graduation-cap"
        ).AddItem(
            new ApplicationMenuItem(
                "StudentList.Students",
                l["Menu:Students"],
                url: "/Students"
            ).RequirePermissions(StudentListPermissions.Students.Default)
        )
        );

        if (MultiTenancyConsts.IsEnabled)
        {
            administration.SetSubItemOrder(TenantManagementMenuNames.GroupName, 1);
        }
        else
        {
            administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
        }

        administration.SetSubItemOrder(IdentityMenuNames.GroupName, 2);
        administration.SetSubItemOrder(SettingManagementMenuNames.GroupName, 3);

        return Task.CompletedTask;
    }
}
