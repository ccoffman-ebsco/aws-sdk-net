/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the elasticloadbalancing-2012-06-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.ElasticLoadBalancing.Model;

namespace Amazon.ElasticLoadBalancing
{
    /// <summary>
    /// Interface for accessing ElasticLoadBalancing
    ///
    /// Elastic Load Balancing 
    /// <para>
    /// A load balancer distributes incoming traffic across your EC2 instances. This enables
    /// you to increase the availability of your application. The load balancer also monitors
    /// the health of its registered instances and ensures that it routes traffic only to
    /// healthy instances. You configure your load balancer to accept incoming traffic by
    /// specifying one or more listeners, which are configured with a protocol and port number
    /// for connections from clients to the load balancer and a protocol and port number for
    /// connections from the load balancer to the instances.
    /// </para>
    ///  
    /// <para>
    /// Elastic Load Balancing supports two types of load balancers: Classic load balancers
    /// and Application load balancers (new). A Classic load balancer makes routing and load
    /// balancing decisions either at the transport layer (TCP/SSL) or the application layer
    /// (HTTP/HTTPS), and supports either EC2-Classic or a VPC. An Application load balancer
    /// makes routing and load balancing decisions at the application layer (HTTP/HTTPS),
    /// supports path-based routing, and can route requests to one or more ports on each EC2
    /// instance or container instance in your virtual private cloud (VPC). For more information,
    /// see the .
    /// </para>
    ///  
    /// <para>
    /// This reference covers the 2012-06-01 API, which supports Classic load balancers. The
    /// 2015-12-01 API supports Application load balancers.
    /// </para>
    ///  
    /// <para>
    /// To get started, create a load balancer with one or more listeners using <a>CreateLoadBalancer</a>.
    /// Register your instances with the load balancer using <a>RegisterInstancesWithLoadBalancer</a>.
    /// </para>
    ///  
    /// <para>
    /// All Elastic Load Balancing operations are <i>idempotent</i>, which means that they
    /// complete at most one time. If you repeat an operation, it succeeds with a 200 OK response
    /// code.
    /// </para>
    /// </summary>
    public partial interface IAmazonElasticLoadBalancing : IDisposable
    {

        
        #region  AddTags


