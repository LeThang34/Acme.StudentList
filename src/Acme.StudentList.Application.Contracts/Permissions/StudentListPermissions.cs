namespace Acme.StudentList.Permissions;

public static class StudentListPermissions
{
    public const string GroupName = "StudentList";

    public static class Students
    {
        public const string Default = GroupName + ".Students";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }
}
