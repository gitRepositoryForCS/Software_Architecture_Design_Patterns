using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Multi_Threaded_B
{
    // a controller for a sequential text file:
    // allows a thread to read or write the file
    public class FileController
    {
        private File thefile;  // the file controlled by this controller

        private Status state = Status.Closed;
        private Object ob;

        public FileController(File f) { thefile = f; }

        // opens the file for read use; returns handle to file.  
        // If file cannot be opened, returns null.
        public Reader openRead(Object obj)
        {
             lock (this)
                {
                    if (this == obj)
                    {
                         Reader r = null;
                         if (state == Status.Closed)
                         {
                             thefile.initRead(ob);
                             r = thefile;
                             state = Status.Reading;
                         }
                         return r;
                     } 
                    else  return null;
                }
            
           
        }

        // opens the file for write use; returns handle to file.  
        //   If file cannot be opened, returns null.
        public Writer openWrite(Object obj)
        {
            lock (this)
            {
                if (this == obj)
                {
                     Writer w = null;
                        if (state == Status.Closed)
                        {
                            thefile.initWrite(ob);
                            w = thefile;
                            state = Status.Writing;
                        }
                        return w;
                    }
                return null;
            }
        }

        // closes file
        public void close(Object ob)
        {
            lock (this)
            {
                if(this == ob)
                {
                    state = Status.Closed;
                }
            }
        }
    }
}
