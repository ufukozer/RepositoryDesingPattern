using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication5.Controllers
{
    public class RepositoryController : Controller
    {
        private IRepository _repository;
        public RepositoryController(IRepository repository)
        {
            //Kapsülleme incapsulation
            _repository = repository;
        }
        public IActionResult Update()
        {
            _repository.Update();
            return null;
        }
        public IActionResult Insert()
        {
            //Dependecy Injection
            _repository.Insert();
            return null;
        }
    }
}