using System;
using NetOffice;
namespace NetOffice.VisioApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Visio 12, 14
	 /// </summary>
	[SupportByVersionAttribute("Visio", 12,14)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum VisGraphicField
	{
		 /// <summary>
		 /// SupportByVersion Visio 12, 14
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("Visio", 12,14)]
		 visGraphicPropertyLabel = 1,

		 /// <summary>
		 /// SupportByVersion Visio 12, 14
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("Visio", 12,14)]
		 visGraphicExpression = 2
	}
}