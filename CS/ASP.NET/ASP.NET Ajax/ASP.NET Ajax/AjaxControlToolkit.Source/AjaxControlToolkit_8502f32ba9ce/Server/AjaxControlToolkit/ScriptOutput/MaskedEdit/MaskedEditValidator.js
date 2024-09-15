// (c) 2010 CodePlex Foundation
function MaskedEditSetMessage(a,b,c){a.errormessage=b;if(c=="")a.text=b;else a.text=c;a.innerHTML=a.text}function MaskedEditMessageShow(a,b){if(typeof a.display=="string"){if(a.display=="None")return;if(a.display=="Dynamic"){a.style.display=b?"none":"inline";return}}a.style.visibility=b?"hidden":"visible"}function MaskedEditSetCssClass(b,c){var a=$get(b.TargetValidator);Sys.UI.DomElement.removeCssClass(a,b.InvalidValueCssClass);Sys.UI.DomElement.removeCssClass(a,b.CssBlurNegative);Sys.UI.DomElement.removeCssClass(a,b.CssFocus);Sys.UI.DomElement.removeCssClass(a,b.CssFocusNegative);c!=""&&Sys.UI.DomElement.addCssClass(a,c)}function MaskedEditValidatorDateTime(a){var f=false,d=true,b="";MaskedEditSetMessage(a,b,b);MaskedEditSetCssClass(a,b);MaskedEditMessageShow(a,d);if(a.IsMaskedEdit=="false")return d;var e=$get(a.TargetValidator);if(a.ValidEmpty=="false")if(Sys.Extended.UI.TextBoxWrapper.get_Wrapper(e).get_Value()==a.InitialValue){MaskedEditSetMessage(a,a.EmptyValueMessage,a.EmptyValueText);MaskedEditSetCssClass(a,a.InvalidValueCssClass);MaskedEditMessageShow(a,f);return f}if(Sys.Extended.UI.TextBoxWrapper.get_Wrapper(e).get_Value()==b)return d;var c=d,g=Sys.Extended.UI.TextBoxWrapper.get_Wrapper(e).get_Value();if(a.ValidationExpression!=b){var p=new RegExp(a.ValidationExpression),h=p.exec(g);c=h!=null&&g==h[0];if(!c){MaskedEditSetMessage(a,a.InvalidValueMessage,a.InvalidValueText);MaskedEditSetCssClass(a,a.InvalidValueCssClass);MaskedEditMessageShow(a,f);return f}}var m=e.MaskedEditBehavior.AutoFormatDate(),n=e.MaskedEditBehavior.AutoFormatTime(),k=b,l=b;if(a.MinimumValue!=b){k=a.MinimumValue.split(" ")[0];l=a.MinimumValue.split(" ")[1]}var i=b,j=b;if(a.MaximumValue!=b){i=a.MaximumValue.split(" ")[0];j=a.MaximumValue.split(" ")[1]}c=MaskedEditValidatorPartDate(a,m,k,i);if(c)c=MaskedEditValidatorPartTime(a,n,l,j);if(c&&a.ClientValidationFunction!=b){var o={Value:g,IsValid:d};eval(a.ClientValidationFunction+"(value, args);");c=o.IsValid;if(!c){MaskedEditSetMessage(a,a.InvalidValueMessage,a.InvalidValueText);MaskedEditSetCssClass(a,a.InvalidValueCssClass)}}!c&&MaskedEditMessageShow(a,c);return c}function MaskedEditValidatorPartTime(b,n,h,g){var a=10,e=-1,x="([0-5][0-9])\\s(",w="([0-5][0-9])",k=true,j=b.TimeSeparator,y=b.AmPmSymbol,v=y.split(";"),z=y.replace(";","|"),A="^(^([0][0-9]|[1][0-2])"+j+w+j+x+z+")$)|(^([0][0-9]|[1][0-2])"+j+x+z+")$)$",B="^(^([0-1][0-9]|[2][0-3])"+j+w+j+"([0-5][0-9])$)|(^([0-1][0-9]|[2][0-3])"+j+"([0-5][0-9])$)$",f=e,p=e,s=e,r="",q=n.split(j),t=new RegExp(A),l=t.exec(n),u=new RegExp(B),m=u.exec(n);if(l&&l[0]==n){r=n.substring(n.length-2).substring(0,1);f=parseInt(q[0],a);if(r.toUpperCase()==v[1].substring(0,1).toUpperCase()){f+=12;if(f==24)f=12}p=parseInt(q[1],a);s=b.length>9?parseInt(q[2].substring(0,2),a):0}else if(m&&m[0]==n){f=parseInt(q[0],a);p=parseInt(q[1],a);s=n.length>5?parseInt(q[2],a):0}if(f==e||p==e||s==e)k=false;if(!k){MaskedEditSetMessage(b,b.InvalidValueMessage,b.InvalidValueText);MaskedEditSetCssClass(b,b.InvalidValueCssClass)}if(k&&(g!=""||h!="")){var c,i,o,d;if(h!=""){c=e;i=e;o=e;d=h.split(j);l=t.exec(h);m=u.exec(h);if(l&&l[0]==h){r=h.substring(h.length-2).substring(0,1);c=parseInt(d[0],a);if(r.toUpperCase()==v[1].substring(0,1).toUpperCase()){c+=12;if(c==24)c=0}i=parseInt(d[1],a);o=h.length>9?parseInt(d[2].substring(0,2),a):0}else if(m&&m[0]==h){c=parseInt(d[0],a);i=parseInt(d[1],a);o=h.length>5?parseInt(d[2],a):0}k=f>c||f==c&&p>i||f==c&&p==i&&s>=o;if(!k){MaskedEditSetMessage(b,b.MinimumValueMessage,b.MinimumValueText);MaskedEditSetCssClass(b,b.InvalidValueCssClass)}}if(g!=""&&k){c=e;i=e;o=e;d=g.split(j);l=t.exec(g);m=u.exec(g);if(l&&l[0]==g){r=g.substring(g.length-2).substring(0,1);c=parseInt(d[0],a);if(r.toUpperCase()==v[1].substring(0,1).toUpperCase()){c+=12;if(c==24)c=0}i=parseInt(d[1],a);o=g.length>9?parseInt(d[2].substring(0,2),a):0}else if(m&&m[0]==g){c=parseInt(d[0],a);i=parseInt(d[1],a);o=g.length>5?parseInt(d[2],a):0}k=f<c||f==c&&p<i||f==c&&p==i&&s<=o;if(!k){MaskedEditSetMessage(b,b.MaximumValueMessage,b.MaximumValueText);MaskedEditSetCssClass(b,b.InvalidValueCssClass)}}}return k}function MaskedEditValidatorPartDate(a,p,o,n){var d=10,f=true,e=a.DateFormat,m=a.DateSeparator,l=p.split(m);if(parseInt(l.length,d)!=3){MaskedEditSetMessage(a,a.InvalidValueMessage,a.InvalidValueText);MaskedEditSetCssClass(a,a.InvalidValueCssClass);f=false}if(e.indexOf("D")==-1||e.indexOf("M")==-1||e.indexOf("Y")==-1){MaskedEditSetMessage(a,a.InvalidValueMessage,a.InvalidValueText);MaskedEditSetCssClass(a,a.InvalidValueCssClass);f=false}var k=-1,i=-1,c=-1;if(f){k=parseInt(l[e.indexOf("D")],d);i=parseInt(l[e.indexOf("M")],d);c=parseInt(l[e.indexOf("Y")],d);if(c<100)c=parseInt(c+a.Century,d);else if(c<999)c+=parseInt(a.Century.substring(0,1)+c,d);f=k>0&&i>0&&c>0&&(k<=([,31,28,31,30,31,30,31,31,30,31,30,31])[i]||k==29&&i==2&&c%4==0&&(c%100>0||c%400==0))}if(!f){MaskedEditSetMessage(a,a.InvalidValueMessage,a.InvalidValueText);MaskedEditSetCssClass(a,a.InvalidValueCssClass)}if(f&&(n!=""||o!="")){var g,j=-1,h=-1,b=-1;if(o!=""){g=o.split(m);j=parseInt(g[e.indexOf("D")],d);h=parseInt(g[e.indexOf("M")],d);b=parseInt(g[e.indexOf("Y")],d);if(b<100)b=parseInt(b+a.Century,d);else if(b<999)b+=parseInt(a.Century.substring(0,1)+b,d);f=j>0&&h>0&&b>0&&c>b||c==b&&i>h||c==b&&i==h&&k>=j;if(!f){MaskedEditSetMessage(a,a.MinimumValueMessage,a.MinimumValueText);MaskedEditSetCssClass(a,a.InvalidValueCssClass)}}if(f&&n!=""){g=n.split(m);j=parseInt(g[e.indexOf("D")],d);h=parseInt(g[e.indexOf("M")],d);b=parseInt(g[e.indexOf("Y")],d);if(b<100)b=parseInt(b+a.Century,d);else if(b<999)b+=parseInt(a.Century.substring(0,1)+b,d);f=j>0&&h>0&&b>0&&c<b||c==b&&i<h||c==b&&i==h&&k<=j;if(!f){MaskedEditSetMessage(a,a.MaximumValueMessage,a.MaximumValueText);MaskedEditSetCssClass(a,a.InvalidValueCssClass)}}}return f}function MaskedEditValidatorDate(a){var d=false,c=true;MaskedEditSetMessage(a,"","");MaskedEditSetCssClass(a,"");MaskedEditMessageShow(a,c);if(a.IsMaskedEdit=="false")return c;var f=$get(a.TargetValidator);if(a.ValidEmpty=="false")if(Sys.Extended.UI.TextBoxWrapper.get_Wrapper(f).get_Value()==a.InitialValue){MaskedEditSetMessage(a,a.EmptyValueMessage,a.EmptyValueText);MaskedEditSetCssClass(a,a.InvalidValueCssClass);MaskedEditMessageShow(a,d);return d}if(Sys.Extended.UI.TextBoxWrapper.get_Wrapper(f).get_Value()=="")return c;var b=c,e=Sys.Extended.UI.TextBoxWrapper.get_Wrapper(f).get_Value();if(a.ValidationExpression!=""){var i=new RegExp(a.ValidationExpression),g=i.exec(e);b=g!=null&&e==g[0];if(!b){MaskedEditSetMessage(a,a.InvalidValueMessage,a.InvalidValueText);MaskedEditSetCssClass(a,a.InvalidValueCssClass);MaskedEditMessageShow(a,d);return d}}b=MaskedEditValidatorPartDate(a,e,a.MinimumValue,a.MaximumValue);if(b&&a.ClientValidationFunction!=""){var h={Value:e,IsValid:c};eval(a.ClientValidationFunction+"(value, args);");b=h.IsValid;if(!b){MaskedEditSetMessage(a,a.InvalidValueMessage,a.InvalidValueText);MaskedEditSetCssClass(a,a.InvalidValueCssClass)}}!b&&MaskedEditMessageShow(a,b);return b}function MaskedEditValidatorTime(a){var d=false,c=true;MaskedEditSetMessage(a,"","");MaskedEditSetCssClass(a,"");MaskedEditMessageShow(a,c);if(a.IsMaskedEdit=="false")return c;var f=$get(a.TargetValidator);if(a.ValidEmpty=="false")if(Sys.Extended.UI.TextBoxWrapper.get_Wrapper(f).get_Value()==a.InitialValue){MaskedEditSetMessage(a,a.EmptyValueMessage,a.EmptyValueText);MaskedEditSetCssClass(a,a.InvalidValueCssClass);MaskedEditMessageShow(a,d);return d}if(Sys.Extended.UI.TextBoxWrapper.get_Wrapper(f).get_Value()=="")return c;var b=c,e=Sys.Extended.UI.TextBoxWrapper.get_Wrapper(f).get_Value();if(a.ValidationExpression!=""){var i=new RegExp(a.ValidationExpression),g=i.exec(e);b=g!=null&&e==g[0];if(!b){MaskedEditSetMessage(a,a.InvalidValueMessage,a.InvalidValueText);MaskedEditSetCssClass(a,a.InvalidValueCssClass);MaskedEditMessageShow(a,d);return d}}b=MaskedEditValidatorPartTime(a,e,a.MinimumValue,a.MaximumValue);if(b&&a.ClientValidationFunction!=""){var h={Value:e,IsValid:c};eval(a.ClientValidationFunction+"(value, args);");b=h.IsValid;if(!b){MaskedEditSetMessage(a,a.InvalidValueMessage,a.InvalidValueText);MaskedEditSetCssClass(a,a.InvalidValueCssClass)}}!b&&MaskedEditMessageShow(a,b);return b}function MaskedEditValidatorNumber(a){var d=null,i=false,j=true,f="";MaskedEditSetMessage(a,f,f);MaskedEditSetCssClass(a,f);MaskedEditMessageShow(a,j);if(a.IsMaskedEdit=="false")return j;var m=$get(a.TargetValidator);if(a.ValidEmpty=="false")if(Sys.Extended.UI.TextBoxWrapper.get_Wrapper(m).get_Value()==a.InitialValue){MaskedEditSetMessage(a,a.EmptyValueMessage,a.EmptyValueText);MaskedEditSetCssClass(a,a.InvalidValueCssClass);MaskedEditMessageShow(a,i);return i}if(Sys.Extended.UI.TextBoxWrapper.get_Wrapper(m).get_Value()==f)return j;var c=j,q=a.Thousands,p=a.Decimal,n=a.Money,t=a.LastMaskPosition+n.length+1,g=Sys.Extended.UI.TextBoxWrapper.get_Wrapper(m).get_Value();if(a.ValidationExpression!=f){var s=new RegExp(a.ValidationExpression),o=s.exec(g);c=o!=d&&g==o[0];if(!c){MaskedEditSetMessage(a,a.InvalidValueMessage,a.InvalidValueText);MaskedEditSetCssClass(a,a.InvalidValueCssClass);MaskedEditMessageShow(a,i);return i}}c=i;var k=d,l=d,e=d,h=d,b=d;g=g.replace(new RegExp("(\\"+q+")","g"),f);g=g.replace(new RegExp("(\\"+n+")","g"),f);e=g.match(/^\s*(\S+(\s+\S+)*)\s*$/);if(e!=d)g=e[1];l=/^\s*[-\+]?\d+\s*$/;if(g.match(l)!=d){h=parseInt(g,10);c=h==(isNaN(h)?d:h)}if(c){if(a.MaximumValue!=f){b=parseInt(a.MaximumValue,10);if(b==(isNaN(b)?d:b))if(h>b){c=i;MaskedEditSetMessage(a,a.MaximumValueMessage,a.MaximumValueText);MaskedEditSetCssClass(a,a.InvalidValueCssClass)}}if(c&&a.MinimumValue!=f){b=parseInt(a.MinimumValue,10);if(b==(isNaN(b)?d:b))if(h<b){c=i;MaskedEditSetMessage(a,a.MinimumValueMessage,a.MinimumValueText);MaskedEditSetCssClass(a,a.InvalidValueCssClass)}}}else{l=new RegExp("^\\s*([-\\+])?(\\d+)?(\\"+p+"(\\d+))?\\s*$");e=g.match(l);if(e!=d){k=d;if(typeof e[1]!="undefined")k=e[1]+(e[2].length>0?e[2]:"0")+"."+e[4];else k=(e[2].length>0?e[2]:"0")+"."+e[4];h=parseFloat(k);c=h==(isNaN(h)?d:h)}if(!c){MaskedEditSetMessage(a,a.InvalidValueMessage,a.InvalidValueText);MaskedEditSetCssClass(a,a.InvalidValueCssClass)}if(c){if(a.MaximumValue!=f){b=parseFloat(a.MaximumValue);if(b==(isNaN(b)?d:b))if(h>b){c=i;MaskedEditSetMessage(a,a.MaximumValueMessage,a.MaximumValueText);MaskedEditSetCssClass(a,a.InvalidValueCssClass)}}if(c&&a.MinimumValue!=f){b=parseFloat(a.MinimumValue);if(b==(isNaN(b)?d:b))if(h<b){c=i;MaskedEditSetMessage(a,a.MinimumValueMessage,a.MinimumValueText);MaskedEditSetCssClass(a,a.InvalidValueCssClass)}}}}if(c&&a.ClientValidationFunction!=f){var r={Value:g,IsValid:j};eval(a.ClientValidationFunction+"(value, args);");c=r.IsValid;if(!c){MaskedEditSetMessage(a,a.InvalidValueMessage,a.InvalidValueText);MaskedEditSetCssClass(a,a.InvalidValueCssClass)}}!c&&MaskedEditMessageShow(a,c);return c}function MaskedEditValidatorNone(a){var e=null,d=false,f=true;MaskedEditSetMessage(a,"","");MaskedEditSetCssClass(a,"");MaskedEditMessageShow(a,f);if(a.IsMaskedEdit=="false")return f;var h=$get(a.TargetValidator);if(a.ValidEmpty=="false")if(Sys.Extended.UI.TextBoxWrapper.get_Wrapper(h).get_Value()==a.InitialValue){MaskedEditSetMessage(a,a.EmptyValueMessage,a.EmptyValueText);MaskedEditSetCssClass(a,a.InvalidValueCssClass);MaskedEditMessageShow(a,d);return d}if(Sys.Extended.UI.TextBoxWrapper.get_Wrapper(h).get_Value()=="")return f;var b=f,g=Sys.Extended.UI.TextBoxWrapper.get_Wrapper(h).get_Value();if(a.ValidationExpression!=""){var l=new RegExp(a.ValidationExpression),i=l.exec(g);b=i!=e&&g==i[0];if(!b){MaskedEditSetMessage(a,a.InvalidValueMessage,a.InvalidValueText);MaskedEditSetCssClass(a,a.InvalidValueCssClass);MaskedEditMessageShow(a,d);return d}}var j=/^\d+\s*$/,c=e;if(a.MaximumValue!="")if(a.MaximumValue.match(j)!=e){c=parseInt(a.MaximumValue,10);if(c==(isNaN(c)?e:c))if(g.length>c){b=d;MaskedEditSetMessage(a,a.MaximumValueMessage,a.MaximumValueText);MaskedEditSetCssClass(a,a.InvalidValueCssClass)}}if(b&&a.MinimumValue!="")if(a.MinimumValue.match(j)!=e){c=parseInt(a.MinimumValue,10);if(c==(isNaN(c)?e:c))if(g.length<c){b=d;MaskedEditSetMessage(a,a.MinimumValueMessage,a.MinimumValueText);MaskedEditSetCssClass(a,a.InvalidValueCssClass)}}if(b&&a.ClientValidationFunction!=""){var k={Value:g,IsValid:f};eval(a.ClientValidationFunction+"(value, args);");b=k.IsValid;if(!b){MaskedEditSetMessage(a,a.InvalidValueMessage,a.InvalidValueText);MaskedEditSetCssClass(a,a.InvalidValueCssClass)}}!b&&MaskedEditMessageShow(a,b);return b};