        /// <summary>
        /// Adds the specified tags to the specified load balancer. Each load balancer can have
        /// a maximum of 10 tags.
        /// 
        ///  
        /// <para>
        /// Each tag consists of a key and an optional value. If a tag with the same key is already
        /// associated with the load balancer, <code>AddTags</code> updates its value.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/elasticloadbalancing/latest/classic/add-remove-tags.html">Tag
        /// Your Classic Load Balancer</a> in the <i>Classic Load Balancers Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTags service method.</param>
        /// 
        /// <returns>The response from the AddTags service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.DuplicateTagKeysException">
        /// A tag key was specified more than once.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.TooManyTagsException">
        /// The quota for the number of tags that can be assigned to a load balancer has been
        /// reached.
        /// </exception>
        AddTagsResponse AddTags(AddTagsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the AddTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AddTagsResponse> AddTagsAsync(AddTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ApplySecurityGroupsToLoadBalancer


        /// <summary>
        /// Associates one or more security groups with your load balancer in a virtual private
        /// cloud (VPC). The specified security groups override the previously associated security
        /// groups.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/elasticloadbalancing/latest/classic/elb-security-groups.html#elb-vpc-security-groups">Security
        /// Groups for Load Balancers in a VPC</a> in the <i>Classic Load Balancers Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ApplySecurityGroupsToLoadBalancer service method.</param>
        /// 
        /// <returns>The response from the ApplySecurityGroupsToLoadBalancer service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException">
        /// The requested configuration change is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidSecurityGroupException">
        /// One or more of the specified security groups do not exist.
        /// </exception>
        ApplySecurityGroupsToLoadBalancerResponse ApplySecurityGroupsToLoadBalancer(ApplySecurityGroupsToLoadBalancerRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ApplySecurityGroupsToLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ApplySecurityGroupsToLoadBalancer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ApplySecurityGroupsToLoadBalancerResponse> ApplySecurityGroupsToLoadBalancerAsync(ApplySecurityGroupsToLoadBalancerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AttachLoadBalancerToSubnets


        /// <summary>
        /// Adds one or more subnets to the set of configured subnets for the specified load balancer.
        /// 
        ///  
        /// <para>
        /// The load balancer evenly distributes requests across all registered subnets. For more
        /// information, see <a href="http://docs.aws.amazon.com/elasticloadbalancing/latest/classic/elb-manage-subnets.html">Add
        /// or Remove Subnets for Your Load Balancer in a VPC</a> in the <i>Classic Load Balancers
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachLoadBalancerToSubnets service method.</param>
        /// 
        /// <returns>The response from the AttachLoadBalancerToSubnets service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException">
        /// The requested configuration change is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidSubnetException">
        /// The specified VPC has no associated Internet gateway.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.SubnetNotFoundException">
        /// One or more of the specified subnets do not exist.
        /// </exception>
        AttachLoadBalancerToSubnetsResponse AttachLoadBalancerToSubnets(AttachLoadBalancerToSubnetsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the AttachLoadBalancerToSubnets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachLoadBalancerToSubnets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AttachLoadBalancerToSubnetsResponse> AttachLoadBalancerToSubnetsAsync(AttachLoadBalancerToSubnetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ConfigureHealthCheck


        /// <summary>
        /// Specifies the health check settings to use when evaluating the health state of your
        /// EC2 instances.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/elasticloadbalancing/latest/classic/elb-healthchecks.html">Configure
        /// Health Checks for Your Load Balancer</a> in the <i>Classic Load Balancers Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfigureHealthCheck service method.</param>
        /// 
        /// <returns>The response from the ConfigureHealthCheck service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        ConfigureHealthCheckResponse ConfigureHealthCheck(ConfigureHealthCheckRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ConfigureHealthCheck operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfigureHealthCheck operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ConfigureHealthCheckResponse> ConfigureHealthCheckAsync(ConfigureHealthCheckRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateAppCookieStickinessPolicy


        /// <summary>
        /// Generates a stickiness policy with sticky session lifetimes that follow that of an
        /// application-generated cookie. This policy can be associated only with HTTP/HTTPS listeners.
        /// 
        ///  
        /// <para>
        /// This policy is similar to the policy created by <a>CreateLBCookieStickinessPolicy</a>,
        /// except that the lifetime of the special Elastic Load Balancing cookie, <code>AWSELB</code>,
        /// follows the lifetime of the application-generated cookie specified in the policy configuration.
        /// The load balancer only inserts a new stickiness cookie when the application response
        /// includes a new application cookie.
        /// </para>
        ///  
        /// <para>
        /// If the application cookie is explicitly removed or expires, the session stops being
        /// sticky until a new application cookie is issued.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/elasticloadbalancing/latest/classic/elb-sticky-sessions.html#enable-sticky-sessions-application">Application-Controlled
        /// Session Stickiness</a> in the <i>Classic Load Balancers Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAppCookieStickinessPolicy service method.</param>
        /// 
        /// <returns>The response from the CreateAppCookieStickinessPolicy service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.DuplicatePolicyNameException">
        /// A policy with the specified name already exists for this load balancer.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException">
        /// The requested configuration change is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.TooManyPoliciesException">
        /// The quota for the number of policies for this load balancer has been reached.
        /// </exception>
        CreateAppCookieStickinessPolicyResponse CreateAppCookieStickinessPolicy(CreateAppCookieStickinessPolicyRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateAppCookieStickinessPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAppCookieStickinessPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateAppCookieStickinessPolicyResponse> CreateAppCookieStickinessPolicyAsync(CreateAppCookieStickinessPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateLBCookieStickinessPolicy


        /// <summary>
        /// Generates a stickiness policy with sticky session lifetimes controlled by the lifetime
        /// of the browser (user-agent) or a specified expiration period. This policy can be associated
        /// only with HTTP/HTTPS listeners.
        /// 
        ///  
        /// <para>
        /// When a load balancer implements this policy, the load balancer uses a special cookie
        /// to track the instance for each request. When the load balancer receives a request,
        /// it first checks to see if this cookie is present in the request. If so, the load balancer
        /// sends the request to the application server specified in the cookie. If not, the load
        /// balancer sends the request to a server that is chosen based on the existing load-balancing
        /// algorithm.
        /// </para>
        ///  
        /// <para>
        /// A cookie is inserted into the response for binding subsequent requests from the same
        /// user to that server. The validity of the cookie is based on the cookie expiration
        /// time, which is specified in the policy configuration.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/elasticloadbalancing/latest/classic/elb-sticky-sessions.html#enable-sticky-sessions-duration">Duration-Based
        /// Session Stickiness</a> in the <i>Classic Load Balancers Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLBCookieStickinessPolicy service method.</param>
        /// 
        /// <returns>The response from the CreateLBCookieStickinessPolicy service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.DuplicatePolicyNameException">
        /// A policy with the specified name already exists for this load balancer.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException">
        /// The requested configuration change is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.TooManyPoliciesException">
        /// The quota for the number of policies for this load balancer has been reached.
        /// </exception>
        CreateLBCookieStickinessPolicyResponse CreateLBCookieStickinessPolicy(CreateLBCookieStickinessPolicyRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateLBCookieStickinessPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLBCookieStickinessPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateLBCookieStickinessPolicyResponse> CreateLBCookieStickinessPolicyAsync(CreateLBCookieStickinessPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateLoadBalancer


        /// <summary>
        /// Creates a Classic load balancer.
        /// 
        ///  
        /// <para>
        /// You can add listeners, security groups, subnets, and tags when you create your load
        /// balancer, or you can add them later using <a>CreateLoadBalancerListeners</a>, <a>ApplySecurityGroupsToLoadBalancer</a>,
        /// <a>AttachLoadBalancerToSubnets</a>, and <a>AddTags</a>.
        /// </para>
        ///  
        /// <para>
        /// To describe your current load balancers, see <a>DescribeLoadBalancers</a>. When you
        /// are finished with a load balancer, you can delete it using <a>DeleteLoadBalancer</a>.
        /// </para>
        ///  
        /// <para>
        /// You can create up to 20 load balancers per region per account. You can request an
        /// increase for the number of load balancers for your account. For more information,
        /// see <a href="http://docs.aws.amazon.com/elasticloadbalancing/latest/classic/elb-limits.html">Limits
        /// for Your Classic Load Balancer</a> in the <i>Classic Load Balancers Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLoadBalancer service method.</param>
        /// 
        /// <returns>The response from the CreateLoadBalancer service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.CertificateNotFoundException">
        /// The specified ARN does not refer to a valid SSL certificate in AWS Identity and Access
        /// Management (IAM) or AWS Certificate Manager (ACM). Note that if you recently uploaded
        /// the certificate to IAM, this error might indicate that the certificate is not fully
        /// available yet.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.DuplicateAccessPointNameException">
        /// The specified load balancer name already exists for this account.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.DuplicateTagKeysException">
        /// A tag key was specified more than once.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException">
        /// The requested configuration change is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidSchemeException">
        /// The specified value for the schema is not valid. You can only specify a scheme for
        /// load balancers in a VPC.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidSecurityGroupException">
        /// One or more of the specified security groups do not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidSubnetException">
        /// The specified VPC has no associated Internet gateway.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.SubnetNotFoundException">
        /// One or more of the specified subnets do not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.TooManyAccessPointsException">
        /// The quota for the number of load balancers has been reached.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.TooManyTagsException">
        /// The quota for the number of tags that can be assigned to a load balancer has been
        /// reached.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.UnsupportedProtocolException">
        /// 
        /// </exception>
        CreateLoadBalancerResponse CreateLoadBalancer(CreateLoadBalancerRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLoadBalancer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateLoadBalancerResponse> CreateLoadBalancerAsync(CreateLoadBalancerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateLoadBalancerListeners


        /// <summary>
        /// Creates one or more listeners for the specified load balancer. If a listener with
        /// the specified port does not already exist, it is created; otherwise, the properties
        /// of the new listener must match the properties of the existing listener.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/elasticloadbalancing/latest/classic/elb-listener-config.html">Listeners
        /// for Your Classic Load Balancer</a> in the <i>Classic Load Balancers Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLoadBalancerListeners service method.</param>
        /// 
        /// <returns>The response from the CreateLoadBalancerListeners service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.CertificateNotFoundException">
        /// The specified ARN does not refer to a valid SSL certificate in AWS Identity and Access
        /// Management (IAM) or AWS Certificate Manager (ACM). Note that if you recently uploaded
        /// the certificate to IAM, this error might indicate that the certificate is not fully
        /// available yet.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.DuplicateListenerException">
        /// A listener already exists for the specified load balancer name and port, but with
        /// a different instance port, protocol, or SSL certificate.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException">
        /// The requested configuration change is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.UnsupportedProtocolException">
        /// 
        /// </exception>
        CreateLoadBalancerListenersResponse CreateLoadBalancerListeners(CreateLoadBalancerListenersRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateLoadBalancerListeners operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLoadBalancerListeners operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateLoadBalancerListenersResponse> CreateLoadBalancerListenersAsync(CreateLoadBalancerListenersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateLoadBalancerPolicy


        /// <summary>
        /// Creates a policy with the specified attributes for the specified load balancer.
        /// 
        ///  
        /// <para>
        /// Policies are settings that are saved for your load balancer and that can be applied
        /// to the listener or the application server, depending on the policy type.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLoadBalancerPolicy service method.</param>
        /// 
        /// <returns>The response from the CreateLoadBalancerPolicy service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.DuplicatePolicyNameException">
        /// A policy with the specified name already exists for this load balancer.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException">
        /// The requested configuration change is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.PolicyTypeNotFoundException">
        /// One or more of the specified policy types do not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.TooManyPoliciesException">
        /// The quota for the number of policies for this load balancer has been reached.
        /// </exception>
        CreateLoadBalancerPolicyResponse CreateLoadBalancerPolicy(CreateLoadBalancerPolicyRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateLoadBalancerPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLoadBalancerPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateLoadBalancerPolicyResponse> CreateLoadBalancerPolicyAsync(CreateLoadBalancerPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteLoadBalancer


        /// <summary>
        /// Deletes the specified load balancer.
        /// 
        ///  
        /// <para>
        /// If you are attempting to recreate a load balancer, you must reconfigure all settings.
        /// The DNS name associated with a deleted load balancer are no longer usable. The name
        /// and associated DNS record of the deleted load balancer no longer exist and traffic
        /// sent to any of its IP addresses is no longer delivered to your instances.
        /// </para>
        ///  
        /// <para>
        /// If the load balancer does not exist or has already been deleted, the call to <code>DeleteLoadBalancer</code>
        /// still succeeds.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoadBalancer service method.</param>
        /// 
        /// <returns>The response from the DeleteLoadBalancer service method, as returned by ElasticLoadBalancing.</returns>
        DeleteLoadBalancerResponse DeleteLoadBalancer(DeleteLoadBalancerRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoadBalancer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteLoadBalancerResponse> DeleteLoadBalancerAsync(DeleteLoadBalancerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteLoadBalancerListeners


        /// <summary>
        /// Deletes the specified listeners from the specified load balancer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoadBalancerListeners service method.</param>
        /// 
        /// <returns>The response from the DeleteLoadBalancerListeners service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        DeleteLoadBalancerListenersResponse DeleteLoadBalancerListeners(DeleteLoadBalancerListenersRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLoadBalancerListeners operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoadBalancerListeners operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteLoadBalancerListenersResponse> DeleteLoadBalancerListenersAsync(DeleteLoadBalancerListenersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteLoadBalancerPolicy


        /// <summary>
        /// Deletes the specified policy from the specified load balancer. This policy must not
        /// be enabled for any listeners.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoadBalancerPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteLoadBalancerPolicy service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException">
        /// The requested configuration change is not valid.
        /// </exception>
        DeleteLoadBalancerPolicyResponse DeleteLoadBalancerPolicy(DeleteLoadBalancerPolicyRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLoadBalancerPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoadBalancerPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteLoadBalancerPolicyResponse> DeleteLoadBalancerPolicyAsync(DeleteLoadBalancerPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeregisterInstancesFromLoadBalancer


        /// <summary>
        /// Deregisters the specified instances from the specified load balancer. After the instance
        /// is deregistered, it no longer receives traffic from the load balancer.
        /// 
        ///  
        /// <para>
        /// You can use <a>DescribeLoadBalancers</a> to verify that the instance is deregistered
        /// from the load balancer.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/elasticloadbalancing/latest/classic/elb-deregister-register-instances.html">Register
        /// or De-Register EC2 Instances</a> in the <i>Classic Load Balancers Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterInstancesFromLoadBalancer service method.</param>
        /// 
        /// <returns>The response from the DeregisterInstancesFromLoadBalancer service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidEndPointException">
        /// The specified endpoint is not valid.
        /// </exception>
        DeregisterInstancesFromLoadBalancerResponse DeregisterInstancesFromLoadBalancer(DeregisterInstancesFromLoadBalancerRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterInstancesFromLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterInstancesFromLoadBalancer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeregisterInstancesFromLoadBalancerResponse> DeregisterInstancesFromLoadBalancerAsync(DeregisterInstancesFromLoadBalancerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeInstanceHealth


        /// <summary>
        /// Describes the state of the specified instances with respect to the specified load
        /// balancer. If no instances are specified, the call describes the state of all instances
        /// that are currently registered with the load balancer. If instances are specified,
        /// their state is returned even if they are no longer registered with the load balancer.
        /// The state of terminated instances is not returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceHealth service method.</param>
        /// 
        /// <returns>The response from the DescribeInstanceHealth service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidEndPointException">
        /// The specified endpoint is not valid.
        /// </exception>
        DescribeInstanceHealthResponse DescribeInstanceHealth(DescribeInstanceHealthRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstanceHealth operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceHealth operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeInstanceHealthResponse> DescribeInstanceHealthAsync(DescribeInstanceHealthRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeLoadBalancerAttributes


        /// <summary>
        /// Describes the attributes for the specified load balancer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancerAttributes service method.</param>
        /// 
        /// <returns>The response from the DescribeLoadBalancerAttributes service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.LoadBalancerAttributeNotFoundException">
        /// The specified load balancer attribute does not exist.
        /// </exception>
        DescribeLoadBalancerAttributesResponse DescribeLoadBalancerAttributes(DescribeLoadBalancerAttributesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoadBalancerAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancerAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeLoadBalancerAttributesResponse> DescribeLoadBalancerAttributesAsync(DescribeLoadBalancerAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeLoadBalancerPolicies


        /// <summary>
        /// Describes the specified policies.
        /// 
        ///  
        /// <para>
        /// If you specify a load balancer name, the action returns the descriptions of all policies
        /// created for the load balancer. If you specify a policy name associated with your load
        /// balancer, the action returns the description of that policy. If you don't specify
        /// a load balancer name, the action returns descriptions of the specified sample policies,
        /// or descriptions of all sample policies. The names of the sample policies have the
        /// <code>ELBSample-</code> prefix.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeLoadBalancerPolicies service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.PolicyNotFoundException">
        /// One or more of the specified policies do not exist.
        /// </exception>
        DescribeLoadBalancerPoliciesResponse DescribeLoadBalancerPolicies();


        /// <summary>
        /// Describes the specified policies.
        /// 
        ///  
        /// <para>
        /// If you specify a load balancer name, the action returns the descriptions of all policies
        /// created for the load balancer. If you specify a policy name associated with your load
        /// balancer, the action returns the description of that policy. If you don't specify
        /// a load balancer name, the action returns descriptions of the specified sample policies,
        /// or descriptions of all sample policies. The names of the sample policies have the
        /// <code>ELBSample-</code> prefix.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancerPolicies service method.</param>
        /// 
        /// <returns>The response from the DescribeLoadBalancerPolicies service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.PolicyNotFoundException">
        /// One or more of the specified policies do not exist.
        /// </exception>
        DescribeLoadBalancerPoliciesResponse DescribeLoadBalancerPolicies(DescribeLoadBalancerPoliciesRequest request);


        /// <summary>
        /// Describes the specified policies.
        /// 
        ///  
        /// <para>
        /// If you specify a load balancer name, the action returns the descriptions of all policies
        /// created for the load balancer. If you specify a policy name associated with your load
        /// balancer, the action returns the description of that policy. If you don't specify
        /// a load balancer name, the action returns descriptions of the specified sample policies,
        /// or descriptions of all sample policies. The names of the sample policies have the
        /// <code>ELBSample-</code> prefix.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLoadBalancerPolicies service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.PolicyNotFoundException">
        /// One or more of the specified policies do not exist.
        /// </exception>
        Task<DescribeLoadBalancerPoliciesResponse> DescribeLoadBalancerPoliciesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoadBalancerPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancerPolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeLoadBalancerPoliciesResponse> DescribeLoadBalancerPoliciesAsync(DescribeLoadBalancerPoliciesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeLoadBalancerPolicyTypes


        /// <summary>
        /// Describes the specified load balancer policy types or all load balancer policy types.
        /// 
        ///  
        /// <para>
        /// The description of each type indicates how it can be used. For example, some policies
        /// can be used only with layer 7 listeners, some policies can be used only with layer
        /// 4 listeners, and some policies can be used only with your EC2 instances.
        /// </para>
        ///  
        /// <para>
        /// You can use <a>CreateLoadBalancerPolicy</a> to create a policy configuration for any
        /// of these policy types. Then, depending on the policy type, use either <a>SetLoadBalancerPoliciesOfListener</a>
        /// or <a>SetLoadBalancerPoliciesForBackendServer</a> to set the policy.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeLoadBalancerPolicyTypes service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.PolicyTypeNotFoundException">
        /// One or more of the specified policy types do not exist.
        /// </exception>
        DescribeLoadBalancerPolicyTypesResponse DescribeLoadBalancerPolicyTypes();


        /// <summary>
        /// Describes the specified load balancer policy types or all load balancer policy types.
        /// 
        ///  
        /// <para>
        /// The description of each type indicates how it can be used. For example, some policies
        /// can be used only with layer 7 listeners, some policies can be used only with layer
        /// 4 listeners, and some policies can be used only with your EC2 instances.
        /// </para>
        ///  
        /// <para>
        /// You can use <a>CreateLoadBalancerPolicy</a> to create a policy configuration for any
        /// of these policy types. Then, depending on the policy type, use either <a>SetLoadBalancerPoliciesOfListener</a>
        /// or <a>SetLoadBalancerPoliciesForBackendServer</a> to set the policy.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancerPolicyTypes service method.</param>
        /// 
        /// <returns>The response from the DescribeLoadBalancerPolicyTypes service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.PolicyTypeNotFoundException">
        /// One or more of the specified policy types do not exist.
        /// </exception>
        DescribeLoadBalancerPolicyTypesResponse DescribeLoadBalancerPolicyTypes(DescribeLoadBalancerPolicyTypesRequest request);


        /// <summary>
        /// Describes the specified load balancer policy types or all load balancer policy types.
        /// 
        ///  
        /// <para>
        /// The description of each type indicates how it can be used. For example, some policies
        /// can be used only with layer 7 listeners, some policies can be used only with layer
        /// 4 listeners, and some policies can be used only with your EC2 instances.
        /// </para>
        ///  
        /// <para>
        /// You can use <a>CreateLoadBalancerPolicy</a> to create a policy configuration for any
        /// of these policy types. Then, depending on the policy type, use either <a>SetLoadBalancerPoliciesOfListener</a>
        /// or <a>SetLoadBalancerPoliciesForBackendServer</a> to set the policy.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLoadBalancerPolicyTypes service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.PolicyTypeNotFoundException">
        /// One or more of the specified policy types do not exist.
        /// </exception>
        Task<DescribeLoadBalancerPolicyTypesResponse> DescribeLoadBalancerPolicyTypesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoadBalancerPolicyTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancerPolicyTypes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeLoadBalancerPolicyTypesResponse> DescribeLoadBalancerPolicyTypesAsync(DescribeLoadBalancerPolicyTypesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeLoadBalancers


        /// <summary>
        /// Describes the specified the load balancers. If no load balancers are specified, the
        /// call describes all of your load balancers.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeLoadBalancers service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.DependencyThrottleException">
        /// 
        /// </exception>
        DescribeLoadBalancersResponse DescribeLoadBalancers();


        /// <summary>
        /// Describes the specified the load balancers. If no load balancers are specified, the
        /// call describes all of your load balancers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancers service method.</param>
        /// 
        /// <returns>The response from the DescribeLoadBalancers service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.DependencyThrottleException">
        /// 
        /// </exception>
        DescribeLoadBalancersResponse DescribeLoadBalancers(DescribeLoadBalancersRequest request);


        /// <summary>
        /// Describes the specified the load balancers. If no load balancers are specified, the
        /// call describes all of your load balancers.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLoadBalancers service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.DependencyThrottleException">
        /// 
        /// </exception>
        Task<DescribeLoadBalancersResponse> DescribeLoadBalancersAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoadBalancers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeLoadBalancersResponse> DescribeLoadBalancersAsync(DescribeLoadBalancersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeTags


        /// <summary>
        /// Describes the tags associated with the specified load balancers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags service method.</param>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        DescribeTagsResponse DescribeTags(DescribeTagsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DetachLoadBalancerFromSubnets


        /// <summary>
        /// Removes the specified subnets from the set of configured subnets for the load balancer.
        /// 
        ///  
        /// <para>
        /// After a subnet is removed, all EC2 instances registered with the load balancer in
        /// the removed subnet go into the <code>OutOfService</code> state. Then, the load balancer
        /// balances the traffic among the remaining routable subnets.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachLoadBalancerFromSubnets service method.</param>
        /// 
        /// <returns>The response from the DetachLoadBalancerFromSubnets service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException">
        /// The requested configuration change is not valid.
        /// </exception>
        DetachLoadBalancerFromSubnetsResponse DetachLoadBalancerFromSubnets(DetachLoadBalancerFromSubnetsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DetachLoadBalancerFromSubnets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachLoadBalancerFromSubnets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DetachLoadBalancerFromSubnetsResponse> DetachLoadBalancerFromSubnetsAsync(DetachLoadBalancerFromSubnetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisableAvailabilityZonesForLoadBalancer


        /// <summary>
        /// Removes the specified Availability Zones from the set of Availability Zones for the
        /// specified load balancer.
        /// 
        ///  
        /// <para>
        /// There must be at least one Availability Zone registered with a load balancer at all
        /// times. After an Availability Zone is removed, all instances registered with the load
        /// balancer that are in the removed Availability Zone go into the <code>OutOfService</code>
        /// state. Then, the load balancer attempts to equally balance the traffic among its remaining
        /// Availability Zones.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/elasticloadbalancing/latest/classic/enable-disable-az.html">Add
        /// or Remove Availability Zones</a> in the <i>Classic Load Balancers Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableAvailabilityZonesForLoadBalancer service method.</param>
        /// 
        /// <returns>The response from the DisableAvailabilityZonesForLoadBalancer service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException">
        /// The requested configuration change is not valid.
        /// </exception>
        DisableAvailabilityZonesForLoadBalancerResponse DisableAvailabilityZonesForLoadBalancer(DisableAvailabilityZonesForLoadBalancerRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DisableAvailabilityZonesForLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableAvailabilityZonesForLoadBalancer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DisableAvailabilityZonesForLoadBalancerResponse> DisableAvailabilityZonesForLoadBalancerAsync(DisableAvailabilityZonesForLoadBalancerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  EnableAvailabilityZonesForLoadBalancer


        /// <summary>
        /// Adds the specified Availability Zones to the set of Availability Zones for the specified
        /// load balancer.
        /// 
        ///  
        /// <para>
        /// The load balancer evenly distributes requests across all its registered Availability
        /// Zones that contain instances.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/elasticloadbalancing/latest/classic/enable-disable-az.html">Add
        /// or Remove Availability Zones</a> in the <i>Classic Load Balancers Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableAvailabilityZonesForLoadBalancer service method.</param>
        /// 
        /// <returns>The response from the EnableAvailabilityZonesForLoadBalancer service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        EnableAvailabilityZonesForLoadBalancerResponse EnableAvailabilityZonesForLoadBalancer(EnableAvailabilityZonesForLoadBalancerRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the EnableAvailabilityZonesForLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableAvailabilityZonesForLoadBalancer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<EnableAvailabilityZonesForLoadBalancerResponse> EnableAvailabilityZonesForLoadBalancerAsync(EnableAvailabilityZonesForLoadBalancerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ModifyLoadBalancerAttributes


        /// <summary>
        /// Modifies the attributes of the specified load balancer.
        /// 
        ///  
        /// <para>
        /// You can modify the load balancer attributes, such as <code>AccessLogs</code>, <code>ConnectionDraining</code>,
        /// and <code>CrossZoneLoadBalancing</code> by either enabling or disabling them. Or,
        /// you can modify the load balancer attribute <code>ConnectionSettings</code> by specifying
        /// an idle connection timeout value for your load balancer.
        /// </para>
        ///  
        /// <para>
        /// For more information, see the following in the <i>Classic Load Balancers Guide</i>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="http://docs.aws.amazon.com/elasticloadbalancing/latest/classic/enable-disable-crosszone-lb.html">Cross-Zone
        /// Load Balancing</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="http://docs.aws.amazon.com/elasticloadbalancing/latest/classic/config-conn-drain.html">Connection
        /// Draining</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="http://docs.aws.amazon.com/elasticloadbalancing/latest/classic/access-log-collection.html">Access
        /// Logs</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="http://docs.aws.amazon.com/elasticloadbalancing/latest/classic/config-idle-timeout.html">Idle
        /// Connection Timeout</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyLoadBalancerAttributes service method.</param>
        /// 
        /// <returns>The response from the ModifyLoadBalancerAttributes service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException">
        /// The requested configuration change is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.LoadBalancerAttributeNotFoundException">
        /// The specified load balancer attribute does not exist.
        /// </exception>
        ModifyLoadBalancerAttributesResponse ModifyLoadBalancerAttributes(ModifyLoadBalancerAttributesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyLoadBalancerAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyLoadBalancerAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ModifyLoadBalancerAttributesResponse> ModifyLoadBalancerAttributesAsync(ModifyLoadBalancerAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RegisterInstancesWithLoadBalancer


        /// <summary>
        /// Adds the specified instances to the specified load balancer.
        /// 
        ///  
        /// <para>
        /// The instance must be a running instance in the same network as the load balancer (EC2-Classic
        /// or the same VPC). If you have EC2-Classic instances and a load balancer in a VPC with
        /// ClassicLink enabled, you can link the EC2-Classic instances to that VPC and then register
        /// the linked EC2-Classic instances with the load balancer in the VPC.
        /// </para>
        ///  
        /// <para>
        /// Note that <code>RegisterInstanceWithLoadBalancer</code> completes when the request
        /// has been registered. Instance registration takes a little time to complete. To check
        /// the state of the registered instances, use <a>DescribeLoadBalancers</a> or <a>DescribeInstanceHealth</a>.
        /// </para>
        ///  
        /// <para>
        /// After the instance is registered, it starts receiving traffic and requests from the
        /// load balancer. Any instance that is not in one of the Availability Zones registered
        /// for the load balancer is moved to the <code>OutOfService</code> state. If an Availability
        /// Zone is added to the load balancer later, any instances registered with the load balancer
        /// move to the <code>InService</code> state.
        /// </para>
        ///  
        /// <para>
        /// To deregister instances from a load balancer, use <a>DeregisterInstancesFromLoadBalancer</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/elasticloadbalancing/latest/classic/elb-deregister-register-instances.html">Register
        /// or De-Register EC2 Instances</a> in the <i>Classic Load Balancers Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterInstancesWithLoadBalancer service method.</param>
        /// 
        /// <returns>The response from the RegisterInstancesWithLoadBalancer service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidEndPointException">
        /// The specified endpoint is not valid.
        /// </exception>
        RegisterInstancesWithLoadBalancerResponse RegisterInstancesWithLoadBalancer(RegisterInstancesWithLoadBalancerRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the RegisterInstancesWithLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterInstancesWithLoadBalancer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RegisterInstancesWithLoadBalancerResponse> RegisterInstancesWithLoadBalancerAsync(RegisterInstancesWithLoadBalancerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RemoveTags


        /// <summary>
        /// Removes one or more tags from the specified load balancer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTags service method.</param>
        /// 
        /// <returns>The response from the RemoveTags service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        RemoveTagsResponse RemoveTags(RemoveTagsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RemoveTagsResponse> RemoveTagsAsync(RemoveTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SetLoadBalancerListenerSSLCertificate


        /// <summary>
        /// Sets the certificate that terminates the specified listener's SSL connections. The
        /// specified certificate replaces any prior certificate that was used on the same load
        /// balancer and port.
        /// 
        ///  
        /// <para>
        /// For more information about updating your SSL certificate, see <a href="http://docs.aws.amazon.com/elasticloadbalancing/latest/classic/elb-update-ssl-cert.html">Replace
        /// the SSL Certificate for Your Load Balancer</a> in the <i>Classic Load Balancers Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetLoadBalancerListenerSSLCertificate service method.</param>
        /// 
        /// <returns>The response from the SetLoadBalancerListenerSSLCertificate service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.CertificateNotFoundException">
        /// The specified ARN does not refer to a valid SSL certificate in AWS Identity and Access
        /// Management (IAM) or AWS Certificate Manager (ACM). Note that if you recently uploaded
        /// the certificate to IAM, this error might indicate that the certificate is not fully
        /// available yet.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException">
        /// The requested configuration change is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.ListenerNotFoundException">
        /// The load balancer does not have a listener configured at the specified port.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.UnsupportedProtocolException">
        /// 
        /// </exception>
        SetLoadBalancerListenerSSLCertificateResponse SetLoadBalancerListenerSSLCertificate(SetLoadBalancerListenerSSLCertificateRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the SetLoadBalancerListenerSSLCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetLoadBalancerListenerSSLCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<SetLoadBalancerListenerSSLCertificateResponse> SetLoadBalancerListenerSSLCertificateAsync(SetLoadBalancerListenerSSLCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SetLoadBalancerPoliciesForBackendServer


        /// <summary>
        /// Replaces the set of policies associated with the specified port on which the EC2 instance
        /// is listening with a new set of policies. At this time, only the back-end server authentication
        /// policy type can be applied to the instance ports; this policy type is composed of
        /// multiple public key policies.
        /// 
        ///  
        /// <para>
        /// Each time you use <code>SetLoadBalancerPoliciesForBackendServer</code> to enable the
        /// policies, use the <code>PolicyNames</code> parameter to list the policies that you
        /// want to enable.
        /// </para>
        ///  
        /// <para>
        /// You can use <a>DescribeLoadBalancers</a> or <a>DescribeLoadBalancerPolicies</a> to
        /// verify that the policy is associated with the EC2 instance.
        /// </para>
        ///  
        /// <para>
        /// For more information about enabling back-end instance authentication, see <a href="http://docs.aws.amazon.com/elasticloadbalancing/latest/classic/elb-create-https-ssl-load-balancer.html#configure_backendauth_clt">Configure
        /// Back-end Instance Authentication</a> in the <i>Classic Load Balancers Guide</i>. For
        /// more information about Proxy Protocol, see <a href="http://docs.aws.amazon.com/elasticloadbalancing/latest/classic/enable-proxy-protocol.html">Configure
        /// Proxy Protocol Support</a> in the <i>Classic Load Balancers Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetLoadBalancerPoliciesForBackendServer service method.</param>
        /// 
        /// <returns>The response from the SetLoadBalancerPoliciesForBackendServer service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException">
        /// The requested configuration change is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.PolicyNotFoundException">
        /// One or more of the specified policies do not exist.
        /// </exception>
        SetLoadBalancerPoliciesForBackendServerResponse SetLoadBalancerPoliciesForBackendServer(SetLoadBalancerPoliciesForBackendServerRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the SetLoadBalancerPoliciesForBackendServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetLoadBalancerPoliciesForBackendServer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<SetLoadBalancerPoliciesForBackendServerResponse> SetLoadBalancerPoliciesForBackendServerAsync(SetLoadBalancerPoliciesForBackendServerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SetLoadBalancerPoliciesOfListener


        /// <summary>
        /// Replaces the current set of policies for the specified load balancer port with the
        /// specified set of policies.
        /// 
        ///  
        /// <para>
        /// To enable back-end server authentication, use <a>SetLoadBalancerPoliciesForBackendServer</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information about setting policies, see <a href="http://docs.aws.amazon.com/elasticloadbalancing/latest/classic/ssl-config-update.html">Update
        /// the SSL Negotiation Configuration</a>, <a href="http://docs.aws.amazon.com/elasticloadbalancing/latest/classic/elb-sticky-sessions.html#enable-sticky-sessions-duration">Duration-Based
        /// Session Stickiness</a>, and <a href="http://docs.aws.amazon.com/elasticloadbalancing/latest/classic/elb-sticky-sessions.html#enable-sticky-sessions-application">Application-Controlled
        /// Session Stickiness</a> in the <i>Classic Load Balancers Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetLoadBalancerPoliciesOfListener service method.</param>
        /// 
        /// <returns>The response from the SetLoadBalancerPoliciesOfListener service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException">
        /// The requested configuration change is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.ListenerNotFoundException">
        /// The load balancer does not have a listener configured at the specified port.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.PolicyNotFoundException">
        /// One or more of the specified policies do not exist.
        /// </exception>
        SetLoadBalancerPoliciesOfListenerResponse SetLoadBalancerPoliciesOfListener(SetLoadBalancerPoliciesOfListenerRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the SetLoadBalancerPoliciesOfListener operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetLoadBalancerPoliciesOfListener operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<SetLoadBalancerPoliciesOfListenerResponse> SetLoadBalancerPoliciesOfListenerAsync(SetLoadBalancerPoliciesOfListenerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}