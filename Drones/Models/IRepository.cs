using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drones.Models
{
    public interface IRepository
    {
        List<Dron> Drons();
    }
}
