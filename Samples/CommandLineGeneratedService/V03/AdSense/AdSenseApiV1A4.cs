// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Google.Apis.Samples.CommandLineGeneratedService.V03.AdSenseApiV1A4.Data {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    
    
    public class AdClient {
        
        private string id;
        
        private string kind;
        
        private string name;
        
        private bool supportsReporting;
        
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id {
            get {
                return this.id;
            }
            set {
                this.id = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind {
            get {
                return this.kind;
            }
            set {
                this.kind = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name {
            get {
                return this.name;
            }
            set {
                this.name = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("supportsReporting")]
        public virtual bool SupportsReporting {
            get {
                return this.supportsReporting;
            }
            set {
                this.supportsReporting = value;
            }
        }
    }
    
    public class AdClients {
        
        private string etag;
        
        private IList<AdClient> items;
        
        private string kind;
        
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string Etag {
            get {
                return this.etag;
            }
            set {
                this.etag = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual IList<AdClient> Items {
            get {
                return this.items;
            }
            set {
                this.items = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind {
            get {
                return this.kind;
            }
            set {
                this.kind = value;
            }
        }
    }
    
    public class AdUnit {
        
        private string code;
        
        private string id;
        
        private string kind;
        
        private string name;
        
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code {
            get {
                return this.code;
            }
            set {
                this.code = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id {
            get {
                return this.id;
            }
            set {
                this.id = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind {
            get {
                return this.kind;
            }
            set {
                this.kind = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name {
            get {
                return this.name;
            }
            set {
                this.name = value;
            }
        }
    }
    
    public class AdUnits {
        
        private string etag;
        
        private IList<AdUnit> items;
        
        private string kind;
        
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string Etag {
            get {
                return this.etag;
            }
            set {
                this.etag = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual IList<AdUnit> Items {
            get {
                return this.items;
            }
            set {
                this.items = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind {
            get {
                return this.kind;
            }
            set {
                this.kind = value;
            }
        }
    }
    
    public class AdsenseReportsGenerateRequest {
        
        private string currency;
        
        private NestedClass1 daterangeField1;
        
        private IList<System.String> dimensions;
        
        private string locale;
        
        private IList<System.String> metrics;
        
        private NestedClass2 pagination;
        
        private NestedClass3 scope;
        
        private IList<NestedClass4> sorts;
        
        [Newtonsoft.Json.JsonPropertyAttribute("currency")]
        public virtual string Currency {
            get {
                return this.currency;
            }
            set {
                this.currency = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("date_range")]
        public virtual NestedClass1 DaterangeProperty1 {
            get {
                return this.daterangeField1;
            }
            set {
                this.daterangeField1 = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("dimensions")]
        public virtual IList<System.String> Dimensions {
            get {
                return this.dimensions;
            }
            set {
                this.dimensions = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("locale")]
        public virtual string Locale {
            get {
                return this.locale;
            }
            set {
                this.locale = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
        public virtual IList<System.String> Metrics {
            get {
                return this.metrics;
            }
            set {
                this.metrics = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("pagination")]
        public virtual NestedClass2 Pagination {
            get {
                return this.pagination;
            }
            set {
                this.pagination = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public virtual NestedClass3 Scope {
            get {
                return this.scope;
            }
            set {
                this.scope = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("sorts")]
        public virtual IList<NestedClass4> Sorts {
            get {
                return this.sorts;
            }
            set {
                this.sorts = value;
            }
        }
        
        public class NestedClass1 {
            
            private string enddateField0;
            
            private string startdateField1;
            
            [Newtonsoft.Json.JsonPropertyAttribute("end_date")]
            public virtual string EnddateProperty0 {
                get {
                    return this.enddateField0;
                }
                set {
                    this.enddateField0 = value;
                }
            }
            
            [Newtonsoft.Json.JsonPropertyAttribute("start_date")]
            public virtual string StartdateProperty1 {
                get {
                    return this.startdateField1;
                }
                set {
                    this.startdateField1 = value;
                }
            }
        }
        
        public class NestedClass2 {
            
            private long rowcountField0;
            
            private long startrowField1;
            
            [Newtonsoft.Json.JsonPropertyAttribute("row_count")]
            public virtual long RowcountProperty0 {
                get {
                    return this.rowcountField0;
                }
                set {
                    this.rowcountField0 = value;
                }
            }
            
            [Newtonsoft.Json.JsonPropertyAttribute("start_row")]
            public virtual long StartrowProperty1 {
                get {
                    return this.startrowField1;
                }
                set {
                    this.startrowField1 = value;
                }
            }
        }
        
        public class NestedClass3 {
            
            private IList<System.String> adclientidsField0;
            
            private IList<System.String> adunitidsField1;
            
            private IList<System.String> customchannelidsField2;
            
            private IList<System.String> urlchannelidsField3;
            
            [Newtonsoft.Json.JsonPropertyAttribute("ad_client_ids")]
            public virtual IList<System.String> AdclientidsProperty0 {
                get {
                    return this.adclientidsField0;
                }
                set {
                    this.adclientidsField0 = value;
                }
            }
            
            [Newtonsoft.Json.JsonPropertyAttribute("ad_unit_ids")]
            public virtual IList<System.String> AdunitidsProperty1 {
                get {
                    return this.adunitidsField1;
                }
                set {
                    this.adunitidsField1 = value;
                }
            }
            
            [Newtonsoft.Json.JsonPropertyAttribute("custom_channel_ids")]
            public virtual IList<System.String> CustomchannelidsProperty2 {
                get {
                    return this.customchannelidsField2;
                }
                set {
                    this.customchannelidsField2 = value;
                }
            }
            
            [Newtonsoft.Json.JsonPropertyAttribute("url_channel_ids")]
            public virtual IList<System.String> UrlchannelidsProperty3 {
                get {
                    return this.urlchannelidsField3;
                }
                set {
                    this.urlchannelidsField3 = value;
                }
            }
        }
        
        public class NestedClass4 {
            
            private string column;
            
            private bool descending;
            
            [Newtonsoft.Json.JsonPropertyAttribute("column")]
            public virtual string Column {
                get {
                    return this.column;
                }
                set {
                    this.column = value;
                }
            }
            
            [Newtonsoft.Json.JsonPropertyAttribute("descending")]
            public virtual bool Descending {
                get {
                    return this.descending;
                }
                set {
                    this.descending = value;
                }
            }
        }
    }
    
    public class AdsenseReportsGenerateResponse {
        
        private IList<NestedClass1> headers;
        
        private IList<IList<System.String>> rows;
        
        private long totalmatchedrowsField2;
        
        [Newtonsoft.Json.JsonPropertyAttribute("headers")]
        public virtual IList<NestedClass1> Headers {
            get {
                return this.headers;
            }
            set {
                this.headers = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual IList<IList<System.String>> Rows {
            get {
                return this.rows;
            }
            set {
                this.rows = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("total_matched_rows")]
        public virtual long TotalmatchedrowsProperty2 {
            get {
                return this.totalmatchedrowsField2;
            }
            set {
                this.totalmatchedrowsField2 = value;
            }
        }
        
        public class NestedClass1 {
            
            private string name;
            
            private string type;
            
            [Newtonsoft.Json.JsonPropertyAttribute("name")]
            public virtual string Name {
                get {
                    return this.name;
                }
                set {
                    this.name = value;
                }
            }
            
            [Newtonsoft.Json.JsonPropertyAttribute("type")]
            public virtual string Type {
                get {
                    return this.type;
                }
                set {
                    this.type = value;
                }
            }
        }
    }
    
    public class CustomChannel {
        
        private string code;
        
        private string id;
        
        private string kind;
        
        private string name;
        
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code {
            get {
                return this.code;
            }
            set {
                this.code = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id {
            get {
                return this.id;
            }
            set {
                this.id = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind {
            get {
                return this.kind;
            }
            set {
                this.kind = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name {
            get {
                return this.name;
            }
            set {
                this.name = value;
            }
        }
    }
    
    public class CustomChannels {
        
        private string etag;
        
        private IList<CustomChannel> items;
        
        private string kind;
        
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string Etag {
            get {
                return this.etag;
            }
            set {
                this.etag = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual IList<CustomChannel> Items {
            get {
                return this.items;
            }
            set {
                this.items = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind {
            get {
                return this.kind;
            }
            set {
                this.kind = value;
            }
        }
    }
    
    public class UrlChannel {
        
        private string id;
        
        private string kind;
        
        private string urlPattern;
        
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id {
            get {
                return this.id;
            }
            set {
                this.id = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind {
            get {
                return this.kind;
            }
            set {
                this.kind = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("urlPattern")]
        public virtual string UrlPattern {
            get {
                return this.urlPattern;
            }
            set {
                this.urlPattern = value;
            }
        }
    }
    
    public class UrlChannels {
        
        private string etag;
        
        private IList<UrlChannel> items;
        
        private string kind;
        
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string Etag {
            get {
                return this.etag;
            }
            set {
                this.etag = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual IList<UrlChannel> Items {
            get {
                return this.items;
            }
            set {
                this.items = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind {
            get {
                return this.kind;
            }
            set {
                this.kind = value;
            }
        }
    }
}
namespace Google.Apis.Samples.CommandLineGeneratedService.V03.AdSenseApiV1A4 {
    using System;
    using System.IO;
    using System.Collections.Generic;
    using Google.Apis;
    using Google.Apis.Discovery;
    
    
    public class AdsenseService : Google.Apis.Discovery.IRequestExecutor, Google.Apis.Discovery.ISchemaAwareRequestExecutor {
        
        private Google.Apis.Discovery.IService genericService;
        
        private Google.Apis.Authentication.IAuthenticator authenticator;
        
        private const string Version = "v1";
        
        private const string Name = "adsense";
        
        private const string BaseUri = "http://example.url.com/adsense/v1alpha4/";
        
        private const Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_0_3;
        
        private Newtonsoft.Json.JsonSerializer newtonJsonSerilizer = null;
        
        private Adclients adclients;
        
        private Adunits adunits;
        
        private Customchannels customchannels;
        
        private Reports reports;
        
        private Urlchannels urlchannels;
        
        public AdsenseService(Google.Apis.Discovery.IService genericService, Google.Apis.Authentication.IAuthenticator authenticator) {
            this.genericService = genericService;
            this.authenticator = authenticator;
            this.adclients = new Adclients(this);
            this.adunits = new Adunits(this);
            this.customchannels = new Customchannels(this);
            this.reports = new Reports(this);
            this.urlchannels = new Urlchannels(this);
        }
        
        public AdsenseService() : 
                this(new Google.Apis.Discovery.DiscoveryService(new Google.Apis.Discovery.WebDiscoveryDevice(new System.Uri((string.Format("https://www.googleapis.com/discovery/v0.3/describe/{0}/{1}", AdsenseService.Name, AdsenseService.Version) + AdsenseService.Name)))).GetService(AdsenseService.Version, AdsenseService.DiscoveryVersionUsed, new Google.Apis.Discovery.FactoryParameterV0_3(null, AdsenseService.BaseUri)), Google.Apis.Authentication.AuthenticatorFactory.GetInstance().GetRegisteredAuthenticator()) {
        }
        
        private Newtonsoft.Json.JsonSerializer NewtonJsonSerilizer {
            get {
                if ((this.newtonJsonSerilizer == null)) {
                    Newtonsoft.Json.JsonSerializerSettings settings = new Newtonsoft.Json.JsonSerializerSettings();
                    settings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
                    this.newtonJsonSerilizer = Newtonsoft.Json.JsonSerializer.Create(settings);
                }
                return this.newtonJsonSerilizer;
            }
        }
        
        public virtual Adclients Adclients {
            get {
                return this.adclients;
            }
        }
        
        public virtual Adunits Adunits {
            get {
                return this.adunits;
            }
        }
        
        public virtual Customchannels Customchannels {
            get {
                return this.customchannels;
            }
        }
        
        public virtual Reports Reports {
            get {
                return this.reports;
            }
        }
        
        public virtual Urlchannels Urlchannels {
            get {
                return this.urlchannels;
            }
        }
        
        public virtual System.IO.Stream ExecuteRequest(string resource, string method, string body, System.Collections.Generic.IDictionary<string, string> parameters) {
            Google.Apis.Requests.IRequest request = this.genericService.CreateRequest(resource, method);
            return request.WithParameters(parameters).WithAuthentication(authenticator).WithBody(body).ExecuteRequest();
        }
        
        public virtual System.IO.Stream ExecuteRequest(string resource, string method, object body, System.Collections.Generic.IDictionary<string, string> parameters) {
            return this.ExecuteRequest(resource, method, this.ObjectToJson(body), parameters);
        }
        
        public virtual string ObjectToJson(object obj) {
            System.IO.TextWriter tw = new System.IO.StringWriter();
            this.NewtonJsonSerilizer.Serialize(tw, obj);
            return tw.ToString();
        }
        
        public virtual TOutput JsonToObject<TOutput>(System.IO.Stream stream)
         {
            System.IO.StreamReader streamReader = new System.IO.StreamReader(stream);
            string str = streamReader.ReadToEnd();
            try {
                return Newtonsoft.Json.JsonConvert.DeserializeObject <TOutput>(str);
            }
            catch (System.Exception ex) {
                throw new System.ApplicationException(string.Format("Failed to generate object of type[{0}] from Json[{1}]", typeof(TOutput).Name, str), ex);
            }
        }
    }
    
    public class Adclients {
        
        private Google.Apis.Discovery.ISchemaAwareRequestExecutor service;
        
        private const string Resource = "adclients";
        
        private log4net.ILog logger = log4net.LogManager.GetLogger(typeof(Adclients));
        
        public Adclients(AdsenseService service) {
            this.service = service;
        }
        
        public virtual System.IO.Stream List() {
            string body = null;
            System.Collections.Generic.Dictionary<string, string> parameters = new System.Collections.Generic.Dictionary<string, string>();
            logger.Debug("Executing adclients.list");
            System.IO.Stream ret = this.service.ExecuteRequest(Adclients.Resource, "list", body, parameters);
            logger.Debug("Done Executing adclients.list");
            return ret;
        }
        
        public virtual Google.Apis.Samples.CommandLineGeneratedService.V03.AdSenseApiV1A4.Data.AdClients ListAsObject() {
            string body = null;
            System.Collections.Generic.Dictionary<string, string> parameters = new System.Collections.Generic.Dictionary<string, string>();
            logger.Debug("Executing adclients.list");
            Google.Apis.Samples.CommandLineGeneratedService.V03.AdSenseApiV1A4.Data.AdClients ret = this.service.JsonToObject <Google.Apis.Samples.CommandLineGeneratedService.V03.AdSenseApiV1A4.Data.AdClients>(this.service.ExecuteRequest(Adclients.Resource, "list", body, parameters));
            logger.Debug("Done Executing adclients.list");
            return ret;
        }
    }
    
    public class Adunits {
        
        private Google.Apis.Discovery.ISchemaAwareRequestExecutor service;
        
        private const string Resource = "adunits";
        
        private log4net.ILog logger = log4net.LogManager.GetLogger(typeof(Adunits));
        
        public Adunits(AdsenseService service) {
            this.service = service;
        }
        
        public virtual System.IO.Stream List(string adclientidParam1) {
            string body = null;
            System.Collections.Generic.Dictionary<string, string> parameters = new System.Collections.Generic.Dictionary<string, string>();
            parameters["ad_client_id"] = adclientidParam1;
            logger.Debug("Executing adunits.list");
            System.IO.Stream ret = this.service.ExecuteRequest(Adunits.Resource, "list", body, parameters);
            logger.Debug("Done Executing adunits.list");
            return ret;
        }
        
        public virtual Google.Apis.Samples.CommandLineGeneratedService.V03.AdSenseApiV1A4.Data.AdUnits ListAsObject(string adclientidParam1) {
            string body = null;
            System.Collections.Generic.Dictionary<string, string> parameters = new System.Collections.Generic.Dictionary<string, string>();
            parameters["ad_client_id"] = adclientidParam1;
            logger.Debug("Executing adunits.list");
            Google.Apis.Samples.CommandLineGeneratedService.V03.AdSenseApiV1A4.Data.AdUnits ret = this.service.JsonToObject <Google.Apis.Samples.CommandLineGeneratedService.V03.AdSenseApiV1A4.Data.AdUnits>(this.service.ExecuteRequest(Adunits.Resource, "list", body, parameters));
            logger.Debug("Done Executing adunits.list");
            return ret;
        }
    }
    
    public class Customchannels {
        
        private Google.Apis.Discovery.ISchemaAwareRequestExecutor service;
        
        private const string Resource = "customchannels";
        
        private log4net.ILog logger = log4net.LogManager.GetLogger(typeof(Customchannels));
        
        public Customchannels(AdsenseService service) {
            this.service = service;
        }
        
        public virtual System.IO.Stream List(string adclientidParam1) {
            string body = null;
            System.Collections.Generic.Dictionary<string, string> parameters = new System.Collections.Generic.Dictionary<string, string>();
            parameters["ad_client_id"] = adclientidParam1;
            logger.Debug("Executing customchannels.list");
            System.IO.Stream ret = this.service.ExecuteRequest(Customchannels.Resource, "list", body, parameters);
            logger.Debug("Done Executing customchannels.list");
            return ret;
        }
        
        public virtual Google.Apis.Samples.CommandLineGeneratedService.V03.AdSenseApiV1A4.Data.CustomChannels ListAsObject(string adclientidParam1) {
            string body = null;
            System.Collections.Generic.Dictionary<string, string> parameters = new System.Collections.Generic.Dictionary<string, string>();
            parameters["ad_client_id"] = adclientidParam1;
            logger.Debug("Executing customchannels.list");
            Google.Apis.Samples.CommandLineGeneratedService.V03.AdSenseApiV1A4.Data.CustomChannels ret = this.service.JsonToObject <Google.Apis.Samples.CommandLineGeneratedService.V03.AdSenseApiV1A4.Data.CustomChannels>(this.service.ExecuteRequest(Customchannels.Resource, "list", body, parameters));
            logger.Debug("Done Executing customchannels.list");
            return ret;
        }
    }
    
    public class Reports {
        
        private Google.Apis.Discovery.ISchemaAwareRequestExecutor service;
        
        private const string Resource = "reports";
        
        private log4net.ILog logger = log4net.LogManager.GetLogger(typeof(Reports));
        
        public Reports(AdsenseService service) {
            this.service = service;
        }
        
        public virtual System.IO.Stream Generate(string body) {
            System.Collections.Generic.Dictionary<string, string> parameters = new System.Collections.Generic.Dictionary<string, string>();
            logger.Debug("Executing reports.generate");
            System.IO.Stream ret = this.service.ExecuteRequest(Reports.Resource, "generate", body, parameters);
            logger.Debug("Done Executing reports.generate");
            return ret;
        }
        
        public virtual Google.Apis.Samples.CommandLineGeneratedService.V03.AdSenseApiV1A4.Data.AdsenseReportsGenerateResponse GenerateAsObject(Google.Apis.Samples.CommandLineGeneratedService.V03.AdSenseApiV1A4.Data.AdsenseReportsGenerateRequest body) {
            System.Collections.Generic.Dictionary<string, string> parameters = new System.Collections.Generic.Dictionary<string, string>();
            logger.Debug("Executing reports.generate");
            Google.Apis.Samples.CommandLineGeneratedService.V03.AdSenseApiV1A4.Data.AdsenseReportsGenerateResponse ret = this.service.JsonToObject <Google.Apis.Samples.CommandLineGeneratedService.V03.AdSenseApiV1A4.Data.AdsenseReportsGenerateResponse>(this.service.ExecuteRequest(Reports.Resource, "generate", this.service.ObjectToJson(body), parameters));
            logger.Debug("Done Executing reports.generate");
            return ret;
        }
    }
    
    public class Urlchannels {
        
        private Google.Apis.Discovery.ISchemaAwareRequestExecutor service;
        
        private const string Resource = "urlchannels";
        
        private log4net.ILog logger = log4net.LogManager.GetLogger(typeof(Urlchannels));
        
        public Urlchannels(AdsenseService service) {
            this.service = service;
        }
        
        public virtual System.IO.Stream List(string adclientidParam1) {
            string body = null;
            System.Collections.Generic.Dictionary<string, string> parameters = new System.Collections.Generic.Dictionary<string, string>();
            parameters["ad_client_id"] = adclientidParam1;
            logger.Debug("Executing urlchannels.list");
            System.IO.Stream ret = this.service.ExecuteRequest(Urlchannels.Resource, "list", body, parameters);
            logger.Debug("Done Executing urlchannels.list");
            return ret;
        }
        
        public virtual Google.Apis.Samples.CommandLineGeneratedService.V03.AdSenseApiV1A4.Data.UrlChannels ListAsObject(string adclientidParam1) {
            string body = null;
            System.Collections.Generic.Dictionary<string, string> parameters = new System.Collections.Generic.Dictionary<string, string>();
            parameters["ad_client_id"] = adclientidParam1;
            logger.Debug("Executing urlchannels.list");
            Google.Apis.Samples.CommandLineGeneratedService.V03.AdSenseApiV1A4.Data.UrlChannels ret = this.service.JsonToObject <Google.Apis.Samples.CommandLineGeneratedService.V03.AdSenseApiV1A4.Data.UrlChannels>(this.service.ExecuteRequest(Urlchannels.Resource, "list", body, parameters));
            logger.Debug("Done Executing urlchannels.list");
            return ret;
        }
    }
}
