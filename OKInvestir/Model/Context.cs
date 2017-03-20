namespace OKInvestir.Model
{
    using System;
    using System.Data.Entity;
    using MySql.Data.Entity;
    using System.Linq;
    using System.Configuration;
    using System.ComponentModel.DataAnnotations;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Data.Entity.Validation;

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
        public DbSet<SillInterest> SillInterests { get; set; }
        public DbSet<TimeInterest> TimeInterests { get; set; }
        public DbSet<Simulation> Simulations { get; set; }
        public DbSet<User> Users { get; set; }
        //public DbSet<ForDropDb> ForDropDbs { get; set; }


        // generate connection string by parameters from DbParam.cs file
        public static string GetConnectionString()
        {
            var connString =
                ConfigurationManager.ConnectionStrings["mysqlCon"].ConnectionString.ToString();
            connString = String.Format(connString, DbParam.serverUrl, DbParam.dbName, DbParam.user, DbParam.password);

            return connString;
        }


        /**
         * Override savechanges method, to show more DbEntityValidationException detail
         */
        /*public override int SaveChanges()
        {
            try
            {
                return base.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                // Retrieve the error messages as a list of strings.
                var errorMessages = ex.EntityValidationErrors
                        .SelectMany(x => x.ValidationErrors)
                        .Select(x => x.ErrorMessage);

                // Join the list to a single string.
                var fullErrorMessage = string.Join("; ", errorMessages);

                // Combine the original exception message with the new one.
                var exceptionMessage = string.Concat(ex.Message, " The validation errors are: ", fullErrorMessage);

                // Throw a new DbEntityValidationException with the improved exception message.
                throw new DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors);
            }
        }*/

    }

    // Seeding initializer, add seed rows in db each creation of db.
    //public class SeedingDataInitializer : CreateDatabaseIfNotExists<Context>
    public class SeedingDataInitializer : DropCreateDatabaseIfModelChanges<Context>
    //public class SeedingDataInitializer : DropCreateDatabaseAlways<Context>
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
                new Client { IdCardNumber = "440603198701235555X", FirstName = "ClientFirstName", LastName = "ClientLastName" },
                new Client { IdCardNumber = "000000000001", FirstName = "clt", LastName = "1" },
                new Client { IdCardNumber = "000000000002", FirstName = "clt", LastName = "2" },
                new Client { IdCardNumber = "000000000003", FirstName = "clt", LastName = "3" },
                new Client { IdCardNumber = "000000000004", FirstName = "clt", LastName = "4" },
                new Client { IdCardNumber = "000000000005", FirstName = "clt", LastName = "5" },
                new Client { IdCardNumber = "000000000006", FirstName = "clt", LastName = "6" },
                new Client { IdCardNumber = "000000000007", FirstName = "clt", LastName = "7" },
                new Client { IdCardNumber = "000000000008", FirstName = "Shannon", LastName = "Wycoff" },
                new Client { IdCardNumber = "000000000009", FirstName = "Marita", LastName = "Allmon" },
                new Client { IdCardNumber = "000000000010", FirstName = "Marinda", LastName = "Kwok" },
                new Client { IdCardNumber = "000000000011", FirstName = "Billy", LastName = "Petersen" },
                new Client { IdCardNumber = "000000000012", FirstName = "Rutha", LastName = "Lemmon" },
                new Client { IdCardNumber = "000000000013", FirstName = "Florine", LastName = "Redden" },
                new Client { IdCardNumber = "000000000014", FirstName = "Vicki", LastName = "Gaulke" },
                new Client { IdCardNumber = "000000000015", FirstName = "Karyl", LastName = "Bow" }
            };
            var AccountList = new List<Account>
            {
                new Account { Number = "111111", Balance = 1M, status = 1, Client = CltList[0] },
                new Account { Number = "222221", Balance = 1M, status = 1, Client = CltList[1] },
                new Account { Number = "222222", Balance = 1M, status = 2, Client = CltList[1] },
                new Account { Number = "333331", Balance = 1M, status = 1, Client = CltList[2] },
                new Account { Number = "333332", Balance = 1M, status = 2, Client = CltList[2] },
                new Account { Number = "333333", Balance = 1M, status = 3, Client = CltList[2] },
                new Account { Number = "444441", Balance = 1M, status = 1, Client = CltList[3] },
                new Account { Number = "444442", Balance = 1M, status = 1, Client = CltList[3] },
                new Account { Number = "444443", Balance = 1M, status = 2, Client = CltList[3] },
                new Account { Number = "444444", Balance = 1M, status = 3, Client = CltList[3] },
                new Account { Number = "555551", Balance = 1M, status = 1, Client = CltList[4] },
                new Account { Number = "555552", Balance = 1M, status = 2, Client = CltList[4] },
                new Account { Number = "555553", Balance = 1M, status = 3, Client = CltList[4] }
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
            var SillInterestList = new List<SillInterest>
            {
                new SillInterest { ProductID = 1, Sill = 100M, Interest = 5M },
                new SillInterest { ProductID = 1, Sill = 500M, Interest = 7M },
                new SillInterest { ProductID = 1, Sill = 1000M, Interest = 9.5M },
                new SillInterest { ProductID = 1, Sill = 5000M, Interest = 13M },
                new SillInterest { ProductID = 2, Sill = 10, Interest = 3M },
                new SillInterest { ProductID = 2, Sill = 100M, Interest = 5M },
                new SillInterest { ProductID = 2, Sill = 1000M, Interest = 8M },
                new SillInterest { ProductID = 2, Sill = 10000M, Interest = 14M },
                new SillInterest { ProductID = 3, Sill = 10, Interest = 3M },
                new SillInterest { ProductID = 3, Sill = 100M, Interest = 5M },
                new SillInterest { ProductID = 5, Sill = 233M, Interest = 23.3M },
            };
            var TimeInterestList = new List<TimeInterest>
            {
                new TimeInterest { ProductID = 1, Time = 3, Interest = 1M },
                new TimeInterest { ProductID = 1, Time = 6, Interest = 2.3M },
                new TimeInterest { ProductID = 1, Time = 9, Interest = 3.8M },
                new TimeInterest { ProductID = 1, Time = 12, Interest = 5.5M },
                new TimeInterest { ProductID = 2, Time = 12, Interest = 5M },
                new TimeInterest { ProductID = 2, Time = 24, Interest = 8M },
                new TimeInterest { ProductID = 3, Time = 36, Interest = 13M },
                new TimeInterest { ProductID = 3, Time = 48, Interest = 19M },
                new TimeInterest { ProductID = 4, Time = 24, Interest = 10M },
                new TimeInterest { ProductID = 4, Time = 96, Interest = 50M },
                new TimeInterest { ProductID = 5, Time = 233, Interest = 23.3M }
            };
            var BoughtPdtList = new List<BoughtProduct>
            {
                new BoughtProduct { FinalInterest = 3M, BoughtStatus = 1,
                    StartDate = DateTime.ParseExact("24/12/2016", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("24/01/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    BuyingDate = DateTime.ParseExact("04/01/2017", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Price = 12345, SettlementPrice = 22345, 
                    Client = CltList[0], Product = PdtList[0]},
                new BoughtProduct { FinalInterest = 23M, BoughtStatus = 1,
                    StartDate = DateTime.ParseExact("02/02/2017", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("02/01/2018", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    BuyingDate = DateTime.ParseExact("05/01/2017", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Price = 6666, SettlementPrice = 8888, 
                    Client = CltList[0], Product = PdtList[1]},
                new BoughtProduct { FinalInterest = 5M, BoughtStatus = 1,
                    StartDate = DateTime.ParseExact("03/11/2017", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("03/11/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    BuyingDate = DateTime.ParseExact("11/02/2017", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Price = 20000, SettlementPrice = 23333, 
                    Client = CltList[1], Product = PdtList[2]},
                new BoughtProduct { FinalInterest = 0.5M, BoughtStatus = 1,
                    StartDate = DateTime.ParseExact("10/07/2018", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("10/07/2025", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    BuyingDate = DateTime.ParseExact("14/03/2017", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Price = 3000, SettlementPrice = 5000,
                    Client = CltList[1], Product = PdtList[3]},
                new BoughtProduct { FinalInterest = 0.5M, BoughtStatus = 1,
                    StartDate = DateTime.ParseExact("10/07/2018", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("10/07/2025", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    BuyingDate = DateTime.ParseExact("31/01/2017", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Price = 5000, SettlementPrice = 8000,
                    Client = CltList[2], Product = PdtList[4]},
                new BoughtProduct { FinalInterest = 0.5M, BoughtStatus = 1,
                    StartDate = DateTime.ParseExact("10/07/2018", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("10/07/2025", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    BuyingDate = DateTime.ParseExact("19/02/2017", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Price = 2500, SettlementPrice = 3000,
                    Client = CltList[2], Product = PdtList[4]},
                new BoughtProduct { FinalInterest = 0.5M, BoughtStatus = 1,
                    StartDate = DateTime.ParseExact("10/07/2018", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("10/07/2025", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    BuyingDate = DateTime.ParseExact("30/01/2017", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Price = 23456, SettlementPrice = 26666,
                    Client = CltList[2], Product = PdtList[4]},
                new BoughtProduct { FinalInterest = 0.5M, BoughtStatus = 1,
                    StartDate = DateTime.ParseExact("10/07/2018", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("10/07/2025", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    BuyingDate = DateTime.ParseExact("10/02/2017", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Price = 13579, SettlementPrice = 24680,
                    Client = CltList[2], Product = PdtList[4]}
            };

            // TODO: other models seed
            UsrList.ForEach(w => context.Users.Add(w));
            CltList.ForEach(w => context.Clients.Add(w));
            PdtList.ForEach(w => context.Products.Add(w));
            SillInterestList.ForEach(w => context.SillInterests.Add(w));
            TimeInterestList.ForEach(w => context.TimeInterests.Add(w));
            AccountList.ForEach(w => context.Accounts.Add(w));
            BoughtPdtList.ForEach(w => context.BoughtProducts.Add(w));
            base.Seed(context);
        }
    }
}