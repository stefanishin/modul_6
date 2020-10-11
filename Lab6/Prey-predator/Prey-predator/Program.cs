using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prey_predator
{
    public interface IPredator
    {
        void WriteAttack();
    }
    public interface IPrey
    {

    }
    class IAnimal : IPredator
    {
     
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
