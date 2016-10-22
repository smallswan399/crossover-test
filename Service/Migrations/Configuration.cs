namespace Service.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Service.Entities.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Service.Entities.Context context)
        {
            if (!context.Stocks.Any())
            {
                context.Stocks.AddRange(context.GetRandomStocks());
                context.SaveChanges();
            }
        }
    }
}
