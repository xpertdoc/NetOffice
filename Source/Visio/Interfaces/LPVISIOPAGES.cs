using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using NetOffice;
namespace NetOffice.VisioApi
{
	///<summary>
	/// Interface LPVISIOPAGES 
	/// SupportByVersion Visio, 11,12,14
	///</summary>
	[SupportByVersionAttribute("Visio", 11,12,14)]
	[EntityTypeAttribute(EntityType.IsInterface)]
	public class LPVISIOPAGES : COMObject ,IEnumerable<NetOffice.VisioApi.IVPage>
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(LPVISIOPAGES);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public LPVISIOPAGES(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public LPVISIOPAGES(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public LPVISIOPAGES(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public LPVISIOPAGES() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public LPVISIOPAGES(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14)]
		public NetOffice.VisioApi.IVApplication Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.VisioApi.IVApplication newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVApplication;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14)]
		public Int16 ObjectType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ObjectType", paramsArray);
				return NetRuntimeSystem.Convert.ToInt16(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14
		/// Get
		/// </summary>
		/// <param name="nameOrIndex">object NameOrIndex</param>
		[SupportByVersionAttribute("Visio", 11,12,14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.VisioApi.IVPage this[object nameOrIndex]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(nameOrIndex);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			NetOffice.VisioApi.IVPage newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVPage;
			return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14)]
		public Int16 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return NetRuntimeSystem.Convert.ToInt16(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14)]
		public NetOffice.VisioApi.IVDocument Document
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Document", paramsArray);
				NetOffice.VisioApi.IVDocument newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVDocument;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14)]
		public Int16 Stat
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Stat", paramsArray);
				return NetRuntimeSystem.Convert.ToInt16(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14)]
		public NetOffice.VisioApi.IVEventList EventList
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "EventList", paramsArray);
				NetOffice.VisioApi.IVEventList newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVEventList;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14)]
		public Int16 PersistsEvents
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PersistsEvents", paramsArray);
				return NetRuntimeSystem.Convert.ToInt16(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14
		/// Get
		/// </summary>
		/// <param name="nameOrIndex">object NameOrIndex</param>
		[SupportByVersionAttribute("Visio", 11,12,14)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public NetOffice.VisioApi.IVPage get_ItemU(object nameOrIndex)
		{		
			object[] paramsArray = Invoker.ValidateParamsArray(nameOrIndex);
			object returnItem = Invoker.PropertyGet(this, "ItemU", paramsArray);
			NetOffice.VisioApi.IVPage newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVPage;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14
		/// Alias for get_ItemU
		/// </summary>
		/// <param name="nameOrIndex">object NameOrIndex</param>
		[SupportByVersionAttribute("Visio", 11,12,14)]
		public NetOffice.VisioApi.IVPage ItemU(object nameOrIndex)
		{
			return get_ItemU(nameOrIndex);
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14
		/// Get
		/// </summary>
		/// <param name="nID">Int32 nID</param>
		[SupportByVersionAttribute("Visio", 11,12,14)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public NetOffice.VisioApi.IVPage get_ItemFromID(Int32 nID)
		{		
			object[] paramsArray = Invoker.ValidateParamsArray(nID);
			object returnItem = Invoker.PropertyGet(this, "ItemFromID", paramsArray);
			NetOffice.VisioApi.IVPage newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVPage;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14
		/// Alias for get_ItemFromID
		/// </summary>
		/// <param name="nID">Int32 nID</param>
		[SupportByVersionAttribute("Visio", 11,12,14)]
		public NetOffice.VisioApi.IVPage ItemFromID(Int32 nID)
		{
			return get_ItemFromID(nID);
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14)]
		public NetOffice.VisioApi.IVPage Add()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.VisioApi.IVPage newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVPage;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14
		/// </summary>
		/// <param name="localeSpecificNameArray">String[] localeSpecificNameArray</param>
		[SupportByVersionAttribute("Visio", 11,12,14)]
		public void GetNames(out String[] localeSpecificNameArray)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true);
			localeSpecificNameArray = null;
			object[] paramsArray = Invoker.ValidateParamsArray((object)localeSpecificNameArray);
			Invoker.Method(this, "GetNames", paramsArray, modifiers);
			localeSpecificNameArray = (String[])paramsArray[0];
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14
		/// </summary>
		/// <param name="localeIndependentNameArray">String[] localeIndependentNameArray</param>
		[SupportByVersionAttribute("Visio", 11,12,14)]
		public void GetNamesU(out String[] localeIndependentNameArray)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true);
			localeIndependentNameArray = null;
			object[] paramsArray = Invoker.ValidateParamsArray((object)localeIndependentNameArray);
			Invoker.Method(this, "GetNamesU", paramsArray, modifiers);
			localeIndependentNameArray = (String[])paramsArray[0];
		}

		#endregion

       #region IEnumerable<NetOffice.VisioApi.IVPage> Member
        
        /// <summary>
		/// SupportByVersionAttribute Visio, 11,12,14
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14)]
       public IEnumerator<NetOffice.VisioApi.IVPage> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.VisioApi.IVPage item in innerEnumerator)
               yield return item;
       }

       #endregion
          
		#region IEnumerable Members
       
		/// <summary>
		/// SupportByVersionAttribute Visio, 11,12,14
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return NetOffice.Utils.GetProxyEnumeratorAsProperty(this);
		}

		#endregion
		#pragma warning restore
	}
}