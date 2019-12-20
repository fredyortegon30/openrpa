﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenRPA.Script.Activities
{
    // https://mail.python.org/pipermail/pythondotnet/2016-May/001776.html
    public class PythonOutput
    {
        private TextWriter myWriter = null;
        // ctor
        public PythonOutput(TextWriter writer)
        {
            myWriter = writer;
        }
        public PythonOutput()
        {
        }
        public void write(string str)
        {
            str = str.Replace("\n", Environment.NewLine);
            if (myWriter != null)
            {
                myWriter.Write(str);
            }
            else
            {
                Console.Write(str);
            }
        }
        public void writelines(string[] str)
        {
            foreach (string line in str)
            {
                if (myWriter != null)
                {
                    myWriter.Write(str);
                }
                else
                {
                    Console.Write(str);
                }
            }
        }
        public void flush()
        {
            if (myWriter != null)
            {
                myWriter.Flush();
            }
        }
        public void close()
        {
            if (myWriter != null)
            {
                myWriter.Close();
            }
        }
    }
}
