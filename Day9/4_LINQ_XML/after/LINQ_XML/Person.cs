using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_XML
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Person
    {

        private Person學生[] 學生Field;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("學生")]
        public Person學生[] 學生
        {
            get
            {
                return this.學生Field;
            }
            set
            {
                this.學生Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class Person學生
    {

        private uint 學號Field;

        private string 姓名Field;

        private string 電話Field;

        private string 信箱Field;

        /// <remarks/>
        public uint 學號
        {
            get
            {
                return this.學號Field;
            }
            set
            {
                this.學號Field = value;
            }
        }

        /// <remarks/>
        public string 姓名
        {
            get
            {
                return this.姓名Field;
            }
            set
            {
                this.姓名Field = value;
            }
        }

        /// <remarks/>
        public string 電話
        {
            get
            {
                return this.電話Field;
            }
            set
            {
                this.電話Field = value;
            }
        }

        /// <remarks/>
        public string 信箱
        {
            get
            {
                return this.信箱Field;
            }
            set
            {
                this.信箱Field = value;
            }
        }
    }


}
