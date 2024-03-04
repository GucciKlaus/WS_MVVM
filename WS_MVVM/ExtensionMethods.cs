using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WS_MVVM
{
    public static class ExtensionMethods
    {
        /*wuascht = T*/
        public static ObservableCollection<wuascht> AsObervableCollection <wuascht>(this List<wuascht> list)
        {
            ObservableCollection<wuascht> obsColl = new ObservableCollection<wuascht>();
            foreach (wuascht item in list)
            {
                obsColl.Add(item);
            }
            return obsColl;
        }
    }
}
