﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// Этот исходный код был создан с помощью xsd, версия=4.0.30319.33440.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class АккредитованныеУдостоверяющиеЦентры {
    
    private int версияField;
    
    private System.DateTime датаField;
    
    private АккредитованныеУдостоверяющиеЦентрыУдостоверяющийЦентр[] удостоверяющийЦентрField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public int Версия {
        get {
            return this.версияField;
        }
        set {
            this.версияField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public System.DateTime Дата {
        get {
            return this.датаField;
        }
        set {
            this.датаField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("УдостоверяющийЦентр", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public АккредитованныеУдостоверяющиеЦентрыУдостоверяющийЦентр[] УдостоверяющийЦентр {
        get {
            return this.удостоверяющийЦентрField;
        }
        set {
            this.удостоверяющийЦентрField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class АккредитованныеУдостоверяющиеЦентрыУдостоверяющийЦентр {
    
    private string названиеField;
    
    private string электроннаяПочтаField;
    
    private string краткоеНазваниеField;
    
    private string адресСИнформациейПоУЦField;
    
    private string адресСИнформациейПоРеестрамСертификатовField;
    
    private АдресТип адресField;
    
    private АккредитованныеУдостоверяющиеЦентрыУдостоверяющийЦентрПрограммноАппаратныйКомплекс[] программноАппаратныеКомплексыField;
    
    private string иННField;
    
    private string оГРНField;
    
    private int реестровыйНомерField;
    
    private СтатусАккредитацииТип статусАккредитацииField;
    
    private СтатусАккредитацииТип[] историяСтатусовАккредитацииField;
    
    private object полномочияПереданыУЦсОГРНField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Название {
        get {
            return this.названиеField;
        }
        set {
            this.названиеField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string ЭлектроннаяПочта {
        get {
            return this.электроннаяПочтаField;
        }
        set {
            this.электроннаяПочтаField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string КраткоеНазвание {
        get {
            return this.краткоеНазваниеField;
        }
        set {
            this.краткоеНазваниеField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string АдресСИнформациейПоУЦ {
        get {
            return this.адресСИнформациейПоУЦField;
        }
        set {
            this.адресСИнформациейПоУЦField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string АдресСИнформациейПоРеестрамСертификатов {
        get {
            return this.адресСИнформациейПоРеестрамСертификатовField;
        }
        set {
            this.адресСИнформациейПоРеестрамСертификатовField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public АдресТип Адрес {
        get {
            return this.адресField;
        }
        set {
            this.адресField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute("ПрограммноАппаратныйКомплекс", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
    public АккредитованныеУдостоверяющиеЦентрыУдостоверяющийЦентрПрограммноАппаратныйКомплекс[] ПрограммноАппаратныеКомплексы {
        get {
            return this.программноАппаратныеКомплексыField;
        }
        set {
            this.программноАппаратныеКомплексыField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string ИНН {
        get {
            return this.иННField;
        }
        set {
            this.иННField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string ОГРН {
        get {
            return this.оГРНField;
        }
        set {
            this.оГРНField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public int РеестровыйНомер {
        get {
            return this.реестровыйНомерField;
        }
        set {
            this.реестровыйНомерField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public СтатусАккредитацииТип СтатусАккредитации {
        get {
            return this.статусАккредитацииField;
        }
        set {
            this.статусАккредитацииField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute("СтатусАккредитации", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
    public СтатусАккредитацииТип[] ИсторияСтатусовАккредитации {
        get {
            return this.историяСтатусовАккредитацииField;
        }
        set {
            this.историяСтатусовАккредитацииField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public object ПолномочияПереданыУЦсОГРН {
        get {
            return this.полномочияПереданыУЦсОГРНField;
        }
        set {
            this.полномочияПереданыУЦсОГРНField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class АдресТип {
    
    private string странаField;
    
    private РегионТип регионField;
    
    private string индексField;
    
    private string улицаДомField;
    
    private string городField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Страна {
        get {
            return this.странаField;
        }
        set {
            this.странаField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public РегионТип Регион {
        get {
            return this.регионField;
        }
        set {
            this.регионField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Индекс {
        get {
            return this.индексField;
        }
        set {
            this.индексField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string УлицаДом {
        get {
            return this.улицаДомField;
        }
        set {
            this.улицаДомField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Город {
        get {
            return this.городField;
        }
        set {
            this.городField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class РегионТип {
    
    private string кодField;
    
    private string названиеField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="integer")]
    public string Код {
        get {
            return this.кодField;
        }
        set {
            this.кодField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Название {
        get {
            return this.названиеField;
        }
        set {
            this.названиеField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ДанныеСертификатаТип {
    
    private string отпечатокField;
    
    private string кемВыданField;
    
    private string комуВыданField;
    
    private string серийныйНомерField;
    
    private System.DateTime периодДействияСField;
    
    private System.DateTime периодДействияДоField;
    
    private byte[] данныеField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Отпечаток {
        get {
            return this.отпечатокField;
        }
        set {
            this.отпечатокField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string КемВыдан {
        get {
            return this.кемВыданField;
        }
        set {
            this.кемВыданField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string КомуВыдан {
        get {
            return this.комуВыданField;
        }
        set {
            this.комуВыданField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string СерийныйНомер {
        get {
            return this.серийныйНомерField;
        }
        set {
            this.серийныйНомерField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public System.DateTime ПериодДействияС {
        get {
            return this.периодДействияСField;
        }
        set {
            this.периодДействияСField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public System.DateTime ПериодДействияДо {
        get {
            return this.периодДействияДоField;
        }
        set {
            this.периодДействияДоField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary")]
    public byte[] Данные {
        get {
            return this.данныеField;
        }
        set {
            this.данныеField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class СтатусАккредитацииТип {
    
    private СтатусАккредитацииТипСтатус статусField;
    
    private System.DateTime действуетСField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public СтатусАккредитацииТипСтатус Статус {
        get {
            return this.статусField;
        }
        set {
            this.статусField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public System.DateTime ДействуетС {
        get {
            return this.действуетСField;
        }
        set {
            this.действуетСField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public enum СтатусАккредитацииТипСтатус {
    
    /// <remarks/>
    Приостановлена,
    
    /// <remarks/>
    Прекращена,
    
    /// <remarks/>
    Действует,
    
    /// <remarks/>
    Аннулирована,
    
    /// <remarks/>
    Неизвестно,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class АккредитованныеУдостоверяющиеЦентрыУдостоверяющийЦентрПрограммноАппаратныйКомплекс {
    
    private string псевдонимField;
    
    private АккредитованныеУдостоверяющиеЦентрыУдостоверяющийЦентрПрограммноАппаратныйКомплексКлассСредствЭП классСредствЭПField;
    
    private АдресТип адресField;
    
    private string средстваУЦField;
    
    private АккредитованныеУдостоверяющиеЦентрыУдостоверяющийЦентрПрограммноАппаратныйКомплексКлюч[] ключиУполномоченныхЛицField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Псевдоним {
        get {
            return this.псевдонимField;
        }
        set {
            this.псевдонимField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public АккредитованныеУдостоверяющиеЦентрыУдостоверяющийЦентрПрограммноАппаратныйКомплексКлассСредствЭП КлассСредствЭП {
        get {
            return this.классСредствЭПField;
        }
        set {
            this.классСредствЭПField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public АдресТип Адрес {
        get {
            return this.адресField;
        }
        set {
            this.адресField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string СредстваУЦ {
        get {
            return this.средстваУЦField;
        }
        set {
            this.средстваУЦField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute("Ключ", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
    public АккредитованныеУдостоверяющиеЦентрыУдостоверяющийЦентрПрограммноАппаратныйКомплексКлюч[] КлючиУполномоченныхЛиц {
        get {
            return this.ключиУполномоченныхЛицField;
        }
        set {
            this.ключиУполномоченныхЛицField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public enum АккредитованныеУдостоверяющиеЦентрыУдостоверяющийЦентрПрограммноАппаратныйКомплексКлассСредствЭП {
    
    /// <remarks/>
    КС1,
    
    /// <remarks/>
    КС2,
    
    /// <remarks/>
    КС3,
    
    /// <remarks/>
    КВ1,
    
    /// <remarks/>
    КВ2,
    
    /// <remarks/>
    КА1,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class АккредитованныеУдостоверяющиеЦентрыУдостоверяющийЦентрПрограммноАппаратныйКомплексКлюч {
    
    private object идентификаторКлючаField;
    
    private string[] адресаСписковОтзываField;
    
    private ДанныеСертификатаТип[] сертификатыField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public object ИдентификаторКлюча {
        get {
            return this.идентификаторКлючаField;
        }
        set {
            this.идентификаторКлючаField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute("Адрес", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
    public string[] АдресаСписковОтзыва {
        get {
            return this.адресаСписковОтзываField;
        }
        set {
            this.адресаСписковОтзываField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute("ДанныеСертификата", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
    public ДанныеСертификатаТип[] Сертификаты {
        get {
            return this.сертификатыField;
        }
        set {
            this.сертификатыField = value;
        }
    }
}
