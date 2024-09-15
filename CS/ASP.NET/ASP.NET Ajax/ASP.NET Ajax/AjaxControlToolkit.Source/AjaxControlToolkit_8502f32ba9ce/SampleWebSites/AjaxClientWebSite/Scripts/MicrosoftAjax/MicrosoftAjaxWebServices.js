// (c) 2010 CodePlex Foundation
(function(){var a=null;function b(){var b=false,e="callback",c="undefined";Type._registerScript("MicrosoftAjaxWebServices.js",["MicrosoftAjaxNetwork.js"]);var d,f;Type.registerNamespace("Sys.Net");d=Sys.Net.WebServiceProxy=function(){var a=Object.getType(this);if(a._staticInstance&&typeof a._staticInstance.get_enableJsonp==="function")this._jsonp=a._staticInstance.get_enableJsonp()};d.prototype={get_timeout:function(){return this._timeout||0},set_timeout:function(a){this._timeout=a},get_defaultUserContext:function(){return typeof this._userContext===c?a:this._userContext},set_defaultUserContext:function(a){this._userContext=a},get_defaultSucceededCallback:function(){return this._succeeded||a},set_defaultSucceededCallback:function(a){this._succeeded=a},get_defaultFailedCallback:function(){return this._failed||a},set_defaultFailedCallback:function(a){this._failed=a},get_enableJsonp:function(){return!!this._jsonp},set_enableJsonp:function(a){this._jsonp=a},get_path:function(){return this._path||a},set_path:function(a){this._path=a},get_jsonpCallbackParameter:function(){return this._callbackParameter||e},set_jsonpCallbackParameter:function(a){this._callbackParameter=a},_invoke:function(g,h,j,i,f,e,d){var b=this;f=f||b.get_defaultSucceededCallback();e=e||b.get_defaultFailedCallback();if(d===a||typeof d===c)d=b.get_defaultUserContext();return Sys.Net.WebServiceProxy.invoke(g,h,j,i,f,e,d,b.get_timeout(),b.get_enableJsonp(),b.get_jsonpCallbackParameter())}};d.registerClass("Sys.Net.WebServiceProxy");d.invoke=function(u,d,q,p,o,f,k,l,z,t){var g="Content-Type",n=z!==b?Sys.Net.WebServiceProxy._xdomain.exec(u):a,h,r=n&&n.length===3&&(n[1]!==location.protocol||n[2]!==location.host);q=r||q;if(r){t=t||e;h="_jsonp"+Sys._jsonp++}if(!p)p={};var v=p;if(!q||!v)v={};var m,j=a,s=a,x=Sys.Net.WebRequest._createUrl(d?u+"/"+encodeURIComponent(d):u,v,r?t+"=Sys."+h:a);if(r){function y(){if(j===a)return;j=a;m=new Sys.Net.WebServiceError(true,String.format(Sys.Res.webServiceTimedOut,d));delete Sys[h];f&&f(m,k,d)}function w(e,g){if(j!==a){window.clearTimeout(j);j=a}delete Sys[h];h=a;if(typeof g!==c&&g!==200){if(f){m=new Sys.Net.WebServiceError(b,e.Message||String.format(Sys.Res.webServiceFailedNoMsg,d),e.StackTrace||a,e.ExceptionType||a,e);m._statusCode=g;f(m,k,d)}}else o&&o(e,k,d)}Sys[h]=w;l=l||Sys.Net.WebRequestManager.get_defaultTimeout();if(l>0)j=window.setTimeout(y,l);Sys._loadJsonp(x,function(){h&&w({Message:String.format(Sys.Res.webServiceFailedNoMsg,d)},-1)});return a}var i=new Sys.Net.WebRequest;i.set_url(x);i.get_headers()[g]="application/json; charset=utf-8";if(!q){s=Sys.Serialization.JavaScriptSerializer.serialize(p);if(s==="{}")s=""}i.set_body(s);i.add_completed(A);l>0&&i.set_timeout(l);i.invoke();function A(h){if(h.get_responseAvailable()){var s,i=h.get_statusCode(),e=a,l;try{var m=h.getResponseHeader(g);l=m.startsWith("application/json");e=l?h.get_object():m.startsWith("text/xml")?h.get_xml():h.get_responseData()}catch(s){}var p=h.getResponseHeader("jsonerror"),j=p==="true";if(j){if(e)e=new Sys.Net.WebServiceError(b,e.Message,e.StackTrace,e.ExceptionType,e)}else if(l)e=!e||typeof e.d===c?e:e.d;if(i<200||i>=300||j){if(f){if(!e||!j)e=new Sys.Net.WebServiceError(b,String.format(Sys.Res.webServiceFailedNoMsg,d));e._statusCode=i;f(e,k,d)}}else o&&o(e,k,d)}else{var n=h.get_timedOut(),q=String.format(n?Sys.Res.webServiceTimedOut:Sys.Res.webServiceFailedNoMsg,d);f&&f(new Sys.Net.WebServiceError(n,q,"",""),k,d)}}return i};d._generateTypedConstructor=function(a){return function(b){if(b)for(var c in b)this[c]=b[c];this.__type=a}};Sys._jsonp=0;d._xdomain=/^\s*([a-zA-Z0-9\+\-\.]+\:)\/\/([^?#\/]+)/;Sys._loadJsonp=function(h,g){var d="onreadystatechange",c=document.createElement("script");c.type="text/javascript";c.src=h;var f=c.attachEvent;function e(){if(!f||/loaded|complete/.test(c.readyState)){if(f)c.detachEvent(d,e);else{c.removeEventListener("load",e,b);c.removeEventListener("error",e,b)}g.apply(c);c=a}}if(f)c.attachEvent(d,e);else{c.addEventListener("load",e,b);c.addEventListener("error",e,b)}Sys.get("head").appendChild(c)};d=Sys.Net.WebServiceError=function(e,f,d,b,c){var a=this;a._timedOut=e;a._message=f;a._stackTrace=d;a._exceptionType=b;a._errorObject=c;a._statusCode=-1};d.prototype={get_timedOut:function(){return this._timedOut},get_statusCode:function(){return this._statusCode},get_message:function(){return this._message},get_stackTrace:function(){return this._stackTrace||""},get_exceptionType:function(){return this._exceptionType||""},get_errorObject:function(){return this._errorObject||a}};d.registerClass("Sys.Net.WebServiceError")}if(window.Sys&&Sys.loader)Sys.loader.registerScript("WebServices",a,b);else b()})();