using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5
{
    //Başında bir I yoksa bu bir abstracttır. Yoksa diğerini tüketir.
    public class Repository : IRepository
    {
        private ProjectContext _projectContext;
        //Constractorda veritabanının gelmesi lazım bana. Yine aşağıdaki satırda dependency yapılacak.
        public Repository(ProjectContext projectContext)
        {
            _projectContext = projectContext;
        }
        public void Insert()
        {
            
        }
        public void Update()
        {
            
        }
    }
}
