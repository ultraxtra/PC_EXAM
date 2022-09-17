using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;
using System.Xml;
using static Configurator.PC;
using System.Collections;


namespace Configurator
{
    internal class PC
    {





        //public string? MB { get; set; }
        //public string? RAM { get; set; }
        //public string? GPU { get; set; }
        //public string? HD { get; set; }
        //public string? PSU { get; set; }
        //public string? Body { get; set; }

        // public PC(string? cpu, string? mb, string? ram, string ? gpu, string ? hd, string ? psu, string ? body)
        // {
        //     this.CPU = cpu;
        //     this.MB = mb;
        //     this.RAM = ram;
        //     this.GPU = gpu;
        //     this.HD = hd;
        //     this.PSU = psu;
        //     this.Body = body;
        // }
        public void CreatePC()
        {

            Dictionary<int, string> CPU = new Dictionary<int, string>();

            var CPUS = new Dictionary<int, string>
            {
                [1] = "Intel® CoreTMi5-9400",
                [2] = "Intel@ CoreTMi5-9400F",
                [3] = "Intel® CoreTMi5-9500F" ,
                [4] =  "Intel® CoreTMi5-9600K",
                [5] = "Intel@ CoreTMi5-9600KF"
            };

            foreach (var CPu in CPUS)
            {
                Console.WriteLine($"key: {CPu.Key}  value: {CPu.Value}");
            }

            Write("Choose CPU:\t");

            int cpu = Convert.ToInt32(ReadLine());

            if(cpu == 1)
            {
                WriteLine($"{CPUS[1]}\n");
            }
            else if(cpu == 2)
            {
                WriteLine($"{CPUS[2]}\n");

            }
            else if (cpu == 3)
            {
                WriteLine($"{CPUS[3]}\n");

            }
            else if (cpu == 4)
            {
                WriteLine($"{CPUS[4]}\n");

            }
            else if (cpu == 5)
            {
                WriteLine($"{CPUS[5]}\n");

            }

            Dictionary<int, string> MB = new Dictionary<int, string>();

            var MBS = new Dictionary<int, string>
            {
        
            [1] =  "GIGABYTE GA-A320M-H",
            [2] ="ASRock H310CM-DVS"  ,
            [3] = "GIGABYTE H310M S2H" ,
            [4] = "ASUS PRIME B360M-K" ,
            [5] = "MSI A520M PRO-VH"
        };

            foreach (var mB in MBS)
            {
                Console.WriteLine($"key: {mB.Key}  value: {mB.Value}");
            }

            WriteLine("Choose MB:");

            int mb = Convert.ToInt32(ReadLine());

            if (mb == 1)
            {
                WriteLine($"{MBS[1]}\n");
            }
            else if (mb == 2)
            {
                WriteLine($"{MBS[2]}\n");

            }
            else if (mb == 3)
            {
                WriteLine($"{MBS[3]}\n");

            }
            else if (mb == 4)
            {
                WriteLine($"{MBS[4]}\n");

            }
            else if (mb == 5)
            {
                WriteLine($"{MBS[5]}\n");

            }

            Dictionary<int, string> GPU = new Dictionary<int, string>();

            var GPUS = new Dictionary<int, string>
              {
                  [1] =  "GeForce GTX 1660 6GB",
                  [2] = "GeForce GTX 1070Ti 8GB"  ,
                  [3] = "Radeon RX 580 8GB " ,
                  [4] = "GeForce RTX 2080Ti 8GB" ,
                  [5] = "GeForce GTX 1080Ti 8GB"
              };
            
                  foreach (var gPU in GPUS)
                  {
                Console.WriteLine($"key: {gPU.Key}  value: {gPU.Value}");
            }

            WriteLine("Choose GPU:");
            
            int gpu = Convert.ToInt32(ReadLine());


            if (gpu == 1)
            {
                WriteLine($"{GPUS[1]}\n");
            }
            else if (gpu == 2)
            {
                WriteLine($"{GPUS[2]}\n");

            }
            else if (gpu == 3)
            {
                WriteLine($"{GPUS[3]}\n");

            }
            else if (gpu == 4)
            {
                WriteLine($"{GPUS[4]}\n");

            }
            else if (gpu == 5)
            {
                WriteLine($"{GPUS[5]}\n");

            }

            Dictionary<int, string> RAM = new Dictionary<int, string>();


            var RAMS = new Dictionary<int, string>
              {
                 [1]  = "CORSAIR VENGEANCE LED",
                 [2] ="G. SKILL TRIDENT Z RGB"  ,
                 [3] ="KINGSTON HYPERX PREDATOR " ,
                 [4] ="KINGSTON HYPERX FURY" ,
                 [5] ="CORSAIR DOMINATOR PLATINUM RGB"
              };
            foreach (var rAM in RAMS)
            {
                Console.WriteLine($"key: {rAM.Key}  value: {rAM.Value}");
            }

            WriteLine("Choose RAM:");

            int ram = Convert.ToInt32(ReadLine());


            if (ram == 1)
            {
                WriteLine($"{RAMS[1]}\n");
            }
            else if (ram == 2)
            {
                WriteLine($"{RAMS[2]}\n");

            }
            else if (ram == 3)
            {
                WriteLine($"{RAMS[3]}\n");

            }
            else if (ram == 4)
            {
                WriteLine($"{RAMS[4]}\n");

            }
            else if (ram == 5)
            {
                WriteLine($"{RAMS[5]}\n");

            }

            Dictionary<int, string> HD = new Dictionary<int, string>();


            var HDS = new Dictionary<int, string>
            { 
                   [1] = "128GB",
                   [2] = "256GB",
                   [3] = "512GB ",
                   [4] = "1TB" ,
                   [5] = "2TB"
              };

            foreach (var hD in HDS)
            {
                Console.WriteLine($"key: {hD.Key}  value: {hD.Value}");
            }


            WriteLine("Choose HD:");

            int hd = Convert.ToInt32(ReadLine());


            if (hd == 1)
            {
                WriteLine($"{HDS[1]}\n");
            }
            else if (hd == 2)
            {
                WriteLine($"{HDS[2]}\n");

            }
            else if (hd == 3)
            {
                WriteLine($"{HDS[3]}\n");

            }
            else if (hd == 4)
            {
                WriteLine($"{HDS[4]}\n");

            }
            else if (hd == 5)
            {
                WriteLine($"{HDS[5]}\n");

            }



            Dictionary<int, string> PSU = new Dictionary<int, string>();


            var PSUS = new Dictionary<int, string>
            {
                [1] = "500W",
                [2] = "550W",
                [3] = "600W ",
                [4] = "650W",
                [5] = "700W"
            };

            foreach (var pSU in PSUS)
            {
                Console.WriteLine($"key: {pSU.Key}  value: {pSU.Value}");
            }


            WriteLine("Choose PSU:");

            int psu = Convert.ToInt32(ReadLine());

           

            if (psu == 1)
            {
                WriteLine($"{PSUS[1]}\n");
            }
            else if (psu == 2)
            {
                WriteLine($"{PSUS[2]}\n");
            
            }
            else if (psu == 3)
            {
                WriteLine($"{PSUS[3]}\n");
            
            }
            else if (psu == 4)
            {
                WriteLine($"{PSUS[4]}\n");
            
            }
            else if (psu == 5)
            {
                WriteLine($"{PSUS[5]}\n");
            
            }


            WriteLine("Go to orders press 1");
            WriteLine("Exit press 2");

            int chose = Convert.ToInt32(ReadLine());

            if(chose == 1)
            {
                WriteLine($"Your order is: {CPUS[cpu]}\t {MBS[mb]}\t {GPUS[gpu]}\t {RAMS[ram]}\t {HDS[hd]}\t {PSUS[psu]}\t");
            }

            if(chose == 2)
            {
                WriteLine("GoodBye!");
                return;
            }

        }




        public void PCs()
        {
            string line;
            try
            {
                StreamReader sr = new StreamReader("/Users/artemmlnchk/Desktop/component копія.txt");
                line = sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        public void Components()
        {
            string line;
            try
            {
                StreamReader sr = new StreamReader("/Users/artemmlnchk/Desktop/component.txt");
                line = sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }


        }

        
        public void Order()
        {
            WriteLine("There is not any orders!");
        }
    }
}


