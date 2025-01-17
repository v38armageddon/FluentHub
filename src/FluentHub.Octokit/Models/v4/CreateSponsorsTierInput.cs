namespace FluentHub.Octokit.Models.v4
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Autogenerated input type of CreateSponsorsTier
    /// </summary>
    public class CreateSponsorsTierInput
    {
        /// <summary>
        /// The ID of the user or organization who owns the GitHub Sponsors profile. Defaults to the current user if omitted and sponsorableLogin is not given.
        /// </summary>
        public ID? SponsorableId { get; set; }

        /// <summary>
        /// The username of the user or organization who owns the GitHub Sponsors profile. Defaults to the current user if omitted and sponsorableId is not given.
        /// </summary>
        public string SponsorableLogin { get; set; }

        /// <summary>
        /// The value of the new tier in US dollars. Valid values: 1-12000.
        /// </summary>
        public int Amount { get; set; }

        /// <summary>
        /// Whether sponsorships using this tier should happen monthly/yearly or just once.
        /// </summary>
        public bool? IsRecurring { get; set; }

        /// <summary>
        /// Optional ID of the private repository that sponsors at this tier should gain read-only access to. Must be owned by an organization.
        /// </summary>
        public ID? RepositoryId { get; set; }

        /// <summary>
        /// Optional login of the organization owner of the private repository that sponsors at this tier should gain read-only access to. Necessary if repositoryName is given. Will be ignored if repositoryId is given.
        /// </summary>
        public string RepositoryOwnerLogin { get; set; }

        /// <summary>
        /// Optional name of the private repository that sponsors at this tier should gain read-only access to. Must be owned by an organization. Necessary if repositoryOwnerLogin is given. Will be ignored if repositoryId is given.
        /// </summary>
        public string RepositoryName { get; set; }

        /// <summary>
        /// Optional message new sponsors at this tier will receive.
        /// </summary>
        public string WelcomeMessage { get; set; }

        /// <summary>
        /// A description of what this tier is, what perks sponsors might receive, what a sponsorship at this tier means for you, etc.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Whether to make the tier available immediately for sponsors to choose. Defaults to creating a draft tier that will not be publicly visible.
        /// </summary>
        public bool? Publish { get; set; }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }
    }
}