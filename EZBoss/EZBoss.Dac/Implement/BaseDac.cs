using EZBoss.Dac.Interface;
using EZBoss.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZBoss.Dac.Implement
{
    public class BaseDac : IBaseDac
    {
        protected BeABossEntities Context = new BeABossEntities();
    }
}
