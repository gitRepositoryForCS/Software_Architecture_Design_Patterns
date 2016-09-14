using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo;
using Newtonsoft.Json;

namespace ToDoGui
{
    public class TodoController
    {
       // private List<Observer> _observers = new List<Observer>();
        private List<Entry> _entries;
        private int _numberOfActive = 0;
      // public delegate void UpdateController(List<Entry> list);

        public TodoController(List<Entry> entry)
        {
            this._entries = entry;
            for(int i =0; i<entry.Count;i++)
            {
                if(entry[i].Toggle==false)
                {
                    _numberOfActive++;
                } 
            }   
        }
        public List<Entry> AllEntries()
        {
            return _entries;
        }

        public void Delete(int index)
        {
          //  if (_entries[index].Toggle == true)
          //     { _numberOfActive--;}
            _entries.RemoveAt(index);   
        }

        public void AddEntry(object sender, EventArgs e,string des)
        {
            Entry entry = new Entry();
            entry.Des = des;
            entry.Toggle = true;
            _entries.Add(entry);
            _numberOfActive++;
        }

        public int NumberofActive()  {return _numberOfActive; }

        public int TotalNumber() { return _entries.Count; }

        public void Update(string des, int index) 
        {
                _entries[index].Des = des;
            }

        public void SetToggle(int index, bool b)  { _entries[index].Toggle = b; }
        public bool ReturnToggle(int index)   { return _entries[index].Toggle; }
        public string ReturnDes(int index) { return _entries[index].Des; }

        public void SetNumberOfActive(string plusOrMinus) 
        {
            if (plusOrMinus == "+") { _numberOfActive++; }
            if (plusOrMinus == "-") { _numberOfActive--; }
        }

      /*  public void LoadEntries(string content)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                ContractResolver = new CustomJsonContractResolver(),
                PreserveReferencesHandling = PreserveReferencesHandling.Objects
            };

            //_entries = entries;
        }*/
      //  public List<Entry> ReturnEntry()  { return _entries; }
      //  public void register(Observer o)  {_observers.Add(o);}
       // public void SignalObserver() {foreach (Observer o in _observers) { o(); } }

        public void UpdateController(List<Entry> entry)
        {
            _entries = entry;
            _numberOfActive = 0;
            for (int i = 0; i < entry.Count; i++)
            {
                if (entry[i].Toggle == true)
                {
                    _numberOfActive++;
                }
            }
        }
       
    }
}
