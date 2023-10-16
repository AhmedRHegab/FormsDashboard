using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace AppForms.AppForms.Columns;

[ColumnsScript("AppForms.ApplicantsFroms")]
[BasedOnRow(typeof(ApplicantsFromsRow), CheckNames = true)]
public class ApplicantsFromsColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    public string GovernorateName { get; set; }
    public string FacultyName { get; set; }
    public string UniversityName { get; set; }
    [EditLink]
    public string NameEn { get; set; }
    public string Mobile { get; set; }
    public string GithubLink { get; set; }
    public string LinkedInLink { get; set; }
    public bool ItiGraduate { get; set; }
    public string YearOfGraduation { get; set; }
    public string GraduationYear { get; set; }
    public string CurrentCompany { get; set; }
    public string CurrentSalary { get; set; }
    public string ExpectedSalary { get; set; }
    public DateTime AvailabilityDate { get; set; }
    public bool InterestedWorkingInCairo { get; set; }
    public bool MobileAppsExperience { get; set; }
    public bool ECommerceAppsExperience { get; set; }
    public string Cv { get; set; }
    public string SpecialityName { get; set; }
}