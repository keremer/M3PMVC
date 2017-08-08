using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Web.Security;
using M3PMVC.RootModels;
using M3PMVC.ProductModels;
using M3PMVC.ProcessModels;
using M3PMVC.BusinessModels;
using M3PMVC.PartyModels;


namespace M3PMVC.Models

/// <summary>
/// Data Access Layer (DAL)
/// Wrapper for SaveChanges adding the Validation Messages to the generated exception
/// BR: Stands for "Business Rule"
/// </summary>
/// <param name="context">The context.</param>
/// 
{
    //    Accounts

    //public class UsersContext : DbContext
    //{
    //    public UsersContext()
    //        : base("DefaultConnection")
    //    {
    //    }

    //    public DbSet<UserProfile> UserProfiles { get; set; }
    //}

    //    Parties

    public class PartyDBContext : DbContext
    {
        // ifc based classes
        
        public DbSet<M3PProject> BIMProjects { get; set; }
        public DbSet<M3PCostItems> BIMEntity { get; set; }
        public DbSet<M3PPartyReal> PReals { get; set; }
        public DbSet<M3PPartyLegal> PLegals { get; set; }
        public DbSet<PartyPostalAdress> PAdresses { get; set; }
        //public DbSet<IfcClassificationMetabase> CSystems { get; set; }

        // classification classes
        //public DbSet<ClassificationItem> CEntities { get; set; }
        //public DbSet<ClassificationMetabaseOntology> CMappings { get; set; }

        // ciq classes
        public DbSet<PartyEmploymentDetails> PEmployments { get; set; }
        public DbSet<PartyPassport> PPassports { get; set; }
        public DbSet<PartyVisa> PVisas { get; set; }
        public DbSet<PartyPhone> PPhones { get; set; }
        public DbSet<PartyeMail> PMails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            // PARTY MODELS

            modelBuilder.Entity<PartyVisa>()
                        .HasRequired(a => a.partyPassport)
                        .WithMany()
                        .HasForeignKey(u => u.CiqPartyPasno);

            modelBuilder.Entity<PartyVisa>()
                        .HasRequired(a => a.partyReal)
                        .WithMany()
                        .HasForeignKey(u => u.CiqPrID).WillCascadeOnDelete(false);

            modelBuilder.Entity<PartyPassport>()
                        .HasRequired(a => a.partyReal)
                        .WithMany()
                        .HasForeignKey(u => u.CiqPrID);

            modelBuilder.Entity<PartyeMail>()
                        .HasRequired(m => m.emailOwner)
                        .WithMany()
                        .HasForeignKey(k => k.CiqPrID);

            // Many to Many Employment (BR: a party may have more than one job and a company may have a lot of employees)
            modelBuilder.Entity<M3PPartyReal>()
                        .HasMany(t => t.partyEmployment)
                        .WithMany(t => t.humanResources)
                        .Map(t => t.MapLeftKey("CiqPartyTuzelID")
                            .MapRightKey("CiqPrID")
                            .ToTable("partyAffiliation"));

            // Many to Many Adresses (BR: a party may have more than one address and an adress may be owned by more than one party)
            modelBuilder.Entity<M3PPartyReal>()
                        .HasMany(a => a.partyAdresses)
                        .WithMany(a => a.adresOwners)
                        .Map(a => a.MapLeftKey("ciqAdresPID")
                            .MapRightKey("CiqPrID")
                            .ToTable("partyAdresses"));

            // Many to Many Phones (BR: a party may have more than one phone number and a phone number may be owned by more than one party) 
            // (i.e. employees sharing a room and a phone, or employee changes job and his phone is assigned to a new employee)
            modelBuilder.Entity<M3PPartyReal>()
                        .HasMany(p => p.partyPhones)
                        .WithMany(p => p.phoneOwners)
                        .Map(p => p.MapLeftKey("CiqPhonePID")
                            .MapRightKey("CiqPrID")
                            .ToTable("partyPhoneNumbers"));

            // PRODUCT MODELS
            
            // Many to Many Materials 
            // (A specific material may be available from many suppliers. 
            // And a supplier may sell many materials)


            //modelBuilder.Entity<M3PCostItems>()
            //    .HasMany(s => s.suppliers)
            //    .WithMany(s => s.servemats)
            //    .Map(s => s.MapLeftKey("mkID")
            //        .MapRightKey("CiqPrID")
            //        .ToTable("M3PmaterialRepository"));
                
        }
    }
}
       
    /// private void SaveChanges(DbContext context) {
    ///  try {
    ///      context.SaveChanges();
    ///  } catch (DbEntityValidationException ex) {
    ///      StringBuilder sb = new StringBuilder();
    /// 
    ///      foreach (var failure in ex.EntityValidationErrors) {
    ///         sb.AppendFormat("{0} failed validation\n", failure.Entry.Entity.GetType());
    ///          foreach (var error in failure.ValidationErrors) {
    ///              sb.AppendFormat("- {0} : {1}", error.PropertyName, error.ErrorMessage);
    ///              sb.AppendLine();
    ///          }
    ///      }
    /// 
    ///      throw new DbEntityValidationException(
    ///          "Entity Validation Failed - errors follow:\n" + 
    ///          sb.ToString(), ex
    ///      ); // Add the original exception as the innerException
    ///  }

