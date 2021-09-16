using System;
using System.Collections;
using  System.Collections.Generic;

namespace SingletonPattern {
    public class LoadBalancer {
        Random rnd = new Random ();
        List<string> servers = new List<string> ();

        static LoadBalancer instance;
        //Lock synchronization object
        static object locker = new object ();

        // Constructor protected
        protected LoadBalancer () {
            servers.Add ("ServerI");
            servers.Add ("ServerII");
            servers.Add ("ServerIII");
            servers.Add ("ServerIV");
            servers.Add ("ServerV");
        }

        public static LoadBalancer GetLoadBalancer () {
            //Support multithreaded applications through
            // 'Double checked locking' pattern which 
            //(once the instance exists)  avoids locking each
            //time the method is invoked 

            if (instance == null) {
                lock (locker) {
                    if (instance == null) {
                        instance = new LoadBalancer ();
                    }
                }
            }

            return instance;
        }

        public string Server {
            get {
                int r = rnd.Next (servers.Count);
                return servers[r].ToString ();
            }
        }
    }
}