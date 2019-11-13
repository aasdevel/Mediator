using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public abstract class AbstractVisitor
    {
        //the current chatroom that the visitor is in (mediator)
        protected AbstractChatroom _currentChatroom = null;

        //the name of the visitor
        protected string _name = null;

        /// <summary>
        /// Send message
        /// </summary>
        /// <param name="message"></param>
        public void Send(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("{0}--->{1}", _name, message);
            _currentChatroom.Send(message, this);
        }

        //receive a message
        public abstract void Receive(string message);

        public void Enter(AbstractChatroom chatroom)
        {
            if (_currentChatroom != null)
            {
                Leave();
            }
            chatroom.Register(this);
            _currentChatroom = chatroom;
        }

        public void Leave()
        {
            if (_currentChatroom != null)
            {
                _currentChatroom.Unregister(this);
                _currentChatroom = null;
            }
        }
    }
}
