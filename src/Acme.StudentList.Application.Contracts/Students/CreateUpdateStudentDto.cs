using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Acme.StudentList.Students;

public class CreateUpdateStudentDto
{
    [Required]
    [StringLength(128)]
    public string Name { get; set; } = string.Empty;

    [Required]
    [StringLength(10)]
    public string Class { get; set; }
    [Required]
    public StudentSex Type { get; set; } = StudentSex.Undefined;

    [Required]
    [StringLength(10)]
    public string Phone { get; set; }

    [Required]
    [StringLength(128)]
    public String Address { get; set; }

    [DataType(DataType.Date)]
    public DateTime DateOfBirth { get; set; } = DateTime.Now;
}

