using MvcCoreAWSExam1.Data;
using MvcCoreAWSExam1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreAWSExam1.Repositories
{
    public class RepositoryCoches
    {
        CochesContext context;

        public RepositoryCoches(CochesContext context) { this.context = context; }

        public List<Coche> GetCoches()
        {
            return this.context.Coches.ToList();
        }

        public Coche SearchCar(int id)
        {
            return this.context.Coches
                .SingleOrDefault(x => x.id == id);
        }
    }
}
