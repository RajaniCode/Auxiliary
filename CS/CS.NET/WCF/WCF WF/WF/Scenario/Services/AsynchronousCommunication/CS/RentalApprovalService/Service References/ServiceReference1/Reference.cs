﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.20702.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RentalApprovalService.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ICreditCheckService")]
    public interface ICreditCheckService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICreditCheckService/ValidateCredit", ReplyAction="http://tempuri.org/ICreditCheckService/ValidateCreditResponse")]
        RentalApprovalService.ServiceReference1.ValidateCreditResponse ValidateCredit(RentalApprovalService.ServiceReference1.ValidateCreditRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICreditCheckService/ValidateValue", ReplyAction="http://tempuri.org/ICreditCheckService/ValidateValueResponse")]
        RentalApprovalService.ServiceReference1.ValidateValueResponse ValidateValue(RentalApprovalService.ServiceReference1.ValidateValueRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ValidateCreditRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/2003/10/Serialization/", Order=0)]
        public System.Nullable<int> @int;
        
        public ValidateCreditRequest() {
        }
        
        public ValidateCreditRequest(System.Nullable<int> @int) {
            this.@int = @int;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ValidateCreditResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/2003/10/Serialization/", Order=0)]
        public System.Nullable<bool> boolean;
        
        public ValidateCreditResponse() {
        }
        
        public ValidateCreditResponse(System.Nullable<bool> boolean) {
            this.boolean = boolean;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ValidateValueRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/2003/10/Serialization/", Order=0)]
        public System.Nullable<int> @int;
        
        public ValidateValueRequest() {
        }
        
        public ValidateValueRequest(System.Nullable<int> @int) {
            this.@int = @int;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ValidateValueResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/2003/10/Serialization/", Order=0)]
        public System.Nullable<bool> boolean;
        
        public ValidateValueResponse() {
        }
        
        public ValidateValueResponse(System.Nullable<bool> boolean) {
            this.boolean = boolean;
        }
    }
}
