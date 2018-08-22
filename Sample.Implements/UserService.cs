using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Orleans;
using Sample.Interfaces;

namespace Sample.Implements
{
    public class UserService : Grain, IUserService
    {
        public Task<string> SayHello(string greeting)
        {
            return Task.FromResult($"You said:{greeting},I say:Hello!");
        }
    }
}
