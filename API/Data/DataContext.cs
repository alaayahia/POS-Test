using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
    public DataContext(DbContextOptions options) : base(options)
    {
    
    }

    public DbSet<AppUser> Users { get; set;} 
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Photo> Photos { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<PaymentType> PaymentTypes { get; set; }
    public DbSet<Store> Stores { get; set; }
    public DbSet<Inventory> Inventories { get; set; }
    public DbSet<TransactionType> TransactionTypes { get; set; }
    public DbSet<Transaction> Transactions { get; set; }
    public DbSet<TransactionDetail> TransactionDetails { get; set; }



     protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Product>()
                 .HasKey(k => new {k.CategoryId});

            builder.Entity<Inventory>()
                 .HasKey(k => new {k.ProductId, k.StoreId});

            builder.Entity<Photo>()
                 .HasKey(k => new {k.ProductId});

            builder.Entity<Transaction>()
                 .HasKey(k => new {k.CustomerId});

            builder.Entity<TransactionDetail>()
                 .HasKey(k => new {k.TransactionId, k.ProductId, k.StoreId});
                       

            builder.Entity<Product>()
                .HasOne(s => s.Category)
                .WithMany(l => l.Products)
                .HasForeignKey(s => s.CategoryId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Inventory>()
                  .HasOne(s => s.Product)
                  .WithMany(l => l.Inventories)
                  .HasForeignKey(s => s.ProductId)      
                  .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Inventory>()
                  .HasOne(s => s.Store)  
                  .WithMany(l => l.Inventories)
                  .HasForeignKey(s => s.StoreId)
                  .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Photo>()      
                  .HasOne(s => s.Product)
                  .WithMany(l => l.Photos)
                  .HasForeignKey(s => s.ProductId)
                  .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Transaction>()
                   .HasOne(s => s.Customer)  
                   .WithMany(l => l.Transactions)    
                   .HasForeignKey(s => s.CustomerId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<TransactionDetail>()
                 .HasOne(s => s.Transaction)   
                 .WithMany(l => l.TransactionDetails)    
                 .HasForeignKey(s => s.TransactionId)
                 .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<TransactionDetail>()
                 .HasOne(s => s.Product)  
                 .WithMany(l => l.TransactionDetails)   
                 .HasForeignKey(s => s.ProductId)
                 .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<TransactionDetail>()
                 .HasOne(s => s.Store)     
                 .WithMany(l => l.TransactionDetails)
                 .HasForeignKey(s => s.StoreId)
                 .OnDelete(DeleteBehavior.NoAction);

                 


          
        }      


}

}
 