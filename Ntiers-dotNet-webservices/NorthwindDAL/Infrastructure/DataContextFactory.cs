using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindDAL;

namespace NorthwindDAL.Infrastructure
{
    static class DataContextFactory
    {
        private static NORTHWNDEntities _northwndEntities;
        public static NORTHWNDEntities NorthwndEntities { get { return _northwndEntities ?? (_northwndEntities = new NORTHWNDEntities()); } }
    }
}
