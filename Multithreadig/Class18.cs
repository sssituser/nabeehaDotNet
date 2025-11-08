using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace DotNet6pmto7pm
{ 

    class Game
    {
        string name;
       public Game(string name) { 
        this.name =name;
        }
        public void Player()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{name} is Playing {i} Time");
                Thread.Sleep(1000);
            }
        }
        
    }
    internal class Class18
    {
        static void Main(string[] args)
        {
            Game p1 = new Game("kiran");
            Thread th1 = new Thread(p1.Player);  // un Started state
           
            Game p2 = new Game("Raj");
            Thread th2 = new Thread(p2.Player);
            th1.Name = "Kiran";
            th2.Name = "Raj"; // settig the name

            th1.Priority = ThreadPriority.Lowest;
            th2.Priority = ThreadPriority.Highest;


            Console.WriteLine($"First Thread Name : {th1.Name}");
            Console.WriteLine($"Second Thread Name : {th2.Name}");  //Getting name

            th1.Start();     // ready state
            th1.Join(5000);  // non runable state.

            th2.Start(); //Ready state
           

        }
    }
}
