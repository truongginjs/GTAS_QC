using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QCService.Helpers.Enums
{
    public enum ActiveType
    {
        Unknown,
        Find,
        Get,
        AddOrUpdate,
        Delete,
        Save,
        Approve,
        Transfer
    }
}
