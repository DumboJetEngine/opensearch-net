/* SPDX-License-Identifier: Apache-2.0
*
* The OpenSearch Contributors require contributions made to
* this file be licensed under the Apache-2.0 license or a
* compatible open source license.
*/
/*
* Modifications Copyright OpenSearch Contributors. See
* GitHub history for details.
*
*  Licensed to Elasticsearch B.V. under one or more contributor
*  license agreements. See the NOTICE file distributed with
*  this work for additional information regarding copyright
*  ownership. Elasticsearch B.V. licenses this file to you under
*  the Apache License, Version 2.0 (the "License"); you may
*  not use this file except in compliance with the License.
*  You may obtain a copy of the License at
*
* 	http://www.apache.org/licenses/LICENSE-2.0
*
*  Unless required by applicable law or agreed to in writing,
*  software distributed under the License is distributed on an
*  "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
*  KIND, either express or implied.  See the License for the
*  specific language governing permissions and limitations
*  under the License.
*/
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// -----------------------------------------------
//
// This file is automatically generated
// Please do not edit these files manually
// Run the following in the root of the repos:
//
// 		*NIX 		:	./build.sh codegen
// 		Windows 	:	build.bat codegen
//
// -----------------------------------------------
// ReSharper disable RedundantUsingDirective
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using OpenSearch.Net;
using OpenSearch.Net.Utf8Json;
using OpenSearch.Net.Specification.CatApi;

