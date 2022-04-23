using NetworkAcademyFinal.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NetworkAcademyFinal.DataContext
{
    public class Context:DbContext
    {
        public Context()
            : base("name =SchoolDb") //database'e ulaşması için
        {

        }

        //Yapılıcaklar:
        //1. base kısmına connectionstring'deki name adı yazılacak
        //2.NugetPackage üzerinden EntityFramework İndirilecek
        //3.ConnectionString aşağıdaki gibi yapılacak
        //<add name="SchoolDb" connectionString="Data Source=DESKTOP-0685COT\BIROL;Initial Catalog=TESTKISWRMIP;Integrated Security=True" providerName="System.Data.SqlClient"/>
        // 4. enable add update
        // 5. Gerekirse AppStart/RouteConfig kısmındaki Controller adı Ogrencis yapılacak
        // 6. Controller entity framework seçilerek eklenecek 

        public virtual DbSet<Ogrenci> MyEntities { get; set; }
    }
}