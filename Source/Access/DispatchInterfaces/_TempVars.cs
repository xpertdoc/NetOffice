using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using NetOffice;
namespace NetOffice.AccessApi
{
	///<summary>
	/// DispatchInterface _TempVars 
	/// SupportByVersion Access, 12,14
	///</summary>
	[SupportByVersionAttribute("Access", 12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class _TempVars : COMObject ,IEnumerable<NetOffice.AccessApi.TempVar>
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
                    _type = typeof(_TempVars);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _TempVars(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _TempVars(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _TempVars(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _TempVars() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _TempVars(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Access 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Access", 12,14)]
		public NetOffice.AccessApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.AccessApi.Application newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.AccessApi.Application.LateBindingApiWrapperType) as NetOffice.AccessApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Access", 12,14)]
		public object Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14
		/// Get
		/// </summary>
		/// <param name="index">object Index</param>
		[SupportByVersionAttribute("Access", 12,14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.AccessApi.TempVar this[object index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			NetOffice.AccessApi.TempVar newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.AccessApi.TempVar.LateBindingApiWrapperType) as NetOffice.AccessApi.TempVar;
			return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Access", 12,14)]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Access 12, 14
		/// </summary>
		/// <param name="name">string Name</param>
		/// <param name="value">object Value</param>
		[SupportByVersionAttribute("Access", 12,14)]
		public void Add(string name, object value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, value);
			Invoker.Method(this, "Add", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Access 12, 14
		/// </summary>
		/// <param name="var">object var</param>
		[SupportByVersionAttribute("Access", 12,14)]
		public void Remove(object var)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(var);
			Invoker.Method(this, "Remove", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Access 12, 14
		/// </summary>
		[SupportByVersionAttribute("Access", 12,14)]
		public void RemoveAll()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "RemoveAll", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Access 12, 14
		/// </summary>
		/// <param name="dispid">Int32 dispid</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[SupportByVersionAttribute("Access", 12,14)]
		public bool IsMemberSafe(Int32 dispid)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dispid);
			object returnItem = Invoker.MethodReturn(this, "IsMemberSafe", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		#endregion

       #region IEnumerable<NetOffice.AccessApi.TempVar> Member
        
        /// <summary>
		/// SupportByVersionAttribute Access, 12,14
		/// </summary>
		[SupportByVersionAttribute("Access", 12,14)]
       public IEnumerator<NetOffice.AccessApi.TempVar> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.AccessApi.TempVar item in innerEnumerator)
               yield return item;
       }

       #endregion
          
		#region IEnumerable Members
       
		/// <summary>
		/// SupportByVersionAttribute Access, 12,14
		/// </summary>
		[SupportByVersionAttribute("Access", 12,14)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return NetOffice.Utils.GetProxyEnumeratorAsMethod(this);
		}

		#endregion
		#pragma warning restore
	}
}