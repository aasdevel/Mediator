using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class Chatroom : AbstractChatroom
    {
        public override void Register(AbstractVisitor visitor)
        {
            _activeVisitors.Add(visitor);
        }

        public override void Send(string message, AbstractVisitor sender)
        {
            foreach(var visitor in _activeVisitors)
            {
                if (visitor != sender)
                {
                    visitor.Receive(message);
                }    
            }
        }

        public override void Unregister(AbstractVisitor visitor)
        {
            _activeVisitors.Remove(visitor);
        }
    }
}
