namespace FluentHub.Octokit.Models.v4
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Autogenerated input type of RemoveLabelsFromLabelable
    /// </summary>
    public class RemoveLabelsFromLabelableInput
    {
        /// <summary>
        /// The id of the Labelable to remove labels from.
        /// </summary>
        public ID LabelableId { get; set; }

        /// <summary>
        /// The ids of labels to remove.
        /// </summary>
        public List<ID> LabelIds { get; set; }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }
    }
}