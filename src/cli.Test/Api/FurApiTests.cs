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
    ///  Class for testing FurApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class FurApiTests : IDisposable
    {
        private FurApi instance;

        public FurApiTests()
        {
            instance = new FurApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of FurApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' FurApi
            //Assert.IsType<FurApi>(instance);
        }

        /// <summary>
        /// Test ApiFeatureUsageEventNamePost
        /// </summary>
        [Fact]
        public void ApiFeatureUsageEventNamePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string eventName = null;
            //Object? body = null;
            //var response = instance.ApiFeatureUsageEventNamePost(eventName, body);
            //Assert.IsType<UnitJSendSuccess>(response);
        }

        /// <summary>
        /// Test ApiFeedbackSubjectFeedbackPost
        /// </summary>
        [Fact]
        public void ApiFeedbackSubjectFeedbackPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string subject = null;
            //string feedback = null;
            //var response = instance.ApiFeedbackSubjectFeedbackPost(subject, feedback);
            //Assert.IsType<UnitJSendSuccess>(response);
        }
    }
}
