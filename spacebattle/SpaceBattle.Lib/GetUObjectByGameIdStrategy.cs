using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceBattle.Lib
{
    public class GetUObjectByGameIdStrategy : IStrategy
    {
        public object Invoke(object[] args)
        {
            var objectId = (int)args[0];

            var uobject = IoC.Resolve<IDictionary<int, IUObject>>("Game.UObject.Dict")[objectId];
            return uobject;
        }
    }
}
