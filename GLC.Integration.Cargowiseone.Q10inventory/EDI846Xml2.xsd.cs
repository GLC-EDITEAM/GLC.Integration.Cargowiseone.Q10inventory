namespace GLC.Integration.Cargowiseone.Q10inventory {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ISA01", @"ISA02", @"ISA03", @"ISA04", @"ISA05", @"ISA06", @"ISA07", @"ISA08", @"ISA09", @"ISA10", @"ISA11", @"ISA12", @"ISA13", @"ISA14", @"ISA15", @"ISA16", @"FunctionalGroup", @"GS01", @"GS02", @"GS03", @"GS04", @"GS05", @"GS06", @"GS07", @"GS08", @"ST", @"W0501", @"W0502", @"W0503", @"N101", @"N102", @"N301", @"N401", @"N402", @"N403", @"N404", @"N901", @"N902", @"G6201", @"G6202", @"W6601", @"W6602", @"W6605", @"LX01", @"W0101", @"W0102", @"W0103", 
@"W0104", @"W0105", @"G6901", @"W2004", @"W2005", @"W2006", @"W7601", @"W7602", @"W7603", @"SE", @"GE01", @"GE02", @"IEA01", @"IEA02"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"GLC.Integration.Cargowiseone.Q10inventory.EDI846Xml1", typeof(global::GLC.Integration.Cargowiseone.Q10inventory.EDI846Xml1))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"GLC.Integration.Cargowiseone.Q10inventory.X12_00401_846", typeof(global::GLC.Integration.Cargowiseone.Q10inventory.X12_00401_846))]
    public sealed class EDI846Xml2 : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns1=""http://schemas.microsoft.com/Edi/X12ServiceSchema"" xmlns:ns0=""http://schemas.microsoft.com/BizTalk/EDI/X12/2006"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""GLC.Integration.Cargowiseone.Q10inventory.EDI846Xml1"" namespace=""http://schemas.microsoft.com/Edi/X12ServiceSchema"" />
  <xs:import schemaLocation=""GLC.Integration.Cargowiseone.Q10inventory.X12_00401_846"" namespace=""http://schemas.microsoft.com/BizTalk/EDI/X12/2006"" />
  <xs:annotation>
    <xs:appinfo>
      <b:references>
        <b:reference targetNamespace=""http://schemas.microsoft.com/BizTalk/EDI/X12/2006"" />
        <b:reference targetNamespace=""http://schemas.microsoft.com/Edi/X12ServiceSchema"" />
      </b:references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""ISA01"" type=""xs:unsignedByte"" />
  <xs:element name=""ISA02"" type=""xs:string"" />
  <xs:element name=""ISA03"" type=""xs:unsignedByte"" />
  <xs:element name=""ISA04"" type=""xs:string"" />
  <xs:element name=""ISA05"" type=""xs:unsignedByte"" />
  <xs:element name=""ISA06"" type=""xs:unsignedInt"" />
  <xs:element name=""ISA07"" type=""xs:string"" />
  <xs:element name=""ISA08"" type=""xs:string"" />
  <xs:element name=""ISA09"" type=""xs:unsignedInt"" />
  <xs:element name=""ISA10"" type=""xs:unsignedShort"" />
  <xs:element name=""ISA11"" type=""xs:string"" />
  <xs:element name=""ISA12"" type=""xs:unsignedShort"" />
  <xs:element name=""ISA13"" type=""xs:unsignedShort"" />
  <xs:element name=""ISA14"" type=""xs:unsignedByte"" />
  <xs:element name=""ISA15"" type=""xs:string"" />
  <xs:element name=""ISA16"" type=""xs:string"" />
  <xs:element name=""FunctionalGroup"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q1=""http://schemas.microsoft.com/Edi/X12ServiceSchema"" ref=""q1:GS"" />
        <xs:element name=""TransactionSet"">
          <xs:complexType>
            <xs:sequence>
              <xs:element xmlns:q2=""http://schemas.microsoft.com/BizTalk/EDI/X12/2006"" ref=""q2:X12_00401_846"" />
            </xs:sequence>
            <xs:attribute name=""DocType"" type=""xs:string"" use=""required"" />
          </xs:complexType>
        </xs:element>
        <xs:element xmlns:q3=""http://schemas.microsoft.com/Edi/X12ServiceSchema"" ref=""q3:GE"" />
      </xs:sequence>
      <xs:attribute name=""DocType"" type=""xs:string"" use=""required"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""GS01"" type=""xs:string"" />
  <xs:element name=""GS02"" type=""xs:unsignedInt"" />
  <xs:element name=""GS03"" type=""xs:string"" />
  <xs:element name=""GS04"" type=""xs:unsignedInt"" />
  <xs:element name=""GS05"" type=""xs:unsignedShort"" />
  <xs:element name=""GS06"" type=""xs:unsignedShort"" />
  <xs:element name=""GS07"" type=""xs:string"" />
  <xs:element name=""GS08"" type=""xs:unsignedShort"" />
  <xs:element name=""ST"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""ST01"" type=""xs:unsignedShort"" />
        <xs:element name=""ST02"" type=""xs:unsignedByte"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""W0501"" type=""xs:string"" />
  <xs:element name=""W0502"" type=""xs:unsignedInt"" />
  <xs:element name=""W0503"" type=""xs:string"" />
  <xs:element name=""N101"" type=""xs:string"" />
  <xs:element name=""N102"" type=""xs:string"" />
  <xs:element name=""N301"" type=""xs:string"" />
  <xs:element name=""N401"" type=""xs:string"" />
  <xs:element name=""N402"" type=""xs:string"" />
  <xs:element name=""N403"" type=""xs:unsignedShort"" />
  <xs:element name=""N404"" type=""xs:string"" />
  <xs:element name=""N901"" type=""xs:string"" />
  <xs:element name=""N902"" type=""xs:string"" />
  <xs:element name=""G6201"" type=""xs:unsignedByte"" />
  <xs:element name=""G6202"" type=""xs:unsignedInt"" />
  <xs:element name=""W6601"" type=""xs:string"" />
  <xs:element name=""W6602"" type=""xs:string"" />
  <xs:element name=""W6605"" type=""xs:string"" />
  <xs:element name=""LX01"" type=""xs:unsignedByte"" />
  <xs:element name=""W0101"" type=""xs:unsignedByte"" />
  <xs:element name=""W0102"" type=""xs:string"" />
  <xs:element name=""W0103"" type=""xs:unsignedLong"" />
  <xs:element name=""W0104"" type=""xs:string"" />
  <xs:element name=""W0105"" type=""xs:string"" />
  <xs:element name=""G6901"" type=""xs:string"" />
  <xs:element name=""W2004"" type=""xs:unsignedByte"" />
  <xs:element name=""W2005"" type=""xs:string"" />
  <xs:element name=""W2006"" type=""xs:string"" />
  <xs:element name=""W7601"" type=""xs:unsignedByte"" />
  <xs:element name=""W7602"" type=""xs:unsignedByte"" />
  <xs:element name=""W7603"" type=""xs:string"" />
  <xs:element name=""SE"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""SE01"" type=""xs:unsignedByte"" />
        <xs:element name=""SE02"" type=""xs:unsignedByte"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""GE01"" type=""xs:unsignedByte"" />
  <xs:element name=""GE02"" type=""xs:unsignedShort"" />
  <xs:element name=""IEA01"" type=""xs:unsignedByte"" />
  <xs:element name=""IEA02"" type=""xs:unsignedShort"" />
