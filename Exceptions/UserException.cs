using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Bank.Exceptions {
    public class UserException : Exception {
        public UserException() {
        }
        public UserException(String message) : base(message) {

        }
    }
}
