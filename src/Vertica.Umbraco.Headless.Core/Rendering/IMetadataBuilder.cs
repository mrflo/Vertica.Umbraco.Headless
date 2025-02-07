﻿using Umbraco.Cms.Core.Models.PublishedContent;
using Vertica.Umbraco.Headless.Core.Models;

namespace Vertica.Umbraco.Headless.Core.Rendering
{
	public interface IMetadataBuilder
	{
		IMetadata BuildMetadata(IPublishedContent content);
	}
}