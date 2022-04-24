using System;
using System.Collections;
using System.Collections.Generic;


namespace DontTellAskPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Client c =new Client();
            c.AlertService(new List<CpuMonitor>{
                new CpuMonitor(10,d=>{Console.WriteLine("10 luk");}
                ){ Value=50},
                new CpuMonitor(1000,c=>{Console.WriteLine("1000 lij");}){Value=90}
            });
            
            Console.ReadLine();
        }
    }


  /*  public class CpuMonitor{
           public int Value{get;set;}
    }
    public class Client{
        public void AlertService(List<CpuMonitor> cpuMonitors){
           foreach(var cpuMonitor in cpuMonitors){
               if(cpuMonitor.Value>90){
                   // alert
               }
           }
        }
    }*/
    //Refactored

    /*public class CpuMonitor{
        private readonly int _alertThreshold;
        public CpuMonitor(int alertThreshold){
            _alertThreshold=alertThreshold;
        }

        public int Value{get;set;}
        public bool ExceedsThreshold{
            get{
                return Value>= _alertThreshold;
            }
        }
    
    }

    public class Client{
        public void AlertService(List<CpuMonitor> cpuMonitors){
            foreach(var cpuMonitor in cpuMonitors){
                if(cpuMonitor.ExceedsThreshold){
                    Console.WriteLine($"{cpuMonitor.Value}");
                }
            }
        }
    }*/

    //Refactor 2
    public class CpuMonitor{
        private readonly int _alertThreshold;
        private readonly Action<CpuMonitor> _alertAction;

        public CpuMonitor(int alertThreShold,Action<CpuMonitor> alertAction){
            _alertThreshold=alertThreShold;
            _alertAction=alertAction;
        }

        public int Value{get;set;}

        public bool ExceedsThreshold{get{
            return Value>=_alertThreshold;
        }}

        public void Sample(){
            if(ExceedsThreshold){
                _alertAction(this);
            }
        }       

    }

    public class Client{
        public void AlertService(List<CpuMonitor> cpuMonitors){
            foreach(var cpuMonitor in cpuMonitors){
                cpuMonitor.Sample();
            }
        }
    }
}
