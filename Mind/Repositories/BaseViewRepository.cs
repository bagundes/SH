using Mind.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Mind.Repositories
{

    public interface IBaseViewRepository<T> where T : BaseViewModel
    {

    }
   

    public class BaseViewRepository<T> where T : BaseViewModel
    {

        public BaseViewRepository()
        {

        }
    }
}
