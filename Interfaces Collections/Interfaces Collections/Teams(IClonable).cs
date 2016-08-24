using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces_Collections
{
    class Team:ICloneable
    {
        public string TeamName { get; set; }
        public int Guc { get; set; }

        public Team()
        {
            this.TeamName = "BEŞİKTAŞ";
            this.Guc = 90;
        }

        public Team(string team,int guc)
        {
            this.TeamName = team;
            this.Guc = guc;
        }

        public override string ToString()
        {
            return TeamName+"  :"+Guc;
        }

        public object Clone()
        {
            //return new Team(this.TeamName, this.Guc);
            return this.MemberwiseClone();//reference types doesn't copy
        }
    }
}
