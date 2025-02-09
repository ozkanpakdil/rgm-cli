/*
 * Redgate Monitor API - internal - for dev use only
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 14.0.45
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using cli.Client;
using cli.Api;
// uncomment below to import models
//using cli.Model;

namespace cli.Test.Api
{
    /// <summary>
    ///  Class for testing QueryRecommendationsApiApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class QueryRecommendationsApiApiTests : IDisposable
    {
        private QueryRecommendationsApiApi instance;

        public QueryRecommendationsApiApiTests()
        {
            instance = new QueryRecommendationsApiApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of QueryRecommendationsApiApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' QueryRecommendationsApiApi
            //Assert.IsType<QueryRecommendationsApiApi>(instance);
        }

        /// <summary>
        /// Test ApiBasemonitorsBaseMonitorNameRecommendationsInstanceSqlInstanceCirQueryplanPlanHandleCreateDateDatabaseNameGet
        /// </summary>
        [Fact]
        public void ApiBasemonitorsBaseMonitorNameRecommendationsInstanceSqlInstanceCirQueryplanPlanHandleCreateDateDatabaseNameGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SqlInstanceChannelInstanceRef sqlInstanceCir = null;
            //string planHandle = null;
            //DateTime createDate = null;
            //string databaseName = null;
            //DateTime startDate = null;
            //DateTime endDate = null;
            //string baseMonitorName = null;
            //var response = instance.ApiBasemonitorsBaseMonitorNameRecommendationsInstanceSqlInstanceCirQueryplanPlanHandleCreateDateDatabaseNameGet(sqlInstanceCir, planHandle, createDate, databaseName, startDate, endDate, baseMonitorName);
            //Assert.IsType<QueryRecommendationDtoArrayJSendSuccess>(response);
        }

        /// <summary>
        /// Test ApiBasemonitorsBaseMonitorNameRecommendationsPost
        /// </summary>
        [Fact]
        public void ApiBasemonitorsBaseMonitorNameRecommendationsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string baseMonitorName = null;
            //QueryRecommendationsRequestDto? queryRecommendationsRequestDto = null;
            //var response = instance.ApiBasemonitorsBaseMonitorNameRecommendationsPost(baseMonitorName, queryRecommendationsRequestDto);
            //Assert.IsType<QueryRecommendationDtoQueryRecommendationCollectionDtoArrayJSendSuccess>(response);
        }

        /// <summary>
        /// Test ApiBasemonitorsBaseMonitorNameRecommendationsPostgresinstancesPost
        /// </summary>
        [Fact]
        public void ApiBasemonitorsBaseMonitorNameRecommendationsPostgresinstancesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string baseMonitorName = null;
            //PostgresQueryRecommendationsRequestDto? postgresQueryRecommendationsRequestDto = null;
            //var response = instance.ApiBasemonitorsBaseMonitorNameRecommendationsPostgresinstancesPost(baseMonitorName, postgresQueryRecommendationsRequestDto);
            //Assert.IsType<PostgresQueryRecommendationDtoPostgresQueryRecommendationCollectionDtoArrayJSendSuccess>(response);
        }

        /// <summary>
        /// Test ApiBasemonitorsBaseMonitorNameRecommendationsPostgresinstancesQueryplanGet
        /// </summary>
        [Fact]
        public void ApiBasemonitorsBaseMonitorNameRecommendationsPostgresinstancesQueryplanGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PostgresInstanceChannelInstanceRef postgresInstanceCir = null;
            //string queryHash = null;
            //string databaseName = null;
            //string queryId = null;
            //string userId = null;
            //string databaseId = null;
            //bool topLevel = null;
            //string planHash = null;
            //DateTime startDate = null;
            //DateTime endDate = null;
            //string baseMonitorName = null;
            //var response = instance.ApiBasemonitorsBaseMonitorNameRecommendationsPostgresinstancesQueryplanGet(postgresInstanceCir, queryHash, databaseName, queryId, userId, databaseId, topLevel, planHash, startDate, endDate, baseMonitorName);
            //Assert.IsType<PostgresQueryRecommendationDtoArrayJSendSuccess>(response);
        }
    }
}
