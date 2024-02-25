using Acme.StudentList.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Acme.StudentList.Permissions;

public class StudentListPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var studentlistGroup = context.AddGroup(StudentListPermissions.GroupName, L("Permission:StudentList"));

        var studentsPermission = studentlistGroup.AddPermission(StudentListPermissions.Students.Default, L("Permission:Students"));
        studentsPermission.AddChild(StudentListPermissions.Students.Create, L("Permission:Students.Create"));
        studentsPermission.AddChild(StudentListPermissions.Students.Edit, L("Permission:Students.Edit"));
        studentsPermission.AddChild(StudentListPermissions.Students.Delete, L("Permission:Students.Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<StudentListResource>(name);
    }
}
