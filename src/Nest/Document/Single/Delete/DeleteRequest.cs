﻿using Elasticsearch.Net;

namespace Nest
{
	[MapsApi("delete.json")]
	public partial interface IDeleteRequest : IRequest<DeleteRequestParameters> { }

	public interface IDeleteRequest<T> : IDeleteRequest where T : class { }

	public partial class DeleteRequest
	{
		private object AutoRouteDocument() => null;
	}

	public partial class DeleteRequest<T> where T : class
	{
		private object AutoRouteDocument() => null;
	}

	public partial class DeleteDescriptor<T> where T : class
	{
		private object AutoRouteDocument() => null;
	}
}
