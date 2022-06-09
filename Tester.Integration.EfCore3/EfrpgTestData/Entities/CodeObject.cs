// <auto-generated>
// ReSharper disable All

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Tester.Integration.EfCore3
{
    // CodeObject
    /// <summary>
    /// This is a test
    /// </summary>
    public class CodeObject
    {
        public int CodeObjectNo { get; set; } // codeObjectNo (Primary key)
        public int? ApplicationNo { get; set; } // applicationNo
        public int Type { get; set; } // type
        public string EName { get; set; } // eName (length: 250)
        public string AName { get; set; } // aName (length: 250)
        public string Description { get; set; } // description (length: 250)
        public string CodeName { get; set; } // codeName (length: 250)
        public string Note { get; set; } // note (length: 250)
        public bool IsObject { get; set; } // isObject
        public byte[] VersionNumber { get; set; } // versionNumber (length: 8)

        public CodeObject()
        {
            CodeObjectNo = 0;
            IsObject = false;
        }
    }

}
// </auto-generated>
