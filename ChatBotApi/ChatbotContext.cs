
using ChatBotApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ChatBotApi
{
    public class ChatbotContext :DbContext
    {
        public ChatbotContext()
            : base("DB_Context")
        {
            Database.SetInitializer<ChatbotContext>(null);//Disable initializer
        }

        public DbSet<ChatBot> ChatBot { get; set; }
        public DbSet<ContactInfromation> ContactInfromation { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}