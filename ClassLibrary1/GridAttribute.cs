using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class GridAttribute : Attribute
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Format { get; set; }
        public Type ForeignKeyType { get; set; }
        public string ForeignKeyValueMember { get; set; }
        public string ForeignKeyDisplayMember { get; set; }
        public string Mask { get; set; }
        public ColumnWidth Width { get; set; }
        public bool AllowBreakLines { get; set; }


        public string CellType { get; set; }


        public GridAttribute([CallerMemberName] string name = null, string title = null, string format = null, Type foreignKeyType = null, string foreignKeyValueMember = null, string foreignKeyDisplayMember = null, string cellType = null, ColumnWidth cellWidth = ColumnWidth.Medium, bool allowBreakLines = true, string description = null, string mask = null)
        {
            Name = name;
            Title = string.IsNullOrWhiteSpace(title) ? name : title;
            Format = format;
            ForeignKeyType = foreignKeyType;
            CellType = cellType;
            ForeignKeyValueMember = foreignKeyValueMember;
            ForeignKeyDisplayMember = foreignKeyDisplayMember;
            Width = cellWidth;
            AllowBreakLines = allowBreakLines;
            Description = description;
            Mask = mask;
        }

        public enum ColumnWidth
        {
            VerySmall = 30,
            Small = 50,
            MediumSmall = 100,
            Medium = 150,
            Large = 300,
            VeryLarge = 600
        }
    }
}
