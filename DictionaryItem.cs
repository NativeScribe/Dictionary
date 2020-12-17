using System;
using System.Collections.Generic;

namespace NativeScribe
{
    [Serializable]
    public class DictionaryItem
    {
        private List<Dictionary> items;

        public List<Dictionary> Items { get => items; set => items = value; }
    }
}