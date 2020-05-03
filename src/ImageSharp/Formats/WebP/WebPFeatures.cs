// Copyright (c) Six Labors and contributors.
// Licensed under the GNU Affero General Public License, Version 3.

using System;
using System.Buffers;

namespace SixLabors.ImageSharp.Formats.WebP
{
    /// <summary>
    /// Image features of a VP8X image.
    /// </summary>
    internal class WebPFeatures : IDisposable
    {
        /// <summary>
        /// Gets or sets a value indicating whether this image has an ICC Profile.
        /// </summary>
        public bool IccProfile { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this image has an alpha channel.
        /// </summary>
        public bool Alpha { get; set; }

        /// <summary>
        /// Gets or sets the alpha data, if an ALPH chunk is present.
        /// </summary>
        public IMemoryOwner<byte> AlphaData { get; set; }

        /// <summary>
        /// Gets or sets the alpha chunk header.
        /// </summary>
        public byte AlphaChunkHeader { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this image has an EXIF Profile.
        /// </summary>
        public bool ExifProfile { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this image has XMP Metadata.
        /// </summary>
        public bool XmpMetaData { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this image is an animation.
        /// </summary>
        public bool Animation { get; set; }

        /// <inheritdoc/>
        public void Dispose()
        {
            this.AlphaData?.Dispose();
        }
    }
}