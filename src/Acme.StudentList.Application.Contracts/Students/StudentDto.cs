using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.StudentList.Students;
public class StudentDto : AuditedEntityDto<Guid>
{
    public string Name { get; set; }
    public string Class { get; set; }
    public StudentSex Type { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
}
