using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OCR_Implementation.Models.Entity;
using Microsoft.Extensions.Configuration;
using MyFirstWebAPI.Controllers;

namespace OCR_Implementation.Models.OCR_Repository
{
    public class OCR_DBContext:DbContext 
    {
        public OCR_DBContext():base() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            // For using Connection string of sql server. 
            string str = OCRController.Configuration.GetSection("ConnectionStrings").GetSection("MySqlDBConnectionString").Value;


            optionsBuilder.UseSqlServer("Data Source=(localdb)\\Mssqllocaldb;Initial Catalog=PracticeDatabase;Integrated Security=True");//ConnStr.Cont);
            //ConnStr.Cont);
            

            //"Data Source=(localdb)\\Mssqllocaldb;Initial Catalog=PracticeDatabase;Integrated Security=True");

            //("Data Source=tcp:cmd-atmecs.database.windows.net;Initial Catalog=CMD-DB;Persist Security Info=True;User ID=atmecs;Password=password@123");
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<PreviousEmploymentInfo> PreviousEmploymentInfos { get;set; }
    }


    //public class ConnStr
    //{
    //    public static string Cont { get; set; }
    //    public static void initstr(string con)
    //    {
    //        Cont= con;
    //    }
    //}
}
