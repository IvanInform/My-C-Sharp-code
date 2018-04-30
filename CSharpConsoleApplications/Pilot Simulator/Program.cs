using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilotSimulator
{
    public delegate void Fly();
    class Program
    {
        class Plane {
           public List<dispetcher> dispetchers = null;
           public int plane_rating { get; set; }
            public int height { get; set; }
            public int speed { get; set; }
            public int altitude { get; set; }
            public bool speedup { get; set; }
            public string picture { get; set; }
            public Plane(string name1,string name2) {
                dispetchers=new List<dispetcher>();
                this.dispetchers.Add(new dispetcher(name1));
                this.dispetchers.Add(new dispetcher(name2));
                this.speed = 0;
                this.altitude = 0;
                this.speedup = false;
                plane_rating = 100;
            }
            
            public void fly_right(){
                if (this.speedup)
                {
                    this.speed += 150;
                }
                else
                {
                    this.speed += 50;

                }
            }
            public void fly_left()
            {
                if (this.speedup)
                {
                    this.speed -= 150;
                }
                else
                {
                    this.speed -= 50;

                }
            }
            public void fly_up()
            {
                if (this.speedup)
                {
                    this.altitude+= 500;
                }
                else
                {
                    this.altitude += 250;

                }
            }
            public void fly_down()
            {
                if (this.speedup)
                {
                    this.altitude -= 500;
                }
                else
                {
                    this.altitude -= 250;

                }
            }
        }
        
        class dispetcher{
            public Fly MadeMovement ;
            public string Name { get; set; }
            public int correction;
            public int myaltitude;
            public dispetcher(string name) {
                this.Name = name;
               
            }
           
            public void check() {
                if (MadeMovement != null) {
                    MadeMovement();
                }
            
            
            }
            
            public void Show_Message()
            {
              int correction=rand.Next(-200,200);
               int altitude = 7 * globalSpeed - correction;
               globalAltitude = altitude;
               Console.WriteLine("Рекомендуемая корректировка высоты: {0}",altitude);
            }
        
        }
        public static int globalAltitude=0;
        public static int globalSpeed;
        public static Random rand;
        static void Main(string[] args)
        {
            Console.WriteLine("Это симулятор. Тренируйтесь: нажмите up-взлететь\n" +
                "Нажмите down-опуститься, нажмите left-влево, нажмите right--право");
            Console.WriteLine("Если нажать shift скорость увеличивается");
            ConsoleKeyInfo cki;
            Console.WriteLine("Введите имена диспетчеров");
            string name1, name2;
            name1= Console.ReadLine();
            name2 = Console.ReadLine();
            rand=new Random();
            Plane plane = new Plane(name1, name2);
            globalSpeed = plane.speed;
            Console.WriteLine("скорость:{0} высота: {1}", plane.speed, plane.altitude);
            do 
            {
                cki = Console.ReadKey();
                Console.WriteLine("{0}", cki.KeyChar);
                if ((cki.Modifiers & ConsoleModifiers.Shift) != 0)
                {
                    plane.speedup = true;
                    Console.WriteLine("Ускорение включено");
                }
                else {
                    plane.speedup = false;
                }
                 switch (cki.Key) {
                        case ConsoleKey.LeftArrow:
                         
                            plane.fly_left();
                            globalSpeed = plane.speed;
                            foreach (dispetcher dis in plane.dispetchers) {
                                dis.MadeMovement = new Fly(dis.Show_Message);
                                dis.check();
                            }
                            break;
                        case ConsoleKey.UpArrow:
                            
                            plane.fly_up();
                          
                           
                            break;
                        case ConsoleKey.DownArrow:
                            plane.fly_down();
                            break;
                        case ConsoleKey.RightArrow:
                            plane.fly_right();
                            globalSpeed = plane.speed;
                            foreach (dispetcher dis in plane.dispetchers) {
                                dis.MadeMovement = new Fly(dis.Show_Message);
                                dis.check();
                            }
                            break;
                    }


                 Console.WriteLine("скорость:{0} высота: {1}", plane.speed, plane.altitude);
                 if (globalAltitude < plane.altitude && (plane.altitude - Math.Abs(globalAltitude)) > 300 &&
                     (plane.altitude - Math.Abs(globalAltitude)) < 600) {
                         plane.plane_rating -= 25 ;
                         Console.WriteLine("Рэйтинг самолета: ", plane.plane_rating);
                     }
                 if (globalAltitude < plane.altitude && (plane.altitude - Math.Abs(globalAltitude)) > 600 &&
                     (plane.altitude - Math.Abs(globalAltitude)) < 1000)
                 {
                     plane.plane_rating -= 50;
                     Console.WriteLine("Рэйтинг самолета: ", plane.plane_rating);
                 }
                 if ((plane.altitude - globalAltitude) > 1000) {
                     Console.WriteLine("Самолет разбился");
                     break;
                 }

            }while (cki.Key!= ConsoleKey.Escape);

            Console.ReadKey();

        }
    }
}
