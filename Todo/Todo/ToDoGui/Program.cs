using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Todo;
using Newtonsoft.Json;

namespace ToDoGui
{
    //
    public delegate void InputHandler(object sender, EventArgs e);
    public delegate void Observer();
    public delegate void Checkenter( object sender, System.Windows.Forms.KeyPressEventArgs e);
    public delegate void Delete(int i);
    public delegate void Add(object sender, EventArgs e, string des);
    public delegate int NumberofActive();
    public delegate void Update(string des, int index);
    public delegate void SetToggle(int index, bool b);
    public delegate int TotalNunmber();
    public delegate bool ReturnToggle(int index);
    public delegate string ReturnDes(int index);
    public delegate void SetNumberOfActive(string plusOrminus);
    public delegate void LoadEntries(string content);
    public delegate string SaveEntries();
    //public delegate void UpdateController(List<Entry> list);
  //  public delegate List<Entry> ReturnEntry(int index);
    static class Program
    {
        private static List<Entry> entry = new List<Entry>();
        private static TodoController c = new TodoController(entry);
      //  private UpdateController updateController;
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

           
            UserInterface ui = new UserInterface(c.Delete, c.AddEntry, c.NumberofActive,c.Update,c.SetToggle, c.TotalNumber, c.ReturnToggle, c.ReturnDes, c.SetNumberOfActive, loadEntries,saveEntries);
          //  updateController(c.UpdateController); 
            Application.Run(ui);
           
        }

        public static void loadEntries(string content)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                ContractResolver = new CustomJsonContractResolver(),
                PreserveReferencesHandling = PreserveReferencesHandling.Objects
            };
            List<Entry> list = JsonConvert.DeserializeObject<List<Entry>>(content, settings);
            c.UpdateController(list);
        }

        public static string saveEntries()
        {
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                ContractResolver = new CustomJsonContractResolver(),
                PreserveReferencesHandling = PreserveReferencesHandling.Objects
            };
            string s= JsonConvert.SerializeObject(c.AllEntries(), Formatting.Indented, settings);
            return s;
           // List<Entry> back = JsonConvert.DeserializeObject<List<Entry>>(content, settings);
           // TodoController newc = new TodoController(back);
        }
    }
}
