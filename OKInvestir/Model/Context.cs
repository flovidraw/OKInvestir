namespace OKInvestir.Model
{
    using System;
    using System.Data.Entity;
    using MySql.Data.Entity;
    using System.Linq;
    using System.Configuration;
    using System.ComponentModel.DataAnnotations;

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
            Database.SetInitializer<Context>(new DropCreateDatabaseIfModelChanges<Context>());
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


        public static string GetConnectionString()
        {
            var connString =
                ConfigurationManager.ConnectionStrings["mysqlCon"].ConnectionString.ToString();
            connString = String.Format(connString, DbParam.serverUrl, DbParam.dbName, DbParam.user, DbParam.password);
            
            return connString;
        }
    }
    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}