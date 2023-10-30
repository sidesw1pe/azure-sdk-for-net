// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Communication.Chat
{
    /// <summary> An attachment in a chat message. </summary>
    internal partial class ChatAttachmentInternal
    {
        /// <summary> Initializes a new instance of ChatAttachmentInternal. </summary>
        /// <param name="id"> Id of the attachment. </param>
        /// <param name="attachmentType"> The type of attachment. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        internal ChatAttachmentInternal(string id, AttachmentType attachmentType)
        {
            Argument.AssertNotNull(id, nameof(id));

            Id = id;
            AttachmentType = attachmentType;
        }

        /// <summary> Initializes a new instance of ChatAttachmentInternal. </summary>
        /// <param name="id"> Id of the attachment. </param>
        /// <param name="attachmentType"> The type of attachment. </param>
        /// <param name="extension"> The file extension of the attachment, if available. </param>
        /// <param name="name"> The name of the attachment content. </param>
        /// <param name="url"> The URL where the attachment can be downloaded. </param>
        /// <param name="previewUrl"> The URL where the preview of attachment can be downloaded. </param>
        internal ChatAttachmentInternal(string id, AttachmentType attachmentType, string extension, string name, string url, string previewUrl)
        {
            Id = id;
            AttachmentType = attachmentType;
            Extension = extension;
            Name = name;
            Url = url;
            PreviewUrl = previewUrl;
        }

        /// <summary> Id of the attachment. </summary>
        public string Id { get; }
        /// <summary> The type of attachment. </summary>
        public AttachmentType AttachmentType { get; }
        /// <summary> The file extension of the attachment, if available. </summary>
        public string Extension { get; }
        /// <summary> The name of the attachment content. </summary>
        public string Name { get; }
        /// <summary> The URL where the attachment can be downloaded. </summary>
        public string Url { get; }
        /// <summary> The URL where the preview of attachment can be downloaded. </summary>
        public string PreviewUrl { get; }
    }
}
