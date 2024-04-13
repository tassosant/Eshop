using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Account
{
    internal abstract class ProfileUserAbstract
    {
        private int _profileId;
        private int _userId;

        public int ProfileId { get { return _profileId; } set { _profileId = value; } }
        public int UserId { get { return _userId;} set { _userId = value; } }
    }
}
