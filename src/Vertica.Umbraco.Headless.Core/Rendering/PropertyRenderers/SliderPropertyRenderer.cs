﻿using System;
using Umbraco.Cms.Core;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PropertyEditors;
using Vertica.Umbraco.Headless.Core.Models;

namespace Vertica.Umbraco.Headless.Core.Rendering.PropertyRenderers
{
	public class SliderPropertyRenderer : IPropertyRenderer
	{
		public string PropertyEditorAlias => Constants.PropertyEditors.Aliases.Slider;

		public Type TypeFor(IPublishedPropertyType propertyType)
			=> propertyType.DataType.ConfigurationAs<SliderConfiguration>().EnableRange
				? typeof(DecimalRange) 
				: typeof(decimal);

		public object ValueFor(object umbracoValue, IPublishedProperty property, IContentElementBuilder contentElementBuilder)
		{
			return umbracoValue switch
			{
				Range<decimal> range => new DecimalRange(range.Minimum, range.Maximum),
				decimal value => value,
				_ => 0m
			};
		}
	}
}