// ReSharper disable RedundantBaseConstructorCall
// ReSharper disable UnusedTypeParameter
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
namespace OpenSearch.Client
{
	///<summary>Descriptor for Plugins <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-plugins/</para></summary>
	public partial class CatPluginsDescriptor : RequestDescriptorBase<CatPluginsDescriptor, CatPluginsRequestParameters, ICatPluginsRequest>, ICatPluginsRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatPlugins;
		// values part of the url path
		// Request parameters
		///<summary>a short version of the Accept header, e.g. json, yaml</summary>
		public CatPluginsDescriptor Format(string format) => Qs("format", format);
		///<summary>Comma-separated list of column names to display</summary>
		public CatPluginsDescriptor Headers(params string[] headers) => Qs("h", headers);
		///<summary>Return help information</summary>
		public CatPluginsDescriptor Help(bool? help = true) => Qs("help", help);
		///<summary>Include bootstrap plugins in the response</summary>
		public CatPluginsDescriptor IncludeBootstrap(bool? includebootstrap = true) => Qs("include_bootstrap", includebootstrap);
		///<summary>Return local information, do not retrieve the state from cluster_manager node (default: false)</summary>
		public CatPluginsDescriptor Local(bool? local = true) => Qs("local", local);
		///<summary>Explicit operation timeout for connection to master node</summary>
		///<remarks>Deprecated as of OpenSearch 2.0, use <see cref="ClusterManagerTimeout"/> instead</remarks>
		public CatPluginsDescriptor MasterTimeout(Time mastertimeout) => Qs("master_timeout", mastertimeout);
		///<summary>Explicit operation timeout for connection to cluster_manager node</summary>
		///<remarks>Introduced in OpenSearch 2.0 instead of <see cref="MasterTimeout"/></remarks>
		public CatPluginsDescriptor ClusterManagerTimeout(Time timeout) => Qs("cluster_manager_timeout", timeout);
		///<summary>Comma-separated list of column names or column aliases to sort by</summary>
		public CatPluginsDescriptor SortByColumns(params string[] sortbycolumns) => Qs("s", sortbycolumns);
		///<summary>Verbose mode. Display column headers</summary>
		public CatPluginsDescriptor Verbose(bool? verbose = true) => Qs("v", verbose);
	}

	///<summary>Descriptor for Recovery <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-recovery/</para></summary>
	public partial class CatRecoveryDescriptor : RequestDescriptorBase<CatRecoveryDescriptor, CatRecoveryRequestParameters, ICatRecoveryRequest>, ICatRecoveryRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatRecovery;
		///<summary>/_cat/recovery</summary>
		public CatRecoveryDescriptor(): base()
		{
		}

		///<summary>/_cat/recovery/{index}</summary>
		///<param name = "index">Optional, accepts null</param>
		public CatRecoveryDescriptor(Indices index): base(r => r.Optional("index", index))
		{
		}

		// values part of the url path
		Indices ICatRecoveryRequest.Index => Self.RouteValues.Get<Indices>("index");
		///<summary>Comma-separated list or wildcard expression of index names to limit the returned information</summary>
		public CatRecoveryDescriptor Index(Indices index) => Assign(index, (a, v) => a.RouteValues.Optional("index", v));
		///<summary>a shortcut into calling Index(typeof(TOther))</summary>
		public CatRecoveryDescriptor Index<TOther>()
			where TOther : class => Assign(typeof(TOther), (a, v) => a.RouteValues.Optional("index", (Indices)v));
		///<summary>A shortcut into calling Index(Indices.All)</summary>
		public CatRecoveryDescriptor AllIndices() => Index(Indices.All);
		// Request parameters
		///<summary>If `true`, the response only includes ongoing shard recoveries</summary>
		public CatRecoveryDescriptor ActiveOnly(bool? activeonly = true) => Qs("active_only", activeonly);
		///<summary>The unit in which to display byte values</summary>
		public CatRecoveryDescriptor Bytes(Bytes? bytes) => Qs("bytes", bytes);
		///<summary>If `true`, the response includes detailed information about shard recoveries</summary>
		public CatRecoveryDescriptor Detailed(bool? detailed = true) => Qs("detailed", detailed);
		///<summary>a short version of the Accept header, e.g. json, yaml</summary>
		public CatRecoveryDescriptor Format(string format) => Qs("format", format);
		///<summary>Comma-separated list of column names to display</summary>
		public CatRecoveryDescriptor Headers(params string[] headers) => Qs("h", headers);
		///<summary>Return help information</summary>
		public CatRecoveryDescriptor Help(bool? help = true) => Qs("help", help);
		///<summary>Comma-separated list of column names or column aliases to sort by</summary>
		public CatRecoveryDescriptor SortByColumns(params string[] sortbycolumns) => Qs("s", sortbycolumns);
		///<summary>Verbose mode. Display column headers</summary>
		public CatRecoveryDescriptor Verbose(bool? verbose = true) => Qs("v", verbose);
	}

	///<summary>Descriptor for Repositories <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-repositories/</para></summary>
	public partial class CatRepositoriesDescriptor : RequestDescriptorBase<CatRepositoriesDescriptor, CatRepositoriesRequestParameters, ICatRepositoriesRequest>, ICatRepositoriesRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatRepositories;
		// values part of the url path
		// Request parameters
		///<summary>a short version of the Accept header, e.g. json, yaml</summary>
		public CatRepositoriesDescriptor Format(string format) => Qs("format", format);
		///<summary>Comma-separated list of column names to display</summary>
		public CatRepositoriesDescriptor Headers(params string[] headers) => Qs("h", headers);
		///<summary>Return help information</summary>
		public CatRepositoriesDescriptor Help(bool? help = true) => Qs("help", help);
		///<summary>Return local information, do not retrieve the state from cluster_manager node</summary>
		public CatRepositoriesDescriptor Local(bool? local = true) => Qs("local", local);
		///<summary>Explicit operation timeout for connection to master node</summary>
		///<remarks>Deprecated as of OpenSearch 2.0, use <see cref="ClusterManagerTimeout"/> instead</remarks>
		public CatRepositoriesDescriptor MasterTimeout(Time mastertimeout) => Qs("master_timeout", mastertimeout);
		///<summary>Explicit operation timeout for connection to cluster_manager node</summary>
		///<remarks>Introduced in OpenSearch 2.0 instead of <see cref="MasterTimeout"/></remarks>
		public CatRepositoriesDescriptor ClusterManagerTimeout(Time timeout) => Qs("cluster_manager_timeout", timeout);
		///<summary>Comma-separated list of column names or column aliases to sort by</summary>
		public CatRepositoriesDescriptor SortByColumns(params string[] sortbycolumns) => Qs("s", sortbycolumns);
		///<summary>Verbose mode. Display column headers</summary>
		public CatRepositoriesDescriptor Verbose(bool? verbose = true) => Qs("v", verbose);
	}

	///<summary>Descriptor for Segments <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-segments/</para></summary>
	public partial class CatSegmentsDescriptor : RequestDescriptorBase<CatSegmentsDescriptor, CatSegmentsRequestParameters, ICatSegmentsRequest>, ICatSegmentsRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatSegments;
		///<summary>/_cat/segments</summary>
		public CatSegmentsDescriptor(): base()
		{
		}

		///<summary>/_cat/segments/{index}</summary>
		///<param name = "index">Optional, accepts null</param>
		public CatSegmentsDescriptor(Indices index): base(r => r.Optional("index", index))
		{
		}

		// values part of the url path
		Indices ICatSegmentsRequest.Index => Self.RouteValues.Get<Indices>("index");
		///<summary>A comma-separated list of index names to limit the returned information</summary>
		public CatSegmentsDescriptor Index(Indices index) => Assign(index, (a, v) => a.RouteValues.Optional("index", v));
		///<summary>a shortcut into calling Index(typeof(TOther))</summary>
		public CatSegmentsDescriptor Index<TOther>()
			where TOther : class => Assign(typeof(TOther), (a, v) => a.RouteValues.Optional("index", (Indices)v));
		///<summary>A shortcut into calling Index(Indices.All)</summary>
		public CatSegmentsDescriptor AllIndices() => Index(Indices.All);
		// Request parameters
		///<summary>The unit in which to display byte values</summary>
		public CatSegmentsDescriptor Bytes(Bytes? bytes) => Qs("bytes", bytes);
		///<summary>a short version of the Accept header, e.g. json, yaml</summary>
		public CatSegmentsDescriptor Format(string format) => Qs("format", format);
		///<summary>Comma-separated list of column names to display</summary>
		public CatSegmentsDescriptor Headers(params string[] headers) => Qs("h", headers);
		///<summary>Return help information</summary>
		public CatSegmentsDescriptor Help(bool? help = true) => Qs("help", help);
		///<summary>Comma-separated list of column names or column aliases to sort by</summary>
		public CatSegmentsDescriptor SortByColumns(params string[] sortbycolumns) => Qs("s", sortbycolumns);
		///<summary>Verbose mode. Display column headers</summary>
		public CatSegmentsDescriptor Verbose(bool? verbose = true) => Qs("v", verbose);
	}

	///<summary>Descriptor for Shards <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-shards/</para></summary>
	public partial class CatShardsDescriptor : RequestDescriptorBase<CatShardsDescriptor, CatShardsRequestParameters, ICatShardsRequest>, ICatShardsRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatShards;
		///<summary>/_cat/shards</summary>
		public CatShardsDescriptor(): base()
		{
		}

		///<summary>/_cat/shards/{index}</summary>
		///<param name = "index">Optional, accepts null</param>
		public CatShardsDescriptor(Indices index): base(r => r.Optional("index", index))
		{
		}

		// values part of the url path
		Indices ICatShardsRequest.Index => Self.RouteValues.Get<Indices>("index");
		///<summary>A comma-separated list of index names to limit the returned information</summary>
		public CatShardsDescriptor Index(Indices index) => Assign(index, (a, v) => a.RouteValues.Optional("index", v));
		///<summary>a shortcut into calling Index(typeof(TOther))</summary>
		public CatShardsDescriptor Index<TOther>()
			where TOther : class => Assign(typeof(TOther), (a, v) => a.RouteValues.Optional("index", (Indices)v));
		///<summary>A shortcut into calling Index(Indices.All)</summary>
		public CatShardsDescriptor AllIndices() => Index(Indices.All);
		// Request parameters
		///<summary>The unit in which to display byte values</summary>
		public CatShardsDescriptor Bytes(Bytes? bytes) => Qs("bytes", bytes);
		///<summary>a short version of the Accept header, e.g. json, yaml</summary>
		public CatShardsDescriptor Format(string format) => Qs("format", format);
		///<summary>Comma-separated list of column names to display</summary>
		public CatShardsDescriptor Headers(params string[] headers) => Qs("h", headers);
		///<summary>Return help information</summary>
		public CatShardsDescriptor Help(bool? help = true) => Qs("help", help);
		///<summary>Return local information, do not retrieve the state from cluster_manager node (default: false)</summary>
		public CatShardsDescriptor Local(bool? local = true) => Qs("local", local);
		///<summary>Explicit operation timeout for connection to master node</summary>
		///<remarks>Deprecated as of OpenSearch 2.0, use <see cref="ClusterManagerTimeout"/> instead</remarks>
		public CatShardsDescriptor MasterTimeout(Time mastertimeout) => Qs("master_timeout", mastertimeout);
		///<summary>Explicit operation timeout for connection to cluster_manager node</summary>
		///<remarks>Introduced in OpenSearch 2.0 instead of <see cref="MasterTimeout"/></remarks>
		public CatShardsDescriptor ClusterManagerTimeout(Time timeout) => Qs("cluster_manager_timeout", timeout);
		///<summary>Comma-separated list of column names or column aliases to sort by</summary>
		public CatShardsDescriptor SortByColumns(params string[] sortbycolumns) => Qs("s", sortbycolumns);
		///<summary>Verbose mode. Display column headers</summary>
		public CatShardsDescriptor Verbose(bool? verbose = true) => Qs("v", verbose);
	}

	///<summary>Descriptor for Snapshots <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/</para></summary>
	public partial class CatSnapshotsDescriptor : RequestDescriptorBase<CatSnapshotsDescriptor, CatSnapshotsRequestParameters, ICatSnapshotsRequest>, ICatSnapshotsRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatSnapshots;
		///<summary>/_cat/snapshots</summary>
		public CatSnapshotsDescriptor(): base()
		{
		}

		///<summary>/_cat/snapshots/{repository}</summary>
		///<param name = "repository">Optional, accepts null</param>
		public CatSnapshotsDescriptor(Names repository): base(r => r.Optional("repository", repository))
		{
		}

		// values part of the url path
		Names ICatSnapshotsRequest.RepositoryName => Self.RouteValues.Get<Names>("repository");
		///<summary>Name of repository from which to fetch the snapshot information</summary>
		public CatSnapshotsDescriptor RepositoryName(Names repository) => Assign(repository, (a, v) => a.RouteValues.Optional("repository", v));
		// Request parameters
		///<summary>a short version of the Accept header, e.g. json, yaml</summary>
		public CatSnapshotsDescriptor Format(string format) => Qs("format", format);
		///<summary>Comma-separated list of column names to display</summary>
		public CatSnapshotsDescriptor Headers(params string[] headers) => Qs("h", headers);
		///<summary>Return help information</summary>
		public CatSnapshotsDescriptor Help(bool? help = true) => Qs("help", help);
		///<summary>Set to true to ignore unavailable snapshots</summary>
		public CatSnapshotsDescriptor IgnoreUnavailable(bool? ignoreunavailable = true) => Qs("ignore_unavailable", ignoreunavailable);
		///<summary>Explicit operation timeout for connection to master node</summary>
		///<remarks>Deprecated as of OpenSearch 2.0, use <see cref="ClusterManagerTimeout"/> instead</remarks>
		public CatSnapshotsDescriptor MasterTimeout(Time mastertimeout) => Qs("master_timeout", mastertimeout);
		///<summary>Explicit operation timeout for connection to cluster_manager node</summary>
		///<remarks>Introduced in OpenSearch 2.0 instead of <see cref="MasterTimeout"/></remarks>
		public CatSnapshotsDescriptor ClusterManagerTimeout(Time timeout) => Qs("cluster_manager_timeout", timeout);
		///<summary>Comma-separated list of column names or column aliases to sort by</summary>
		public CatSnapshotsDescriptor SortByColumns(params string[] sortbycolumns) => Qs("s", sortbycolumns);
		///<summary>Verbose mode. Display column headers</summary>
		public CatSnapshotsDescriptor Verbose(bool? verbose = true) => Qs("v", verbose);
	}

	///<summary>Descriptor for Tasks <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-tasks/</para></summary>
	public partial class CatTasksDescriptor : RequestDescriptorBase<CatTasksDescriptor, CatTasksRequestParameters, ICatTasksRequest>, ICatTasksRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatTasks;
		// values part of the url path
		// Request parameters
		///<summary>A comma-separated list of actions that should be returned. Leave empty to return all.</summary>
		public CatTasksDescriptor Actions(params string[] actions) => Qs("actions", actions);
		///<summary>Return detailed task information (default: false)</summary>
		public CatTasksDescriptor Detailed(bool? detailed = true) => Qs("detailed", detailed);
		///<summary>a short version of the Accept header, e.g. json, yaml</summary>
		public CatTasksDescriptor Format(string format) => Qs("format", format);
		///<summary>Comma-separated list of column names to display</summary>
		public CatTasksDescriptor Headers(params string[] headers) => Qs("h", headers);
		///<summary>Return help information</summary>
		public CatTasksDescriptor Help(bool? help = true) => Qs("help", help);
		///<summary>A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you're connecting to, leave empty to get information from all nodes</summary>
		public CatTasksDescriptor Nodes(params string[] nodes) => Qs("nodes", nodes);
		///<summary>Return tasks with specified parent task id (node_id:task_number). Set to -1 to return all.</summary>
		public CatTasksDescriptor ParentTaskId(string parenttaskid) => Qs("parent_task_id", parenttaskid);
		///<summary>Comma-separated list of column names or column aliases to sort by</summary>
		public CatTasksDescriptor SortByColumns(params string[] sortbycolumns) => Qs("s", sortbycolumns);
		///<summary>Verbose mode. Display column headers</summary>
		public CatTasksDescriptor Verbose(bool? verbose = true) => Qs("v", verbose);
	}

	///<summary>Descriptor for Templates <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-templates/</para></summary>
	public partial class CatTemplatesDescriptor : RequestDescriptorBase<CatTemplatesDescriptor, CatTemplatesRequestParameters, ICatTemplatesRequest>, ICatTemplatesRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatTemplates;
		///<summary>/_cat/templates</summary>
		public CatTemplatesDescriptor(): base()
		{
		}

		///<summary>/_cat/templates/{name}</summary>
		///<param name = "name">Optional, accepts null</param>
		public CatTemplatesDescriptor(Name name): base(r => r.Optional("name", name))
		{
		}

		// values part of the url path
		Name ICatTemplatesRequest.Name => Self.RouteValues.Get<Name>("name");
		///<summary>A pattern that returned template names must match</summary>
		public CatTemplatesDescriptor Name(Name name) => Assign(name, (a, v) => a.RouteValues.Optional("name", v));
		// Request parameters
		///<summary>a short version of the Accept header, e.g. json, yaml</summary>
		public CatTemplatesDescriptor Format(string format) => Qs("format", format);
		///<summary>Comma-separated list of column names to display</summary>
		public CatTemplatesDescriptor Headers(params string[] headers) => Qs("h", headers);
		///<summary>Return help information</summary>
		public CatTemplatesDescriptor Help(bool? help = true) => Qs("help", help);
		///<summary>Return local information, do not retrieve the state from cluster_manager node (default: false)</summary>
		public CatTemplatesDescriptor Local(bool? local = true) => Qs("local", local);
		///<summary>Explicit operation timeout for connection to master node</summary>
		///<remarks>Deprecated as of OpenSearch 2.0, use <see cref="ClusterManagerTimeout"/> instead</remarks>
		public CatTemplatesDescriptor MasterTimeout(Time mastertimeout) => Qs("master_timeout", mastertimeout);
		///<summary>Explicit operation timeout for connection to cluster_manager node</summary>
		///<remarks>Introduced in OpenSearch 2.0 instead of <see cref="MasterTimeout"/></remarks>
		public CatTemplatesDescriptor ClusterManagerTimeout(Time timeout) => Qs("cluster_manager_timeout", timeout);
		///<summary>Comma-separated list of column names or column aliases to sort by</summary>
		public CatTemplatesDescriptor SortByColumns(params string[] sortbycolumns) => Qs("s", sortbycolumns);
		///<summary>Verbose mode. Display column headers</summary>
		public CatTemplatesDescriptor Verbose(bool? verbose = true) => Qs("v", verbose);
	}

	///<summary>Descriptor for ThreadPool <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-thread-pool/</para></summary>
	public partial class CatThreadPoolDescriptor : RequestDescriptorBase<CatThreadPoolDescriptor, CatThreadPoolRequestParameters, ICatThreadPoolRequest>, ICatThreadPoolRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatThreadPool;
		///<summary>/_cat/thread_pool</summary>
		public CatThreadPoolDescriptor(): base()
		{
		}

		///<summary>/_cat/thread_pool/{thread_pool_patterns}</summary>
		///<param name = "threadPoolPatterns">Optional, accepts null</param>
		public CatThreadPoolDescriptor(Names threadPoolPatterns): base(r => r.Optional("thread_pool_patterns", threadPoolPatterns))
		{
		}

		// values part of the url path
		Names ICatThreadPoolRequest.ThreadPoolPatterns => Self.RouteValues.Get<Names>("thread_pool_patterns");
		///<summary>A comma-separated list of regular-expressions to filter the thread pools in the output</summary>
		public CatThreadPoolDescriptor ThreadPoolPatterns(Names threadPoolPatterns) => Assign(threadPoolPatterns, (a, v) => a.RouteValues.Optional("thread_pool_patterns", v));
		// Request parameters
		///<summary>a short version of the Accept header, e.g. json, yaml</summary>
		public CatThreadPoolDescriptor Format(string format) => Qs("format", format);
		///<summary>Comma-separated list of column names to display</summary>
		public CatThreadPoolDescriptor Headers(params string[] headers) => Qs("h", headers);
		///<summary>Return help information</summary>
		public CatThreadPoolDescriptor Help(bool? help = true) => Qs("help", help);
		///<summary>Return local information, do not retrieve the state from cluster_manager node (default: false)</summary>
		public CatThreadPoolDescriptor Local(bool? local = true) => Qs("local", local);
		///<summary>Explicit operation timeout for connection to master node</summary>
		///<remarks>Deprecated as of OpenSearch 2.0, use <see cref="ClusterManagerTimeout"/> instead</remarks>
		public CatThreadPoolDescriptor MasterTimeout(Time mastertimeout) => Qs("master_timeout", mastertimeout);
		///<summary>Explicit operation timeout for connection to cluster_manager node</summary>
		///<remarks>Introduced in OpenSearch 2.0 instead of <see cref="MasterTimeout"/></remarks>
		public CatThreadPoolDescriptor ClusterManagerTimeout(Time timeout) => Qs("cluster_manager_timeout", timeout);
		///<summary>Comma-separated list of column names or column aliases to sort by</summary>
		public CatThreadPoolDescriptor SortByColumns(params string[] sortbycolumns) => Qs("s", sortbycolumns);
		///<summary>Verbose mode. Display column headers</summary>
		public CatThreadPoolDescriptor Verbose(bool? verbose = true) => Qs("v", verbose);
	}
}
