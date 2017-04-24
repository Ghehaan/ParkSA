using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParkSACore
{
    class GetStoredProcedureNameAttribute : Attribute
    {
        internal GetStoredProcedureNameAttribute(string name)
        {
            this.Name = name;
        }
        public string Name { get; private set; }
    }

    class UpdateStoredProcedureNameAttribute : Attribute
    {
        internal UpdateStoredProcedureNameAttribute(string name)
        {
            this.Name = name;
        }
        public string Name { get; private set; }
    }

    class InsertStoredProcedureNameAttribute : Attribute
    {
        internal InsertStoredProcedureNameAttribute(string name)
        {
            this.Name = name;
        }
        public string Name { get; private set; }
    }

    class DeleteStoredProcedureNameAttribute : Attribute
    {
        internal DeleteStoredProcedureNameAttribute(string name)
        {
            this.Name = name;
        }
        public string Name { get; private set; }
    }
}
