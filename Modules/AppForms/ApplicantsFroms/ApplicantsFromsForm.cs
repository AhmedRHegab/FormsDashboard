using Serenity.ComponentModel;
using System;

namespace AppForms.AppForms.Forms;

[FormScript("AppForms.ApplicantsFroms")]
[BasedOnRow(typeof(ApplicantsFromsRow), CheckNames = true)]
public class ApplicantsFromsForm
{
    public int GovernorateId { get; set; }
    public int FacultyId { get; set; }
    public int UniversityId { get; set; }
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
    public int SpecialityId { get; set; }
}