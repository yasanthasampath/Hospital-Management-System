﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hospital_Management_System.HospitalService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PersonClass", Namespace="http://schemas.datacontract.org/2004/07/HospitalService")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Hospital_Management_System.HospitalService.Nurseclass))]
    public partial class PersonClass : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Address1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Address2Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AgeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DobField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GenderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MobnumField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NicField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TelnumField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Address1 {
            get {
                return this.Address1Field;
            }
            set {
                if ((object.ReferenceEquals(this.Address1Field, value) != true)) {
                    this.Address1Field = value;
                    this.RaisePropertyChanged("Address1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Address2 {
            get {
                return this.Address2Field;
            }
            set {
                if ((object.ReferenceEquals(this.Address2Field, value) != true)) {
                    this.Address2Field = value;
                    this.RaisePropertyChanged("Address2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Age {
            get {
                return this.AgeField;
            }
            set {
                if ((this.AgeField.Equals(value) != true)) {
                    this.AgeField = value;
                    this.RaisePropertyChanged("Age");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Dob {
            get {
                return this.DobField;
            }
            set {
                if ((object.ReferenceEquals(this.DobField, value) != true)) {
                    this.DobField = value;
                    this.RaisePropertyChanged("Dob");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Fname {
            get {
                return this.FnameField;
            }
            set {
                if ((object.ReferenceEquals(this.FnameField, value) != true)) {
                    this.FnameField = value;
                    this.RaisePropertyChanged("Fname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Gender {
            get {
                return this.GenderField;
            }
            set {
                if ((object.ReferenceEquals(this.GenderField, value) != true)) {
                    this.GenderField = value;
                    this.RaisePropertyChanged("Gender");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Lname {
            get {
                return this.LnameField;
            }
            set {
                if ((object.ReferenceEquals(this.LnameField, value) != true)) {
                    this.LnameField = value;
                    this.RaisePropertyChanged("Lname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Mobnum {
            get {
                return this.MobnumField;
            }
            set {
                if ((object.ReferenceEquals(this.MobnumField, value) != true)) {
                    this.MobnumField = value;
                    this.RaisePropertyChanged("Mobnum");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nic {
            get {
                return this.NicField;
            }
            set {
                if ((object.ReferenceEquals(this.NicField, value) != true)) {
                    this.NicField = value;
                    this.RaisePropertyChanged("Nic");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Telnum {
            get {
                return this.TelnumField;
            }
            set {
                if ((object.ReferenceEquals(this.TelnumField, value) != true)) {
                    this.TelnumField = value;
                    this.RaisePropertyChanged("Telnum");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Nurseclass", Namespace="http://schemas.datacontract.org/2004/07/HospitalService")]
    [System.SerializableAttribute()]
    public partial class Nurseclass : Hospital_Management_System.HospitalService.PersonClass {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NurseId1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string QualifField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SalaryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ShiftField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NurseId1 {
            get {
                return this.NurseId1Field;
            }
            set {
                if ((object.ReferenceEquals(this.NurseId1Field, value) != true)) {
                    this.NurseId1Field = value;
                    this.RaisePropertyChanged("NurseId1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Qualif {
            get {
                return this.QualifField;
            }
            set {
                if ((object.ReferenceEquals(this.QualifField, value) != true)) {
                    this.QualifField = value;
                    this.RaisePropertyChanged("Qualif");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Salary {
            get {
                return this.SalaryField;
            }
            set {
                if ((object.ReferenceEquals(this.SalaryField, value) != true)) {
                    this.SalaryField = value;
                    this.RaisePropertyChanged("Salary");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Shift {
            get {
                return this.ShiftField;
            }
            set {
                if ((object.ReferenceEquals(this.ShiftField, value) != true)) {
                    this.ShiftField = value;
                    this.RaisePropertyChanged("Shift");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="HospitalService.IHospitalService")]
    public interface IHospitalService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHospitalService/AddNurse", ReplyAction="http://tempuri.org/IHospitalService/AddNurseResponse")]
        void AddNurse(Hospital_Management_System.HospitalService.Nurseclass nurse);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IHospitalServiceChannel : Hospital_Management_System.HospitalService.IHospitalService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HospitalServiceClient : System.ServiceModel.ClientBase<Hospital_Management_System.HospitalService.IHospitalService>, Hospital_Management_System.HospitalService.IHospitalService {
        
        public HospitalServiceClient() {
        }
        
        public HospitalServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HospitalServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HospitalServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HospitalServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AddNurse(Hospital_Management_System.HospitalService.Nurseclass nurse) {
            base.Channel.AddNurse(nurse);
        }
    }
}
