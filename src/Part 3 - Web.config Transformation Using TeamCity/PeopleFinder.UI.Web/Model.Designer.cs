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

namespace PeopleFinder.UI.Web
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class DatabaseEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new DatabaseEntities object using the connection string found in the 'DatabaseEntities' section of the application configuration file.
        /// </summary>
        public DatabaseEntities() : base("name=DatabaseEntities", "DatabaseEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new DatabaseEntities object.
        /// </summary>
        public DatabaseEntities(string connectionString) : base(connectionString, "DatabaseEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new DatabaseEntities object.
        /// </summary>
        public DatabaseEntities(EntityConnection connection) : base(connection, "DatabaseEntities")
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
        public ObjectSet<Person> People
        {
            get
            {
                if ((_People == null))
                {
                    _People = base.CreateObjectSet<Person>("People");
                }
                return _People;
            }
        }
        private ObjectSet<Person> _People;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the People EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToPeople(Person person)
        {
            base.AddObject("People", person);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DatabaseModel", Name="Person")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Person : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Person object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="firstname">Initial value of the Firstname property.</param>
        /// <param name="lastname">Initial value of the Lastname property.</param>
        public static Person CreatePerson(global::System.Int32 id, global::System.String firstname, global::System.String lastname)
        {
            Person person = new Person();
            person.Id = id;
            person.Firstname = firstname;
            person.Lastname = lastname;
            return person;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Firstname
        {
            get
            {
                return _Firstname;
            }
            set
            {
                OnFirstnameChanging(value);
                ReportPropertyChanging("Firstname");
                _Firstname = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Firstname");
                OnFirstnameChanged();
            }
        }
        private global::System.String _Firstname;
        partial void OnFirstnameChanging(global::System.String value);
        partial void OnFirstnameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Lastname
        {
            get
            {
                return _Lastname;
            }
            set
            {
                OnLastnameChanging(value);
                ReportPropertyChanging("Lastname");
                _Lastname = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Lastname");
                OnLastnameChanged();
            }
        }
        private global::System.String _Lastname;
        partial void OnLastnameChanging(global::System.String value);
        partial void OnLastnameChanged();

        #endregion
    
    }

    #endregion
    
}