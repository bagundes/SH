using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mind.Models
{
    public interface IBaseViewModel<T> where T : BaseViewModel
    {

    }

    public class BaseViewModel
    {
       

    }
}
