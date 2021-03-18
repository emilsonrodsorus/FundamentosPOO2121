using ManagerEscuela.Models.PadreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerEscuela.Interface
{
    public interface IFilter
    {
        bool Filter(Persona persona, string parameter);
    }
}
