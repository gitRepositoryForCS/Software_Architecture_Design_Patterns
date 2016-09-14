﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Multi_Threaded_B
{

    // models a simple text file that can be read or written one line at a time.
    // It implements both interfaces Reader and Writer, depending on how it's used.
    public class File : Reader, Writer
    {

        private List<string> lines;  // the "file" is a list of strings
        private int count;   // counts the lines read while reading/writing the file
        private Object ob;
        public File() { lines = new List<string>(); }

        // initializes the file for reading its lines one by one:
        public void initRead(Object ob) { count = 0; this.ob = ob; }

        // initializes the file for writing fresh lines to it.  Erases existing contents.
        public void initWrite(Object ob) { lines = new List<string>(); count = 0; this.ob = ob; }

        // reads and returns the next line of the file (or returns null if no more lines):
        public string readLine(Object ob)
        {
            string line = null;
            if (count < lines.Count)
            {
                line = lines[count]; count++;
            }
            return line;
        }

        // writes a new line to the end of the file:
        public void writeLine(string s, Object ob)
        {
            lines.Add(s); count++;
        }
    }
}
