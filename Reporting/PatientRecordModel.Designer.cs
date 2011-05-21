﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace Reporting
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class PatientDBEventStoreEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new PatientDBEventStoreEntities object using the connection string found in the 'PatientDBEventStoreEntities' section of the application configuration file.
        /// </summary>
        public PatientDBEventStoreEntities() : base("name=PatientDBEventStoreEntities", "PatientDBEventStoreEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new PatientDBEventStoreEntities object.
        /// </summary>
        public PatientDBEventStoreEntities(string connectionString) : base(connectionString, "PatientDBEventStoreEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new PatientDBEventStoreEntities object.
        /// </summary>
        public PatientDBEventStoreEntities(EntityConnection connection) : base(connection, "PatientDBEventStoreEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Patient> Patients
        {
            get
            {
                if ((_Patients == null))
                {
                    _Patients = base.CreateObjectSet<Patient>("Patients");
                }
                return _Patients;
            }
        }
        private ObjectSet<Patient> _Patients;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Patients EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToPatients(Patient patient)
        {
            base.AddObject("Patients", patient);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Reporting", Name="Patient")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Patient : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Patient object.
        /// </summary>
        /// <param name="patientId">Initial value of the PatientId property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        public static Patient CreatePatient(global::System.Guid patientId, global::System.String name)
        {
            Patient patient = new Patient();
            patient.PatientId = patientId;
            patient.Name = name;
            return patient;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid PatientId
        {
            get
            {
                return _PatientId;
            }
            set
            {
                if (_PatientId != value)
                {
                    OnPatientIdChanging(value);
                    ReportPropertyChanging("PatientId");
                    _PatientId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("PatientId");
                    OnPatientIdChanged();
                }
            }
        }
        private global::System.Guid _PatientId;
        partial void OnPatientIdChanging(global::System.Guid value);
        partial void OnPatientIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Status
        {
            get
            {
                return _Status;
            }
            set
            {
                OnStatusChanging(value);
                ReportPropertyChanging("Status");
                _Status = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Status");
                OnStatusChanged();
            }
        }
        private global::System.String _Status;
        partial void OnStatusChanging(global::System.String value);
        partial void OnStatusChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Street
        {
            get
            {
                return _Street;
            }
            set
            {
                OnStreetChanging(value);
                ReportPropertyChanging("Street");
                _Street = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Street");
                OnStreetChanged();
            }
        }
        private global::System.String _Street;
        partial void OnStreetChanging(global::System.String value);
        partial void OnStreetChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String City
        {
            get
            {
                return _City;
            }
            set
            {
                OnCityChanging(value);
                ReportPropertyChanging("City");
                _City = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("City");
                OnCityChanged();
            }
        }
        private global::System.String _City;
        partial void OnCityChanging(global::System.String value);
        partial void OnCityChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String State
        {
            get
            {
                return _State;
            }
            set
            {
                OnStateChanging(value);
                ReportPropertyChanging("State");
                _State = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("State");
                OnStateChanged();
            }
        }
        private global::System.String _State;
        partial void OnStateChanging(global::System.String value);
        partial void OnStateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Zip
        {
            get
            {
                return _Zip;
            }
            set
            {
                OnZipChanging(value);
                ReportPropertyChanging("Zip");
                _Zip = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Zip");
                OnZipChanged();
            }
        }
        private global::System.String _Zip;
        partial void OnZipChanging(global::System.String value);
        partial void OnZipChanged();

        #endregion
    
    }

    #endregion
    
}