using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Orleans;

namespace Sample.Interfaces
{
    public interface IUserService : IGrainWithIntegerKey
    {
        Task<string> SayHello(string greeting);
    }
}
