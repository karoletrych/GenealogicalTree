using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Application
{
    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class family
    {
        private familyMarriage[] marriagesField;

        private familyPerson[] peopleField;

        /// <remarks />
        [XmlArrayItem("person", IsNullable = false)]
        public familyPerson[] people
        {
            get { return peopleField; }
            set { peopleField = value; }
        }

        /// <remarks />
        [XmlArrayItem("marriage", IsNullable = false)]
        public familyMarriage[] marriages
        {
            get { return marriagesField; }
            set { marriagesField = value; }
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class familyPerson
    {
        private familyPersonBorn bornField;

        private familyPersonDied diedField;

        private familyPersonFather fatherField;

        private string forenamesField;

        private string idField;

        private familyPersonMother motherField;

        private string sexField;

        private string surnameField;

        /// <remarks />
        public familyPersonBorn born
        {
            get { return bornField; }
            set { bornField = value; }
        }

        /// <remarks />
        public familyPersonMother mother
        {
            get { return motherField; }
            set { motherField = value; }
        }

        /// <remarks />
        public familyPersonFather father
        {
            get { return fatherField; }
            set { fatherField = value; }
        }

        /// <remarks />
        public familyPersonDied died
        {
            get { return diedField; }
            set { diedField = value; }
        }

        /// <remarks />
        [XmlAttribute]
        public string forenames
        {
            get { return forenamesField; }
            set { forenamesField = value; }
        }

        /// <remarks />
        [XmlAttribute]
        public string id
        {
            get { return idField; }
            set { idField = value; }
        }

        /// <remarks />
        [XmlAttribute]
        public string sex
        {
            get { return sexField; }
            set { sexField = value; }
        }

        /// <remarks />
        [XmlAttribute]
        public string surname
        {
            get { return surnameField; }
            set { surnameField = value; }
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class familyPersonBorn
    {
        private ushort dateField;

        /// <remarks />
        [XmlAttribute]
        public ushort date
        {
            get { return dateField; }
            set { dateField = value; }
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class familyPersonMother
    {
        private string idField;

        /// <remarks />
        [XmlAttribute]
        public string id
        {
            get { return idField; }
            set { idField = value; }
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class familyPersonFather
    {
        private string idField;

        /// <remarks />
        [XmlAttribute]
        public string id
        {
            get { return idField; }
            set { idField = value; }
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class familyPersonDied
    {
        private ushort dateField;

        /// <remarks />
        [XmlAttribute]
        public ushort date
        {
            get { return dateField; }
            set { dateField = value; }
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class familyMarriage
    {
        private ushort dateField;

        private bool dateFieldSpecified;

        private string husbandField;

        private string wifeField;

        /// <remarks />
        [XmlAttribute]
        public ushort date
        {
            get { return dateField; }
            set { dateField = value; }
        }

        /// <remarks />
        [XmlIgnore]
        public bool dateSpecified
        {
            get { return dateFieldSpecified; }
            set { dateFieldSpecified = value; }
        }

        /// <remarks />
        [XmlAttribute]
        public string husband
        {
            get { return husbandField; }
            set { husbandField = value; }
        }

        /// <remarks />
        [XmlAttribute]
        public string wife
        {
            get { return wifeField; }
            set { wifeField = value; }
        }
    }
}