﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3082
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by wsdl, Version=2.0.50727.42.
// 
namespace com.google.api.adwords.v200906.AdGroupService {
  using System.Diagnostics;
  using System.Web.Services;
  using System.ComponentModel;
  using System.Web.Services.Protocols;
  using System;
  using System.Xml.Serialization;


  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "AdGroupServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/cm/v200906")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ListReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Operation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ComparableValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Page))]
  public partial class AdGroupService : System.Web.Services.Protocols.SoapHttpClientProtocol {

    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    private System.Threading.SendOrPostCallback getOperationCompleted;

    private System.Threading.SendOrPostCallback mutateOperationCompleted;

    /// <remarks/>
    public AdGroupService() {
      this.Url = "https://adwords-sandbox.google.com/api/adwords/cm/v200906/AdGroupService";
    }

    public RequestHeader RequestHeader {
      get {
        return this.requestHeaderField;
      }
      set {
        this.requestHeaderField = value;
      }
    }

    public ResponseHeader ResponseHeader {
      get {
        return this.responseHeaderField;
      }
      set {
        this.responseHeaderField = value;
      }
    }

    /// <remarks/>
    public event getCompletedEventHandler getCompleted;

    /// <remarks/>
    public event mutateCompletedEventHandler mutateCompleted;

    /// <remarks/>
    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v200906", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v200906", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public AdGroupPage get(AdGroupSelector selector) {
      object[] results = this.Invoke("get", new object[] {
                        selector});
      return ((AdGroupPage) (results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult Beginget(AdGroupSelector selector, System.AsyncCallback callback, object asyncState) {
      return this.BeginInvoke("get", new object[] {
                        selector}, callback, asyncState);
    }

    /// <remarks/>
    public AdGroupPage Endget(System.IAsyncResult asyncResult) {
      object[] results = this.EndInvoke(asyncResult);
      return ((AdGroupPage) (results[0]));
    }

    /// <remarks/>
    public void getAsync(AdGroupSelector selector) {
      this.getAsync(selector, null);
    }

    /// <remarks/>
    public void getAsync(AdGroupSelector selector, object userState) {
      if ((this.getOperationCompleted == null)) {
        this.getOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetOperationCompleted);
      }
      this.InvokeAsync("get", new object[] {
                        selector}, this.getOperationCompleted, userState);
    }

    private void OngetOperationCompleted(object arg) {
      if ((this.getCompleted != null)) {
        System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs) (arg));
        this.getCompleted(this, new getCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
      }
    }

    /// <remarks/>
    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v200906", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v200906", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public AdGroupReturnValue mutate([System.Xml.Serialization.XmlElementAttribute("operations")] AdGroupOperation[] operations) {
      object[] results = this.Invoke("mutate", new object[] {
                        operations});
      return ((AdGroupReturnValue) (results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult Beginmutate(AdGroupOperation[] operations, System.AsyncCallback callback, object asyncState) {
      return this.BeginInvoke("mutate", new object[] {
                        operations}, callback, asyncState);
    }

    /// <remarks/>
    public AdGroupReturnValue Endmutate(System.IAsyncResult asyncResult) {
      object[] results = this.EndInvoke(asyncResult);
      return ((AdGroupReturnValue) (results[0]));
    }

    /// <remarks/>
    public void mutateAsync(AdGroupOperation[] operations) {
      this.mutateAsync(operations, null);
    }

    /// <remarks/>
    public void mutateAsync(AdGroupOperation[] operations, object userState) {
      if ((this.mutateOperationCompleted == null)) {
        this.mutateOperationCompleted = new System.Threading.SendOrPostCallback(this.OnmutateOperationCompleted);
      }
      this.InvokeAsync("mutate", new object[] {
                        operations}, this.mutateOperationCompleted, userState);
    }

    private void OnmutateOperationCompleted(object arg) {
      if ((this.mutateCompleted != null)) {
        System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs) (arg));
        this.mutateCompleted(this, new mutateCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
      }
    }

    /// <remarks/>
    public new void CancelAsync(object userState) {
      base.CancelAsync(userState);
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupReturnValue))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200906")]
  public abstract partial class ListReturnValue {

    private string listReturnValueTypeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ListReturnValue.Type")]
    public string ListReturnValueType {
      get {
        return this.listReturnValueTypeField;
      }
      set {
        this.listReturnValueTypeField = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200906")]
  public partial class AdGroupReturnValue : ListReturnValue {

    private AdGroup[] valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("value")]
    public AdGroup[] value {
      get {
        return this.valueField;
      }
      set {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200906")]
  public partial class AdGroup {

    private long idField;

    private bool idFieldSpecified;

    private long campaignIdField;

    private bool campaignIdFieldSpecified;

    private string campaignNameField;

    private string nameField;

    private AdGroupStatus statusField;

    private bool statusFieldSpecified;

    private AdGroupBids bidsField;

    private Stats statsField;

    /// <remarks/>
    public long id {
      get {
        return this.idField;
      }
      set {
        this.idField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool idSpecified {
      get {
        return this.idFieldSpecified;
      }
      set {
        this.idFieldSpecified = value;
      }
    }

    /// <remarks/>
    public long campaignId {
      get {
        return this.campaignIdField;
      }
      set {
        this.campaignIdField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool campaignIdSpecified {
      get {
        return this.campaignIdFieldSpecified;
      }
      set {
        this.campaignIdFieldSpecified = value;
      }
    }

    /// <remarks/>
    public string campaignName {
      get {
        return this.campaignNameField;
      }
      set {
        this.campaignNameField = value;
      }
    }

    /// <remarks/>
    public string name {
      get {
        return this.nameField;
      }
      set {
        this.nameField = value;
      }
    }

    /// <remarks/>
    public AdGroupStatus status {
      get {
        return this.statusField;
      }
      set {
        this.statusField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool statusSpecified {
      get {
        return this.statusFieldSpecified;
      }
      set {
        this.statusFieldSpecified = value;
      }
    }

    /// <remarks/>
    public AdGroupBids bids {
      get {
        return this.bidsField;
      }
      set {
        this.bidsField = value;
      }
    }

    /// <remarks/>
    public Stats stats {
      get {
        return this.statsField;
      }
      set {
        this.statsField = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AdGroup.Status", Namespace = "https://adwords.google.com/api/adwords/cm/v200906")]
  public enum AdGroupStatus {

    /// <remarks/>
    ENABLED,

    /// <remarks/>
    PAUSED,

    /// <remarks/>
    DELETED,
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ManualCPMAdGroupBids))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ManualCPCAdGroupBids))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConversionOptimizerAdGroupBids))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(BudgetOptimizerAdGroupBids))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200906")]
  public abstract partial class AdGroupBids {

    private string adGroupBidsTypeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AdGroupBids.Type")]
    public string AdGroupBidsType {
      get {
        return this.adGroupBidsTypeField;
      }
      set {
        this.adGroupBidsTypeField = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200906")]
  public partial class ManualCPMAdGroupBids : AdGroupBids {

    private Bid maxCpmField;

    /// <remarks/>
    public Bid maxCpm {
      get {
        return this.maxCpmField;
      }
      set {
        this.maxCpmField = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200906")]
  public partial class Bid {

    private Money amountField;

    /// <remarks/>
    public Money amount {
      get {
        return this.amountField;
      }
      set {
        this.amountField = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200906")]
  public partial class Money : ComparableValue {

    private long microAmountField;

    private bool microAmountFieldSpecified;

    /// <remarks/>
    public long microAmount {
      get {
        return this.microAmountField;
      }
      set {
        this.microAmountField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool microAmountSpecified {
      get {
        return this.microAmountFieldSpecified;
      }
      set {
        this.microAmountFieldSpecified = value;
      }
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(NumberValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(LongValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(DoubleValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Money))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200906")]
  public abstract partial class ComparableValue {

    private string comparableValueTypeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ComparableValue.Type")]
    public string ComparableValueType {
      get {
        return this.comparableValueTypeField;
      }
      set {
        this.comparableValueTypeField = value;
      }
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(LongValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(DoubleValue))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200906")]
  public abstract partial class NumberValue : ComparableValue {
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200906")]
  public partial class LongValue : NumberValue {

    private long numberField;

    private bool numberFieldSpecified;

    /// <remarks/>
    public long number {
      get {
        return this.numberField;
      }
      set {
        this.numberField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool numberSpecified {
      get {
        return this.numberFieldSpecified;
      }
      set {
        this.numberFieldSpecified = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200906")]
  public partial class DoubleValue : NumberValue {

    private double numberField;

    private bool numberFieldSpecified;

    /// <remarks/>
    public double number {
      get {
        return this.numberField;
      }
      set {
        this.numberField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool numberSpecified {
      get {
        return this.numberFieldSpecified;
      }
      set {
        this.numberFieldSpecified = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200906")]
  public partial class ManualCPCAdGroupBids : AdGroupBids {

    private Bid keywordMaxCpcField;

    private Bid keywordContentMaxCpcField;

    private Bid siteMaxCpcField;

    /// <remarks/>
    public Bid keywordMaxCpc {
      get {
        return this.keywordMaxCpcField;
      }
      set {
        this.keywordMaxCpcField = value;
      }
    }

    /// <remarks/>
    public Bid keywordContentMaxCpc {
      get {
        return this.keywordContentMaxCpcField;
      }
      set {
        this.keywordContentMaxCpcField = value;
      }
    }

    /// <remarks/>
    public Bid siteMaxCpc {
      get {
        return this.siteMaxCpcField;
      }
      set {
        this.siteMaxCpcField = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200906")]
  public partial class ConversionOptimizerAdGroupBids : AdGroupBids {

    private Bid targetCpaField;

    /// <remarks/>
    public Bid targetCpa {
      get {
        return this.targetCpaField;
      }
      set {
        this.targetCpaField = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200906")]
  public partial class BudgetOptimizerAdGroupBids : AdGroupBids {

    private Bid proxyKeywordMaxCpcField;

    private Bid proxySiteMaxCpcField;

    /// <remarks/>
    public Bid proxyKeywordMaxCpc {
      get {
        return this.proxyKeywordMaxCpcField;
      }
      set {
        this.proxyKeywordMaxCpcField = value;
      }
    }

    /// <remarks/>
    public Bid proxySiteMaxCpc {
      get {
        return this.proxySiteMaxCpcField;
      }
      set {
        this.proxySiteMaxCpcField = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200906")]
  public partial class Stats {

    private string startDateField;

    private string endDateField;

    private StatsNetwork networkField;

    private bool networkFieldSpecified;

    private long clicksField;

    private bool clicksFieldSpecified;

    private long impressionsField;

    private bool impressionsFieldSpecified;

    private Money costField;

    private double averagePositionField;

    private bool averagePositionFieldSpecified;

    private Money averageCpcField;

    private Money averageCpmField;

    private double ctrField;

    private bool ctrFieldSpecified;

    private long conversionsField;

    private bool conversionsFieldSpecified;

    private double conversionRateField;

    private bool conversionRateFieldSpecified;

    private Money costPerConversionField;

    private long conversionsManyPerClickField;

    private bool conversionsManyPerClickFieldSpecified;

    private double conversionRateManyPerClickField;

    private bool conversionRateManyPerClickFieldSpecified;

    private Money costPerConversionManyPerClickField;

    private string statsTypeField;

    /// <remarks/>
    public string startDate {
      get {
        return this.startDateField;
      }
      set {
        this.startDateField = value;
      }
    }

    /// <remarks/>
    public string endDate {
      get {
        return this.endDateField;
      }
      set {
        this.endDateField = value;
      }
    }

    /// <remarks/>
    public StatsNetwork network {
      get {
        return this.networkField;
      }
      set {
        this.networkField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool networkSpecified {
      get {
        return this.networkFieldSpecified;
      }
      set {
        this.networkFieldSpecified = value;
      }
    }

    /// <remarks/>
    public long clicks {
      get {
        return this.clicksField;
      }
      set {
        this.clicksField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool clicksSpecified {
      get {
        return this.clicksFieldSpecified;
      }
      set {
        this.clicksFieldSpecified = value;
      }
    }

    /// <remarks/>
    public long impressions {
      get {
        return this.impressionsField;
      }
      set {
        this.impressionsField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool impressionsSpecified {
      get {
        return this.impressionsFieldSpecified;
      }
      set {
        this.impressionsFieldSpecified = value;
      }
    }

    /// <remarks/>
    public Money cost {
      get {
        return this.costField;
      }
      set {
        this.costField = value;
      }
    }

    /// <remarks/>
    public double averagePosition {
      get {
        return this.averagePositionField;
      }
      set {
        this.averagePositionField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool averagePositionSpecified {
      get {
        return this.averagePositionFieldSpecified;
      }
      set {
        this.averagePositionFieldSpecified = value;
      }
    }

    /// <remarks/>
    public Money averageCpc {
      get {
        return this.averageCpcField;
      }
      set {
        this.averageCpcField = value;
      }
    }

    /// <remarks/>
    public Money averageCpm {
      get {
        return this.averageCpmField;
      }
      set {
        this.averageCpmField = value;
      }
    }

    /// <remarks/>
    public double ctr {
      get {
        return this.ctrField;
      }
      set {
        this.ctrField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ctrSpecified {
      get {
        return this.ctrFieldSpecified;
      }
      set {
        this.ctrFieldSpecified = value;
      }
    }

    /// <remarks/>
    public long conversions {
      get {
        return this.conversionsField;
      }
      set {
        this.conversionsField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool conversionsSpecified {
      get {
        return this.conversionsFieldSpecified;
      }
      set {
        this.conversionsFieldSpecified = value;
      }
    }

    /// <remarks/>
    public double conversionRate {
      get {
        return this.conversionRateField;
      }
      set {
        this.conversionRateField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool conversionRateSpecified {
      get {
        return this.conversionRateFieldSpecified;
      }
      set {
        this.conversionRateFieldSpecified = value;
      }
    }

    /// <remarks/>
    public Money costPerConversion {
      get {
        return this.costPerConversionField;
      }
      set {
        this.costPerConversionField = value;
      }
    }

    /// <remarks/>
    public long conversionsManyPerClick {
      get {
        return this.conversionsManyPerClickField;
      }
      set {
        this.conversionsManyPerClickField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool conversionsManyPerClickSpecified {
      get {
        return this.conversionsManyPerClickFieldSpecified;
      }
      set {
        this.conversionsManyPerClickFieldSpecified = value;
      }
    }

    /// <remarks/>
    public double conversionRateManyPerClick {
      get {
        return this.conversionRateManyPerClickField;
      }
      set {
        this.conversionRateManyPerClickField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool conversionRateManyPerClickSpecified {
      get {
        return this.conversionRateManyPerClickFieldSpecified;
      }
      set {
        this.conversionRateManyPerClickFieldSpecified = value;
      }
    }

    /// <remarks/>
    public Money costPerConversionManyPerClick {
      get {
        return this.costPerConversionManyPerClickField;
      }
      set {
        this.costPerConversionManyPerClickField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Stats.Type")]
    public string StatsType {
      get {
        return this.statsTypeField;
      }
      set {
        this.statsTypeField = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Stats.Network", Namespace = "https://adwords.google.com/api/adwords/cm/v200906")]
  public enum StatsNetwork {

    /// <remarks/>
    SEARCH,

    /// <remarks/>
    GOOGLE_SEARCH,

    /// <remarks/>
    SEARCH_NETWORK,

    /// <remarks/>
    CONTENT,

    /// <remarks/>
    CONTENT_KEYWORD_BID,

    /// <remarks/>
    CONTENT_PLACEMENT_BID,

    /// <remarks/>
    ALL,
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupOperation))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200906")]
  public abstract partial class Operation {

    private Operator operatorField;

    private bool operatorFieldSpecified;

    private string operationTypeField;

    /// <remarks/>
    public Operator @operator {
      get {
        return this.operatorField;
      }
      set {
        this.operatorField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool operatorSpecified {
      get {
        return this.operatorFieldSpecified;
      }
      set {
        this.operatorFieldSpecified = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Operation.Type")]
    public string OperationType {
      get {
        return this.operationTypeField;
      }
      set {
        this.operationTypeField = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200906")]
  public enum Operator {

    /// <remarks/>
    ADD,

    /// <remarks/>
    REMOVE,

    /// <remarks/>
    SET,
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200906")]
  public partial class AdGroupOperation : Operation {

    private AdGroup operandField;

    /// <remarks/>
    public AdGroup operand {
      get {
        return this.operandField;
      }
      set {
        this.operandField = value;
      }
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupPage))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200906")]
  public abstract partial class Page {

    private int totalNumEntriesField;

    private bool totalNumEntriesFieldSpecified;

    private string pageTypeField;

    /// <remarks/>
    public int totalNumEntries {
      get {
        return this.totalNumEntriesField;
      }
      set {
        this.totalNumEntriesField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool totalNumEntriesSpecified {
      get {
        return this.totalNumEntriesFieldSpecified;
      }
      set {
        this.totalNumEntriesFieldSpecified = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Page.Type")]
    public string PageType {
      get {
        return this.pageTypeField;
      }
      set {
        this.pageTypeField = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200906")]
  public partial class AdGroupPage : Page {

    private AdGroup[] entriesField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("entries")]
    public AdGroup[] entries {
      get {
        return this.entriesField;
      }
      set {
        this.entriesField = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200906")]
  public partial class Paging {

    private int startIndexField;

    private bool startIndexFieldSpecified;

    private int numberResultsField;

    private bool numberResultsFieldSpecified;

    /// <remarks/>
    public int startIndex {
      get {
        return this.startIndexField;
      }
      set {
        this.startIndexField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool startIndexSpecified {
      get {
        return this.startIndexFieldSpecified;
      }
      set {
        this.startIndexFieldSpecified = value;
      }
    }

    /// <remarks/>
    public int numberResults {
      get {
        return this.numberResultsField;
      }
      set {
        this.numberResultsField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool numberResultsSpecified {
      get {
        return this.numberResultsFieldSpecified;
      }
      set {
        this.numberResultsFieldSpecified = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200906")]
  public partial class DateRange {

    private string minField;

    private string maxField;

    /// <remarks/>
    public string min {
      get {
        return this.minField;
      }
      set {
        this.minField = value;
      }
    }

    /// <remarks/>
    public string max {
      get {
        return this.maxField;
      }
      set {
        this.maxField = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200906")]
  public partial class StatsSelector {

    private DateRange dateRangeField;

    /// <remarks/>
    public DateRange dateRange {
      get {
        return this.dateRangeField;
      }
      set {
        this.dateRangeField = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200906")]
  public partial class AdGroupSelector {

    private long campaignIdField;

    private bool campaignIdFieldSpecified;

    private long[] adGroupIdsField;

    private StatsSelector statsSelectorField;

    private Paging pagingField;

    /// <remarks/>
    public long campaignId {
      get {
        return this.campaignIdField;
      }
      set {
        this.campaignIdField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool campaignIdSpecified {
      get {
        return this.campaignIdFieldSpecified;
      }
      set {
        this.campaignIdFieldSpecified = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("adGroupIds")]
    public long[] adGroupIds {
      get {
        return this.adGroupIdsField;
      }
      set {
        this.adGroupIdsField = value;
      }
    }

    /// <remarks/>
    public StatsSelector statsSelector {
      get {
        return this.statsSelectorField;
      }
      set {
        this.statsSelectorField = value;
      }
    }

    /// <remarks/>
    public Paging paging {
      get {
        return this.pagingField;
      }
      set {
        this.pagingField = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
  public delegate void getCompletedEventHandler(object sender, getCompletedEventArgs e);

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  public partial class getCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {

    private object[] results;

    internal getCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState)
      :
            base(exception, cancelled, userState) {
      this.results = results;
    }

    /// <remarks/>
    public AdGroupPage Result {
      get {
        this.RaiseExceptionIfNecessary();
        return ((AdGroupPage) (this.results[0]));
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
  public delegate void mutateCompletedEventHandler(object sender, mutateCompletedEventArgs e);

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  public partial class mutateCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {

    private object[] results;

    internal mutateCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState)
      :
            base(exception, cancelled, userState) {
      this.results = results;
    }

    /// <remarks/>
    public AdGroupReturnValue Result {
      get {
        this.RaiseExceptionIfNecessary();
        return ((AdGroupReturnValue) (this.results[0]));
      }
    }
  }
}
