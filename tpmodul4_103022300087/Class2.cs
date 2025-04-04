﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_103022300087
{
    class DoorMachine
    {
        private enum State { Terkunci, Terbuka }
        private State currentState;

        public DoorMachine()
        {
            currentState = State.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }

        public void BukaPintu()
        {
            if (currentState == State.Terkunci)
            {
                currentState = State.Terbuka;
                Console.WriteLine("Pintu tidak terkunci");
            }
            else
            {
                Console.WriteLine("Pintu sudah terbuka");
            }
        }

        public void KunciPintu()
        {
            if (currentState == State.Terbuka)
            {
                currentState = State.Terkunci;
                Console.WriteLine("Pintu terkunci");
            }
            else
            {
                Console.WriteLine("Pintu sudah terkunci");
            }
        }
    }

    class DoorMachineApp
    {
        static void Main()
        {
            Console.WriteLine("=== Simulasi Pintu ===");
            DoorMachine door = new DoorMachine();

            while (true)
            {
                Console.Write("\nPerintah (buka/kunci/keluar): ");
                string command = Console.ReadLine().ToLower();

                if (command == "buka")
                {
                    door.BukaPintu();
                }
                else if (command == "kunci")
                {
                    door.KunciPintu();
                }
                else if (command == "keluar")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Perintah tidak dikenali!");
                }
            }

            Console.WriteLine("Program selesai.");
        }
    }
}
