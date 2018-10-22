﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using Microsoft.Build.Evaluation;

namespace Microsoft.Build.Graph
{
    /// <summary>
    /// Represents the node for a particular project in a project graph.
    /// </summary>
    internal sealed class ProjectGraphNode
    {
        // No public creation.
        internal ProjectGraphNode() { }

        /// <summary>
        /// Gets an unordered collection of graph nodes for projects which this project references.
        /// </summary>
        public IReadOnlyCollection<ProjectGraphNode> ProjectReferences => Array.Empty<ProjectGraphNode>();

        /// <summary>
        /// Gets the evaluated project represented by this node in the graph.
        /// </summary>
        public Project Project => new Project();
    }
}
