using Microsoft.EntityFrameworkCore;
using SavingsApp.Models;
using System.Data;



class ShopContext : DbContext // DbContext overriden

{

    // Product entites can be accessed by this context

    public virtual DbSet<Person> Products { get; set; }

    // Shop entities can be accessed by this context

    public virtual DbSet<SavingAccount> Shops { get; set; }


    // OnConfiguring is a hook that executes while the context configures itself

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

    {

        // I add a connection to a database instance while the context configures

        optionsBuilder.UseSqlServer(

            @"Server=LOCALHOST\SQLEXPRESS;Database=Bank;Integrated Security=True");

    }

    
}
