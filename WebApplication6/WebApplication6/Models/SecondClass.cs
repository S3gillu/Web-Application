using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication6.Models;

namespace WebApplication6.Models
{
    public class SecondClass
    {
        private readonly NewCustomer entities = new NewCustomer();

    }
    public IEnumerable<state> GetStateList()
    {
        return entities.state.ToList();
    }

}