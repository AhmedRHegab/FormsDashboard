using Serenity.Navigation;
using MyPages = AppForms.AppForms.Pages;

[assembly: NavigationLink(int.MaxValue, "AppForms/Applicants Froms", typeof(MyPages.ApplicantsFromsPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "AppForms/Faculties", typeof(MyPages.FacultiesPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "AppForms/Governorates", typeof(MyPages.GovernoratesPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "AppForms/Specialities", typeof(MyPages.SpecialitiesPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "AppForms/Universities", typeof(MyPages.UniversitiesPage), icon: null)]