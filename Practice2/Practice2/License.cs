using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    internal class License
    {
        private string keyCode;
        private DateTime initialDate;
        private DateTime expirationDate;
        private bool statius = false;
        private string type = "";

        public License(string type, string initialDate, string expirationDate, string keyCode)
        {
            this.keyCode = keyCode;
            if (type.Equals("A"))
            {
                this.type = "A";
            }
            if (type.Equals("B"))
            {
                this.type = "B";
            }
            if (type.Equals("C"))
            {
                this.type = "C";
            }
            
            this.initialDate = DateTime.Parse(initialDate);
            this.expirationDate = DateTime.Parse(expirationDate);
            this.keyCode = keyCode;

            if (this.expirationDate < DateTime.Today)
            {
                this.statius = false;
            }
            else
            {
                this.statius = true;
            }
        }

        public string getType()
        {
            return type;
        }

        public bool getStatus()
        {
            return statius;
        }
    }
}
