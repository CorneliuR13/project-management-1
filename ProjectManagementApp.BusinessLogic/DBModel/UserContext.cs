using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementApp.BusinessLogic.DBModel
{
    class UserContext : DbContext
    {
        public UserContext() :
                base("name=ProjectManagementApp")
            { }
        public virtual DbSet<UDbTable> Users { get; set; }
    }
}
