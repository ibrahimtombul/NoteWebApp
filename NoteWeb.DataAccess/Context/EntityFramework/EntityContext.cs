using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteWeb.DataAccess.Context.EntityFramework
{
    public class EntityContext : DbContext
    {


        public EntityContext(DbContextOptions<EntityContext> options):base(options)
        {

        }
    }
}
