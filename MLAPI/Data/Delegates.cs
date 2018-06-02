using MLAPI.NetworkingManagerComponents.Binary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MLAPI.Data
{
    public static class Delegates
    {
        public delegate void ReplyDelegate(uint clientId, BitReader reader);
        public delegate void ReplyFailureDelegate(uint clientId);
    }
}