</xs:schema>";
        
        public EDI846Xml2() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [61];
                _RootElements[0] = "ISA01";
                _RootElements[1] = "ISA02";
                _RootElements[2] = "ISA03";
                _RootElements[3] = "ISA04";
                _RootElements[4] = "ISA05";
                _RootElements[5] = "ISA06";
                _RootElements[6] = "ISA07";
                _RootElements[7] = "ISA08";
                _RootElements[8] = "ISA09";
                _RootElements[9] = "ISA10";
                _RootElements[10] = "ISA11";
                _RootElements[11] = "ISA12";
                _RootElements[12] = "ISA13";
                _RootElements[13] = "ISA14";
                _RootElements[14] = "ISA15";
                _RootElements[15] = "ISA16";
                _RootElements[16] = "FunctionalGroup";
                _RootElements[17] = "GS01";
                _RootElements[18] = "GS02";
                _RootElements[19] = "GS03";
                _RootElements[20] = "GS04";
                _RootElements[21] = "GS05";
                _RootElements[22] = "GS06";
                _RootElements[23] = "GS07";
                _RootElements[24] = "GS08";
                _RootElements[25] = "ST";
                _RootElements[26] = "W0501";
                _RootElements[27] = "W0502";
                _RootElements[28] = "W0503";
                _RootElements[29] = "N101";
                _RootElements[30] = "N102";
                _RootElements[31] = "N301";
                _RootElements[32] = "N401";
                _RootElements[33] = "N402";
                _RootElements[34] = "N403";
                _RootElements[35] = "N404";
                _RootElements[36] = "N901";
                _RootElements[37] = "N902";
                _RootElements[38] = "G6201";
                _RootElements[39] = "G6202";
                _RootElements[40] = "W6601";
                _RootElements[41] = "W6602";
                _RootElements[42] = "W6605";
                _RootElements[43] = "LX01";
                _RootElements[44] = "W0101";
                _RootElements[45] = "W0102";
                _RootElements[46] = "W0103";
                _RootElements[47] = "W0104";
                _RootElements[48] = "W0105";
                _RootElements[49] = "G6901";
                _RootElements[50] = "W2004";
                _RootElements[51] = "W2005";
                _RootElements[52] = "W2006";
                _RootElements[53] = "W7601";
                _RootElements[54] = "W7602";
                _RootElements[55] = "W7603";
                _RootElements[56] = "SE";
                _RootElements[57] = "GE01";
                _RootElements[58] = "GE02";
                _RootElements[59] = "IEA01";
                _RootElements[60] = "IEA02";
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
        
        [Schema(@"",@"ISA01")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ISA01"})]
        public sealed class ISA01 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ISA01() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ISA01";
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
        
        [Schema(@"",@"ISA02")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ISA02"})]
        public sealed class ISA02 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ISA02() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ISA02";
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
        
        [Schema(@"",@"ISA03")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ISA03"})]
        public sealed class ISA03 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ISA03() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ISA03";
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
        
        [Schema(@"",@"ISA04")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ISA04"})]
        public sealed class ISA04 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ISA04() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ISA04";
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
        
        [Schema(@"",@"ISA05")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ISA05"})]
        public sealed class ISA05 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ISA05() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ISA05";
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
        
        [Schema(@"",@"ISA06")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ISA06"})]
        public sealed class ISA06 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ISA06() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ISA06";
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
        
        [Schema(@"",@"ISA07")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ISA07"})]
        public sealed class ISA07 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ISA07() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ISA07";
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
        
        [Schema(@"",@"ISA08")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ISA08"})]
        public sealed class ISA08 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ISA08() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ISA08";
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
        
        [Schema(@"",@"ISA09")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ISA09"})]
        public sealed class ISA09 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ISA09() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ISA09";
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
        
        [Schema(@"",@"ISA10")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ISA10"})]
        public sealed class ISA10 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ISA10() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ISA10";
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
        
        [Schema(@"",@"ISA11")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ISA11"})]
        public sealed class ISA11 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ISA11() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ISA11";
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
        
        [Schema(@"",@"ISA12")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ISA12"})]
        public sealed class ISA12 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ISA12() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ISA12";
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
        
        [Schema(@"",@"ISA13")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ISA13"})]
        public sealed class ISA13 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ISA13() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ISA13";
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
        
        [Schema(@"",@"ISA14")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ISA14"})]
        public sealed class ISA14 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ISA14() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ISA14";
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
        
        [Schema(@"",@"ISA15")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ISA15"})]
        public sealed class ISA15 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ISA15() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ISA15";
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
        
        [Schema(@"",@"ISA16")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ISA16"})]
        public sealed class ISA16 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ISA16() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ISA16";
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
        
        [Schema(@"",@"FunctionalGroup")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"FunctionalGroup"})]
        public sealed class FunctionalGroup : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public FunctionalGroup() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "FunctionalGroup";
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
        
        [Schema(@"",@"GS01")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"GS01"})]
        public sealed class GS01 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public GS01() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "GS01";
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
        
        [Schema(@"",@"GS02")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"GS02"})]
        public sealed class GS02 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public GS02() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "GS02";
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
        
        [Schema(@"",@"GS03")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"GS03"})]
        public sealed class GS03 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public GS03() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "GS03";
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
        
        [Schema(@"",@"GS04")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"GS04"})]
        public sealed class GS04 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public GS04() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "GS04";
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
        
        [Schema(@"",@"GS05")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"GS05"})]
        public sealed class GS05 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public GS05() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "GS05";
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
        
        [Schema(@"",@"GS06")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"GS06"})]
        public sealed class GS06 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public GS06() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "GS06";
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
        
        [Schema(@"",@"GS07")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"GS07"})]
        public sealed class GS07 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public GS07() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "GS07";
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
        
        [Schema(@"",@"GS08")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"GS08"})]
        public sealed class GS08 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public GS08() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "GS08";
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
        
        [Schema(@"",@"ST")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ST"})]
        public sealed class ST : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ST() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ST";
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
        
        [Schema(@"",@"W0501")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"W0501"})]
        public sealed class W0501 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public W0501() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "W0501";
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
        
        [Schema(@"",@"W0502")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"W0502"})]
        public sealed class W0502 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public W0502() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "W0502";
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
        
        [Schema(@"",@"W0503")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"W0503"})]
        public sealed class W0503 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public W0503() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "W0503";
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
        
        [Schema(@"",@"N101")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"N101"})]
        public sealed class N101 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public N101() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "N101";
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
        
        [Schema(@"",@"N102")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"N102"})]
        public sealed class N102 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public N102() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "N102";
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
        
        [Schema(@"",@"N301")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"N301"})]
        public sealed class N301 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public N301() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "N301";
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
        
        [Schema(@"",@"N401")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"N401"})]
        public sealed class N401 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public N401() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "N401";
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
        
        [Schema(@"",@"N402")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"N402"})]
        public sealed class N402 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public N402() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "N402";
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
        
        [Schema(@"",@"N403")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"N403"})]
        public sealed class N403 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public N403() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "N403";
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
        
        [Schema(@"",@"N404")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"N404"})]
        public sealed class N404 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public N404() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "N404";
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
        
        [Schema(@"",@"N901")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"N901"})]
        public sealed class N901 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public N901() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "N901";
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
        
        [Schema(@"",@"N902")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"N902"})]
        public sealed class N902 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public N902() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "N902";
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
        
        [Schema(@"",@"G6201")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"G6201"})]
        public sealed class G6201 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public G6201() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "G6201";
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
        
        [Schema(@"",@"G6202")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"G6202"})]
        public sealed class G6202 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public G6202() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "G6202";
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
        
        [Schema(@"",@"W6601")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"W6601"})]
        public sealed class W6601 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public W6601() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "W6601";
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
        
        [Schema(@"",@"W6602")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"W6602"})]
        public sealed class W6602 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public W6602() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "W6602";
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
        
        [Schema(@"",@"W6605")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"W6605"})]
        public sealed class W6605 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public W6605() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "W6605";
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
        
        [Schema(@"",@"LX01")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"LX01"})]
        public sealed class LX01 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public LX01() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "LX01";
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
        
        [Schema(@"",@"W0101")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"W0101"})]
        public sealed class W0101 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public W0101() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "W0101";
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
        
        [Schema(@"",@"W0102")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"W0102"})]
        public sealed class W0102 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public W0102() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "W0102";
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
        
        [Schema(@"",@"W0103")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"W0103"})]
        public sealed class W0103 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public W0103() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "W0103";
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
        
        [Schema(@"",@"W0104")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"W0104"})]
        public sealed class W0104 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public W0104() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "W0104";
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
        
        [Schema(@"",@"W0105")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"W0105"})]
        public sealed class W0105 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public W0105() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "W0105";
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
        
        [Schema(@"",@"G6901")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"G6901"})]
        public sealed class G6901 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public G6901() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "G6901";
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
        
        [Schema(@"",@"W2004")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"W2004"})]
        public sealed class W2004 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public W2004() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "W2004";
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
        
        [Schema(@"",@"W2005")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"W2005"})]
        public sealed class W2005 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public W2005() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "W2005";
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
        
        [Schema(@"",@"W2006")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"W2006"})]
        public sealed class W2006 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public W2006() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "W2006";
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
        
        [Schema(@"",@"W7601")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"W7601"})]
        public sealed class W7601 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public W7601() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "W7601";
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
        
        [Schema(@"",@"W7602")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"W7602"})]
        public sealed class W7602 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public W7602() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "W7602";
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
        
        [Schema(@"",@"W7603")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"W7603"})]
        public sealed class W7603 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public W7603() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "W7603";
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
        
        [Schema(@"",@"SE")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"SE"})]
        public sealed class SE : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public SE() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "SE";
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
        
        [Schema(@"",@"GE01")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"GE01"})]
        public sealed class GE01 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public GE01() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "GE01";
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
        
        [Schema(@"",@"GE02")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"GE02"})]
        public sealed class GE02 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public GE02() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "GE02";
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
        
        [Schema(@"",@"IEA01")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"IEA01"})]
        public sealed class IEA01 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public IEA01() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "IEA01";
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
        
        [Schema(@"",@"IEA02")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"IEA02"})]
        public sealed class IEA02 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public IEA02() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "IEA02";
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
