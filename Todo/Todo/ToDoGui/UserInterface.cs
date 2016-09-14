/* UserInterace.cs     501 HW_2
 * Author: Ying Chen
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Todo;
using System.IO;
using Newtonsoft.Json;

namespace ToDoGui
{
    public partial class UserInterface : Form
    {
        private Delete delete;
        private Add add;
        private NumberofActive number;
       // private Checkenter checkenter;
        private Update update;
        private SetToggle toggle;
        private TotalNunmber totalNumber;
        private ReturnToggle returnToggle;
        private ReturnDes returnDes;
        private SetNumberOfActive plusOrMinus;
        private LoadEntries loadEntries;
        private SaveEntries saveEntries;
       // private UpdateController updateController;
      //  private ReturnEntry returnEntry;
     
       // private List<Entry> _entries = new List<Entry> { };
       // private int _numberOfActive = 0;

        /// <summary>
        /// delegate used when AfterLabelEdit called.
        /// </summary>
        /// <param name="item"></param>
        private delegate void RemoveItemDelegate(ListViewItem item);

        /// <summary>
        /// Display userinterface.
        /// </summary>
        public UserInterface(Delete delete, Add add, NumberofActive number, Update update, SetToggle toggle, TotalNunmber totalNumber,ReturnToggle returnToggle, ReturnDes returnDes, SetNumberOfActive plusOrMinus, LoadEntries loadEntries, SaveEntries saveEntries)
        {
            this.delete = delete;
            this.add = add;
            this.number = number;
            this.update = update;
            this.toggle = toggle;
            this.totalNumber = totalNumber;
            this.returnToggle = returnToggle;
            this.returnDes = returnDes;
            this.plusOrMinus = plusOrMinus;
            this.loadEntries = loadEntries;
            this.saveEntries = saveEntries;
           // this.updateController = updateController;
           // this.returnAllEntries = returnAllEntries;
            InitializeComponent();
            uxLableShowActive.Text = "No Active Entries";
        }

        /// <summary>
        /// this method is invoked after user types a char in the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckEnter(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                string des = uxEnterDescription.Text;
                if (des != "")
                {   
                    add(sender,e,des);
                    ListViewItem item = new ListViewItem(des);
                    item.SubItems.Add(des);
                    uxEntryList.Items.Add(item);
                }
                uxEntryList.View = View.List;
                uxEnterDescription.Text = ""; // _numberOfActive = _entries.Count; // _numberOfActive = number();
                ShowActiveEntries(number()); 
            }
        }
        /// <summary>
        /// This method shows the messages that displayed in the lable at the bottom.
        /// </summary>
        public void ShowActiveEntries(int number){
            if (number > 1) {uxLableShowActive.Text = number + " Active Entries";}
            if (number == 0) { uxLableShowActive.Text = "No Active Entries"; }
            if (number == 1) { uxLableShowActive.Text = "1 Active Entry"; }
        }
        /// <summary>
        /// Remove the given item in the listView.
        /// </summary>
        /// <param name="item">the given item to be removed.</param>
        private void RemoveItem(ListViewItem item) { item.Remove(); }

        /// <summary>
        /// this is invoked after user changes lable in the listView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxEntryList_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            if (e.Label != "")
            {
                update(e.Label, e.Item);  // _entries[e.Item].Des = e.Label;
                uxEntryList.Items[e.Item].Text = e.Label;
            }
            else
            {
                if (returnToggle(e.Item)) { plusOrMinus("-"); }
               // update("", e.Item);     // if(_entries[e.Item].Toggle == true) {_numberOfActive--; }
                delete(e.Item);                        //_entries.RemoveAt(e.Item);
                ShowActiveEntries(number());
                ListViewItem i = uxEntryList.Items[e.Item];
                uxEntryList.BeginInvoke(new RemoveItemDelegate(RemoveItem), i); 
           }
        }
        /// <summary>
        /// this is invoked after user drag an item out of the listView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxEntryList_ItemDrag(object sender, ItemDragEventArgs e)
        {
            ListViewItem liv = uxEntryList.SelectedItems[0];
            int index = uxEntryList.Items.IndexOf(liv);
            if (returnToggle(index)) { plusOrMinus("-"); }
            // update("",index);                      //if (_entries[index].Toggle == true)   {_numberOfActive--;}
            delete(index);                         // _entries.RemoveAt(index);
            uxEntryList.Items.Remove(liv);
            ShowActiveEntries(number());
        }

        /// <summary>
        /// this is invoked after user clicks the checkbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxEntryList_ItemCheck_1(object sender, ItemCheckEventArgs e)
        {
           if (e.CurrentValue == CheckState.Checked)
           {
               int i = e.Index;
               toggle(i, true);                      // _entries[i].Toggle = true;
               uxEntryList.Items[i].Font = new Font(uxEntryList.Items[i].Font, uxEntryList.Items[i].Font.Style & ~FontStyle.Strikeout);
               plusOrMinus("+");   //_numberOfActive++;
               ShowActiveEntries(number());
           }
           if (e.CurrentValue == CheckState.Unchecked)
           {
               int index = e.Index;
               toggle(index, false);                       //_entries[index].Toggle = false;
               uxEntryList.Items[index].Font = new Font(uxEntryList.Items[index].Font, uxEntryList.Items[index].Font.Style | FontStyle.Strikeout);
               plusOrMinus("-");//_numberOfActive--;
               ShowActiveEntries(number());
           }
        }

        /// <summary>
        /// this is invoked after user click on the ClearComplete button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxClearCompleted_Click(object sender, EventArgs e)
        {
             uxEntryList.Items.Clear();
             for (int i = 0; i < totalNumber(); i++ )
             {
                 if (returnToggle(i))              //if (_entries[i].Toggle == true)   {uxEntryList.Items.Add(_entries[i].Des); }
                 { uxEntryList.Items.Add(returnDes(i)); }                              //  { uxEntryList.Items.Add(_entries[i].Des); } 
                 else { delete(i); i--; }                                                    // else { _entries.RemoveAt(i); i--; }
             }
          
        }

        /// <summary>
        /// This is invoked after user change the index in the combobox. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxChooseView_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = (string)uxChooseView.SelectedItem;
             uxEntryList.Items.Clear();
             if (selected.Equals("All entries"))
             {
                 for (int i = 0; i < totalNumber(); i++ )
                 {
                     ListViewItem lvi = uxEntryList.Items.Add(returnDes(i));
                     if(!returnToggle(i))
                     {
                         lvi.Font = new Font(lvi.Font, lvi.Font.Style | FontStyle.Strikeout);
                     }
                 }
                    /* foreach (Entry entry in _entries) {
                         ListViewItem lvi = uxEntryList.Items.Add(entry.Des);
                         if (entry.Toggle == false) {lvi.Font = new Font(lvi.Font, lvi.Font.Style | FontStyle.Strikeout);} } */
             }
            if(selected.Equals("Active entries"))
            {
                // foreach(Entry entry in _entries) {if(entry.Toggle ==true) { uxEntryList.Items.Add(entry.Des);} }
                for (int i = 0; i < totalNumber(); i++)
                {
                    if (returnToggle(i)) { uxEntryList.Items.Add(returnDes(i));}
                }
            }
            if (selected.Equals("Completed entries"))
            {
               /* foreach (Entry entry in _entries)
                { if (entry.Toggle == false) {
                       ListViewItem i = uxEntryList.Items.Add(entry.Des);
                       i.Font = new Font(i.Font, i.Font.Style | FontStyle.Strikeout); }}*/
                for (int i = 0; i < totalNumber(); i++)
                {
                    if (!returnToggle(i)) 
                    {
                        ListViewItem lvi = uxEntryList.Items.Add(returnDes(i));
                        lvi.Font = new Font(lvi.Font, lvi.Font.Style | FontStyle.Strikeout);
                    }
                }

            }

        }

        private void uxLoad_Click(object sender, EventArgs e)
        {
            if(uxOpenFile.ShowDialog()==DialogResult.OK)
            {
                string content= File.ReadAllText(uxOpenFile.FileName);
                loadEntries(content);
                uxEntryList.Items.Clear();
                for(int i = 0;i<totalNumber();i++)
                {
                    ListViewItem lvi = uxEntryList.Items.Add(returnDes(i));
                    if (!returnToggle(i))
                    {
                        lvi.Font = new Font(lvi.Font, lvi.Font.Style | FontStyle.Strikeout);
                    }
                }
                uxEntryList.View = View.List;
                uxEnterDescription.Text = ""; // _numberOfActive = _entries.Count; // _numberOfActive = number();
                ShowActiveEntries(number()); 
            }
        }

        private void uxSave_Click(object sender, EventArgs e)
        {
            if (uxSaveFile.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(uxSaveFile.FileName, saveEntries());
            }
        }
    }
}