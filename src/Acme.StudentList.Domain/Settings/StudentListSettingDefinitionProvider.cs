using Volo.Abp.Settings;

namespace Acme.StudentList.Settings;

public class StudentListSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(StudentListSettings.MySetting1));
    }
}
