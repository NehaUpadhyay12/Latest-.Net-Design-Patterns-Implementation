using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDP
{
    internal class PhysicsSubjectFactory : SubjectFactory
    {
        public override Subject GetSubject()
        {
            return new PhysicsSubject();
        }
    }
}
