using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Ruler
{
    public class SingleBell
    {
        #region Поля класса SingleBell
        private List<int> _config;
        private int _length;
        private TypeSorted _sorted;
        private TypeAlignCfg _align;
        #endregion
        #region Конструкторы класса SingleBell
        public SingleBell() : this(new List<int>()) { }
        public SingleBell(List<int> config) : this(config, TypeSorted.Up) { }

        public SingleBell(List<int> config, TypeSorted sorted) : this(config, sorted, TypeAlignCfg.Right) { }
        public SingleBell(List<int> config, TypeSorted sorted, TypeAlignCfg align) : this(config, config.Count, sorted, align) { }

        public SingleBell(List<int> config, int length, TypeSorted sorted, TypeAlignCfg align)
        {
            _config = config;
            _sorted = sorted;
            _align = align;
            _length = length;
        }
        #endregion
        #region Свойства класса SingleBell

        public int Count
        {
            get { return _config.Count; }
        }
        public int Length
        {
            get { return _length; }
            set
            {
                if ((value != 0) && (value > _config.Count))
                    _length = value;
            }
        }
        public TypeSorted Sorted
        {
            get { return _sorted; }
            set { _sorted = value; }
        }

        public TypeAlignCfg Align
        {
            get { return _align; }
            set { _align = value; }
        }
        #endregion
        #region Методы класса SingleBell

        public int this[int index]
        {
            get
            {
                if (Length > Count)
                {
                    if (Align == TypeAlignCfg.Left)
                    {
                        if (index >= Count) return 0;
                    }
                }
            }
        }
        public override string ToString()
        {
            string s = "";
        }

        #endregion

    }
}
