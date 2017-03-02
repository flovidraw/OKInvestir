namespace OKInvestir.Model
{
    using System;
    using System.Data.Entity;
    using MySql.Data.Entity;
    using System.Linq;
    using System.Configuration;
    using System.ComponentModel.DataAnnotations;
    using System.Collections.Generic;

    [DbConfigurationType(typeof(MySqlEFConfiguration))]

    public class Context : DbContext
    {
        //您的上下文已配置为从您的应用程序的配置文件(App.config 或 Web.config)
        //使用“Context”连接字符串。默认情况下，此连接字符串针对您的 LocalDb 实例上的
        //“OKInvestir.model.Context”数据库。
        // 
        //如果您想要针对其他数据库和/或数据库提供程序，请在应用程序配置文件中修改“Context”
        //连接字符串。
        public Context()
            : base(GetConnectionString())
        //: base("name=Context")
        {
            Database.SetInitializer<Context>(new SeedingDataInitializer());
        }

        //为您要在模型中包含的每种实体类型都添加 DbSet。有关配置和使用 Code First  模型
        //的详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=390109。

        public DbSet<Account> Accounts { get; set; }
        public DbSet<BoughtProduct> BoughtProducts { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<SillInterest> SillInterestDict { get; set; }
        public DbSet<Simulation> Simulations { get; set; }
        public DbSet<TimeInterest> TimeInterestDict { get; set; }
        public DbSet<User> Users { get; set; }


        // generate connection string by parameters from DbParam.cs file
        public static string GetConnectionString()
        {
            var connString =
                ConfigurationManager.ConnectionStrings["mysqlCon"].ConnectionString.ToString();
            connString = String.Format(connString, DbParam.serverUrl, DbParam.dbName, DbParam.user, DbParam.password);
            
            return connString;
        }
    }

    // Seeding initializer, add seed rows in db each creation of db.
    //public class SeedingDataInitializer : CreateDatabaseIfNotExists<Context>
    public class SeedingDataInitializer : DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {
            var UsrList = new List<User>
            {
                new User { Username = "a", Password = "a", UserLevel = 1},
                new User { Username = "bb", Password = "bb", UserLevel = 2},
                new User { Username = "ccc", Password = "ccc", UserLevel = 2}
            };
            var CltList = new List<Client>
            {
                new Client { FirstName = "ClientFirstName", LastName = "ClientLastName" },
                new Client { FirstName = "clt", LastName = "1" },
                new Client { FirstName = "clt", LastName = "2" },
                new Client { FirstName = "clt", LastName = "3" },
                new Client { FirstName = "clt", LastName = "4" },
                new Client { FirstName = "clt", LastName = "5" },
                new Client { FirstName = "clt", LastName = "6" },
                new Client { FirstName = "clt", LastName = "7" },
                new Client { FirstName = "Shannon", LastName = "Wycoff" },
                new Client { FirstName = "Marita", LastName = "Allmon" },
                new Client { FirstName = "Marinda", LastName = "Kwok" },
                new Client { FirstName = "Billy", LastName = "Petersen" },
                new Client { FirstName = "Rutha", LastName = "Lemmon" },
                new Client { FirstName = "Florine", LastName = "Redden" },
                new Client { FirstName = "Vicki", LastName = "Gaulke" },
                new Client { FirstName = "Karyl", LastName = "Bow" }
            };
            var PdtList = new List<Product>
            {
                new Product { Name = "First Product", Description = "First Description", ProductStatus = 1 },
                new Product { Name = "Product 2", Description = "Description 2", ProductStatus = 2 },
                new Product { Name = "pdt3", Description = "d3", ProductStatus = 1 },
                new Product { Name = "pdt4", Description = "d4", ProductStatus = 1 },
                new Product { Name = "pdt5", Description = "d5", ProductStatus = 2 },
                new Product { Name = "pdt6", Description = "d6", ProductStatus = 2 },
                new Product { Name = "pdt7", Description = "d7", ProductStatus = 2 },
                new Product { Name = "pdt8", Description = "d8", ProductStatus = 3 },
                new Product { Name = "pdt9", Description = "d9", ProductStatus = 3 },
                new Product { Name = "pdt10", Description = "d10", ProductStatus = 3 },
                new Product { Name = "余额宝", Description = "余额宝是支付宝打造的余额理财服务。" +
                    "\n把钱转入余额宝即购买了由天弘基金提供的天弘余额宝货币市场基金，可获得收益。" +
                    "\n余额宝内的资金还能随时用于网购支付，灵活提取。", ProductStatus = 1 }
            };

            // TODO: other models seed
            UsrList.ForEach(w => context.Users.Add(w));
            CltList.ForEach(w => context.Clients.Add(w));
            PdtList.ForEach(w => context.Products.Add(w));
            base.Seed(context);
        }
    }
}