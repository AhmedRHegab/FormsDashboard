using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace AppForms.AppForms;

[ConnectionKey("AppForms"), Module("AppForms"), TableName("ApplicantsFroms")]
[DisplayName("Applicants Froms"), InstanceName("Applicants Froms")]
[ReadPermission("ApplicantsFroms")]
[ModifyPermission("ApplicantsFroms")]
public sealed class ApplicantsFromsRow : Row<ApplicantsFromsRow.RowFields>, IIdRow, INameRow
{
    const string jGovernorate = nameof(jGovernorate);
    const string jFaculty = nameof(jFaculty);
    const string jUniversity = nameof(jUniversity);
    const string jSpeciality = nameof(jSpeciality);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id
    {
        get => fields.Id[this];
        set => fields.Id[this] = value;
    }

    [DisplayName("Governorate"), NotNull, ForeignKey("Governorates", "Id"), LeftJoin(jGovernorate), TextualField(nameof(GovernorateName))]
    public int? GovernorateId
    {
        get => fields.GovernorateId[this];
        set => fields.GovernorateId[this] = value;
    }

    [DisplayName("Faculty"), NotNull, ForeignKey("Faculties", "Id"), LeftJoin(jFaculty), TextualField(nameof(FacultyName))]
    public int? FacultyId
    {
        get => fields.FacultyId[this];
        set => fields.FacultyId[this] = value;
    }

    [DisplayName("University"), NotNull, ForeignKey("Universities", "Id"), LeftJoin(jUniversity), TextualField(nameof(UniversityName))]
    public int? UniversityId
    {
        get => fields.UniversityId[this];
        set => fields.UniversityId[this] = value;
    }

    [DisplayName("Name En"), Column("Name_En"), NotNull, QuickSearch, NameProperty]
    public string NameEn
    {
        get => fields.NameEn[this];
        set => fields.NameEn[this] = value;
    }

    [DisplayName("Mobile"), NotNull]
    public string Mobile
    {
        get => fields.Mobile[this];
        set => fields.Mobile[this] = value;
    }

    [DisplayName("Github Link"), Column("Github_Link")]
    public string GithubLink
    {
        get => fields.GithubLink[this];
        set => fields.GithubLink[this] = value;
    }

    [DisplayName("Linked In Link"), Column("LinkedIn_Link")]
    public string LinkedInLink
    {
        get => fields.LinkedInLink[this];
        set => fields.LinkedInLink[this] = value;
    }

    [DisplayName("Iti Graduate"), Column("ITI_Graduate"), NotNull]
    public bool? ItiGraduate
    {
        get => fields.ItiGraduate[this];
        set => fields.ItiGraduate[this] = value;
    }

    [DisplayName("Year Of Graduation"), Column("year_Of_Graduation")]
    public string YearOfGraduation
    {
        get => fields.YearOfGraduation[this];
        set => fields.YearOfGraduation[this] = value;
    }

    [DisplayName("Graduation Year"), Column("Graduation_Year"), NotNull]
    public string GraduationYear
    {
        get => fields.GraduationYear[this];
        set => fields.GraduationYear[this] = value;
    }

    [DisplayName("Current Company"), Column("Current_Company")]
    public string CurrentCompany
    {
        get => fields.CurrentCompany[this];
        set => fields.CurrentCompany[this] = value;
    }

    [DisplayName("Current Salary"), Column("Current_Salary")]
    public string CurrentSalary
    {
        get => fields.CurrentSalary[this];
        set => fields.CurrentSalary[this] = value;
    }

    [DisplayName("Expected Salary"), Column("Expected_Salary"), NotNull]
    public string ExpectedSalary
    {
        get => fields.ExpectedSalary[this];
        set => fields.ExpectedSalary[this] = value;
    }

    [DisplayName("Availability Date"), Column("Availability_Date"), NotNull]
    public DateTime? AvailabilityDate
    {
        get => fields.AvailabilityDate[this];
        set => fields.AvailabilityDate[this] = value;
    }

    [DisplayName("Interested Working In Cairo"), Column("Interested_Working_In_Cairo"), NotNull]
    public bool? InterestedWorkingInCairo
    {
        get => fields.InterestedWorkingInCairo[this];
        set => fields.InterestedWorkingInCairo[this] = value;
    }

    [DisplayName("Mobile Apps Experience"), Column("Mobile_Apps_Experience"), NotNull]
    public bool? MobileAppsExperience
    {
        get => fields.MobileAppsExperience[this];
        set => fields.MobileAppsExperience[this] = value;
    }

    [DisplayName("E Commerce Apps Experience"), Column("E_Commerce_Apps_Experience"), NotNull]
    public bool? ECommerceAppsExperience
    {
        get => fields.ECommerceAppsExperience[this];
        set => fields.ECommerceAppsExperience[this] = value;
    }

    [DisplayName("Cv"), Column("CV"), NotNull, EditLink]
    public string Cv
    {
        get => fields.Cv[this];
        set => fields.Cv[this] = value;
    }

    [DisplayName("Speciality"), NotNull, ForeignKey("Specialities", "Id"), LeftJoin(jSpeciality), TextualField(nameof(SpecialityName))]
    public int? SpecialityId
    {
        get => fields.SpecialityId[this];
        set => fields.SpecialityId[this] = value;
    }

    [DisplayName("Governorate Name"), Expression($"{jGovernorate}.[Name]")]
    public string GovernorateName
    {
        get => fields.GovernorateName[this];
        set => fields.GovernorateName[this] = value;
    }

    [DisplayName("Faculty Name"), Expression($"{jFaculty}.[Name]")]
    public string FacultyName
    {
        get => fields.FacultyName[this];
        set => fields.FacultyName[this] = value;
    }

    [DisplayName("University Name"), Expression($"{jUniversity}.[Name]")]
    public string UniversityName
    {
        get => fields.UniversityName[this];
        set => fields.UniversityName[this] = value;
    }

    [DisplayName("Speciality Name"), Expression($"{jSpeciality}.[Name]")]
    public string SpecialityName
    {
        get => fields.SpecialityName[this];
        set => fields.SpecialityName[this] = value;
    }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public Int32Field GovernorateId;
        public Int32Field FacultyId;
        public Int32Field UniversityId;
        public StringField NameEn;
        public StringField Mobile;
        public StringField GithubLink;
        public StringField LinkedInLink;
        public BooleanField ItiGraduate;
        public StringField YearOfGraduation;
        public StringField GraduationYear;
        public StringField CurrentCompany;
        public StringField CurrentSalary;
        public StringField ExpectedSalary;
        public DateTimeField AvailabilityDate;
        public BooleanField InterestedWorkingInCairo;
        public BooleanField MobileAppsExperience;
        public BooleanField ECommerceAppsExperience;
        public StringField Cv;
        public Int32Field SpecialityId;

        public StringField GovernorateName;
        public StringField FacultyName;
        public StringField UniversityName;
        public StringField SpecialityName;
    }
}