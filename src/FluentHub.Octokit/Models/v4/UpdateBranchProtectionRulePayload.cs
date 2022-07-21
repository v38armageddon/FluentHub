namespace FluentHub.Octokit.Models.v4
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    /// <summary>
    /// Autogenerated return type of UpdateBranchProtectionRule
    /// </summary>
    public class UpdateBranchProtectionRulePayload
    {
        /// <summary>
        /// The newly created BranchProtectionRule.
        /// </summary>
        public BranchProtectionRule BranchProtectionRule { get; set; }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }
    }
}