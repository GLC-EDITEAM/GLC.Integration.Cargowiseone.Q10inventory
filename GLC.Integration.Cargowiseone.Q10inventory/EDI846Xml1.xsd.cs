namespace GLC.Integration.Cargowiseone.Q10inventory {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ISA", @"GS", @"GE", @"IEA"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"GLC.Integration.Cargowiseone.Q10inventory.EDI846Xml2", typeof(global::GLC.Integration.Cargowiseone.Q10inventory.EDI846Xml2))]
    public sealed class EDI846Xml1 : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:tns=""http://schemas.microsoft.com/Edi/X12ServiceSchema"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://schemas.microsoft.com/Edi/X12ServiceSchema"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""GLC.Integration.Cargowiseone.Q10inventory.EDI846Xml2"" />
  <xs:annotation>
    <xs:appinfo>
      <b:references>
        <b:reference targetNamespace=""http://schemas.microsoft.com/BizTalk/EDI/X12/2006"" />
        <b:reference targetNamespace=""http://schemas.microsoft.com/Edi/X12ServiceSchema"" />
      </b:references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""ISA"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ISA01"" />
        <xs:element ref=""ISA02"" />
        <xs:element ref=""ISA03"" />
        <xs:element ref=""ISA04"" />
        <xs:element ref=""ISA05"" />
        <xs:element ref=""ISA06"" />
        <xs:element ref=""ISA07"" />
        <xs:element ref=""ISA08"" />
        <xs:element ref=""ISA09"" />
        <xs:element ref=""ISA10"" />
        <xs:element ref=""ISA11"" />
        <xs:element ref=""ISA12"" />
        <xs:element ref=""ISA13"" />
        <xs:element ref=""ISA14"" />
        <xs:element ref=""ISA15"" />
        <xs:element ref=""ISA16"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""GS"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""GS01"" />
        <xs:element ref=""GS02"" />
        <xs:element ref=""GS03"" />
        <xs:element ref=""GS04"" />
        <xs:element ref=""GS05"" />
        <xs:element ref=""GS06"" />
        <xs:element ref=""GS07"" />
        <xs:element ref=""GS08"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""GE"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""GE01"" />
        <xs:element ref=""GE02"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""IEA"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""IEA01"" />
        <xs:element ref=""IEA02"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public EDI846Xml1() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [4];
                _RootElements[0] = "ISA";
                _RootElements[1] = "GS";
                _RootElements[2] = "GE";
                _RootElements[3] = "IEA";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
        
        [Schema(@"http://schemas.microsoft.com/Edi/X12ServiceSchema",@"ISA")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ISA"})]
        public sealed class ISA : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ISA() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ISA";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://schemas.microsoft.com/Edi/X12ServiceSchema",@"GS")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"GS"})]
        public sealed class GS : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public GS() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "GS";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://schemas.microsoft.com/Edi/X12ServiceSchema",@"GE")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"GE"})]
        public sealed class GE : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public GE() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "GE";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://schemas.microsoft.com/Edi/X12ServiceSchema",@"IEA")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"IEA"})]
        public sealed class IEA : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public IEA() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "IEA";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
    }
}
