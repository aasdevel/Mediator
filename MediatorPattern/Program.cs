using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //visitros
            var ani = new Visitor("Ani");
            var van = new Visitor("Van");
            var inessa = new Visitor("Inessa");

            //all visitors join the chatroom
            var chatroom = new Chatroom();
            ani.Enter(chatroom);
            van.Enter(chatroom);
            inessa.Enter(chatroom);

            ani.Send("Hello everyone");

            van.Send("Welcome to the chatroom ani");

            inessa.Send("Hi ani, nice to meet you");


            Console.ReadLine();
        }
    }
}
