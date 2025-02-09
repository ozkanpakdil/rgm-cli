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
    ///  Class for testing AnnotationsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AnnotationsApiTests : IDisposable
    {
        private AnnotationsApi instance;

        public AnnotationsApiTests()
        {
            instance = new AnnotationsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AnnotationsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AnnotationsApi
            //Assert.IsType<AnnotationsApi>(instance);
        }

        /// <summary>
        /// Test ApiAnnotationsDelete
        /// </summary>
        [Fact]
        public void ApiAnnotationsDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? instanceName = null;
            //DateTime? utcDate = null;
            //instance.ApiAnnotationsDelete(instanceName, utcDate);
        }

        /// <summary>
        /// Test ApiAnnotationsGet
        /// </summary>
        [Fact]
        public void ApiAnnotationsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? instanceName = null;
            //DateTime? utcDate = null;
            //instance.ApiAnnotationsGet(instanceName, utcDate);
        }

        /// <summary>
        /// Test ApiAnnotationsPost
        /// </summary>
        [Fact]
        public void ApiAnnotationsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Annotation? annotation = null;
            //instance.ApiAnnotationsPost(annotation);
        }

        /// <summary>
        /// Test ApiAnnotationsPut
        /// </summary>
        [Fact]
        public void ApiAnnotationsPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Annotation? annotation = null;
            //instance.ApiAnnotationsPut(annotation);
        }

        /// <summary>
        /// Test Instances
        /// </summary>
        [Fact]
        public void InstancesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.Instances();
            //Assert.IsType<List<string>>(response);
        }
    }
}
