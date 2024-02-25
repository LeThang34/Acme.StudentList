using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.StudentList.Students;

public class Student : AuditedAggregateRoot<Guid>
{
    public string Name { get; set; }
    public string Class { get; set; }
    public StudentSex Type { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
}
