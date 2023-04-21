using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDP
{
    internal class ChemistrySubjectFactory : SubjectFactory
    {
        public override Subject GetSubject()
        {
            return new ChemistrySubject();
        }
    }
}
