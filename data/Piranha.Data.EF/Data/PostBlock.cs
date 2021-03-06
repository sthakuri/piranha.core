/*
 * Copyright (c) 2018-2019 Håkan Edling
 *
 * This software may be modified and distributed under the terms
 * of the MIT license.  See the LICENSE file for details.
 *
 * https://github.com/piranhacms/piranha.core
 *
 */

using System;
using Newtonsoft.Json;

namespace Piranha.Data
{
    [Serializable]
    /// <summary>
    /// Connection between a post and a block.
    /// </summary>
    public sealed class PostBlock : IContentBlock
    {
        /// <summary>
        /// Gets/sets the unique id.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// This property is not used any more, but is kept for atm
        /// backwards compatible SQLite migrations.
        /// </summary>
        public Guid? ParentId { get; set; }

        /// <summary>
        /// Gets/sets the post id.
        /// </summary>
        public Guid PostId { get; set; }

        /// <summary>
        /// Gets/sets the block id.
        /// </summary>
        public Guid BlockId { get; set; }

        /// <summary>
        /// Gets/sets the zero based sort index.
        /// </summary>
        public int SortOrder { get; set; }

        /// <summary>
        /// Gets/sets the post containing the block.
        /// </summary>
        [JsonIgnore]
        public Post Post { get; set; }

        /// <summary>
        /// Gets/sets the block data.
        /// </summary>
        public Block Block { get; set; }
    }
}
