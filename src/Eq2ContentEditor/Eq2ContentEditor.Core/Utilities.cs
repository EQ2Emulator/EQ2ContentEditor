using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eq2ContentEditor.Core
{
    public class Utilities
    {
        public int CalcSpellBuffValue(int level, int potency)
        {
            var result = level * potency;
            //if (result > 100)
            //{
            //    result = 100;
            //}

            return result;
        }
    }
}
