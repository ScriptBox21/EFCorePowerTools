﻿namespace RevEng.Core.Abstractions.Metadata
{
    public class TableFunctionResultElement
    {
        public string Name { get; set; }
        public string StoreType { get; set; }
        public int Ordinal { get; set; }
        public bool Nullable { get; set; }
    }
}
