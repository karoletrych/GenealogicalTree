namespace Frontend
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class family
    {

        private familyPerson[] peopleField;

        private familyMarriage[] marriagesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("person", IsNullable = false)]
        public familyPerson[] people
        {
            get
            {
                return this.peopleField;
            }
            set
            {
                this.peopleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("marriage", IsNullable = false)]
        public familyMarriage[] marriages
        {
            get
            {
                return this.marriagesField;
            }
            set
            {
                this.marriagesField = value;
            }
        }

        public object Members
        {
            get { throw new System.NotImplementedException(); }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class familyPerson
    {

        private familyPersonBorn bornField;

        private familyPersonMother motherField;

        private familyPersonFather fatherField;

        private familyPersonDied diedField;

        private string forenamesField;

        private string idField;

        private string sexField;

        private string surnameField;

        /// <remarks/>
        public familyPersonBorn born
        {
            get
            {
                return this.bornField;
            }
            set
            {
                this.bornField = value;
            }
        }

        /// <remarks/>
        public familyPersonMother mother
        {
            get
            {
                return this.motherField;
            }
            set
            {
                this.motherField = value;
            }
        }

        /// <remarks/>
        public familyPersonFather father
        {
            get
            {
                return this.fatherField;
            }
            set
            {
                this.fatherField = value;
            }
        }

        /// <remarks/>
        public familyPersonDied died
        {
            get
            {
                return this.diedField;
            }
            set
            {
                this.diedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string forenames
        {
            get
            {
                return this.forenamesField;
            }
            set
            {
                this.forenamesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string sex
        {
            get
            {
                return this.sexField;
            }
            set
            {
                this.sexField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string surname
        {
            get
            {
                return this.surnameField;
            }
            set
            {
                this.surnameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class familyPersonBorn
    {

        private ushort dateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class familyPersonMother
    {

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class familyPersonFather
    {

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class familyPersonDied
    {

        private ushort dateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class familyMarriage
    {

        private ushort dateField;

        private bool dateFieldSpecified;

        private string husbandField;

        private string wifeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dateSpecified
        {
            get
            {
                return this.dateFieldSpecified;
            }
            set
            {
                this.dateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string husband
        {
            get
            {
                return this.husbandField;
            }
            set
            {
                this.husbandField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string wife
        {
            get
            {
                return this.wifeField;
            }
            set
            {
                this.wifeField = value;
            }
        }
    }
}