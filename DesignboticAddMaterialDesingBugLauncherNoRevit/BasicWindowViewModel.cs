using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml.Linq;

namespace DesignboticAddMaterialDesingBugLauncher
{
    public class BasicWindowViewModel : BaseViewModel
    {
        private ObservableCollection<string> _comboBoxOptionsVM;

        public ObservableCollection<string> ComboBoxOptionsVM
        {
            get { return _comboBoxOptionsVM; }
            set { _comboBoxOptionsVM = value; }
        }
        public List<DummyObject> DummyObjects { get; set; }

        public BasicWindowViewModel()
        {
            DummyObjects = new List<DummyObject>()
            {
                new DummyObject("one"),
                new DummyObject("two"),
                new DummyObject("tree")
            };
            ComboBoxOptionsVM = new ObservableCollection<string>(new List<string>
            {
                "Option 1",
                "Option 2",
                "Option 3",
                "Option 4"
            }
            );
        }
    }
    public class DummyObject{
        public string Name { get; set; }
        public List<string> ComboBoxOptions { get; set; }
        public string SelectedComboBoxOptions { get; set; }
        public DummyObject(string name)
        {
            Name = name;
            SelectedComboBoxOptions = "Initial value";
            ComboBoxOptions = new List<string>
            {
                "Option 1",
                "Option 2",
                "Option 3",
                "Option 4"
            };
        }
}   
}



