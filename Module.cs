using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone_2_PRG252_Group_Project
{
    class Module
    {
        private string code, sname, description;

        public string Code { get => code; set => code = value; }
        public string SName { get => sname; set => sname = value; }
        public string Description { get => description; set => description = value; }

        public Module()
        {
            
        }

        public Module(string code, string name, string description)
        {
            this.Code = code;
            this.SName = name;
            this.Description = description;
        }
    }
}
