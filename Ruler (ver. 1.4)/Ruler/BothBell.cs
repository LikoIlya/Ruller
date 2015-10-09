using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ruler
{
    [Serializable]
    class BothBell : IComparable<BothBell>
    {
        #region Конструкторы класса BothBell
        public BothBell() : this(new SingleBell(), new SingleBell()) { }
        public BothBell(SingleBell parents, SingleBell child) : this(parents, child, TypeCompare.FirstParents, TypeSorted.Up) { }
        public BothBell(SingleBell parents, SingleBell child, TypeCompare typeCompare, TypeSorted typeSorted)
        {
            this._parents = parents;
            this._child = child;
            this._typeCompare = typeCompare;
            this._typeSorted = typeSorted;
        }
        #endregion
        #region Поля класса BothBell
        private SingleBell _parents;
        private SingleBell _child;
        private TypeCompare _typeCompare;
        private TypeSorted _typeSorted;
        #endregion
        #region Свойства класса BothBell
        public SingleBell Parents
        {
            get { return _parents; }
            set
            {
                if (value != null)
                    _parents = value;
            }
        }

        public SingleBell Child
        {
            get { return _child; }
            set
            {
                if (value != null)
                    child = value; 
            }
        }

        public TypeCompare TypeOfCompare
        {
            get { return _typeCompare; }
            set
            { if (value != null) _typeCompare = value; }

        }
        #endregion
        #region Методы класса BothBell

        public override string ToString()
        {
            return Parents.ToString() + " " + Child.ToString();
        }

        public int CompareTo(BothBell other)
        {
            int result = this.Parents.CompareTo(other.Parents);
            if (result == 0)
                result = this.Child.CompareTo(other.Child);
            return result;
        }
        public override bool Equals(object obj)
        {
            bool result = false;
            if (obj is BothBell)
                if (CompareTo((BothBell)(obj)) == 0) result = true;
            return result;
        }


        #endregion
    }
}
