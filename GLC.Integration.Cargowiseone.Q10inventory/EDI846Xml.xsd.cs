namespace GLC.Integration.Cargowiseone.Q10inventory {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://schemas.microsoft.com/BizTalk/EDI/X12/2006/InterchangeXML",@"X12InterchangeXml")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"X12InterchangeXml"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"GLC.Integration.Cargowiseone.Q10inventory.EDI846Xml2", typeof(global::GLC.Integration.Cargowiseone.Q10inventory.EDI846Xml2))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"GLC.Integration.Cargowiseone.Q10inventory.EDI846Xml1", typeof(global::GLC.Integration.Cargowiseone.Q10inventory.EDI846Xml1))]
    public sealed class EDI846Xml : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""http://schemas.microsoft.com/Edi/X12ServiceSchema"" xmlns:ins0=""http://schemas.microsoft.com/BizTalk/EDI/X12/2006/InterchangeXML"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://schemas.microsoft.com/BizTalk/EDI/X12/2006/InterchangeXML"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""GLC.Integration.Cargowiseone.Q10inventory.EDI846Xml2"" />
  <xs:import schemaLocation=""GLC.Integration.Cargowiseone.Q10inventory.EDI846Xml1"" namespace=""http://schemas.microsoft.com/Edi/X12ServiceSchema"" />
  <xs:annotation>
    <xs:appinfo>
      <b:references>
        <b:reference targetNamespace=""http://schemas.microsoft.com/BizTalk/EDI/X12/2006"" />
        <b:reference targetNamespace=""http://schemas.microsoft.com/Edi/X12ServiceSchema"" />
      </b:references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""X12InterchangeXml"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:ISA"" />
        <xs:element ref=""FunctionalGroup"" />
        <xs:element ref=""ns0:IEA"" />
      </xs:sequence>
      <xs:attribute name=""DelimiterSetSerializedData"" type=""xs:string"" use=""required"" />
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public EDI846Xml() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "X12InterchangeXml";
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
