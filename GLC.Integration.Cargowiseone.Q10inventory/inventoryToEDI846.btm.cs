namespace GLC.Integration.Cargowiseone.Q10inventory {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"GLC.Integration.Cargowiseone.Q10inventory.inventoryflatfile", typeof(global::GLC.Integration.Cargowiseone.Q10inventory.inventoryflatfile))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"GLC.Integration.Cargowiseone.Q10inventory.X12_00401_846", typeof(global::GLC.Integration.Cargowiseone.Q10inventory.X12_00401_846))]
    public sealed class inventoryToEDI846 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://schemas.microsoft.com/BizTalk/EDI/X12/2006"" xmlns:s0=""http://GLC.Integration.Cargowiseone.Q10inventory.inventoryflatfile""  xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"" xmlns:ScriptNS0=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Root"" />
  </xsl:template>
  <xsl:template match=""/s0:Root"">
       <ns0:X12_00401_846>
         <ns0:ST>
           <ST01>846</ST01>
           <ST02>04010</ST02>
         </ns0:ST>
         <ns0:BIA>
           <BIA01>00</BIA01>
           <BIA02>SI</BIA02>
           <BIA03>
        <xsl:value-of select=""userCSharp:Getdatetimeformat()"" />
         </BIA03>
         <BIA04>
        <xsl:value-of select=""userCSharp:Getdateformat()"" />
         </BIA04>
         <BIA05>
        <xsl:value-of select=""userCSharp:Gettimeformat()"" />
         </BIA05>
         </ns0:BIA>           
            <ns0:LINLoop1>
              <xsl:for-each select=""Root_Child1"">
                <xsl:value-of select=""userCSharp:setcnt()"" />
                <ns0:LIN>
                  <ns0:LIN02>VN</ns0:LIN02>                  
                  <LIN03>
                    <xsl:value-of select=""userCSharp:replacefunc(Product/text())"" />
                  </LIN03>
                  <LIN04>DP</LIN04>
                  <LIN05>N</LIN05>
                </ns0:LIN>              
              <ns0:QTYLoop1>               
                  <ns0:QTY>
                    <QTY01>33</QTY01>
                    <QTY02>
                      <xsl:value-of select=""userCSharp:replacefunc(Quantity/text())"" />
                    </QTY02>
                    <ns0:C001_8>
                      <C00101>EA</C00101>
                        <!--<xsl:value-of select=""userCSharp:replacefunc(Unit/text())"" />-->                      
                    </ns0:C001_8>
                  </ns0:QTY>               
              </ns0:QTYLoop1>
              </xsl:for-each>
            </ns0:LINLoop1>
         <ns0:CTT>
           <CTT01> <xsl:value-of select=""userCSharp:getcnt()"" /> </CTT01>
       </ns0:CTT>
       <xsl:value-of select=""userCSharp:emptycnt()"" />
          </ns0:X12_00401_846>
        </xsl:template>

  <msxsl:script language=""C#"" implements-prefix=""userCSharp"">
    <![CDATA[
    
    
    public int a=0;
    
    public void setcnt()
    {
     a= a+1;
     }
    public int getcnt()
    {
    return a;
    }
     public void emptycnt()
     {
      a=0;
      }
    public int getdiff(int a1,int a2)
    {
         int a11=a1-a2;
         return a11;
    }
    
    public string replacefunc(string strin)
    {
    strin=strin.Replace(""\"""","""");
    return strin;
    }    
    public string Getdateformat()
    {
    string strin="""";
           DateTime dt2 = DateTime.Now;
           
            strin = dt2.ToString(""yyyyMMdd"");
            return strin;
    }
     public string Getdatetimeformat()
    {
           DateTime dt3 = DateTime.Now;
            string strin="""";
            strin = dt3.ToString(""yyyyMMddHHmm"");
            return strin;
    }
     public string Gettimeformat()
    {
           DateTime dt4 =DateTime.Now;
            string strin="""";
            strin = dt4.ToString(""HHmm"");
            return strin;
    }
public bool LogicalEq(string val1, string val2)
{
	bool ret = false;
	double d1 = 0;
	double d2 = 0;
	if (IsNumeric(val1, ref d1) && IsNumeric(val2, ref d2))
	{
		ret = d1 == d2;
	}
	else
	{
		ret = String.Compare(val1, val2, StringComparison.Ordinal) == 0;
	}
	return ret;
}


public string StringConcat(string param0)
{
   return param0;
}


public bool IsNumeric(string val)
{
	if (val == null)
	{
		return false;
	}
	double d = 0;
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}

public bool IsNumeric(string val, ref double d)
{
	if (val == null)
	{
		return false;
	}
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}


]]>
  </msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"GLC.Integration.Cargowiseone.Q10inventory.inventoryflatfile";
        
        private const global::GLC.Integration.Cargowiseone.Q10inventory.inventoryflatfile _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"GLC.Integration.Cargowiseone.Q10inventory.X12_00401_846";
        
        private const global::GLC.Integration.Cargowiseone.Q10inventory.X12_00401_846 _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override int UseXSLTransform {
            get {
                return _useXSLTransform;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"GLC.Integration.Cargowiseone.Q10inventory.inventoryflatfile";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"GLC.Integration.Cargowiseone.Q10inventory.X12_00401_846";
                return _TrgSchemas;
            }
        }
    }
}
