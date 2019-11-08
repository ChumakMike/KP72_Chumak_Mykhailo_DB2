using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_databases {
    public class DeleteException : Exception {
        public DeleteException() : base() { }

        public DeleteException(string msg) : base(msg) { }
    }
}
