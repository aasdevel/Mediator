using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public abstract class AbstractChatroom
    {
        //current visitors list
        protected List<AbstractVisitor> _activeVisitors = new List<AbstractVisitor>();

        /// <summary>
        /// Send message
        /// </summary>
        /// <param name="message"></param>
        /// <param name="sender"></param>
        public abstract void Send(string message, AbstractVisitor sender);

        /// <summary>
        /// Register the visitor
        /// </summary>
        /// <param name="visitor"></param>
        public abstract void Register(AbstractVisitor visitor);

        /// <summary>
        /// Unregister the visitor
        /// </summary>
        /// <param name="visitor"></param>
        public abstract void Unregister(AbstractVisitor visitor);
    }
}
