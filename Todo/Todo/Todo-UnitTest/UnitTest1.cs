using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo;
using System.Collections.Generic;
using ToDoGui;

namespace Todo_UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Entry entry = new Entry();
            string s = entry.Des;
            bool b = entry.Toggle;
            entry.Des = "";
            entry.Toggle = true;
        }
        [TestMethod]
        public void TestMethod2()
        {
            List<Entry> _entries = new List<Entry>();
            Entry e = new Entry();
            e.Des = "";
            e.Toggle = false;
            _entries.Add(e);
            TodoController c = new TodoController(_entries);
        }

        [TestMethod]
        public void TestMethod3()
        {
            List<Entry> _entries = new List<Entry>();
            TodoController c = new TodoController(_entries);
            c.AllEntries();
        }

        [TestMethod]
        public void TestMethod4()
        {
            List<Entry> _entries = new List<Entry>();
            TodoController c = new TodoController(_entries);
            Entry e = new Entry();
            e.Des = "";
            e.Toggle = false;
            _entries.Add(e);
            c.Delete(0);
        }

        [TestMethod]
        public void TestMethod5()
        {
            List<Entry> _entries = new List<Entry>();
            TodoController c = new TodoController(_entries);
            object send = new object();
            EventArgs e= new EventArgs();
            string d="";
            c.AddEntry(send, e, d);
        }
          [TestMethod]
        public void TestMethod6()
        {
            List<Entry> _entries = new List<Entry>();
            TodoController c = new TodoController(_entries);
            c.NumberofActive();
            c.TotalNumber();
        }

          [TestMethod]
          public void TestMethod7()
          {
              List<Entry> _entries = new List<Entry>();
              TodoController c = new TodoController(_entries);
                 Entry e = new Entry();
                e.Des = "";
                e.Toggle = false;
                _entries.Add(e);
                c.Update("a", 0);
          }
          [TestMethod]
          public void TestMethod8()
          {
              List<Entry> _entries = new List<Entry>();
              TodoController c = new TodoController(_entries);
              Entry e = new Entry();
              e.Des = "";
              e.Toggle = false;
              _entries.Add(e);
              c.SetToggle(0, true);
             c.ReturnToggle(0);
             c.ReturnDes(0);
          }

          [TestMethod]
          public void TestMethod9()
          {
              List<Entry> _entries = new List<Entry>();
              TodoController c = new TodoController(_entries);
              Entry e = new Entry();
              e.Des = "";
              e.Toggle = false;
              _entries.Add(e);
              c.SetNumberOfActive("+");
              c.SetNumberOfActive("-");
          }

          [TestMethod]
          public void TestMethod10()
          {
              List<Entry> _entries = new List<Entry>();
              List<Entry> entries = new List<Entry>();
              TodoController c = new TodoController(entries);
              Entry e = new Entry();
              e.Des = "";
              e.Toggle = true;
              _entries.Add(e);
              c.UpdateController(_entries);
          }

    }
}
