using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDP
{
    internal class SubjectFactory
    {
        public Subject GetSubject(int id)
        {
            if(id==0)
                return new PhysicsSubject();
            else
                return new ChemistrySubject();
        }
    }
}
