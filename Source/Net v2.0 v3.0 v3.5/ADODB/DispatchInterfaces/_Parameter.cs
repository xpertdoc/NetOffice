//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.ADODBApi
{
	///<summary>
	/// DispatchInterface _Parameter SupportByLibrary ADO2.1 ADO2.5 
	///</summary>
	[SupportByLibrary("ADO2.1","ADO2.5")]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class _Parameter : _ADO
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Parameter(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Parameter(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Parameter(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Parameter()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public string Name
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Name", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Name", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public object Value
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Value", paramsArray);
				Type returnItemType = Invoker.GetObjectType(returnItem);
				if ((null != returnItemType) && (true == returnItemType.IsCOMObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Value", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public NetOffice.ADODBApi.Enums.DataTypeEnum Type
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Type", paramsArray);
				return (NetOffice.ADODBApi.Enums.DataTypeEnum)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Type", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public NetOffice.ADODBApi.Enums.ParameterDirectionEnum Direction
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Direction", paramsArray);
				return (NetOffice.ADODBApi.Enums.ParameterDirectionEnum)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Direction", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public byte Precision
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Precision", paramsArray);
				return (byte)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Precision", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public byte NumericScale
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NumericScale", paramsArray);
				return (byte)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "NumericScale", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public Int32 Size
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Size", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Size", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public Int32 Attributes
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Attributes", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Attributes", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		/// <param name="Val">object Val</param>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public void AppendChunk(object val)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(val);
			Invoker.Method(this, "AppendChunk", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}