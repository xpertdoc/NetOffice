using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using NetOffice;
namespace NetOffice.ExcelApi
{
	///<summary>
	/// DispatchInterface ListRows 
	/// SupportByVersion Excel, 11,12,14
	///</summary>
	[SupportByVersionAttribute("Excel", 11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class ListRows : COMObject ,IEnumerable<NetOffice.ExcelApi.ListRow>
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
                    _type = typeof(ListRows);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ListRows(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ListRows(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ListRows(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ListRows() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ListRows(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 11,12,14)]
		public NetOffice.ExcelApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.ExcelApi.Application newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.Application.LateBindingApiWrapperType) as NetOffice.ExcelApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 11,12,14)]
		public NetOffice.ExcelApi.Enums.XlCreator Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.ExcelApi.Enums.XlCreator)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Excel", 11,12,14)]
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
		/// SupportByVersion Excel 11, 12, 14
		/// Get
		/// </summary>
		/// <param name="index">object Index</param>
		[SupportByVersionAttribute("Excel", 11,12,14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.ExcelApi.ListRow this[object index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "_Default", paramsArray);
			NetOffice.ExcelApi.ListRow newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.ListRow.LateBindingApiWrapperType) as NetOffice.ExcelApi.ListRow;
			return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 11,12,14)]
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
		/// SupportByVersion Excel 11, 12, 14
		/// </summary>
		/// <param name="position">optional object Position</param>
		[SupportByVersionAttribute("Excel", 11,12,14)]
		public NetOffice.ExcelApi.ListRow Add(object position)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(position);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.ListRow newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.ListRow.LateBindingApiWrapperType) as NetOffice.ExcelApi.ListRow;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14
		/// </summary>
		/// <param name="position">optional object Position</param>
		/// <param name="alwaysInsert">optional object AlwaysInsert</param>
		[SupportByVersionAttribute("Excel", 12,14)]
		public NetOffice.ExcelApi.ListRow Add(object position, object alwaysInsert)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(position, alwaysInsert);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.ListRow newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.ListRow.LateBindingApiWrapperType) as NetOffice.ExcelApi.ListRow;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 11,12,14)]
		public NetOffice.ExcelApi.ListRow Add()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.ListRow newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.ListRow.LateBindingApiWrapperType) as NetOffice.ExcelApi.ListRow;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14
		/// </summary>
		/// <param name="position">optional object Position</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[SupportByVersionAttribute("Excel", 12,14)]
		public NetOffice.ExcelApi.ListRow _Add(object position)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(position);
			object returnItem = Invoker.MethodReturn(this, "_Add", paramsArray);
			NetOffice.ExcelApi.ListRow newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.ListRow.LateBindingApiWrapperType) as NetOffice.ExcelApi.ListRow;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 12,14)]
		public NetOffice.ExcelApi.ListRow _Add()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "_Add", paramsArray);
			NetOffice.ExcelApi.ListRow newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.ListRow.LateBindingApiWrapperType) as NetOffice.ExcelApi.ListRow;
			return newObject;
		}

		#endregion

       #region IEnumerable<NetOffice.ExcelApi.ListRow> Member
        
        /// <summary>
		/// SupportByVersionAttribute Excel, 11,12,14
		/// </summary>
		[SupportByVersionAttribute("Excel", 11,12,14)]
       public IEnumerator<NetOffice.ExcelApi.ListRow> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.ExcelApi.ListRow item in innerEnumerator)
               yield return item;
       }

       #endregion
          
		#region IEnumerable Members
       
		/// <summary>
		/// SupportByVersionAttribute Excel, 11,12,14
		/// </summary>
		[SupportByVersionAttribute("Excel", 11,12,14)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return NetOffice.Utils.GetProxyEnumeratorAsProperty(this);
		}

		#endregion
		#pragma warning restore
	}
}