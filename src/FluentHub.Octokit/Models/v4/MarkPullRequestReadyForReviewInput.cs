namespace FluentHub.Octokit.Models.v4
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Autogenerated input type of MarkPullRequestReadyForReview
    /// </summary>
    public class MarkPullRequestReadyForReviewInput
    {
        /// <summary>
        /// ID of the pull request to be marked as ready for review.
        /// </summary>
        public ID PullRequestId { get; set; }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }
    }
}