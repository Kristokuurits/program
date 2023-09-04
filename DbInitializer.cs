using ÄRA_NÄPPI_MINU_FAILI.Models;

namespace ÄRA_NÄPPI_MINU_FAILI.Data
{
    public class DbInitializer
    {
        public static void Initalize(SchoolContext context)
        {
            //otsib õpilasi
            if (context.Students.Any())
            {
                return;//väljub meetodist kui andmebaas sisaldab juba andmeid ning meedotis kirjeltatuid näidisõpilasi//kursuseid ja aineosalusi ei lisata      
            }
        

            var students = new Student[]
            {
                new Student {FirstMidName="Markus",LastName="Nirgi",EnrollmentDate=DateTime.Parse("2022-09-01")},
                new Student {FirstMidName="Virkus",LastName="Uusküla",EnrollmentDate=DateTime.Parse("2022-09-01")},
                new Student {FirstMidName="Juuli",LastName="Virtsu",EnrollmentDate=DateTime.Parse("2022-09-01")},
                new Student {FirstMidName="Maali",LastName="Plätsu",EnrollmentDate=DateTime.Parse("2022-09-01")},
                new Student {FirstMidName="Beta",LastName="Male",EnrollmentDate=DateTime.Parse("2022-09-01")},
                new Student {FirstMidName="Alpha",LastName="Chad",EnrollmentDate=DateTime.Now}
            };
            foreach (Student s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();
        }
    }
}
